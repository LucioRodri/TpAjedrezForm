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
    public partial class Menu : Form
    {
        static int cantidad = 10;
        static int inicio = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Tablero tableros = new Tablero(cantidad, this, inicio);
            tableros.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidad = comboBox1.SelectedIndex + 1;
        }
    }
}
