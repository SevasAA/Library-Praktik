using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class UserAccess : Form
    {

        private string Login;
        private string Password;
        public UserAccess()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) ||
               string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if(textBoxPassword.Text != UserData.password)
            {
                MessageBox.Show("Неверный пароль");
                return;
            }

            Login = textBoxLogin.Text;
            Password = textBoxPassword.Text;

            int id = CheckUser(textBoxLogin.Text);

            if (id != -1)
            {
                SaveInTable(id);
                DialogResult = DialogResult.OK;
                Close();
            }
            Story story = new Story();
            story.InsertRecord("Неудача при придоставлении доступа");
            Close();
        }

        private void SaveInTable(int IdUser)
        {

            ClassDataBase db = new ClassDataBase();

            DataTable Table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO access_to_library (id_user, id_user_with_access) VALUES (@usId, @usIdTo);", db.connection);

            command.Parameters.AddWithValue("@usId", NpgsqlDbType.Integer, UserData.userId).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@usIdTo", NpgsqlDbType.Integer, IdUser).Direction = ParameterDirection.Input;

            db.openConnection();

            try
            {
                db.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Успех");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при записи в базу данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public int CheckUser(string login)
        {
            int userId = -1;
            ClassDataBase db = new ClassDataBase();

            try
            {
                db.openConnection();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id FROM Users WHERE Login = @Login;", db.connection))
                {
                    command.Parameters.AddWithValue("@Login", NpgsqlDbType.Varchar, login).Direction = ParameterDirection.Input;

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неудача: " + ex.Message);
                Story story = new Story();
                story.InsertRecord("Неудача при придоставлении доступа");
            }
            finally
            {
                db.closeConnection();
            }

            return userId;
        }

        public string GetNewLogin()
        {
            return Login;
        }

        public string GetNewPassword()
        {
            return Password;
        }
    }
}
