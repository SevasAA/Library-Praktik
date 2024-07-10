namespace Library2
{
    partial class UserAccess
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
            this.labelText = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelText.ForeColor = System.Drawing.Color.Maroon;
            this.labelText.Location = new System.Drawing.Point(16, 50);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(550, 50);
            this.labelText.TabIndex = 8;
            this.labelText.Text = "Введите";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelLogin.ForeColor = System.Drawing.Color.Maroon;
            this.labelLogin.Location = new System.Drawing.Point(16, 116);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(550, 29);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Логин кому хотите дать доступ: \n";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelPassword.ForeColor = System.Drawing.Color.Maroon;
            this.labelPassword.Location = new System.Drawing.Point(16, 205);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(550, 29);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Ваш пароль: \n";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.Location = new System.Drawing.Point(16, 155);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(550, 30);
            this.textBoxLogin.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(16, 244);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(550, 30);
            this.textBoxPassword.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonSave.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSave.Location = new System.Drawing.Point(16, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(550, 55);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Подтвердить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSave);
            this.Name = "UserAccess";
            this.Text = "Подтверждение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSave;
    }
}