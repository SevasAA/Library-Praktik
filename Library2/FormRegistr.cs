using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class FormRegistr : Form
    {
        public FormRegistr()
        {
            InitializeComponent();
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm formRegistr = new loginForm();
            formRegistr.Show();
        }

        private void buttonEnterPass_Click(object sender, EventArgs e)
        {
            String LoginUser = textBoxLogin.Text;
            String PasswordUser = textBoxPassword.Text;
            String NameUser = textBoxName.Text;

            if(LoginUser == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (PasswordUser == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (NameUser == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (!checkUser(LoginUser))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }


            ClassDataBase db = new ClassDataBase();

            DataTable Table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO USERS (login, password, name) VALUES (@usLog, @usPass, @usName);", db.connection);

            command.Parameters.AddWithValue("@usLog", NpgsqlDbType.Varchar, LoginUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@usPass", NpgsqlDbType.Varchar, PasswordUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@usName", NpgsqlDbType.Varchar, NameUser).Direction = ParameterDirection.Input;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1 ) { 
                MessageBox.Show("Приветствую, " + NameUser);
                this.Hide();
                loginForm formRegistr = new loginForm();
                formRegistr.Show();
            }
            else
                MessageBox.Show("Неудача");
            // adapter.SelectCommand = command;

            db.closeConnection();

        }

        public Boolean checkUser(String LoginUser)
        {
            ClassDataBase db = new ClassDataBase();

            DataTable Table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @usLog;", db.connection);

            command.Parameters.AddWithValue("@usLog", NpgsqlDbType.Varchar, LoginUser).Direction = ParameterDirection.Input;
          
            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(Table);

            db.closeConnection();

            if (Table.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

    }
}
