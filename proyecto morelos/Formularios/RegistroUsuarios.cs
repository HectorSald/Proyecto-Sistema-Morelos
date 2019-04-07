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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.databaseDataSet.Usuarios);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked ==true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                tipo_usuarioTextBox.Text = "Administrador";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                tipo_usuarioTextBox.Text = "Moderador";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                tipo_usuarioTextBox.Text = "Visitante";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == " " ||  contraseñaTextBox.Text ==" " || nombre_completoTextBox.Text == "" || tipo_usuarioTextBox.Text =="")
            {
                MessageBox.Show("Algunos Campos Estan Vacios","Usuarios",MessageBoxButtons.RetryCancel,MessageBoxIcon.Asterisk);
            }
            else
            {
                this.usuariosTableAdapter.INSERTAR_USER(usuarioTextBox.Text, contraseñaTextBox.Text, tipo_usuarioTextBox.Text, nombre_completoTextBox.Text);
                this.usuariosTableAdapter.Fill(this.databaseDataSet.Usuarios);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.MODIFICAR_USER(usuarioTextBox.Text, contraseñaTextBox.Text, tipo_usuarioTextBox.Text, nombre_completoTextBox.Text, usuarioTextBox.Text);
            this.usuariosTableAdapter.Fill(this.databaseDataSet.Usuarios);
            usuarioTextBox.Text = "";
            contraseñaTextBox.Text = "";
            tipo_usuarioTextBox.Text = "";
            nombre_completoTextBox.Text = "";
            usuarioTextBox.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el Usuario?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.usuariosTableAdapter.ELIMINAR_USER(usuarioTextBox.Text);
                this.usuariosTableAdapter.Fill(this.databaseDataSet.Usuarios);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.FillBy(this.databaseDataSet.Usuarios, usuarioTextBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.databaseDataSet.Usuarios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta apunto de salir del Sistema, ¿Desea hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Text = "";
            contraseñaTextBox.Text = "";
            nombre_completoTextBox.Text="";
            tipo_usuarioTextBox.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntreporte_Click(object sender, EventArgs e)
        {
            ReporteUsuarios ru = new ReporteUsuarios();
            this.Close();
            ru.Show();
        }
    }
}
