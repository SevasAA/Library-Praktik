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
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
            
            labeluser.Text = UserData.name;
            labellogin.Text = UserData.login;
            labelpass.Text = UserData.password;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int IdUser = UserData.userId;
            NpgsqlCommand command;

            ClassDataBase db = new ClassDataBase();
            if (UserData.userId < 100)
            {
                command = new NpgsqlCommand("SELECT * FROM story;", db.connection);

            }
            else
            {
                command = new NpgsqlCommand("SELECT * FROM story WHERE id_user = @usId;", db.connection);

            }

            command.Parameters.AddWithValue("@usId", NpgsqlDbType.Integer, IdUser).Direction = ParameterDirection.Input;

            try
            {
                db.openConnection();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewRecords.DataSource = dataTable;
                dataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                // Обработка возможных ошибок
                MessageBox.Show("Ошибка при выводе записей из базы данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }


        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm formRegistr = new loginForm();
            formRegistr.Show();
        }



        

        private void buttonChange_Click(object sender, EventArgs e)
        {
            // Создаем и отображаем форму для изменения значений
            EditForm editForm = new EditForm();
            editForm.ShowDialog();

            // Проверяем, была ли форма закрыта с помощью кнопки "Сохранить"
            if (editForm.DialogResult == DialogResult.OK)
            {
                // Получаем новые значения из формы
                string newName = editForm.GetNewName();
                string newLogin = editForm.GetNewLogin();
                string newPassword = editForm.GetNewPassword();

                // Сохраняем новые значения в базе данных
                UserData.name = newName;
                UserData.login = newLogin;
                UserData.password = newPassword;

                // Обновляем значения на метках
                labeluser.Text = UserData.name;
                labellogin.Text = UserData.login;
                labelpass.Text = UserData.password;

                // Сохраняем изменения в базе данных
                SaveToDatabase();
                Story story = new Story();
                story.InsertRecord("Изменение данных");
            }
        }

        
        private void SaveToDatabase()
        {
            String LoginUser = UserData.login;
            String PasswordUser = UserData.password;
            String NameUser = UserData.name;
            int IdUser = UserData.userId;

            if (LoginUser == "")
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

           

            ClassDataBase db = new ClassDataBase();

            DataTable Table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("UPDATE USERS SET login = @newLogin, password = @newPassword, name = @newName WHERE id = @idUser;", db.connection);

            command.Parameters.AddWithValue("@newLogin", NpgsqlDbType.Varchar, LoginUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@newPassword", NpgsqlDbType.Varchar, PasswordUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@newName", NpgsqlDbType.Varchar, NameUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@idUser", NpgsqlDbType.Integer, IdUser).Direction = ParameterDirection.Input;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения сохранены!");                
            }
            else
                MessageBox.Show("Неудача");

            db.closeConnection();
        }

        private void dataGridViewStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void pictureBoxreturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (UserData.userId < 100) 
            { 
            FormMenuAdmin formRegistr = new FormMenuAdmin();
            formRegistr.Show();
            }
            else
            {
                FormMenu formRegistr = new FormMenu();
                formRegistr.Show();
            }
        }
    }
}
