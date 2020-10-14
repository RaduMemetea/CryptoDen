using Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoDen
{
    public partial class MainWindow : Form
    {
        private Lazy<Playfair> Playfair = new Lazy<Playfair>();
        private Lazy<RSA> RSA = new Lazy<RSA>();
        private Lazy<Caesar> Caesar = new Lazy<Caesar>();

        public MainWindow()
        {
            InitializeComponent();
        }


        #region Caesar Tab Control Events
        private void CaesarEncryptButton_Click(object sender, EventArgs e)
        {
            if (CaesarKeyBox.TextLength > 0)
                Caesar = new Lazy<Caesar>(() => new Caesar(Convert.ToInt32(CaesarShiftNumberBox.Value), CaesarKeyBox.Text));
            else
                Caesar = new Lazy<Caesar>(() => new Caesar(Convert.ToInt32(CaesarShiftNumberBox.Value)));

            if (CaesarNormalText.TextLength > 0)
                CaesarEncryptedText.Text = Caesar.Value.Encrypt(CaesarNormalText.Text);

            CaesarKeyBox.Text = Caesar.Value.GetKeys();
            CaesarAlphabetBox.Text = Caesar.Value.GetAlphabet();

        }

        private void CaesarDecryptButton_Click(object sender, EventArgs e)
        {
            if (CaesarKeyBox.TextLength > 0)
            {
                Caesar = new Lazy<Caesar>(() => new Caesar(Convert.ToInt32(CaesarShiftNumberBox.Value), CaesarKeyBox.Text));

                CaesarNormalText.Text = Caesar.Value.Decrypt(CaesarEncryptedText.Text);
                CaesarAlphabetBox.Text = Caesar.Value.GetAlphabet();
            }
            else
                CaesarNormalText.Text = "Please insert a key!";
        }

        private void CaesarKeyButton_Click(object sender, EventArgs e)
        {
            Caesar = new Lazy<Caesar>(() => new Caesar(Convert.ToInt32(CaesarShiftNumberBox.Value)));
            CaesarKeyBox.Text = Caesar.Value.GetKeys();
            CaesarAlphabetBox.Text = Caesar.Value.GetAlphabet();
        }

        #endregion

        #region Playfair Tab Control Events
        private void PlayfairEncryptButton_Click(object sender, EventArgs e)
        {
            if (PlayfairKeyBox.Text.Length > 0)
                Playfair.Value.ModifyKey(PlayfairKeyBox.Text);

            if (PlayfairNormalText.TextLength > 0)
                PlayfairEncryptedText.Text = Playfair.Value.Encrypt(PlayfairNormalText.Text);

            PlayfairMatrixBox.Text = Playfair.Value.GetMatrix();
            PlayfairKeyBox.Text = Playfair.Value.GetKeys();
        }


        private void PlayfairDecryptButton_Click(object sender, EventArgs e)
        {
            if (PlayfairKeyBox.Text.Length > 0)
                Playfair.Value.ModifyKey(PlayfairKeyBox.Text);
            else
            {
                PlayfairNormalText.Text = "Invalid Key!";
                return;
            }

            if (PlayfairEncryptedText.TextLength > 0)
            {
                string response = Playfair.Value.Decrypt(PlayfairEncryptedText.Text);
                if (response == null)
                {
                    PlayfairNormalText.Text = "Encrypted text was invalid!";
                    return;
                }

                PlayfairNormalText.Text = response;
                PlayfairMatrixBox.Text = Playfair.Value.GetMatrix();
                PlayfairKeyBox.Text = Playfair.Value.GetKeys();
            }
        }

        private void PlayfairKeyButton_Click(object sender, EventArgs e)
        {
            Playfair = new Lazy<Playfair>();
            PlayfairKeyBox.Text = Playfair.Value.GetKeys();
            PlayfairMatrixBox.Text = Playfair.Value.GetMatrix();
        }
        #endregion

        #region RSA Tab Control Events

        private void RSAEncryptButton_Click(object sender, EventArgs e)
        {
            if (RSAFactorsCheckBox.Checked == true && pRSAnumeric.Value > 0 && qRSAnumeric.Value > 0)
            {
                if (pRSAnumeric.Value * qRSAnumeric.Value < 127)
                {
                    RSAEncryptedText.Text = "Please chose other values, P*Q must be >=127";
                    return;
                }

                RSA = new Lazy<RSA>(() => new RSA(Convert.ToInt64(pRSAnumeric.Value), Convert.ToInt64(qRSAnumeric.Value)));

            }
            else
            if (RSAFactorsCheckBox.Checked == false && NPublicKey.Value > 0 && EPublicKey.Value > 0 && NPrivateKey.Value > 0 && DPrivateKey.Value > 0)
            {
                RSA = new Lazy<RSA>(() => new RSA(
                    Tuple.Create(Convert.ToInt64(NPublicKey.Value), Convert.ToInt64(EPublicKey.Value)),
                    Tuple.Create(Convert.ToInt64(NPrivateKey.Value), Convert.ToInt64(DPrivateKey.Value))
                    ));
            }
            else
                RSA = new Lazy<RSA>();


            if (RSANormalText.TextLength > 0)
                RSAEncryptedText.Text = RSA.Value.Encrypt(RSANormalText.Text);

            var keys = RSA.Value.GetKeys();
            NPublicKey.Value = keys.Item1.Item1;
            EPublicKey.Value = keys.Item1.Item2;
            NPrivateKey.Value = keys.Item2.Item1;
            DPrivateKey.Value = keys.Item2.Item2;
        }

        private void RSADecryptButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(RSAEncryptedText.Text, @"[^0-9 ]"))
            {
                RSANormalText.Text = "Invalid Encrypted text. Only numbers and spaces allowed!";
                return;
            }

            if (NPublicKey.Value > 0 && EPublicKey.Value > 0 && NPrivateKey.Value > 0 && DPrivateKey.Value > 0)
            {
                RSA = new Lazy<RSA>(() => new RSA(
                    Tuple.Create(Convert.ToInt64(NPublicKey.Value), Convert.ToInt64(EPublicKey.Value)),
                    Tuple.Create(Convert.ToInt64(NPrivateKey.Value), Convert.ToInt64(DPrivateKey.Value))
                    ));

                if (RSAEncryptedText.TextLength > 0)
                    RSANormalText.Text = RSA.Value.Decrypt(RSAEncryptedText.Text);
            }
            else
                RSANormalText.Text = "Please set the apropriate key values!";
        }

        private void RSAFactorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RSAFactorsCheckBox.Checked == true)
            {
                pRSAnumeric.Enabled = true;
                qRSAnumeric.Enabled = true;
            }
            if (RSAFactorsCheckBox.Checked == false)
            {
                pRSAnumeric.Enabled = false;
                qRSAnumeric.Enabled = false;
            }
        }

        #endregion


    }
}
