namespace LicenseCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtGuidInput = new TextBox();
            txtEncryptedOutput = new TextBox();
            btnEncrypt = new Button();
            btnCopy = new Button();
            btnGetGuid = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 0;
            label1.Text = "GUID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 1;
            label2.Text = "OUTPUT :";
            // 
            // txtGuidInput
            // 
            txtGuidInput.Location = new Point(106, 8);
            txtGuidInput.Name = "txtGuidInput";
            txtGuidInput.Size = new Size(350, 23);
            txtGuidInput.TabIndex = 2;
            // 
            // txtEncryptedOutput
            // 
            txtEncryptedOutput.Location = new Point(106, 89);
            txtEncryptedOutput.Name = "txtEncryptedOutput";
            txtEncryptedOutput.Size = new Size(297, 23);
            txtEncryptedOutput.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(355, 37);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(101, 46);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(409, 89);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(47, 23);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnGetGuid
            // 
            btnGetGuid.Location = new Point(248, 37);
            btnGetGuid.Name = "btnGetGuid";
            btnGetGuid.Size = new Size(101, 46);
            btnGetGuid.TabIndex = 6;
            btnGetGuid.Text = "Get GUID";
            btnGetGuid.UseVisualStyleBackColor = true;
            btnGetGuid.Click += btnGetGuid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 127);
            Controls.Add(btnGetGuid);
            Controls.Add(btnCopy);
            Controls.Add(btnEncrypt);
            Controls.Add(txtEncryptedOutput);
            Controls.Add(txtGuidInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "License Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGuidInput;
        private TextBox txtEncryptedOutput;
        private Button btnEncrypt;
        private Button btnCopy;
        private Button btnGetGuid;
    }
}
