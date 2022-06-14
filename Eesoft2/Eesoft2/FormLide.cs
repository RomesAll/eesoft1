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
    public partial class FormLide : Form
    {
        string result1 = "";
        public FormLide()
        {
            InitializeComponent();
            ClassLide.SelectLide();
            SelectLideDg.DataSource = ClassLide.dataTableLide;
        }
        /// <summary>
        /// Метод для загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLide_Load(object sender, EventArgs e)
        {
            ClassLide.SelectUser();
            SelectUserCm.DataSource = ClassLide.dataTableUser;
            SelectUserCm.ValueMember = "ID";
            SelectUserCm.DisplayMember = "Fio";
        }
        /// <summary>
        /// Метод для отбора записей по номеру пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectUserCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClassLide.SelectLideUser(SelectUserCm.SelectedValue.ToString(), ActiveLideCh.Checked);
                SelectLideDg.DataSource = ClassLide.dataTableLide;
            }
            catch
            {
                MessageBox.Show("Не удалось вывести пользователей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для отбора записей по активности лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLideCh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ClassLide.SelectLideUser(SelectUserCm.SelectedValue.ToString(), ActiveLideCh.Checked);
                SelectLideDg.DataSource = ClassLide.dataTableLide;
            }
            catch
            {
                MessageBox.Show("Не удалось вывести активные лиды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для отмены отбораы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtmenaBtn_Click(object sender, EventArgs e)
        {
            SelectUserCm.SelectedIndex = 0;
            ActiveLideCh.Checked = true;
            ClassLide.SelectLide();
            SelectLideDg.DataSource = ClassLide.dataTableLide;
        }
        /// <summary>
        /// Метод для перехода на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExidBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu().Show();
        }
        /// <summary>
        /// Метод для перехода на форму с интерфейсом лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterfaceLideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new FormInterfaceLide(SelectLideDg.CurrentRow.Cells[0].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[1].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[2].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[3].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[4].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[5].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[6].Value.ToString(),
                    SelectLideDg.CurrentRow.Cells[7].Value.ToString()).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Не удалось перейти на форму интерфейса лида", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод для удаления лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLide_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы точно хотите удалить лид?", "Удаление лида", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    result1 = SelectLideDg.CurrentRow.Cells[7].Value.ToString();
                    if (result1 == "True")
                    {
                        if (ClassLide.DeleteLide(SelectLideDg.CurrentRow.Cells[0].Value.ToString()) == true)
                        {
                            ClassLide.SelectLideUser(SelectUserCm.SelectedValue.ToString(), ActiveLideCh.Checked);
                            MessageBox.Show("Запись удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Удалять неактивные лиды запрещено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить лид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
