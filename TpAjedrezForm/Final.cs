using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAjedrezForm
{
    public partial class Final : Form
    {
        private Form origen;
        public Final(Form menu)
        {
            InitializeComponent();
            origen = menu;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            origen.Show();
            this.Close();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
