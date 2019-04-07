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
    public partial class AccesoRapido : Form
    {
        public AccesoRapido()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FormMenu fm = new FormMenu();
            fm.Show();
            
        }


        private void lugaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lugaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AccesoRapido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Lugares' Puede moverla o quitarla según sea necesario.
            this.lugaresTableAdapter.Fill(this.databaseDataSet.Lugares);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF (*.gif)|*.gif";
            if(getImagen.ShowDialog() == DialogResult.OK)
            {
                imagen_LogoPictureBox.ImageLocation = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                imagen_Lugar1PictureBox.ImageLocation = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                imagen_Lugar2PictureBox.ImageLocation = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                imagen_Lugar3PictureBox.ImageLocation = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
         
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bntreporte_Click(object sender, EventArgs e)
        {
            RepoteLugar rpl = new RepoteLugar();
            rpl.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
