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
    public partial class FormAddLide : Form
    {
        public FormAddLide()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAddLide_Load(object sender, EventArgs e)
        {
            ClassLide.SelectUserInterface();
            SelectUserCm.DataSource = ClassLide.dataTableUserInteface;
            SelectUserCm.ValueMember = "ID";
            SelectUserCm.DisplayMember = "Fio";
        }
        /// <summary>
        /// Метод для добавление лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassLide.AddLide(TelephoneTx.Text, SelectUserCm.SelectedValue.ToString(), numericUpDown1.Text.Replace(',', '.'), numericUpDown2.Text.Replace(',', '.'), numericUpDown3.Text.Replace(',', '.')) == true)
                {
                    MessageBox.Show("Лид добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClassLide.SelectLide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить лид", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось добавить лид", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
