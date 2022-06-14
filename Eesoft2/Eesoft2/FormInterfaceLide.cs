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
    public partial class FormInterfaceLide : Form
    {
        string nomer = "";
        public FormInterfaceLide(params string [] par)
        {
            InitializeComponent();
            nomer = par[0];
            label13.Text = par[1];
            label9.Text = par[2];
            label10.Text = par[3];
            label11.Text = par[4];
            label12.Text = par[5];
            label8.Text = par[6];
            ClassLide.SelectDiescriprion(par[0]);
            DescriptionTx.Text = Convert.ToString(ClassLide.Description);
            ClassLide.SelectCallLide(par[0]);
            SelectCallLideDg.DataSource = ClassLide.dataTableCallLide;
        }
        /// <summary>
        /// Метод для перехода на форму с добавлением лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtmenaBtn_Click(object sender, EventArgs e)
        {
            new FormAddLide().ShowDialog();
        }
        /// <summary>
        /// Метод для перехода на форму с редактированием лида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new FormRedLide(nomer,label9.Text,label13.Text, label10.Text, label11.Text, label12.Text).ShowDialog();
        }
    }
}
