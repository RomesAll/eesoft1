using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Eesoft2
{
    class ClassAutorizacie : ClassConnect
    {
        static public object fiouser;
        static public object nomeruser;
        /// <summary>
        /// Метод авторизации пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool Autorizacion(string login,string password)
        {
            try
            {
                command.CommandText = $@"SELECT FirstName FROM user WHERE Login = '{login}' AND Password = md5('{password}')";
                fiouser = command.ExecuteScalar();
                if (fiouser != null)
                {
                    command.CommandText = $@"SELECT ID FROM user WHERE Login = '{login}' AND Password = md5('{password}')";
                    nomeruser = command.ExecuteScalar();
                    if (nomeruser != null)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Не удалось вывести пользователя с данным логином и паролем","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
