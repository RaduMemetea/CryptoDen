using Algorithms;
using Algorithms.Hash;
using System;
using System.IO;
using System.Windows.Forms;

namespace CryptoDen
{
    public partial class MainPage : Form
    {
        String fileContent = string.Empty;
        String filePath = string.Empty;

        public MainPage()
        {
            InitializeComponent();

            AlgorithmSelect.Items.Add("Caesar");
            AlgorithmSelect.Items.Add("Playfaire");
            AlgorithmSelect.Items.Add("RSA");

            MakeAllSettingsInvisible();
            AlgorithmSelect.SelectedIndex = 0;
            AlgorithmSelect_SelectedIndexChanged(null, null);

            RSAKeySize.Items.Add(RSA.KeySize.Key512);
            RSAKeySize.Items.Add(RSA.KeySize.Key1024);
            RSAKeySize.Items.Add(RSA.KeySize.Key2048);
            RSAKeySize.Items.Add(RSA.KeySize.Key4096);

            RSAKeySize.SelectedIndex = 2;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (NormalText.TextLength < 1)
                return;

            switch (AlgorithmSelect.SelectedIndex)
            {
                case 0:
                    var caesar = new Caesar((int)caesarShift.Value, string25Key.Text);
                    EncryptedText.Text = caesar.Encrypt(NormalText.Text);
                    break;

                case 1:
                    var playfaire = new Playfair(string25Key.Text);
                    EncryptedText.Text = playfaire.Encrypt(NormalText.Text);
                    break;

                case 2:
                    RSA rsa;
                    if (rsaPublicText.TextLength < 10 || rsaPrivateText.TextLength < 10)
                        rsa = new RSA((RSA.KeySize)RSAKeySize.SelectedItem);
                    else
                        rsa = new RSA(rsaPublicText.Text, rsaPrivateText.Text);

                    rsaPublicText.Text = rsa.Keys.PublicKey;
                    rsaPrivateText.Text = rsa.Keys.PrivateKey;


                    EncryptedText.Text = rsa.Encrypt(NormalText.Text);

                    break;


                default:
                    break;
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptedText.TextLength < 1)
                return;

            switch (AlgorithmSelect.SelectedIndex)
            {
                case 0:
                    var caesar = new Caesar((int)caesarShift.Value, string25Key.Text);
                    NormalText.Text = caesar.Decrypt(EncryptedText.Text);
                    break;

                case 1:
                    var playfaire = new Playfair(string25Key.Text);
                    NormalText.Text = playfaire.Decrypt(EncryptedText.Text);
                    break;

                case 2:
                    var rsa = new RSA(rsaPublicText.Text, rsaPrivateText.Text);
                    NormalText.Text = rsa.Decrypt(EncryptedText.Text);
                    break;


                default:
                    break;
            }
        }

        private void genKeyButton_Click(object sender, EventArgs e)
        {
            switch (AlgorithmSelect.SelectedIndex)
            {
                case 0:
                    string25Key.Text = new Caesar().GenerateRandomKey();
                    break;

                case 1:
                    string25Key.Text = new Playfair().GenerateRandomKey();
                    break;

                case 2:
                    var rsa = new RSA((RSA.KeySize)RSAKeySize.SelectedItem);
                    rsaPublicText.Text = rsa.Keys.PublicKey;
                    rsaPrivateText.Text = rsa.Keys.PrivateKey;
                    break;


                default:
                    break;
            }
        }

        private void AlgorithmSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AlgorithmSelect.SelectedIndex)
            {
                case 0:
                    MakeAllSettingsInvisible();
                    MakeControlsVisible(new Control[] { label7, label8, caesarShift, string25Key });
                    break;

                case 1:
                    MakeAllSettingsInvisible();
                    MakeControlsVisible(new Control[] { label8, string25Key });
                    break;

                case 2:
                    MakeAllSettingsInvisible();
                    MakeControlsVisible(new Control[] { label9, RSAKeySize, rsaSettings });
                    break;


            }
        }

        private void MakeAllSettingsInvisible()
        {
            Control[] list = { label7, label8, label9, caesarShift, string25Key, RSAKeySize, rsaSettings };
            foreach (var item in list)
                item.Visible = false;

        }
        private void MakeControlsVisible(Control[] controls)
        {
            foreach (var item in controls)
                item.Visible = true;
        }

        private void GenerateHashButton_Click(object sender, EventArgs e)
        {



            if (textRadio.Checked)
                if (HashInputTextBox.TextLength < 1 ) return;
                else
                    GenerateHashOutput(HashInputTextBox.Text);

            if (fileRadio.Checked)
                if (fileContent.Length < 1) return;
                else
                    GenerateHashOutput(fileContent);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textRadio.Checked)
                HashInputTextBox.Enabled = true;
            else
                HashInputTextBox.Enabled = false;

            if (fileRadio.Checked)
                BrowseButton.Enabled = true;
            else
                BrowseButton.Enabled = false;

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            fileTextBox.Text = filePath;

        }

        private void GenerateHashOutput(string input)
        {
            sha1TextBox.Text = SHA.Hash(input, ShaSize.SHA1);
            sha256TextBox.Text = SHA.Hash(input, ShaSize.SHA256);
            sha384TextBox.Text = SHA.Hash(input, ShaSize.SHA384);
            sha512TextBox.Text = SHA.Hash(input, ShaSize.SHA512);
            md5TextBox.Text = Md5.Hash(input);
        }
    }
}
