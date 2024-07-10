using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    internal class Library
    {
        public void UploadFile()
        {
            try
            {
                // Создаем экземпляр диалогового окна OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Устанавливаем фильтр для выбора 
                openFileDialog.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

                // Отображаем диалоговое окно и ждем, пока пользователь выберет файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Проверяем, существует ли файл
                    if (File.Exists(filePath))
                    {
                        // Проверяем расширение файла
                        string fileExtension = Path.GetExtension(filePath).ToLower();
                        if (fileExtension == ".txt" || fileExtension == ".pdf" || fileExtension == ".docx" || fileExtension == ".xlsx")
                        {
                            string destinationPath = Path.Combine(Environment.CurrentDirectory, "uploads/" + UserData.login, Path.GetFileName(filePath));

                            // Проверяем, существует ли папка назначения
                            if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                            }

                            File.Copy(filePath, destinationPath);

                            MessageBox.Show("Файл успешно загружен!");
                        }
                        else
                        {
                            MessageBox.Show("Выбранный файл имеет недопустимое расширение!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не существует!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем возможные ошибки при загрузке файла
                MessageBox.Show("Ошибка загрузки файла: " + ex.Message);
            }
        }

        public List<string> GetFileNames(string directoryPath)
        {
            List<string> fileNames = new List<string>();

            try
            {
                // Проверяем, существует ли указанная директория
                if (Directory.Exists(directoryPath))
                {
                    // Получаем все файлы в указанной директории
                    string[] files = Directory.GetFiles(directoryPath);

                    // Итерируемся по каждому файлу и добавляем его название в список
                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);
                        fileNames.Add(fileName);
                    }
                }
                else
                {
                    MessageBox.Show("В вашей библиотеке пока еще пусто, пожалуйста загрузите файлы.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка файлов: " + ex.Message);
            }

            return fileNames;
        }

        public List<string> GetUsersById(int id)
        {
            ClassDataBase db = new ClassDataBase();

            List<string> userIds = new List<string>();

            try
            {
                db.openConnection();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT login FROM Users WHERE id IN (SELECT  id_user FROM access_to_library WHERE id_user_with_access = @Id);", db.connection))
                {
                    command.Parameters.AddWithValue("@Id", NpgsqlDbType.Integer, id).Direction = ParameterDirection.Input;

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string login = Convert.ToString(reader["login"]);
                            userIds.Add(login);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неудача: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return userIds;
        }



    }


    

}
