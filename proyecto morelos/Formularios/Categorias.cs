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
using System.IO;

namespace proyecto_morelos
{
    public partial class Categorias : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\Database.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dtr;
        
        public Categorias()
        {
            InitializeComponent();
        }
        public static string NombreLugar = FormMenu.NombreLugar;
        public static string NombreCategoria = Temixco.NombreCategoria;
        public static string LugarNom;
        public static string Nomlugar;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Categorias_Load(object sender, EventArgs e) //INICIO FORMULARIO
        {
            NombreLugar = FormMenu.NombreLugar;
            NombreCategoria = Temixco.NombreCategoria;
            int SI = Form1.NO;
            if (SI == 0)
            {
                panel9.Visible = false;
                panel10.Visible = false;
            }
            else if (SI == 1)
            {
                
                panel9.Visible = false;          
            }
            else if (SI == 2)
            {
                label6.Visible = false;
                panel9.Visible = true;
                panel10.Visible = true;

            }
            label2.Text = NombreLugar + " >> " + NombreCategoria;
            actualizar();

        }
                      
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lugaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }
        private void button1_Click_1(object sender, EventArgs e) //INSERTAR LUEGARES
        {
            NombreLugar = FormMenu.NombreLugar;
            NombreCategoria = Temixco.NombreCategoria;
            listBox1.SelectedIndex = -1;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Lugares(Municipio, Categoria, Lugar) VALUES('"+NombreLugar+"', '"+NombreCategoria+"','"+textBox2.Text+"')";     
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lugar Agregado", "LUGAR", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Causado por:" + ex + "", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }      
            cmd.Dispose();
            conn.Close();
            actualizar();

        }
        public void actualizar() //ACTUALIZAR LUGARES
        {
            NombreLugar = FormMenu.NombreLugar;
            NombreCategoria = Temixco.NombreCategoria;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Lugar FROM Lugares WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "'";
            listBox1.Items.Clear();
            conn.Open();
            try
            {
                dtr = cmd.ExecuteReader();
                while (dtr.Read())
                {
                    listBox1.Items.Add(dtr["Lugar"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Causado por: " + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            cmd.Dispose();
            conn.Close();
            textBox2.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void listBox1_DoubleClick(object sender, EventArgs e) //SIGUIENTE FORMULARIO
        {
            LugarNom = listBox1.GetItemText(listBox1.SelectedItem);
            Informacion info = new Informacion();           
            info.Show();
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e) //ELIMINAR LUGAR
        {
            NombreLugar = FormMenu.NombreLugar;
            NombreCategoria = Temixco.NombreCategoria;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            LugarNom = listBox1.GetItemText(listBox1.SelectedItem);
            cmd.CommandText = "DELETE * FROM Lugares WHERE Municipio = '" + NombreLugar + "' AND Categoria=  '" + NombreCategoria + "' AND Lugar ='" + LugarNom + "'";
            conn.Open();
            try
            {         
                cmd.ExecuteNonQuery();                
                MessageBox.Show("Lugar Eliminado", "LUGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Causado por:" + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            conn.Close();
            listBox1.Items.Clear();
            cmd.CommandText = "SELECT Lugar FROM Lugares WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "'";
            conn.Open();
            try
            {
                dtr = cmd.ExecuteReader();
                while (dtr.Read())
                {
                    listBox1.Items.Add(dtr["Lugar"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Causado por:" + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            conn.Close();
            textBox2.Text = "";           
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void Textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e) //BUSCAR LUGAR
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Lugar FROM Lugares WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "' AND Lugar ='" + textBox1.Text + "'";
            
            if (e.KeyCode == Keys.Enter)
            {
                conn.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    
                    listBox1.Items.Clear();                    
                    while (dtr.Read())
                    {
                        listBox1.Items.Add(dtr["Lugar"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el lugar", "Lugares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                             
            }          
            cmd.Dispose();
            conn.Close();        
            if(textBox1.Focus() == true && textBox1.Text==" ")
            {
                actualizar();
            }
        }
    }
}
