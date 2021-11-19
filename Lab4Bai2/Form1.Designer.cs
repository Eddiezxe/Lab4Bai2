namespace Lab4Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonInputFromFile = new System.Windows.Forms.Button();
            this.buttonSHA256 = new System.Windows.Forms.Button();
            this.buttonCopySHA1 = new System.Windows.Forms.Button();
            this.textBoxSHA1 = new System.Windows.Forms.TextBox();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSHA256 = new System.Windows.Forms.TextBox();
            this.buttonCopyMD5 = new System.Windows.Forms.Button();
            this.buttonHash = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSHA384 = new System.Windows.Forms.TextBox();
            this.textBoxSHA512 = new System.Windows.Forms.TextBox();
            this.buttonSHA384 = new System.Windows.Forms.Button();
            this.buttonSHA512 = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(145, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(49, 21);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Input:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInput.Location = new System.Drawing.Point(145, 33);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(358, 23);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonInputFromFile
            // 
            this.buttonInputFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInputFromFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInputFromFile.Location = new System.Drawing.Point(3, 3);
            this.buttonInputFromFile.Name = "buttonInputFromFile";
            this.buttonInputFromFile.Size = new System.Drawing.Size(131, 27);
            this.buttonInputFromFile.TabIndex = 3;
            this.buttonInputFromFile.Text = "Input from file";
            this.buttonInputFromFile.UseVisualStyleBackColor = true;
            this.buttonInputFromFile.Click += new System.EventHandler(this.buttonInputFromFile_Click);
            // 
            // buttonSHA256
            // 
            this.buttonSHA256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSHA256.Location = new System.Drawing.Point(437, 199);
            this.buttonSHA256.Name = "buttonSHA256";
            this.buttonSHA256.Size = new System.Drawing.Size(66, 23);
            this.buttonSHA256.TabIndex = 100;
            this.buttonSHA256.Text = "Copy";
            this.buttonSHA256.UseVisualStyleBackColor = true;
            this.buttonSHA256.Click += new System.EventHandler(this.buttonSHA256_Click);
            // 
            // buttonCopySHA1
            // 
            this.buttonCopySHA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopySHA1.Location = new System.Drawing.Point(437, 170);
            this.buttonCopySHA1.Name = "buttonCopySHA1";
            this.buttonCopySHA1.Size = new System.Drawing.Size(66, 23);
            this.buttonCopySHA1.TabIndex = 6;
            this.buttonCopySHA1.Text = "Copy";
            this.buttonCopySHA1.UseVisualStyleBackColor = true;
            this.buttonCopySHA1.Click += new System.EventHandler(this.buttonCopySHA1_Click);
            // 
            // textBoxSHA1
            // 
            this.textBoxSHA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSHA1.Location = new System.Drawing.Point(95, 170);
            this.textBoxSHA1.Name = "textBoxSHA1";
            this.textBoxSHA1.ReadOnly = true;
            this.textBoxSHA1.Size = new System.Drawing.Size(336, 23);
            this.textBoxSHA1.TabIndex = 10;
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMD5.Location = new System.Drawing.Point(95, 141);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.ReadOnly = true;
            this.textBoxMD5.Size = new System.Drawing.Size(336, 23);
            this.textBoxMD5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "SHA-256:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "SHA-1:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "MD-5:";
            // 
            // textBoxSHA256
            // 
            this.textBoxSHA256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSHA256.Location = new System.Drawing.Point(95, 199);
            this.textBoxSHA256.Name = "textBoxSHA256";
            this.textBoxSHA256.ReadOnly = true;
            this.textBoxSHA256.Size = new System.Drawing.Size(336, 23);
            this.textBoxSHA256.TabIndex = 11;
            // 
            // buttonCopyMD5
            // 
            this.buttonCopyMD5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopyMD5.Location = new System.Drawing.Point(437, 141);
            this.buttonCopyMD5.Name = "buttonCopyMD5";
            this.buttonCopyMD5.Size = new System.Drawing.Size(66, 23);
            this.buttonCopyMD5.TabIndex = 5;
            this.buttonCopyMD5.Text = "Copy";
            this.buttonCopyMD5.UseVisualStyleBackColor = true;
            this.buttonCopyMD5.Click += new System.EventHandler(this.buttonCopyMD5_Click);
            // 
            // buttonHash
            // 
            this.buttonHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHash.Location = new System.Drawing.Point(153, 3);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(131, 27);
            this.buttonHash.TabIndex = 4;
            this.buttonHash.Text = "HASH";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonInputFromFile, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonHash, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(216, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 33);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 101;
            this.label4.Text = "SHA-384:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 102;
            this.label5.Text = "SHA-512:";
            // 
            // textBoxSHA384
            // 
            this.textBoxSHA384.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSHA384.Location = new System.Drawing.Point(95, 228);
            this.textBoxSHA384.Name = "textBoxSHA384";
            this.textBoxSHA384.ReadOnly = true;
            this.textBoxSHA384.Size = new System.Drawing.Size(336, 23);
            this.textBoxSHA384.TabIndex = 103;
            // 
            // textBoxSHA512
            // 
            this.textBoxSHA512.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSHA512.Location = new System.Drawing.Point(95, 257);
            this.textBoxSHA512.Name = "textBoxSHA512";
            this.textBoxSHA512.ReadOnly = true;
            this.textBoxSHA512.Size = new System.Drawing.Size(336, 23);
            this.textBoxSHA512.TabIndex = 104;
            // 
            // buttonSHA384
            // 
            this.buttonSHA384.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSHA384.Location = new System.Drawing.Point(437, 230);
            this.buttonSHA384.Name = "buttonSHA384";
            this.buttonSHA384.Size = new System.Drawing.Size(66, 23);
            this.buttonSHA384.TabIndex = 105;
            this.buttonSHA384.Text = "Copy";
            this.buttonSHA384.UseVisualStyleBackColor = true;
            this.buttonSHA384.Click += new System.EventHandler(this.buttonSHA384_Click);
            // 
            // buttonSHA512
            // 
            this.buttonSHA512.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSHA512.Location = new System.Drawing.Point(437, 257);
            this.buttonSHA512.Name = "buttonSHA512";
            this.buttonSHA512.Size = new System.Drawing.Size(66, 23);
            this.buttonSHA512.TabIndex = 106;
            this.buttonSHA512.Text = "Copy";
            this.buttonSHA512.UseVisualStyleBackColor = true;
            this.buttonSHA512.Click += new System.EventHandler(this.buttonSHA512_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Text",
            "Hex"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 33);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(112, 23);
            this.comboBoxType.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 108;
            this.label6.Text = "Input type:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 109;
            this.label7.Text = "File đã chọn:";
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(95, 106);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(106, 15);
            this.labelFilePath.TabIndex = 110;
            this.labelFilePath.Text = "File path goes here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 339);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonSHA512);
            this.Controls.Add(this.buttonSHA384);
            this.Controls.Add(this.textBoxSHA512);
            this.Controls.Add(this.textBoxSHA384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSHA256);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.buttonCopySHA1);
            this.Controls.Add(this.buttonCopyMD5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.textBoxSHA1);
            this.Controls.Add(this.textBoxSHA256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Hash Function";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxInput;
        private Label labelText;
        private Button buttonInputFromFile;
        private Button buttonCopySHA1;
        private TextBox textBoxSHA1;
        private TextBox textBoxMD5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxSHA256;
        private Button buttonCopyMD5;
        private Button buttonHash;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonSHA256;
        private Label label4;
        private Label label5;
        private TextBox textBoxSHA384;
        private TextBox textBoxSHA512;
        private Button buttonSHA384;
        private Button buttonSHA512;
        private ComboBox comboBoxType;
        private Label label6;
        private Label label7;
        private Label labelFilePath;
    }
}