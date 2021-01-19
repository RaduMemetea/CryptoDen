
namespace CryptoDen
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Crypt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NormalText = new System.Windows.Forms.TextBox();
            this.EncryptedText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RSAKeySize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genKeyButton = new System.Windows.Forms.Button();
            this.rsaSettings = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rsaPublicText = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rsaPrivateText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.string25Key = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.caesarShift = new System.Windows.Forms.NumericUpDown();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.AlgorithmSelect = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HashInputTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileRadio = new System.Windows.Forms.RadioButton();
            this.textRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sha512TextBox = new System.Windows.Forms.TextBox();
            this.sha384TextBox = new System.Windows.Forms.TextBox();
            this.sha256TextBox = new System.Windows.Forms.TextBox();
            this.sha1TextBox = new System.Windows.Forms.TextBox();
            this.md5TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateHashButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Tabs.SuspendLayout();
            this.Crypt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rsaSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarShift)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Crypt);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1024, 640);
            this.Tabs.TabIndex = 0;
            // 
            // Crypt
            // 
            this.Crypt.Controls.Add(this.tableLayoutPanel1);
            this.Crypt.Location = new System.Drawing.Point(4, 24);
            this.Crypt.Name = "Crypt";
            this.Crypt.Padding = new System.Windows.Forms.Padding(3);
            this.Crypt.Size = new System.Drawing.Size(1016, 612);
            this.Crypt.TabIndex = 0;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.NormalText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EncryptedText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 606);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NormalText
            // 
            this.NormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NormalText.Location = new System.Drawing.Point(3, 3);
            this.NormalText.Multiline = true;
            this.NormalText.Name = "NormalText";
            this.NormalText.PlaceholderText = "Insert here the normal text.";
            this.NormalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NormalText.Size = new System.Drawing.Size(398, 600);
            this.NormalText.TabIndex = 0;
            // 
            // EncryptedText
            // 
            this.EncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedText.Location = new System.Drawing.Point(609, 3);
            this.EncryptedText.Multiline = true;
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.PlaceholderText = "Here is the encrypted text.";
            this.EncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncryptedText.Size = new System.Drawing.Size(398, 600);
            this.EncryptedText.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RSAKeySize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.genKeyButton);
            this.groupBox1.Controls.Add(this.rsaSettings);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.string25Key);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.caesarShift);
            this.groupBox1.Controls.Add(this.DecryptButton);
            this.groupBox1.Controls.Add(this.EncryptButton);
            this.groupBox1.Controls.Add(this.AlgorithmSelect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(404, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 606);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // RSAKeySize
            // 
            this.RSAKeySize.AutoCompleteCustomSource.AddRange(new string[] {
            "Key512",
            "Key1024",
            "Key2048",
            "Key4096"});
            this.RSAKeySize.FormattingEnabled = true;
            this.RSAKeySize.Location = new System.Drawing.Point(64, 190);
            this.RSAKeySize.Name = "RSAKeySize";
            this.RSAKeySize.Size = new System.Drawing.Size(132, 23);
            this.RSAKeySize.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Key size:";
            // 
            // genKeyButton
            // 
            this.genKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genKeyButton.AutoSize = true;
            this.genKeyButton.Location = new System.Drawing.Point(6, 97);
            this.genKeyButton.Name = "genKeyButton";
            this.genKeyButton.Size = new System.Drawing.Size(193, 25);
            this.genKeyButton.TabIndex = 8;
            this.genKeyButton.Text = "Generate Key";
            this.genKeyButton.UseVisualStyleBackColor = true;
            this.genKeyButton.Click += new System.EventHandler(this.genKeyButton_Click);
            // 
            // rsaSettings
            // 
            this.rsaSettings.Controls.Add(this.splitContainer1);
            this.rsaSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rsaSettings.Location = new System.Drawing.Point(3, 219);
            this.rsaSettings.Name = "rsaSettings";
            this.rsaSettings.Size = new System.Drawing.Size(196, 384);
            this.rsaSettings.TabIndex = 7;
            this.rsaSettings.TabStop = false;
            this.rsaSettings.Text = "RSA keys";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 19);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1MinSize = 1;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2MinSize = 1;
            this.splitContainer1.Size = new System.Drawing.Size(190, 362);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rsaPublicText);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 193);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Public";
            // 
            // rsaPublicText
            // 
            this.rsaPublicText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rsaPublicText.Location = new System.Drawing.Point(3, 19);
            this.rsaPublicText.Multiline = true;
            this.rsaPublicText.Name = "rsaPublicText";
            this.rsaPublicText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rsaPublicText.Size = new System.Drawing.Size(184, 171);
            this.rsaPublicText.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rsaPrivateText);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 165);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Private";
            // 
            // rsaPrivateText
            // 
            this.rsaPrivateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rsaPrivateText.Location = new System.Drawing.Point(3, 19);
            this.rsaPrivateText.Multiline = true;
            this.rsaPrivateText.Name = "rsaPrivateText";
            this.rsaPrivateText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rsaPrivateText.Size = new System.Drawing.Size(184, 143);
            this.rsaPrivateText.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Key:";
            // 
            // string25Key
            // 
            this.string25Key.Location = new System.Drawing.Point(49, 160);
            this.string25Key.MaxLength = 100;
            this.string25Key.Name = "string25Key";
            this.string25Key.Size = new System.Drawing.Size(147, 23);
            this.string25Key.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Shift:";
            // 
            // caesarShift
            // 
            this.caesarShift.AutoSize = true;
            this.caesarShift.Location = new System.Drawing.Point(49, 131);
            this.caesarShift.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.caesarShift.Name = "caesarShift";
            this.caesarShift.Size = new System.Drawing.Size(147, 23);
            this.caesarShift.TabIndex = 1;
            this.caesarShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.AutoSize = true;
            this.DecryptButton.Location = new System.Drawing.Point(100, 48);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(99, 42);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.AutoSize = true;
            this.EncryptButton.Location = new System.Drawing.Point(6, 48);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(94, 42);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // AlgorithmSelect
            // 
            this.AlgorithmSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlgorithmSelect.FormattingEnabled = true;
            this.AlgorithmSelect.Location = new System.Drawing.Point(3, 19);
            this.AlgorithmSelect.Name = "AlgorithmSelect";
            this.AlgorithmSelect.Size = new System.Drawing.Size(196, 23);
            this.AlgorithmSelect.TabIndex = 0;
            this.AlgorithmSelect.SelectedIndexChanged += new System.EventHandler(this.AlgorithmSelect_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hash";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.GenerateHashButton, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1010, 606);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HashInputTextBox);
            this.groupBox2.Controls.Add(this.BrowseButton);
            this.groupBox2.Controls.Add(this.fileTextBox);
            this.groupBox2.Controls.Add(this.fileRadio);
            this.groupBox2.Controls.Add(this.textRadio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 324);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // HashInputTextBox
            // 
            this.HashInputTextBox.Location = new System.Drawing.Point(59, 23);
            this.HashInputTextBox.Multiline = true;
            this.HashInputTextBox.Name = "HashInputTextBox";
            this.HashInputTextBox.PlaceholderText = "Insert text here";
            this.HashInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HashInputTextBox.Size = new System.Drawing.Size(939, 264);
            this.HashInputTextBox.TabIndex = 4;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Enabled = false;
            this.BrowseButton.Location = new System.Drawing.Point(923, 293);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextBox.Location = new System.Drawing.Point(59, 293);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(858, 23);
            this.fileTextBox.TabIndex = 2;
            // 
            // fileRadio
            // 
            this.fileRadio.AutoSize = true;
            this.fileRadio.Location = new System.Drawing.Point(7, 294);
            this.fileRadio.Name = "fileRadio";
            this.fileRadio.Size = new System.Drawing.Size(43, 19);
            this.fileRadio.TabIndex = 1;
            this.fileRadio.Text = "File";
            this.fileRadio.UseVisualStyleBackColor = true;
            this.fileRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textRadio
            // 
            this.textRadio.AutoSize = true;
            this.textRadio.Checked = true;
            this.textRadio.Location = new System.Drawing.Point(7, 23);
            this.textRadio.Name = "textRadio";
            this.textRadio.Size = new System.Drawing.Size(46, 19);
            this.textRadio.TabIndex = 0;
            this.textRadio.TabStop = true;
            this.textRadio.Text = "Text";
            this.textRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sha512TextBox);
            this.groupBox3.Controls.Add(this.sha384TextBox);
            this.groupBox3.Controls.Add(this.sha256TextBox);
            this.groupBox3.Controls.Add(this.sha1TextBox);
            this.groupBox3.Controls.Add(this.md5TextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1004, 214);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // sha512TextBox
            // 
            this.sha512TextBox.Location = new System.Drawing.Point(90, 136);
            this.sha512TextBox.Name = "sha512TextBox";
            this.sha512TextBox.ReadOnly = true;
            this.sha512TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sha512TextBox.Size = new System.Drawing.Size(908, 23);
            this.sha512TextBox.TabIndex = 10;
            // 
            // sha384TextBox
            // 
            this.sha384TextBox.Location = new System.Drawing.Point(90, 107);
            this.sha384TextBox.Name = "sha384TextBox";
            this.sha384TextBox.ReadOnly = true;
            this.sha384TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sha384TextBox.Size = new System.Drawing.Size(908, 23);
            this.sha384TextBox.TabIndex = 9;
            // 
            // sha256TextBox
            // 
            this.sha256TextBox.Location = new System.Drawing.Point(90, 78);
            this.sha256TextBox.Name = "sha256TextBox";
            this.sha256TextBox.ReadOnly = true;
            this.sha256TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sha256TextBox.Size = new System.Drawing.Size(908, 23);
            this.sha256TextBox.TabIndex = 8;
            // 
            // sha1TextBox
            // 
            this.sha1TextBox.Location = new System.Drawing.Point(90, 49);
            this.sha1TextBox.Name = "sha1TextBox";
            this.sha1TextBox.ReadOnly = true;
            this.sha1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sha1TextBox.Size = new System.Drawing.Size(908, 23);
            this.sha1TextBox.TabIndex = 7;
            // 
            // md5TextBox
            // 
            this.md5TextBox.Location = new System.Drawing.Point(90, 20);
            this.md5TextBox.Name = "md5TextBox";
            this.md5TextBox.ReadOnly = true;
            this.md5TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.md5TextBox.Size = new System.Drawing.Size(908, 23);
            this.md5TextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "SHA512:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SHA384:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHA256:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5:";
            // 
            // GenerateHashButton
            // 
            this.GenerateHashButton.Location = new System.Drawing.Point(3, 553);
            this.GenerateHashButton.Name = "GenerateHashButton";
            this.GenerateHashButton.Size = new System.Drawing.Size(139, 48);
            this.GenerateHashButton.TabIndex = 2;
            this.GenerateHashButton.Text = "Generate";
            this.GenerateHashButton.UseVisualStyleBackColor = true;
            this.GenerateHashButton.Click += new System.EventHandler(this.GenerateHashButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "textBox1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.Tabs);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Tabs.ResumeLayout(false);
            this.Crypt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rsaSettings.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarShift)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Crypt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NormalText;
        private System.Windows.Forms.TextBox EncryptedText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button genKeyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox HashInputTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.RadioButton textRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sha512TextBox;
        private System.Windows.Forms.TextBox sha384TextBox;
        private System.Windows.Forms.TextBox sha256TextBox;
        private System.Windows.Forms.TextBox sha1TextBox;
        private System.Windows.Forms.TextBox md5TextBox;
        private System.Windows.Forms.Button GenerateHashButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.ComboBox AlgorithmSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown caesarShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox string25Key;
        private System.Windows.Forms.GroupBox rsaSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox rsaPublicText;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox rsaPrivateText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RSAKeySize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}