using MultiPass.Data;
using MultiPass.Exceptions;
using MultiPass.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MultiPass.Logic
{
    public class PasswordVault
    {
        #region Private Fields

        private const string VAULTFILE = "MultiPass.pwv";
        private const string VAULTID = "MULTIPASSV1.0";
        private PasswordContainer _passwordContainer;

        #endregion

        #region Constructors
        public PasswordVault() : this(true) {}
        public PasswordVault(bool loadFromFile)
        {
            // Initialize container
            _passwordContainer = new PasswordContainer();
            _passwordContainer.VaultID = VAULTID;

            // Load vault if needed
            if (loadFromFile)
            {
                Load();
            }
        }

        #endregion

        #region Public Methods

        public void AddPassword(string name, string password, string masterPassword)
        {
            // Ensure arguments are not blank and password entry does not already exist
            if(!(name?.Length > 0))
            {
                throw new InvalidArgumentException($"Error adding password: Argument '{nameof(name)}' is blank.");
            }
            else if(!(password?.Length > 0))
            {
                throw new InvalidArgumentException($"Error adding password: Argument '{nameof(password)}' is blank.");
            }
            else if (!(masterPassword?.Length > 0))
            {
                throw new InvalidArgumentException($"Error adding password: Argument '{nameof(masterPassword)}' is blank.");
            }
            else if(_passwordContainer.PasswordEntries.Any(e => e.Name == name))
            {
                throw new InvalidEntryException($"Error adding password: Entry '{name}' already exists.");
            }

            // Create new password entry
            PasswordEntry entry = new PasswordEntry();

            // Set name, encrypt and set password
            entry.Name = name;
            entry.Password = Crypto.Encrypt(password, masterPassword, name);

            // Add new entry to container
            _passwordContainer.PasswordEntries.Add(entry);

            // Save vault
            Save();
        }

        public void CreateMasterPassword(string masterPassword)
        {
            // Ensure argument is not blank
            if (!(masterPassword?.Length > 0))
            {
                throw new InvalidArgumentException($"Error creating master password: Argument '{nameof(masterPassword)}' is blank.");
            }

            // Set new master password
            SetMasterPassword(masterPassword);

            // Save vault
            Save();
        }

        public void DeletePassword(string name)
        {
            // Get password entry from container
            PasswordEntry entry = _passwordContainer.PasswordEntries.Where(e => e.Name == name).FirstOrDefault();

            // Ensure argument is not blank and password entry exists
            if (!(name?.Length > 0))
            {
                throw new InvalidArgumentException($"Error deleting password: Argument '{nameof(name)}' is blank.");
            }
            else if (string.IsNullOrEmpty(entry.Name))
            {
                throw new InvalidEntryException($"Error deleting password: Entry '{name}' not found.");
            }
            
            // Remove selected password entry from container
            _passwordContainer.PasswordEntries.Remove(entry);

            // Save vault
            Save();
        }

        public string GetPassword(string name, string masterPassword)
        {
            // Get matching entry from password container
            PasswordEntry entry = _passwordContainer.PasswordEntries.Where(e => e.Name == name).FirstOrDefault();

            // Check if password entry exists
            if (string.IsNullOrEmpty(entry.Name))
            {
                throw new InvalidEntryException($"Error retrieving password: Entry '{name}' not found.");
            }

            // Decrypt password
            string plaintext = Crypto.Decrypt(entry.Password, masterPassword, name);

            // Return plaintext password
            return plaintext;
        }

        public IEnumerable<string> GetPasswordNames()
        {
            // Retrieve password entries from container
            foreach (var entry in _passwordContainer.PasswordEntries)
            {
                yield return entry.Name;
            }
        }

        public void ModifyMasterPassword(string oldMasterPassword, string newMasterPassword)
        {
            // Ensure arguments are not blank
            if (!(oldMasterPassword?.Length > 0))
            {
                throw new InvalidArgumentException($"Error modifying master password: Argument '{nameof(oldMasterPassword)}' is blank.");
            }
            else if (!(newMasterPassword?.Length > 0))
            {
                throw new InvalidArgumentException($"Error modifying master password: Argument '{nameof(newMasterPassword)}' is blank.");
            }

            // Loop through all password entries in container
            for (int i = 0; i < _passwordContainer.PasswordEntries.Count; i++)
            {
                // Get password entry name and decrypted password
                string passwordName = _passwordContainer.PasswordEntries[i].Name;
                string password = GetPassword(passwordName, oldMasterPassword);

                // Re-encrypt the password using new master password
                ModifyPassword(passwordName, password, newMasterPassword);

            }

            // Set new master password
            SetMasterPassword(newMasterPassword);

            // Save vault
            Save();
        }

        public void ModifyPassword(string name, string password, string masterPassword)
        {
            // Ensure arguments are not blank and password entry does not already exist
            if (!(name?.Length > 0))
            {
                throw new InvalidArgumentException($"Error modifying password: Argument '{nameof(name)}' is blank.");
            }
            else if (!(password?.Length > 0))
            {
                throw new InvalidArgumentException($"Error modifying password: Argument '{nameof(password)}' is blank.");
            }
            else if (!(masterPassword?.Length > 0))
            {
                throw new InvalidArgumentException($"Error modifying password: Argument '{nameof(masterPassword)}' is blank.");
            }

            // Create new password entry, set name, encrypt and set password
            PasswordEntry entry = new PasswordEntry();

            entry.Name = name;
            entry.Password = Crypto.Encrypt(password, masterPassword, name);

            // Get existing entry by name
            int index = _passwordContainer.PasswordEntries.FindIndex(e => e.Name == name);

            // Check if entry exists
            if(index<0)
            {
                throw new InvalidEntryException($"Error adding password: Entry '{name}' not found.");
            }

            // Replace old entry with new entry
            _passwordContainer.PasswordEntries[index] = entry;

            // Save vault
            Save();
        }

        public void SetMasterPassword(string masterPassword)
        {
            // Generate hash of master password and set
            _passwordContainer.MasterPasswordHash = Crypto.GenerateHash(masterPassword);
        }

        public bool VerifyMasterPassword(string password)
        {
            // Authenticate and return success/failure result
            return Crypto.VerifyHash(password, _passwordContainer.MasterPasswordHash);
        }

        #endregion

        #region Private Methods

        private void Load()
        {
            try
            {
                // Load password vault from disk and deserialize
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(VAULTFILE, FileMode.Open, FileAccess.Read))
                {
                    _passwordContainer = (PasswordContainer)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                throw new VaultIOException($"Error loading vault: {ex.Message}", ex);
            }
                
            // Check if password vault loaded from disk is compatible with this version
            if(_passwordContainer.VaultID != VAULTID)
            {
                // Vaults are incompatible
                throw new VaultCompatibilityException($"Password container ID \"{_passwordContainer.VaultID}\" is incompatible with Vault ID \"{VAULTID}\".");
            }
            
        }

        private void Save()
        {
            try
            {
                // Serialize and save password vault to disk
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(VAULTFILE, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    formatter.Serialize(stream, _passwordContainer);
                }
            }
            catch (Exception ex)
            {
                throw new VaultIOException($"Error saving vault: {ex.Message}", ex);
            }
        }
        
        #endregion
    }
}