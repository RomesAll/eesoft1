using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Eesoft2
{
    class ClassConnect
    {
        static public string conline = "Database = leadmanage; DataSource = localhost; user = root; password = qwerty; charset = utf8";
        static public MySqlConnection connection;
        static public MySqlCommand command;
        static public MySqlDataAdapter adapter;
        /// <summary>
        /// Метод для подключения к БД
        /// </summary>
        static public void Connection()
        {
            try
            {
                connection = new MySqlConnection(conline);
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                adapter = new MySqlDataAdapter(command);
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к БД","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
