using System;
using System.Collections.Generic;

namespace MultiPass.Data
{
    [Serializable]
    internal class PasswordContainer
    {
        public string VaultID { get; set; }
        public string MasterPasswordHash { get; set; }
        public List<PasswordEntry> PasswordEntries { get; set; }

        public PasswordContainer()
        {
            PasswordEntries = new List<PasswordEntry>();
        }
    }
}
