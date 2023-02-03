using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace Server
{
    public class AccountManagement
    {

        private readonly string AccountsFilePath = @"C:\Users\crantz\source\ServerAccounts.csv";
        public bool CheckLogin(string username, string password)
        {
            using (var reader = new StreamReader(AccountsFilePath))
            {
                // Catogroise valies
                List<string> names = new List<string>();
                List<string> passwordHashes = new List<string>();
                List<string> salts = new List<string>();

                // Read whole file and put data into listts
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split();

                    names.Add(values[0]);
                    passwordHashes.Add(values[1]);
                    salts.Add(values[2]);
                }
                // Chech for asked username
                foreach (string name in names)
                {
                    if (name == username)
                    {
                        int index = names.IndexOf(name);

                        // Create a password hash with supplied pass and salt
                        string passwordHashToCheck = StringToHash($"{password}{salts[index]}");
                        // Check if the created password hash matches the one in record
                        if (passwordHashes[index].ToLower() == passwordHashToCheck.ToLower())
                        {
                            // Username is goodToGo, can be assigned to user
                            return true;
                        }
                    }
                }
                // Username or password where incorrect
                return false;
            }
        }



        public bool AccountNameExists(string accountName)
        {
            foreach (String line in File.ReadAllLines(AccountsFilePath))
            {
                string[] values = line.Split();
                if (values[0] == accountName)
                    return true;

            }
            // Account name does not exist
            return false;
        }
        public bool AccountCreateUser(string userName, string password)
        {
            string salt = SaltCreate512();
            string hashedPassword = StringToHash($"{password}{salt}");
            string data = $"{userName},{hashedPassword},{salt}\n";

            try
            {
                File.AppendAllText(AccountsFilePath, data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
                return false;
            }
        }

        private string StringToHash(string input)
        {
            StringBuilder SB = new StringBuilder();
            foreach (byte b in GenerateSHA512String(input))
                SB.Append(b.ToString("x2"));
            return SB.ToString();
        }

        private static string GenerateSHA512String(string inputString) // Used by the GetHashString function
        {
            StringBuilder sb = new StringBuilder();
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hashValue = sha512.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                foreach (byte b in hashValue)
                {
                    sb.Append($"{b:X2}");
                }
            }

            return sb.ToString();
        }
        private string SaltCreate512()
        {
            Random rand = new Random();
            StringBuilder SB = new StringBuilder();
            string acceptableCharacters = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
            for (int i = 0; i < 64; i++)
            {
                SB.Append(acceptableCharacters[rand.Next(0, acceptableCharacters.Length)]);
            }
            return SB.ToString();
        }
    }
}
    

