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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод для перехода на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExidBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Autorizacie().Show();
        }
        /// <summary>
        /// Метод для перехода на форму с лидами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectLideBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLide().Show();
        }
    }
}
