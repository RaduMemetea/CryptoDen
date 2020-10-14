namespace CryptoDen
{
    partial class MainWindow
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
            this.TabsWindow = new System.Windows.Forms.TabControl();
            this.CaesarTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CaesarAlphabetBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CaesarKeyBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CaesarEncryptedText = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.CaesarNormalText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CaesarShiftNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CaesarKeyButton = new System.Windows.Forms.Button();
            this.CaesarDecryptButton = new System.Windows.Forms.Button();
            this.CaesarEncryptButton = new System.Windows.Forms.Button();
            this.PlayfairTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grupBox7 = new System.Windows.Forms.GroupBox();
            this.PlayfairMatrixBox = new System.Windows.Forms.TextBox();
            this.grupBox6 = new System.Windows.Forms.GroupBox();
            this.PlayfairKeyBox = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.GroupBox();
            this.PlayfairEncryptedText = new System.Windows.Forms.TextBox();
            this.NormalTextBos = new System.Windows.Forms.GroupBox();
            this.PlayfairNormalText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayfairKeyButton = new System.Windows.Forms.Button();
            this.PlayfairDecryptButton = new System.Windows.Forms.Button();
            this.PlayfairEncryptButton = new System.Windows.Forms.Button();
            this.RSATab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EPublicKey = new System.Windows.Forms.NumericUpDown();
            this.NPublicKey = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NPrivateKey = new System.Windows.Forms.NumericUpDown();
            this.DPrivateKey = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RSAEncryptedText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RSANormalText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RSAFactorsCheckBox = new System.Windows.Forms.CheckBox();
            this.qRSAnumeric = new System.Windows.Forms.NumericUpDown();
            this.pRSAnumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RSADecryptButton = new System.Windows.Forms.Button();
            this.RSAEncryptButton = new System.Windows.Forms.Button();
            this.TabsWindow.SuspendLayout();
            this.CaesarTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarShiftNumberBox)).BeginInit();
            this.PlayfairTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grupBox7.SuspendLayout();
            this.grupBox6.SuspendLayout();
            this.EncryptedTextBox.SuspendLayout();
            this.NormalTextBos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RSATab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPublicKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPublicKey)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPrivateKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPrivateKey)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRSAnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSAnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TabsWindow
            // 
            this.TabsWindow.Controls.Add(this.CaesarTab);
            this.TabsWindow.Controls.Add(this.PlayfairTab);
            this.TabsWindow.Controls.Add(this.RSATab);
            this.TabsWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsWindow.Location = new System.Drawing.Point(0, 0);
            this.TabsWindow.Name = "TabsWindow";
            this.TabsWindow.SelectedIndex = 0;
            this.TabsWindow.Size = new System.Drawing.Size(878, 555);
            this.TabsWindow.TabIndex = 0;
            // 
            // CaesarTab
            // 
            this.CaesarTab.Controls.Add(this.tableLayoutPanel3);
            this.CaesarTab.Location = new System.Drawing.Point(4, 22);
            this.CaesarTab.Name = "CaesarTab";
            this.CaesarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaesarTab.Size = new System.Drawing.Size(870, 529);
            this.CaesarTab.TabIndex = 0;
            this.CaesarTab.Text = "Caesar";
            this.CaesarTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(864, 523);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CaesarAlphabetBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(348, 368);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 152);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Caesar Alphabet";
            // 
            // CaesarAlphabetBox
            // 
            this.CaesarAlphabetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaesarAlphabetBox.Location = new System.Drawing.Point(3, 16);
            this.CaesarAlphabetBox.Multiline = true;
            this.CaesarAlphabetBox.Name = "CaesarAlphabetBox";
            this.CaesarAlphabetBox.ReadOnly = true;
            this.CaesarAlphabetBox.Size = new System.Drawing.Size(160, 133);
            this.CaesarAlphabetBox.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.CaesarKeyBox);
            this.groupBox7.Location = new System.Drawing.Point(348, 318);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(166, 44);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Key";
            // 
            // CaesarKeyBox
            // 
            this.CaesarKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaesarKeyBox.Location = new System.Drawing.Point(3, 16);
            this.CaesarKeyBox.MaxLength = 36;
            this.CaesarKeyBox.Name = "CaesarKeyBox";
            this.CaesarKeyBox.Size = new System.Drawing.Size(160, 20);
            this.CaesarKeyBox.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.CaesarEncryptedText);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(520, 3);
            this.groupBox8.Name = "groupBox8";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox8, 3);
            this.groupBox8.Size = new System.Drawing.Size(341, 517);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Encrypted Text";
            // 
            // CaesarEncryptedText
            // 
            this.CaesarEncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaesarEncryptedText.Location = new System.Drawing.Point(3, 16);
            this.CaesarEncryptedText.Multiline = true;
            this.CaesarEncryptedText.Name = "CaesarEncryptedText";
            this.CaesarEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CaesarEncryptedText.Size = new System.Drawing.Size(335, 498);
            this.CaesarEncryptedText.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.CaesarNormalText);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox9, 3);
            this.groupBox9.Size = new System.Drawing.Size(339, 517);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Normal Text";
            // 
            // CaesarNormalText
            // 
            this.CaesarNormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaesarNormalText.Location = new System.Drawing.Point(3, 16);
            this.CaesarNormalText.Multiline = true;
            this.CaesarNormalText.Name = "CaesarNormalText";
            this.CaesarNormalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CaesarNormalText.Size = new System.Drawing.Size(333, 498);
            this.CaesarNormalText.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CaesarShiftNumberBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CaesarKeyButton);
            this.panel3.Controls.Add(this.CaesarDecryptButton);
            this.panel3.Controls.Add(this.CaesarEncryptButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(348, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 297);
            this.panel3.TabIndex = 10;
            // 
            // CaesarShiftNumberBox
            // 
            this.CaesarShiftNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarShiftNumberBox.Location = new System.Drawing.Point(37, 262);
            this.CaesarShiftNumberBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CaesarShiftNumberBox.Name = "CaesarShiftNumberBox";
            this.CaesarShiftNumberBox.Size = new System.Drawing.Size(126, 20);
            this.CaesarShiftNumberBox.TabIndex = 4;
            this.CaesarShiftNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Shift:";
            // 
            // CaesarKeyButton
            // 
            this.CaesarKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarKeyButton.Location = new System.Drawing.Point(37, 165);
            this.CaesarKeyButton.Name = "CaesarKeyButton";
            this.CaesarKeyButton.Size = new System.Drawing.Size(90, 23);
            this.CaesarKeyButton.TabIndex = 2;
            this.CaesarKeyButton.Text = "New Key";
            this.CaesarKeyButton.UseVisualStyleBackColor = true;
            this.CaesarKeyButton.Click += new System.EventHandler(this.CaesarKeyButton_Click);
            // 
            // CaesarDecryptButton
            // 
            this.CaesarDecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarDecryptButton.Location = new System.Drawing.Point(38, 107);
            this.CaesarDecryptButton.Name = "CaesarDecryptButton";
            this.CaesarDecryptButton.Size = new System.Drawing.Size(90, 23);
            this.CaesarDecryptButton.TabIndex = 1;
            this.CaesarDecryptButton.Text = "Decrypt";
            this.CaesarDecryptButton.UseVisualStyleBackColor = true;
            this.CaesarDecryptButton.Click += new System.EventHandler(this.CaesarDecryptButton_Click);
            // 
            // CaesarEncryptButton
            // 
            this.CaesarEncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarEncryptButton.Location = new System.Drawing.Point(37, 53);
            this.CaesarEncryptButton.Name = "CaesarEncryptButton";
            this.CaesarEncryptButton.Size = new System.Drawing.Size(90, 23);
            this.CaesarEncryptButton.TabIndex = 0;
            this.CaesarEncryptButton.Text = "Encrypt";
            this.CaesarEncryptButton.UseVisualStyleBackColor = true;
            this.CaesarEncryptButton.Click += new System.EventHandler(this.CaesarEncryptButton_Click);
            // 
            // PlayfairTab
            // 
            this.PlayfairTab.Controls.Add(this.tableLayoutPanel1);
            this.PlayfairTab.Location = new System.Drawing.Point(4, 22);
            this.PlayfairTab.Name = "PlayfairTab";
            this.PlayfairTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayfairTab.Size = new System.Drawing.Size(870, 529);
            this.PlayfairTab.TabIndex = 1;
            this.PlayfairTab.Text = "Playfair";
            this.PlayfairTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.grupBox7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grupBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EncryptedTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NormalTextBos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 523);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grupBox7
            // 
            this.grupBox7.Controls.Add(this.PlayfairMatrixBox);
            this.grupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupBox7.Location = new System.Drawing.Point(348, 368);
            this.grupBox7.Name = "grupBox7";
            this.grupBox7.Size = new System.Drawing.Size(166, 152);
            this.grupBox7.TabIndex = 9;
            this.grupBox7.TabStop = false;
            this.grupBox7.Text = "Playfair Matrix";
            // 
            // PlayfairMatrixBox
            // 
            this.PlayfairMatrixBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayfairMatrixBox.Location = new System.Drawing.Point(3, 16);
            this.PlayfairMatrixBox.Multiline = true;
            this.PlayfairMatrixBox.Name = "PlayfairMatrixBox";
            this.PlayfairMatrixBox.ReadOnly = true;
            this.PlayfairMatrixBox.Size = new System.Drawing.Size(160, 133);
            this.PlayfairMatrixBox.TabIndex = 0;
            // 
            // grupBox6
            // 
            this.grupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupBox6.Controls.Add(this.PlayfairKeyBox);
            this.grupBox6.Location = new System.Drawing.Point(348, 318);
            this.grupBox6.Name = "grupBox6";
            this.grupBox6.Size = new System.Drawing.Size(166, 44);
            this.grupBox6.TabIndex = 8;
            this.grupBox6.TabStop = false;
            this.grupBox6.Text = "Playfair Key";
            // 
            // PlayfairKeyBox
            // 
            this.PlayfairKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayfairKeyBox.Location = new System.Drawing.Point(3, 16);
            this.PlayfairKeyBox.MaxLength = 25;
            this.PlayfairKeyBox.Name = "PlayfairKeyBox";
            this.PlayfairKeyBox.Size = new System.Drawing.Size(160, 20);
            this.PlayfairKeyBox.TabIndex = 0;
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Controls.Add(this.PlayfairEncryptedText);
            this.EncryptedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedTextBox.Location = new System.Drawing.Point(520, 3);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.EncryptedTextBox, 3);
            this.EncryptedTextBox.Size = new System.Drawing.Size(341, 517);
            this.EncryptedTextBox.TabIndex = 6;
            this.EncryptedTextBox.TabStop = false;
            this.EncryptedTextBox.Text = "Encrypted Text";
            // 
            // PlayfairEncryptedText
            // 
            this.PlayfairEncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayfairEncryptedText.Location = new System.Drawing.Point(3, 16);
            this.PlayfairEncryptedText.Multiline = true;
            this.PlayfairEncryptedText.Name = "PlayfairEncryptedText";
            this.PlayfairEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlayfairEncryptedText.Size = new System.Drawing.Size(335, 498);
            this.PlayfairEncryptedText.TabIndex = 3;
            // 
            // NormalTextBos
            // 
            this.NormalTextBos.Controls.Add(this.PlayfairNormalText);
            this.NormalTextBos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NormalTextBos.Location = new System.Drawing.Point(3, 3);
            this.NormalTextBos.Name = "NormalTextBos";
            this.tableLayoutPanel1.SetRowSpan(this.NormalTextBos, 3);
            this.NormalTextBos.Size = new System.Drawing.Size(339, 517);
            this.NormalTextBos.TabIndex = 4;
            this.NormalTextBos.TabStop = false;
            this.NormalTextBos.Text = "Normal Text";
            // 
            // PlayfairNormalText
            // 
            this.PlayfairNormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayfairNormalText.Location = new System.Drawing.Point(3, 16);
            this.PlayfairNormalText.Multiline = true;
            this.PlayfairNormalText.Name = "PlayfairNormalText";
            this.PlayfairNormalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlayfairNormalText.Size = new System.Drawing.Size(333, 498);
            this.PlayfairNormalText.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlayfairKeyButton);
            this.panel1.Controls.Add(this.PlayfairDecryptButton);
            this.panel1.Controls.Add(this.PlayfairEncryptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(348, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 297);
            this.panel1.TabIndex = 10;
            // 
            // PlayfairKeyButton
            // 
            this.PlayfairKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayfairKeyButton.Location = new System.Drawing.Point(37, 165);
            this.PlayfairKeyButton.Name = "PlayfairKeyButton";
            this.PlayfairKeyButton.Size = new System.Drawing.Size(90, 23);
            this.PlayfairKeyButton.TabIndex = 2;
            this.PlayfairKeyButton.Text = "New Key";
            this.PlayfairKeyButton.UseVisualStyleBackColor = true;
            this.PlayfairKeyButton.Click += new System.EventHandler(this.PlayfairKeyButton_Click);
            // 
            // PlayfairDecryptButton
            // 
            this.PlayfairDecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayfairDecryptButton.Location = new System.Drawing.Point(38, 107);
            this.PlayfairDecryptButton.Name = "PlayfairDecryptButton";
            this.PlayfairDecryptButton.Size = new System.Drawing.Size(90, 23);
            this.PlayfairDecryptButton.TabIndex = 1;
            this.PlayfairDecryptButton.Text = "Decrypt";
            this.PlayfairDecryptButton.UseVisualStyleBackColor = true;
            this.PlayfairDecryptButton.Click += new System.EventHandler(this.PlayfairDecryptButton_Click);
            // 
            // PlayfairEncryptButton
            // 
            this.PlayfairEncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayfairEncryptButton.Location = new System.Drawing.Point(37, 53);
            this.PlayfairEncryptButton.Name = "PlayfairEncryptButton";
            this.PlayfairEncryptButton.Size = new System.Drawing.Size(90, 23);
            this.PlayfairEncryptButton.TabIndex = 0;
            this.PlayfairEncryptButton.Text = "Encrypt";
            this.PlayfairEncryptButton.UseVisualStyleBackColor = true;
            this.PlayfairEncryptButton.Click += new System.EventHandler(this.PlayfairEncryptButton_Click);
            // 
            // RSATab
            // 
            this.RSATab.Controls.Add(this.tableLayoutPanel2);
            this.RSATab.Location = new System.Drawing.Point(4, 22);
            this.RSATab.Name = "RSATab";
            this.RSATab.Padding = new System.Windows.Forms.Padding(3);
            this.RSATab.Size = new System.Drawing.Size(870, 529);
            this.RSATab.TabIndex = 2;
            this.RSATab.Text = "RSA";
            this.RSATab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(864, 523);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(348, 264);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(166, 256);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Size = new System.Drawing.Size(160, 237);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EPublicKey);
            this.groupBox1.Controls.Add(this.NPublicKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key";
            // 
            // EPublicKey
            // 
            this.EPublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EPublicKey.Location = new System.Drawing.Point(29, 71);
            this.EPublicKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.EPublicKey.Name = "EPublicKey";
            this.EPublicKey.Size = new System.Drawing.Size(125, 20);
            this.EPublicKey.TabIndex = 11;
            this.EPublicKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NPublicKey
            // 
            this.NPublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NPublicKey.Location = new System.Drawing.Point(29, 30);
            this.NPublicKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.NPublicKey.Name = "NPublicKey";
            this.NPublicKey.Size = new System.Drawing.Size(125, 20);
            this.NPublicKey.TabIndex = 10;
            this.NPublicKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NPrivateKey);
            this.groupBox5.Controls.Add(this.DPrivateKey);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 137);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Private Key";
            // 
            // NPrivateKey
            // 
            this.NPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NPrivateKey.Location = new System.Drawing.Point(29, 39);
            this.NPrivateKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.NPrivateKey.Name = "NPrivateKey";
            this.NPrivateKey.Size = new System.Drawing.Size(125, 20);
            this.NPrivateKey.TabIndex = 10;
            this.NPrivateKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DPrivateKey
            // 
            this.DPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DPrivateKey.Location = new System.Drawing.Point(29, 80);
            this.DPrivateKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.DPrivateKey.Name = "DPrivateKey";
            this.DPrivateKey.Size = new System.Drawing.Size(125, 20);
            this.DPrivateKey.TabIndex = 9;
            this.DPrivateKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "D:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "N:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RSAEncryptedText);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(520, 3);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox3, 3);
            this.groupBox3.Size = new System.Drawing.Size(341, 517);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encrypted Text";
            // 
            // RSAEncryptedText
            // 
            this.RSAEncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSAEncryptedText.Location = new System.Drawing.Point(3, 16);
            this.RSAEncryptedText.Multiline = true;
            this.RSAEncryptedText.Name = "RSAEncryptedText";
            this.RSAEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RSAEncryptedText.Size = new System.Drawing.Size(335, 498);
            this.RSAEncryptedText.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RSANormalText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox4, 3);
            this.groupBox4.Size = new System.Drawing.Size(339, 517);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Normal Text";
            // 
            // RSANormalText
            // 
            this.RSANormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSANormalText.Location = new System.Drawing.Point(3, 16);
            this.RSANormalText.Multiline = true;
            this.RSANormalText.Name = "RSANormalText";
            this.RSANormalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RSANormalText.Size = new System.Drawing.Size(333, 498);
            this.RSANormalText.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RSAFactorsCheckBox);
            this.panel2.Controls.Add(this.qRSAnumeric);
            this.panel2.Controls.Add(this.pRSAnumeric);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RSADecryptButton);
            this.panel2.Controls.Add(this.RSAEncryptButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(348, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 255);
            this.panel2.TabIndex = 10;
            // 
            // RSAFactorsCheckBox
            // 
            this.RSAFactorsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RSAFactorsCheckBox.AutoSize = true;
            this.RSAFactorsCheckBox.Location = new System.Drawing.Point(12, 171);
            this.RSAFactorsCheckBox.Name = "RSAFactorsCheckBox";
            this.RSAFactorsCheckBox.Size = new System.Drawing.Size(128, 17);
            this.RSAFactorsCheckBox.TabIndex = 10;
            this.RSAFactorsCheckBox.Text = "Use P and Q for Keys";
            this.RSAFactorsCheckBox.UseVisualStyleBackColor = true;
            this.RSAFactorsCheckBox.CheckedChanged += new System.EventHandler(this.RSAFactorsCheckBox_CheckedChanged);
            // 
            // qRSAnumeric
            // 
            this.qRSAnumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qRSAnumeric.Enabled = false;
            this.qRSAnumeric.Location = new System.Drawing.Point(32, 233);
            this.qRSAnumeric.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.qRSAnumeric.Name = "qRSAnumeric";
            this.qRSAnumeric.Size = new System.Drawing.Size(125, 20);
            this.qRSAnumeric.TabIndex = 9;
            this.qRSAnumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pRSAnumeric
            // 
            this.pRSAnumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pRSAnumeric.Enabled = false;
            this.pRSAnumeric.Location = new System.Drawing.Point(32, 194);
            this.pRSAnumeric.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.pRSAnumeric.Name = "pRSAnumeric";
            this.pRSAnumeric.Size = new System.Drawing.Size(125, 20);
            this.pRSAnumeric.TabIndex = 8;
            this.pRSAnumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Q:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "P:";
            // 
            // RSADecryptButton
            // 
            this.RSADecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RSADecryptButton.Location = new System.Drawing.Point(38, 107);
            this.RSADecryptButton.Name = "RSADecryptButton";
            this.RSADecryptButton.Size = new System.Drawing.Size(90, 23);
            this.RSADecryptButton.TabIndex = 1;
            this.RSADecryptButton.Text = "Decrypt";
            this.RSADecryptButton.UseVisualStyleBackColor = true;
            this.RSADecryptButton.Click += new System.EventHandler(this.RSADecryptButton_Click);
            // 
            // RSAEncryptButton
            // 
            this.RSAEncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RSAEncryptButton.Location = new System.Drawing.Point(37, 53);
            this.RSAEncryptButton.Name = "RSAEncryptButton";
            this.RSAEncryptButton.Size = new System.Drawing.Size(90, 23);
            this.RSAEncryptButton.TabIndex = 0;
            this.RSAEncryptButton.Text = "Encrypt";
            this.RSAEncryptButton.UseVisualStyleBackColor = true;
            this.RSAEncryptButton.Click += new System.EventHandler(this.RSAEncryptButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 555);
            this.Controls.Add(this.TabsWindow);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.TabsWindow.ResumeLayout(false);
            this.CaesarTab.ResumeLayout(false);
            this.CaesarTab.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarShiftNumberBox)).EndInit();
            this.PlayfairTab.ResumeLayout(false);
            this.PlayfairTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grupBox7.ResumeLayout(false);
            this.grupBox7.PerformLayout();
            this.grupBox6.ResumeLayout(false);
            this.grupBox6.PerformLayout();
            this.EncryptedTextBox.ResumeLayout(false);
            this.EncryptedTextBox.PerformLayout();
            this.NormalTextBos.ResumeLayout(false);
            this.NormalTextBos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.RSATab.ResumeLayout(false);
            this.RSATab.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPublicKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPublicKey)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPrivateKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPrivateKey)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRSAnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSAnumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabsWindow;
        private System.Windows.Forms.TabPage CaesarTab;
        private System.Windows.Forms.TabPage PlayfairTab;
        private System.Windows.Forms.TabPage RSATab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox CaesarAlphabetBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox CaesarKeyBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox CaesarEncryptedText;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox CaesarNormalText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown CaesarShiftNumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CaesarKeyButton;
        private System.Windows.Forms.Button CaesarDecryptButton;
        private System.Windows.Forms.Button CaesarEncryptButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grupBox7;
        private System.Windows.Forms.TextBox PlayfairMatrixBox;
        private System.Windows.Forms.GroupBox grupBox6;
        private System.Windows.Forms.TextBox PlayfairKeyBox;
        private System.Windows.Forms.GroupBox EncryptedTextBox;
        private System.Windows.Forms.TextBox PlayfairEncryptedText;
        private System.Windows.Forms.GroupBox NormalTextBos;
        private System.Windows.Forms.TextBox PlayfairNormalText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlayfairKeyButton;
        private System.Windows.Forms.Button PlayfairDecryptButton;
        private System.Windows.Forms.Button PlayfairEncryptButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown EPublicKey;
        private System.Windows.Forms.NumericUpDown NPublicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NPrivateKey;
        private System.Windows.Forms.NumericUpDown DPrivateKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox RSAEncryptedText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox RSANormalText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox RSAFactorsCheckBox;
        private System.Windows.Forms.NumericUpDown qRSAnumeric;
        private System.Windows.Forms.NumericUpDown pRSAnumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RSADecryptButton;
        private System.Windows.Forms.Button RSAEncryptButton;
    }
}