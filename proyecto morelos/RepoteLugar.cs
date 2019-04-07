using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_morelos
{
    public partial class RepoteLugar : Form
    {
        public RepoteLugar()
        {
            InitializeComponent();
        }

        private void RepoteLugar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Lugares' Puede moverla o quitarla según sea necesario.
            this.LugaresTableAdapter.Fill(this.DatabaseDataSet.Lugares);

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccesoRapido ac = new AccesoRapido();
            this.Close();
            ac.Show();
        }
    }
}
