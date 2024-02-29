using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT000
{
    class Common
    {
        // データベース接続用変数
        public static SqlCommand cmd;

        // Open database connection
        public static SqlConnection OpenConnection()
        {
        SqlConnection con = new SqlConnection(global::OJT000.Properties.Settings.Default.acdbConnectionString);
            try
             {
                 con.Open();
             }
             catch (System.Exception ex)
             {
                 MessageBox.Show(ex.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             return con;

          /*  con.Open();
            return con;*/
        }

    // Close database connection
    public static void closeConnection()
    {
            SqlConnection con = new SqlConnection(global::OJT000.Properties.Settings.Default.acdbConnectionString);
            con.Close();
    }

    // Encryption - Decryption Method
    public string Encrypt(string plainText, string AESKey)
    {
        RijndaelManaged rijndaelCipher = new RijndaelManaged();
        byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);// Get the byte array to be encrypted 
        rijndaelCipher.Key = Convert.FromBase64String(AESKey);// Encryption and decryption parties agree on the key: AESKey
        rijndaelCipher.GenerateIV();
        byte[] keyIv = rijndaelCipher.IV;
        byte[] cipherBytes = null;
        using (MemoryStream ms = new MemoryStream())
        {
            using (CryptoStream cs = new CryptoStream(ms, rijndaelCipher.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                cipherBytes = ms.ToArray();// Get the encrypted byte array 
                cs.Close();
                ms.Close();
            }
        }
        var allEncrypt = new byte[keyIv.Length + cipherBytes.Length];
        Buffer.BlockCopy(keyIv, 0, allEncrypt, 0, keyIv.Length);
        Buffer.BlockCopy(cipherBytes, 0, allEncrypt, keyIv.Length * sizeof(byte), cipherBytes.Length);
        return Convert.ToBase64String(allEncrypt);
    }

    public string Decrypt(string showText, string AESKey)
    {
        string result = string.Empty;
        try
        {
            byte[] cipherText = Convert.FromBase64String(showText);
            int length = cipherText.Length;
            SymmetricAlgorithm rijndaelCipher = Rijndael.Create();
            rijndaelCipher.Key = Convert.FromBase64String(AESKey);// Encrypt and decrypt the key agreed by both parties 
            byte[] iv = new byte[16];
            Buffer.BlockCopy(cipherText, 0, iv, 0, 16);
            rijndaelCipher.IV = iv;
            byte[] decryptBytes = new byte[length - 16];
            byte[] passwdText = new byte[length - 16];
            Buffer.BlockCopy(cipherText, 16, passwdText, 0, length - 16);
            using (MemoryStream ms = new MemoryStream(passwdText))
            {
                using (CryptoStream cs = new CryptoStream(ms, rijndaelCipher.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.Read(decryptBytes, 0, decryptBytes.Length);
                    cs.Close();
                    ms.Close();
                }
            }
            result = Encoding.UTF8.GetString(decryptBytes).Replace("\0", "");  /// End of the string '\0' Remove 
        }
        catch { }
        return result;
    }
}
}
