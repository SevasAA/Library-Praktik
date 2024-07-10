using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    internal class Story
    {
        public void InsertRecord(string doing)
        {
            int IdUser = UserData.userId;
            
            ClassDataBase db = new ClassDataBase();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO story (id_user, doing) VALUES (@usId, @usDoing);", db.connection);

            // Добавление параметров для безопасного выполнения запроса
            command.Parameters.AddWithValue("@usId", NpgsqlDbType.Integer, IdUser).Direction = ParameterDirection.Input;
            command.Parameters.AddWithValue("@usDoing", NpgsqlDbType.Varchar, doing).Direction = ParameterDirection.Input;

            try
            {
                db.openConnection();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обработка возможных ошибок
                Console.WriteLine("Ошибка при записи в базу данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
