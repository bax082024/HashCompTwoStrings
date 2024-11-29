using System;
using System.Security.Cryptography;
using System.Text;

namespace HashingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hashing Demo Compare two strings!");

            // First string to compute
            Console.Write("Enter first string to hash: ");
            string input1 = Console.ReadLine();
            string hash = ComputeSHA256Hash(input1);
        }

        static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert input to bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Compute Hash
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert hash bytes to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }

        }
    }

}