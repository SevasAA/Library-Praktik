using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Library library = new Library();
            ListOfText();
            listBoxList.SelectedIndexChanged += ListBoxList_SelectedIndexChanged;
            listBoxList.DoubleClick += ListBoxList_DoubleClick;
            buttonDelete.Click += buttonDelete_Click;
        }

        private void ListOfText()
        {
            Library library = new Library();


            string directoryPath = "uploads/" + UserData.login;

            // Получаем список файлов из указанной директории
            List<string> fileList = library.GetFileNames(directoryPath);

            
            labelStore.Text = string.Format("Список доступных файлов для пользователя {0}:", UserData.name);
            listBoxList.Items.Clear();

            
            // Добавляем названия файлов в ListBox
            foreach (string fileName in fileList)
            {
                listBoxList.Items.Add(fileName);
             }



            listBoxList.AutoSize = true;
        }

        private void ListBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxList.SelectedIndex != -1)
            {
                string selectedFileName = listBoxList.SelectedItem.ToString();
                string filePath = Path.Combine("uploads/" + UserData.login, selectedFileName);
                FileInfo fileInfo = new FileInfo(filePath);

                // Выводим информацию о файле
                labelAuthor.Text = "Автор: " + fileInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                labelUploadDate.Text = "Дата загрузки: " + fileInfo.CreationTime.ToString();
                labelSize.Text = "Размер: " + FormatFileSize(fileInfo.Length);
            }
        }


        private string FormatFileSize(long fileSize)
        {
            const int scale = 1024;
            string[] sizeSuffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;

            while (fileSize >= scale && suffixIndex < sizeSuffixes.Length - 1)
            {
                fileSize /= scale;
                suffixIndex++;
            }

            return string.Format("{0} {1}", fileSize, sizeSuffixes[suffixIndex]);
        }

        private void ListBoxList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxList.SelectedIndex != -1)
            {
                string selectedFileName = listBoxList.SelectedItem.ToString();
                string filePath = Path.Combine("uploads/" + UserData.login, selectedFileName);
                Process.Start(filePath);
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm formRegistr = new loginForm();
            formRegistr.Show();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.UploadFile();
            ListOfText();
            listBoxList.SelectedIndexChanged += ListBoxList_SelectedIndexChanged;
            Story story = new Story();
            story.InsertRecord("Загрузка нового файла");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxList.SelectedIndex != -1)
            {
                string selectedFileName = listBoxList.SelectedItem.ToString();
                string filePath = Path.Combine("uploads/" + UserData.login, selectedFileName);
                File.Delete(filePath);
                listBoxList.Items.Remove(selectedFileName);
                Story story = new Story();
                story.InsertRecord("Удаление файла");
            }
        }

        private void buttonDownToUser_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранный файл в списке файлов
            if (listBoxList.SelectedItem != null)
            {
                string selectedFileName = listBoxList.SelectedItem.ToString();
                string filePath = Path.Combine(Environment.CurrentDirectory, "uploads/" + UserData.login, selectedFileName);

                // Проверяем, существует ли файл
                if (File.Exists(filePath))
                {
                    // Открываем диалоговое окно SaveFileDialog для выбора места сохранения файла на компьютере пользователя
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = selectedFileName;

                    // Отображаем диалоговое окно и ждем, пока пользователь выберет место сохранения файла
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = saveFileDialog.FileName;

                        // Копируем выбранный файл в указанное место сохранения
                        File.Copy(filePath, destinationPath);

                        MessageBox.Show("Файл успешно скачан!");
                        Story story = new Story();
                        story.InsertRecord("Скачивание файла (успешно)");
                    }
                }
                else
                {
                    MessageBox.Show("Выбранный файл не существует!");
                    Story story = new Story();
                    story.InsertRecord("Скачивание файла (неудача)");
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран!");
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            UserAccess editForm = new UserAccess();
            editForm.ShowDialog();

            // Проверяем, была ли форма закрыта с помощью кнопки "Сохранить"
            if (editForm.DialogResult == DialogResult.OK)
            {
                // Получаем новые значения из формы
                string newLogin = editForm.GetNewLogin();
                string newPassword = editForm.GetNewPassword();

                Story story = new Story();
                story.InsertRecord("Предоставлен доступ к личной библиотеке");
            }

        }
    }
}
