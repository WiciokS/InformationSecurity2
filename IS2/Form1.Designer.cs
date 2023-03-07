namespace IS2
{
    partial class Form1
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
            this.rtbEnterText = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnterKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCipherMode = new System.Windows.Forms.ComboBox();
            this.cbEncryptDecrypt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReadData = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lbSelectFile = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteDataFromSelectedFile = new System.Windows.Forms.Button();
            this.rtbOriginalText = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateRandomKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEnterText
            // 
            this.rtbEnterText.Location = new System.Drawing.Point(13, 57);
            this.rtbEnterText.Name = "rtbEnterText";
            this.rtbEnterText.Size = new System.Drawing.Size(250, 100);
            this.rtbEnterText.TabIndex = 0;
            this.rtbEnterText.Text = "";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(566, 57);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(250, 100);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // tbEnterKey
            // 
            this.tbEnterKey.Location = new System.Drawing.Point(13, 192);
            this.tbEnterKey.Name = "tbEnterKey";
            this.tbEnterKey.Size = new System.Drawing.Size(189, 30);
            this.tbEnterKey.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Cipher Mode";
            // 
            // cbCipherMode
            // 
            this.cbCipherMode.FormattingEnabled = true;
            this.cbCipherMode.Location = new System.Drawing.Point(319, 57);
            this.cbCipherMode.Name = "cbCipherMode";
            this.cbCipherMode.Size = new System.Drawing.Size(190, 33);
            this.cbCipherMode.TabIndex = 8;
            // 
            // cbEncryptDecrypt
            // 
            this.cbEncryptDecrypt.FormattingEnabled = true;
            this.cbEncryptDecrypt.Location = new System.Drawing.Point(319, 124);
            this.cbEncryptDecrypt.Name = "cbEncryptDecrypt";
            this.cbEncryptDecrypt.Size = new System.Drawing.Size(190, 33);
            this.cbEncryptDecrypt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Encrypt/Decrypt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(323, 256);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 50);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(566, 322);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(160, 30);
            this.btnSaveToFile.TabIndex = 16;
            this.btnSaveToFile.Text = "Save";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Save to selected file";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "From where read data";
            // 
            // cbReadData
            // 
            this.cbReadData.FormattingEnabled = true;
            this.cbReadData.Location = new System.Drawing.Point(318, 192);
            this.cbReadData.Name = "cbReadData";
            this.cbReadData.Size = new System.Drawing.Size(191, 33);
            this.cbReadData.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Add file to read";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 255);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(160, 30);
            this.btnAddFile.TabIndex = 21;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lbSelectFile
            // 
            this.lbSelectFile.FormattingEnabled = true;
            this.lbSelectFile.ItemHeight = 25;
            this.lbSelectFile.Location = new System.Drawing.Point(13, 317);
            this.lbSelectFile.Name = "lbSelectFile";
            this.lbSelectFile.Size = new System.Drawing.Size(496, 129);
            this.lbSelectFile.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Selected File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter data from selected file";
            // 
            // btnWriteDataFromSelectedFile
            // 
            this.btnWriteDataFromSelectedFile.Location = new System.Drawing.Point(566, 387);
            this.btnWriteDataFromSelectedFile.Name = "btnWriteDataFromSelectedFile";
            this.btnWriteDataFromSelectedFile.Size = new System.Drawing.Size(160, 30);
            this.btnWriteDataFromSelectedFile.TabIndex = 25;
            this.btnWriteDataFromSelectedFile.Text = "Enter";
            this.btnWriteDataFromSelectedFile.UseVisualStyleBackColor = true;
            this.btnWriteDataFromSelectedFile.Click += new System.EventHandler(this.btnWriteDataFromSelectedFile_Click);
            // 
            // rtbOriginalText
            // 
            this.rtbOriginalText.Location = new System.Drawing.Point(566, 191);
            this.rtbOriginalText.Name = "rtbOriginalText";
            this.rtbOriginalText.Size = new System.Drawing.Size(250, 100);
            this.rtbOriginalText.TabIndex = 26;
            this.rtbOriginalText.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Original Text";
            // 
            // btnGenerateRandomKey
            // 
            this.btnGenerateRandomKey.Location = new System.Drawing.Point(209, 191);
            this.btnGenerateRandomKey.Name = "btnGenerateRandomKey";
            this.btnGenerateRandomKey.Size = new System.Drawing.Size(103, 34);
            this.btnGenerateRandomKey.TabIndex = 28;
            this.btnGenerateRandomKey.Text = "Generate";
            this.btnGenerateRandomKey.UseVisualStyleBackColor = true;
            this.btnGenerateRandomKey.Click += new System.EventHandler(this.btnGenerateRandomKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.btnGenerateRandomKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbOriginalText);
            this.Controls.Add(this.btnWriteDataFromSelectedFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbSelectFile);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbReadData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEncryptDecrypt);
            this.Controls.Add(this.cbCipherMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEnterKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbEnterText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEnterText;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEnterKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCipherMode;
        private System.Windows.Forms.ComboBox cbEncryptDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbReadData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lbSelectFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteDataFromSelectedFile;
        private System.Windows.Forms.RichTextBox rtbOriginalText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerateRandomKey;
    }
}

