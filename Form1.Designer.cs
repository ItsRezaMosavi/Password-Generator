namespace Password_Generator
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
            btnGenerate = new Button();
            label1 = new Label();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            txtPassword = new TextBox();
            btnChar = new Button();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Tahoma", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(116, 266);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(97, 40);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 46);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(164, 25);
            label1.TabIndex = 2;
            label1.Text = "Password Length";
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F);
            btn8.Location = new Point(18, 95);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 44);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F);
            btn9.Location = new Point(77, 95);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 44);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn10
            // 
            btn10.Font = new Font("Segoe UI", 12F);
            btn10.Location = new Point(136, 95);
            btn10.Name = "btn10";
            btn10.Size = new Size(50, 44);
            btn10.TabIndex = 5;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btn11
            // 
            btn11.Font = new Font("Segoe UI", 12F);
            btn11.Location = new Point(195, 95);
            btn11.Name = "btn11";
            btn11.Size = new Size(50, 44);
            btn11.TabIndex = 6;
            btn11.Text = "11";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn11_Click;
            // 
            // btn12
            // 
            btn12.Font = new Font("Segoe UI", 12F);
            btn12.Location = new Point(254, 95);
            btn12.Name = "btn12";
            btn12.Size = new Size(50, 44);
            btn12.TabIndex = 7;
            btn12.Text = "12";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(83, 326);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(162, 53);
            txtPassword.TabIndex = 8;
            // 
            // btnChar
            // 
            btnChar.Location = new Point(12, 158);
            btnChar.Name = "btnChar";
            btnChar.Size = new Size(56, 23);
            btnChar.TabIndex = 9;
            btnChar.Text = "button1";
            btnChar.UseVisualStyleBackColor = true;
            btnChar.Visible = false;
            btnChar.Click += btnChar_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(12, 187);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(49, 23);
            btnCheck.TabIndex = 10;
            btnCheck.Text = "button1";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Visible = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(btnCheck);
            Controls.Add(btnChar);
            Controls.Add(txtPassword);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label label1;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private TextBox txtPassword;
        private Button btnChar;
        private Button btnCheck;
    }
}
