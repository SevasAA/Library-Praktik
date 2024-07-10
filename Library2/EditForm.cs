using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{

    public class EditForm : Form
    {
        private TextBox textBoxName;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelText;
        private Label labelName;
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonSave;

        public EditForm()
        {
            InitializeComponent();
            textBoxName.Text = UserData.name;
            textBoxLogin.Text = UserData.login;
            textBoxPassword.Text = UserData.password;
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(10, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(550, 30);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.Location = new System.Drawing.Point(10, 177);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(550, 30);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(10, 246);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(550, 30);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonSave.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSave.Location = new System.Drawing.Point(10, 306);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(550, 55);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelText.ForeColor = System.Drawing.Color.Maroon;
            this.labelText.Location = new System.Drawing.Point(10, 10);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(550, 50);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Измените необходимые значения \n";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelName.Location = new System.Drawing.Point(10, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(550, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя: \n";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelLogin.Location = new System.Drawing.Point(10, 147);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(550, 20);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин: \n";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelPassword.Location = new System.Drawing.Point(10, 216);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(550, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль: \n";
            // 
            // EditForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSave);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Метод для сохранения изменений
        private void SaveChanges()
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxLogin.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            // Закрываем форму и устанавливаем DialogResult в OK
            DialogResult = DialogResult.OK;
            Close();
        }

        // Методы для получения новых значений
        public string GetNewName()
        {
            return textBoxName.Text;
        }

        public string GetNewLogin()
        {
            return textBoxLogin.Text;
        }

        public string GetNewPassword()
        {
            return textBoxPassword.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxLogin.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            // Закрываем форму и устанавливаем DialogResult в OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
