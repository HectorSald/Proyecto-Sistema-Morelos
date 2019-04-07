using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_morelos
{
    public partial class Temixco : UserControl
    {
        public Temixco()
        {
            InitializeComponent();
        }
        public static string NombreCategoria;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            AutoScroll = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NombreCategoria = label4.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NombreCategoria = label1.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NombreCategoria = label11.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            NombreCategoria = label12.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            NombreCategoria = label6.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NombreCategoria = label2.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            NombreCategoria = label9.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            NombreCategoria = label7.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            NombreCategoria = label8.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NombreCategoria = label3.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            NombreCategoria = label10.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            NombreCategoria = label5.Text;
            Categorias cat = new Categorias();
            cat.Show();
            this.Hide();
        }
    }
}
