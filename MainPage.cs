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

            RSAKeySize.SelectedIndex = 0;
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

                    break;


                default:
                    break;
            }
        }
    }
}
