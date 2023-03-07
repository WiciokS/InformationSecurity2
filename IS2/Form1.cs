using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //User selects filepath and adds it to the lbSelectFile also checks if the file is already added
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!lbSelectFile.Items.Contains(file))
                    {
                        lbSelectFile.Items.Add(file);
                    }
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            //save text from rtbResult to a file selected in listbox lbSelectFile
            if (lbSelectFile.SelectedIndex != -1)
            {
                System.IO.File.WriteAllText(lbSelectFile.SelectedItem.ToString(), rtbResult.Text);
            }
            //add form feedback with ok button
            MessageBox.Show("File saved successfully!", "Success"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //write a method that will add to cbCipherMode all the available cipher modes
        private void Form1_Load()
        {
            cbCipherMode.Items.Add("ECB");
            cbCipherMode.Items.Add("CBC");
            cbCipherMode.Items.Add("CFB");
            //cbCipherMode.Items.Add("OFB");
            //add to cbEncryptDecrypt all the available options
            cbEncryptDecrypt.Items.Add("Encrypt");
            cbEncryptDecrypt.Items.Add("Decrypt");
            //add to cbReadData all the available options
            cbReadData.Items.Add("Read from file");
            cbReadData.Items.Add("Read from text box");
        }

        private void btnWriteDataFromSelectedFile_Click(object sender, EventArgs e)
        {
            //write text from a file selected in listbox lbSelectFile to rtbEnterText
            if (lbSelectFile.SelectedIndex != -1)
            {
                rtbEnterText.Text = System.IO.File.ReadAllText(lbSelectFile.SelectedItem.ToString());
            }
            //add form feedback with ok button
            MessageBox.Show("File read successfully!", "Success"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //looking what is selected in cbReadData save data to string from rtbEnterText or from a file selected in listbox lbSelectFile
            string data = "";
            if (cbReadData.SelectedIndex == 0)
            {
                if (lbSelectFile.SelectedIndex != -1)
                {
                    data = System.IO.File.ReadAllText(lbSelectFile.SelectedItem.ToString());
                }
            }
            else if (cbReadData.SelectedIndex == 1)
            {
                data = rtbEnterText.Text;
            }
            //save data from tbEnterKey to string
            string key = tbEnterKey.Text;
            //looking what is selected in cbEncryptDecrypt save data to string
            string encryptDecrypt = "";
            if (cbEncryptDecrypt.SelectedIndex == 0)
            {
                encryptDecrypt = "Encrypt";
            }
            else if (cbEncryptDecrypt.SelectedIndex == 1)
            {
                encryptDecrypt = "Decrypt";
            }
            //looking what is selected in cbCipherMode save data to string
            string cipherMode = "";
            if (cbCipherMode.SelectedIndex == 0)
            {
                cipherMode = "ECB";
            }
            else if (cbCipherMode.SelectedIndex == 1)
            {
                cipherMode = "CBC";
            }
            else if (cbCipherMode.SelectedIndex == 2)
            {
                cipherMode = "CFB";
            }

            //Save original text to rtbOriginalText
            rtbOriginalText.Text = data;

            //create CryptoService object
            CryptoService cs = new CryptoService();

            //if selected encrypt and ECB call EncryptECB
            if (encryptDecrypt == "Encrypt" && cipherMode == "ECB")
            {
                rtbResult.Text = cs.EncryptECB(data, key);
            }
            //if selected encrypt and CBC call EncryptCBC
            else if (encryptDecrypt == "Encrypt" && cipherMode == "CBC")
            {
                rtbResult.Text = cs.EncryptCBC(data, key);
            }
            //if selected encrypt and CFB call EncryptCFB
            else if (encryptDecrypt == "Encrypt" && cipherMode == "CFB")
            {
                rtbResult.Text = cs.EncryptCFB(data, key);
            }
            //if selected decrypt and ECB call DecryptECB
            else if (encryptDecrypt == "Decrypt" && cipherMode == "ECB")
            {
                rtbResult.Text = cs.DecryptECB(data, key);
            }
            //if selected decrypt and CBC call DecryptCBC
            else if (encryptDecrypt == "Decrypt" && cipherMode == "CBC")
            {
                rtbResult.Text = cs.DecryptCBC(data, key);
            }
            //if selected decrypt and CFB call DecryptCFB
            else if (encryptDecrypt == "Decrypt" && cipherMode == "CFB")
            {
                rtbResult.Text = cs.DecryptCFB(data, key);
            }



        }

        private void btnGenerateRandomKey_Click(object sender, EventArgs e)
        {
            //Generate random word of 8-16 characters and save it to tbEnterKey
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string result = new string(Enumerable.Repeat(chars, random.Next(8, 16))
                                       .Select(s => s[random.Next(s.Length)])
                                       .ToArray());
            tbEnterKey.Text = result;

        }
    }
}
