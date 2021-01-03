using Algorithms;
using System;
using System.Windows.Forms;

namespace CryptoDen
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            AlgorithmSelect.Items.Add("Caesar");
            AlgorithmSelect.Items.Add("Playfaire");
            AlgorithmSelect.Items.Add("RSA");


            AlgorithmSelect.SelectedIndex = 0;

            RSAKeySize.Items.Add(RSA.KeySize.Key512);
            RSAKeySize.Items.Add(RSA.KeySize.Key1024);
            RSAKeySize.Items.Add(RSA.KeySize.Key2048);
            RSAKeySize.Items.Add(RSA.KeySize.Key4096);

            MakeAllSettingsInvisible();
            RSAKeySize.SelectedIndex = 0;
            AlgorithmSelect_SelectedIndexChanged(null, null);
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
    }
}
