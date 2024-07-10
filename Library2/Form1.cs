using MySqlX.XDevAPI.Relational;
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
    
    public partial class loginForm : Form
    {
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelauth_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterPass_Click(object sender, EventArgs e)
        {
            
            String LoginUser = textBoxLogin.Text;
            String PasswordUser = textBoxPassword.Text;

            ClassDataBase db = new ClassDataBase();

            DataTable Table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @usLog AND password = @usPass;", db.connection);

            command.Parameters.AddWithValue("@usLog", NpgsqlDbType.Varchar, LoginUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@usPass", NpgsqlDbType.Varchar, PasswordUser).Direction = ParameterDirection.Input;

            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(Table);

            db.closeConnection();

            if (Table.Rows.Count > 0)
            {
                int dostupValue = Convert.ToInt32(Table.Rows[0]["dostup"]);

                UserData.userId = Convert.ToInt32(Table.Rows[0]["id"]);
                UserData.login = Convert.ToString(Table.Rows[0]["login"]);
                UserData.password = Convert.ToString(Table.Rows[0]["password"]);
                UserData.name = Convert.ToString(Table.Rows[0]["name"]);

                                    
                switch (dostupValue)
                {
                    case 1:
                        MessageBox.Show("Добро пожаловать хозяин, " + Table.Rows[0]["name"]);
                        AdminMenu();
                       
                        break;
                    case 2:
                        MessageBox.Show("Добро пожаловать пользователь, " + Table.Rows[0]["name"]);
                        UserMenu();
                    
                        break;

                    default:
                        MessageBox.Show("Unexpected access value");
                        break;
                }




            }
            else
                MessageBox.Show("Error");



        }

        private void buttonRegistrat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistr formRegistr = new FormRegistr();
            formRegistr.Show();
        }

        private void AdminMenu()
        {
            this.Hide();
            FormMenuAdmin formRegistr = new FormMenuAdmin();
            formRegistr.Show();
        }

        private void UserMenu()
        {
            this.Hide();
            FormMenu formRegistr = new FormMenu();
            formRegistr.Show();
        }


    }
}
