using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FileForge
{
    public partial class FileForgeApp : Form
    {

   

            public FileForgeApp()
        {
            InitializeComponent();
        }

        private void browseButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            string filePath = filePathTextBox.Text;

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int fileSizeInKB;

            if (int.TryParse(sizeTextBox.Text, out fileSizeInKB) && fileSizeInKB >= 0 && comboBox1.SelectedItem != null)
            {
              
                long sizeInBytes = fileSizeInKB;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "KB":
                        sizeInBytes *= 1024;
                        break;
                    case "MB":
                        sizeInBytes *= 1024 * 1024;
                        break;
                    case "GB":
                        sizeInBytes *= 1024 * 1024 * 1024;
                        break;
                    
                }

                ResizeFile(filePath, sizeInBytes);
                MessageBox.Show("File resized successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a size unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (fileSizeInKB < 0)
                {
                    MessageBox.Show("Please enter a non-negative size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Whole numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void encryptButton_Click(object sender, EventArgs e)
        {
          /*  string filePath = filePathTextBox.Text;

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EncryptFile(filePath);
            MessageBox.Show("File encrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
           /* string filePath = filePathTextBox.Text;

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DecryptFile(filePath);
            MessageBox.Show("File decrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); */
        } 

        private void ResizeFile(string filePath, long newSize)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                stream.SetLength(newSize);
            }
        }

       /* private void EncryptFile(string filePath)
        {
            string encryptedFilePath = $"{filePath}.encrypted";

            using (var inputFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var encryptedFileStream = new FileStream(encryptedFilePath, FileMode.Create, FileAccess.Write))
            using (var cryptoStream = new CryptoStream(encryptedFileStream, GetAesEncryptor(), CryptoStreamMode.Write))
            {
                inputFileStream.CopyTo(cryptoStream);
            }

            File.Delete(filePath);
            File.Move(encryptedFilePath, filePath);
        }

        private void DecryptFile(string filePath)
        {
            string decryptedFilePath = $"{filePath}.decrypted";

            using (var encryptedFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var decryptedFileStream = new FileStream(decryptedFilePath, FileMode.Create, FileAccess.Write))
            using (var cryptoStream = new CryptoStream(decryptedFileStream, GetAesDecryptor(), CryptoStreamMode.Write))
            {
                encryptedFileStream.CopyTo(cryptoStream);
            }

            File.Delete(filePath);
            File.Move(decryptedFilePath, filePath);
        }

        private ICryptoTransform GetAesEncryptor()
        {
            byte[] key = Encoding.UTF8.GetBytes("YourSecretKey123"); // Replace with a secure key
            byte[] iv = Encoding.UTF8.GetBytes("YourInitializationVector"); // Replace with a secure IV

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                return aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            }
        }

        private ICryptoTransform GetAesDecryptor()
        {
            byte[] key = Encoding.UTF8.GetBytes("YourSecretKey123"); // Replace with the same key used for encryption
            byte[] iv = Encoding.UTF8.GetBytes("YourInitializationVector"); // Replace with the same IV used for encryption

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                return aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            }
        } */

        private void newSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
