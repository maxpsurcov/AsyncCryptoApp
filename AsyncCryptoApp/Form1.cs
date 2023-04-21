using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace AsyncCryptoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void btnBlowfish_Click(object sender, EventArgs e)
        {
            string input = "Secret message";
            string key = "MySecretKey";
            byte[] encrypted = await Task.Run(() => EncryptBlowfish(input, key));
            string decrypted = await Task.Run(() => DecryptBlowfish(encrypted, key));
            txtResult.Text = decrypted;
        }

        private async void btnMD5_Click(object sender, EventArgs e)
        {
            string input = "Secret message";
            byte[] hash = await Task.Run(() => HashMD5(input));
            txtResult.Text = Convert.ToBase64String(hash);
        }

        private async void btnWake_Click(object sender, EventArgs e)
        {
            string input = "Secret message";
            byte[] key = Encoding.UTF8.GetBytes("MySecretKey");
            byte[] iv = Encoding.UTF8.GetBytes("MySecretIV");
            byte[] encrypted = await Task.Run(() => EncryptWake(input, key, iv));
            string decrypted = await Task.Run(() => DecryptWake(encrypted, key, iv));
            txtResult.Text = decrypted;
        }
        private byte[] EncryptBlowfish(string input, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (var cipher = new BlowfishManaged())
            using (var ms = new System.IO.MemoryStream())
            {
                var encryptor = cipher.CreateEncryptor(keyBytes, null);
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }

        private string DecryptBlowfish(byte[] input, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            using (var cipher = new BlowfishManaged())
            using (var ms = new System.IO.MemoryStream())
            {
                var decryptor = cipher.CreateDecryptor(keyBytes, null);
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                {
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        private byte[] HashMD5(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                return md5.ComputeHash(inputBytes);
            }
        }

        private byte[] EncryptWake(string input, byte[] key, byte[] iv)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (var cipher = new WakeManaged())
            using (var ms = new System.IO.MemoryStream())
            {
                var encryptor = cipher.CreateEncryptor(key, iv);
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }

        private string DecryptWake(byte[] input, byte[] key, byte[] iv)
        {
            using (var cipher = new WakeManaged())
            using (var ms = new System.IO.MemoryStream())
            {
                var decryptor = cipher.CreateDecryptor(key, iv);
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                {
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}



