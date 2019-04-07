using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proyecto_morelos
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\Database.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dtr;
        public static string Nomuser;
        public static int NO = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado =MessageBox.Show("Esta apunto de salir del Sistema, ¿Desea hacerlo?","Salir",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(resultado == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Nombre_completo, Tipo_usuario FROM Usuarios WHERE Usuario='"+usuarioTextBox.Text+"'AND  Contraseña ='"+contraseñaTextBox.Text +"'";
            cmd.Parameters.AddWithValue("Usuario", usuarioTextBox.Text);
            cmd.Parameters.AddWithValue("Contraseña", contraseñaTextBox.Text);
            try
            {
                dtr = cmd.ExecuteReader();
                if(dtr.HasRows)
                {
                    while(dtr.Read())
                    {
                        if(dtr.GetValue(1).ToString() == "Administrador")
                        {
                            NO = 0;
                            Nomuser = dtr.GetValue(0).ToString();
                            MessageBox.Show("Bienvenid@ "+ dtr.GetValue(0).ToString(), "Admin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            FormMenu frm = new FormMenu();
                            this.Hide();
                            frm.Show();
                        }
                        else if (dtr.GetValue(1).ToString() == "Moderador")
                        {
                            NO = 1;
                            Nomuser = dtr.GetValue(0).ToString();
                            MessageBox.Show("Bienvenid@ " + dtr.GetValue(0).ToString(), "Moderador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMenu frm = new FormMenu();
                            this.Hide();
                            frm.Show();
                        }
                        else if (dtr.GetValue(1).ToString() == "Visitante")
                        {
                            NO = 2;
                            Nomuser = dtr.GetValue(0).ToString();
                            MessageBox.Show(" Hola Bienvenid@ " + dtr.GetValue(0).ToString(), "Visitante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMenu frm = new FormMenu();
                            this.Hide();
                            frm.Show();
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("ERROR AL INGRESAR", "LOGIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                dtr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Causado por:" + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(usuarioTextBox.Text))
            {
              MessageBox.Show("Ingrese Usuario y Contraseña", "LOGIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
              usuarioTextBox.Focus();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
           
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Causado por:" + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ayuda help = new Ayuda();
            help.Show();
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.PasswordChar = '\0';
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            contraseñaTextBox.PasswordChar = '*';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
