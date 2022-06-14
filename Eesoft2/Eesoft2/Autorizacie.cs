using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eesoft2
{
    public partial class Autorizacie : Form
    {
        public Autorizacie()
        {
            InitializeComponent();
            ClassConnect.Connection();
        }

        private void ChekPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTx.UseSystemPasswordChar == true)
                    PasswordTx.UseSystemPasswordChar = false;
                else if (PasswordTx.UseSystemPasswordChar == false)
                    PasswordTx.UseSystemPasswordChar = true;
            }
            catch
            {
                MessageBox.Show("Не удалось показать пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VxodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextBox(LoginTx.Text, PasswordTx.Text) == true)
                {
                    if (ClassAutorizacie.Autorizacion(LoginTx.Text, PasswordTx.Text) == true)
                    {
                        new Menu().Show();
                        this.Hide();
                    }
                    else if (ClassAutorizacie.Autorizacion(LoginTx.Text, PasswordTx.Text) == false)
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось пройти авторизацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool CheckTextBox(string login, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(login) == true & string.IsNullOrEmpty(password) == true)
                {
                    MessageBox.Show("Введите логин и пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (string.IsNullOrEmpty(login) == true || string.IsNullOrEmpty(password) == true)
                {
                    if (string.IsNullOrEmpty(login) == true)
                    {
                        MessageBox.Show("Введите логин", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else if (string.IsNullOrEmpty(password) == true)
                    {
                        MessageBox.Show("Введите пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                        return false;
                }
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
