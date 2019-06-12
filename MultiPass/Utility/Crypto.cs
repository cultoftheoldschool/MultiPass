using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MultiPass.Utility
{
    internal static class Crypto
    {
        #region Private Fields

        private static readonly byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        #endregion

        #region Public Methods

        public static string Decrypt(string encryptedData, string password, string salt)
        {
            // Initialization
            string decryptedText = null;
            string shuffledData = Shuffle(salt, password);
            byte[] bData = Convert.FromBase64String(encryptedData);
            byte[] bSalt = GenerateSalt(shuffledData);
            
            // Create key
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, bSalt, 32767);

            // Decrypt
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = key.GetBytes(32);
                aes.IV = IV;

                using (MemoryStream ms = new MemoryStream(bData))
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor();
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decryptedText = sr.ReadToEnd();
                        }
                    }
                }
            }

            // Return plaintext
            return decryptedText;
        }

        public static string Encrypt(string data, string password, string salt)
        {
            // Initialization
            string shuffledData = Shuffle(salt, password);
            byte[] bData = Encoding.UTF8.GetBytes(data);
            byte[] bSalt = GenerateSalt(shuffledData);

            // Encrypt
            using (Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, bSalt, 32767))
            { 
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(32);
                    aes.IV = IV;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        ICryptoTransform encryptor = aes.CreateEncryptor();
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(bData, 0, bData.Length);
                            cs.FlushFinalBlock();
                            cs.Close();
                        }
                        bData = ms.ToArray();
                    }
                }
            }

            // Return encrypted text
            return Convert.ToBase64String(bData);
        }

        public static string GenerateHash(string password)
        {
            // Initialization
            string hash = null;
            byte[] salt = GenerateSalt(password);
            int dataCount = DataCount(password);

            // Generate hash using customized iteration count based on summation of character values in password
            using (Rfc2898DeriveBytes hashgen = new Rfc2898DeriveBytes(password, salt, dataCount))
            {
                byte[] bHash = hashgen.GetBytes(32);
                hash = Convert.ToBase64String(bHash);
            }

            // Return hash
            return hash;
        }

        public static bool VerifyHash(string password, string hash)
        {
            // Generate hash
            string dataHash = GenerateHash(password);

            // Return match
            return (dataHash == hash);
        }


        #endregion

        #region Private Methods

        private static int DataCount(string data)
        {
            // Initialize counter
            int count = 0;

            // Summation of character values in data string
            foreach (var c in data)
            {
                count += (int)c;
            }

            // Return summation of all character values in data string * 16
            return count * 16;
        }

        private static byte[] GenerateSalt(string data)
        {
            // Put my thing down flip it and reverse it
            while (data.Length < 16) { data += data; }
            byte[] bSalt = Encoding.UTF8.GetBytes(data);
            for (int i = 0; i < bSalt.Length; i++) { bSalt[i] = (byte)~bSalt[i]; }
            Array.Reverse(bSalt, 0, bSalt.Length);

            // Return salt over the shoulder for luck
            return bSalt;
        }

        private static string Shuffle(string str1, string str2)
        {
            // Initialize stringbuilder
            StringBuilder shuffled = new StringBuilder();

            // Shuffle the strings together
            for (int i = 0, pos1 = 0, pos2 = 0; i < 16; i++)
            {
                shuffled.Append(str1[pos1]);
                shuffled.Append(str2[pos2]);
                pos1 = (++pos1 == str1.Length) ? 0 : pos1;
                pos2 = (++pos2 == str2.Length) ? 0 : pos2;
            }

            // Return shuffled strings
            return shuffled.ToString();
        }

        #endregion
    }
}
