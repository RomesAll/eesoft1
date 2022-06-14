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
    public partial class FormRedLide : Form
    {
        string telephone = "";
        string numericUpDown1t = "";
        string numericUpDown2t = "";
        string numericUpDown3t = "";
        string user = "";
        string nomerlide = "";
        public FormRedLide(params string [] par)
        {
            InitializeComponent();
            telephone = par[1];
            numericUpDown1t = par[3];
            numericUpDown2t = par[4];
            numericUpDown3t = par[5];
            user = par[2];
            nomerlide = par[0];
        }
        /// <summary>
        /// Метод для загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRedLide_Load(object sender, EventArgs e)
        {
            ClassLide.SelectUserInterface();
            SelectUserCm.DataSource = ClassLide.dataTableUserInteface;
            SelectUserCm.ValueMember = "ID";
            SelectUserCm.DisplayMember = "Fio";

            TelephoneTx.Text = telephone;
            numericUpDown1.Text = numericUpDown1t;
            numericUpDown2.Text = numericUpDown2t;
            numericUpDown3.Text = numericUpDown3t;
            SelectUserCm.Text = user;
        }
        /// <summary>
        /// Метод для редактирование формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassLide.RedLide(nomerlide, TelephoneTx.Text, SelectUserCm.SelectedValue.ToString(), numericUpDown1.Text.Replace(',', '.'), numericUpDown2.Text.Replace(',', '.'), numericUpDown3.Text.Replace(',', '.'), textBox1.Text) == true)
                {
                    MessageBox.Show("Запись редактирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ClassLide.SelectLide();
                }
                else
                {
                    MessageBox.Show("Не удалось редактировать запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось редактировать запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для редактирование активности лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLideCh_CheckedChanged(object sender, EventArgs e)
        {
            ClassLide.RedLideActive(ActiveLideCh.Checked, nomerlide);
        }
    }
}
