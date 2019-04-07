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
    public partial class FormMenu : Form
    {
        public static string Nomuser;
        public FormMenu()
        {
            InitializeComponent();   
            
        }
        public static string NombreLugar;
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e) //SALIRRR
        {
            DialogResult resultado = MessageBox.Show("Esta apunto de salir del Sistema, ¿Desea hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e) //MINIMIZAR
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            temixco1.label13.Text = button1.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button2.Text.ToUpper(); 
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button3.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button4.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button5.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button6.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button7.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button8.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button9.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button10.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button11.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button12.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button13.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button14.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button15.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button16.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button17.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button18.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button19.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button20.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button21.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button22.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button23.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button24.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button25.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button26.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button27.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button28.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button29.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button30.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button31.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button32.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            temixco1.label13.Text = button33.Text.ToUpper();
            temixco1.Visible = true;
            NombreLugar = temixco1.label13.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void temixco1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            temixco1.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e) //VALIDAR ACCESO RAPIDO
        {
            int SI = Form1.NO;
            if (SI == 1 || SI ==2)
            {
                pictureBox7.Visible = false;
            }
            Nomuser = Form1.Nomuser;
            label2.Text = Nomuser;
        }

        private void pictureBox4_Click(object sender, EventArgs e) //REGRESAR AL LOGIN
        {
            Form1 f1 = new Form1();
            this.Close();           
            f1.Show();
        }
        private void pictureBox7_Click(object sender, EventArgs e) //ACCESO RAPIDO
        {
            AccesoRapido access = new AccesoRapido();
            this.Close();           
            access.Show();
        }
    }
}