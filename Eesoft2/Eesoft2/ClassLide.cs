using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eesoft2
{
    class ClassLide : ClassConnect
    {
        static public DataTable dataTableLide = new DataTable();
        static public DataTable dataTableUser = new DataTable();
        static public DataTable dataTableUserInteface = new DataTable();
        static public DataTable dataTableCallLide = new DataTable();
        static public object Description;
        /// <summary>
        /// Метод для вывода лидов
        /// </summary>
        static public void SelectLide()
        {
            try
            {
                command.CommandText = $@"SELECT `lead`.ID, CONCAT(`user`.FirstName,' ',`user`.MiddleName,' ',`user`.LastName) AS Fio, `lead`.`Phone`, `lead`.HandlingObjections, `lead`.SellTechniques, `lead`.ProductKnowledge, `lead`.CreateDateTime, `lead`.IsActive
                from `lead`, `user`
                WHERE `lead`.UserID = `user`.ID AND `user`.ID = '{ClassAutorizacie.nomeruser}' and `lead`.IsActive = 1";
                dataTableLide.Clear();
                adapter.Fill(dataTableLide);
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести лиды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для вывода пользователей
        /// </summary>
        static public void SelectUser()
        {
            try
            {
                command.CommandText = $@"SELECT ID, CONCAT(`user`.FirstName,' ',`user`.MiddleName,' ',`user`.LastName) AS Fio FROM user";
                dataTableUser.Clear();
                adapter.Fill(dataTableUser);
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести пользователей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для вывода пользователя в интерфейсе лида
        /// </summary>
        static public void SelectUserInterface()
        {
            try
            {
                command.CommandText = $@"SELECT ID, CONCAT(`user`.FirstName,' ',`user`.MiddleName,' ',`user`.LastName) AS Fio FROM user";
                dataTableUserInteface.Clear();
                adapter.Fill(dataTableUserInteface);
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести пользователей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для отбора записей по номеру пользователю
        /// </summary>
        /// <param name="user"></param>
        /// <param name="activ"></param>
        static public void SelectLideUser(string user, bool activ)
        {
            try
            {
                if (activ == true)
                {
                    command.CommandText = $@"SELECT `lead`.ID, CONCAT(`user`.FirstName,' ',`user`.MiddleName,' ',`user`.LastName) AS Fio, `lead`.`Phone`, `lead`.HandlingObjections, `lead`.SellTechniques, `lead`.ProductKnowledge, `lead`.CreateDateTime, `lead`.IsActive
                    from `lead`, `user`
                    WHERE `lead`.UserID = `user`.ID AND `user`.ID = '{user}' and `lead`.IsActive = 1";
                }
                else if (activ == false)
                {
                    command.CommandText = $@"SELECT `lead`.ID, CONCAT(`user`.FirstName,' ',`user`.MiddleName,' ',`user`.LastName) AS Fio, `lead`.`Phone`, `lead`.HandlingObjections, `lead`.SellTechniques, `lead`.ProductKnowledge, `lead`.CreateDateTime, `lead`.IsActive
                    from `lead`, `user`
                    WHERE `lead`.UserID = `user`.ID AND `user`.ID = '{user}' and `lead`.IsActive = 0";
                }
                dataTableLide.Clear();
                adapter.Fill(dataTableLide);
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести лиды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для удаление лида
        /// </summary>
        /// <param name="nomerlide"></param>
        /// <returns></returns>
        static public bool DeleteLide(string nomerlide)
        {
            try
            {
                command.CommandText = $"DELETE FROM `lead` WHERE ID = '{nomerlide}'";
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Не удалсоь удалить лид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Метод для вывода комментария
        /// </summary>
        /// <param name="nomer"></param>
        static public void SelectDiescriprion(string nomer)
        {
            try
            {
                command.CommandText = $"SELECT Comment FROM `lead` WHERE ID = '{nomer}'";
                Description = command.ExecuteScalar();
                if (Description == null)
                    Description = "";
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести коментарий к лиду", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для вывода звонков лида
        /// </summary>
        /// <param name="nomer"></param>
        static public void SelectCallLide(string nomer)
        {
            try
            {
                command.CommandText = $"SELECT ID, CallDateTime, Duration FROM `call` WHERE LeadID = '{nomer}'";
                dataTableCallLide.Clear();
                adapter.Fill(dataTableCallLide);
            }
            catch
            {
                MessageBox.Show("Не удалсоь вывести звонки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для добавление лида
        /// </summary>
        /// <param name="par"></param>
        /// <returns></returns>
        static public bool AddLide(params string[] par)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                command.CommandText = $"INSERT INTO `lead` VALUES(null,'{par[0]}','{par[1]}','{par[2]}','{par[3]}','{par[4]}',null,'{dateTime.ToString("yyyy-MM-dd h:MM")}',1,0)";
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Не удалось добавить лид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Метод для редактирование лида 
        /// </summary>
        /// <param name="par"></param>
        /// <returns></returns>
        static public bool RedLide(params string[] par)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                command.CommandText = $"UPDATE `lead` SET Phone = '{par[1]}', UserID = '{par[2]}', HandlingObjections = '{par[3]}', SellTechniques = '{par[4]}', ProductKnowledge = '{par[5]}', Comment = '{par[6]}' WHERE ID = '{par[0]}'";
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Не удалось добавить лид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Метод для редактирование активности лида
        /// </summary>
        /// <param name="active"></param>
        /// <param name="nomer"></param>
        /// <returns></returns>
        static public bool RedLideActive(bool active, string nomer)
        {
            try
            {
                int i = 0;
                if (active == true)
                {
                    i = 1;
                }
                else if (active == false)
                {
                    i = 0;
                }
                command.CommandText = $"UPDATE `lead` SET IsActive = '{i}' WHERE ID = '{nomer}'";
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Не удалось добавить лид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
