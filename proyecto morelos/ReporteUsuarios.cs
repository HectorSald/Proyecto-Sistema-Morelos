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
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ru = new RegistroUsuarios();
            this.Close();
            ru.Show();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.UsuariosTableAdapter.Fill(this.DatabaseDataSet.Usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
