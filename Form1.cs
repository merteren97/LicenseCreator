using System.Security.Cryptography;
using System.Text;

namespace LicenseCreator
{
    public partial class Form1 : Form
    {
        private static readonly string gizliSifre = "1MertinGizliAnahtari1";
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Click

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string guid = txtGuidInput.Text.Trim();

            if (string.IsNullOrEmpty(guid))
            {
                MessageBox.Show("Lütfen bir GUID girin.");
                return;
            }

            string encrypted = Encrypt(guid, gizliSifre);
            Console.WriteLine($"Encrypted: {encrypted}");
            txtEncryptedOutput.Text = encrypted;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncryptedOutput.Text))
            {
                MessageBox.Show("Lütfen önce şifrelenmiş metni oluşturun.");
                return;
            }
            Clipboard.SetText(txtEncryptedOutput.Text);
            MessageBox.Show("Şifrelenmiş metin panoya kopyalandı.");
        }
        private void btnGetGuid_Click(object sender, EventArgs e)
        {
            string machineGuid = GetMachineGuid();
            txtGuidInput.Text = machineGuid;
        }

        #endregion

        #region Methods

        private string Encrypt(string plainText, string key)
        {
            byte[] keyBytes = GetFixedSizeKey(key);
            Console.WriteLine($"Key: {Convert.ToBase64String(keyBytes)}");
            byte[] iv = Encoding.UTF8.GetBytes("1234567890abcdef");

            using Aes aes = Aes.Create();
            aes.Key = keyBytes;
            aes.IV = iv;

            using MemoryStream ms = new();
            using CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            using StreamWriter sw = new(cs);
            sw.Write(plainText);
            sw.Close();
            return Convert.ToBase64String(ms.ToArray());
        }
        private byte[] GetFixedSizeKey(string key)
        {
            using SHA256 sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(key));
        }
        private string GetMachineGuid()
        {
            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography"))
            {
                if (key != null)
                {
                    object value = key.GetValue("MachineGuid");
                    if (value != null)
                    {
                        return value.ToString();
                    }
                }
            }
            return string.Empty;
        }

        #endregion
    }
}