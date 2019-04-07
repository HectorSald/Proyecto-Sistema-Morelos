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
    public partial class Informacion : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\Database.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dtr;
        public Informacion()
        {
            InitializeComponent();
        }
        public static string NombreLugar;
        public static string NombreCategoria;
        public static string LugarNom;
        public static bool guardar;

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        { 
        }      
        

        private void button2_Click(object sender, EventArgs e)
        {  
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        public Image matrizdebytesaimagen(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
       
        private void Informacion_Load(object sender, EventArgs e)
        {
            NombreLugar = Categorias.NombreLugar;
            NombreCategoria = Categorias.NombreCategoria;
            LugarNom = Categorias.LugarNom;
            label2.Text = NombreLugar + " >> " + NombreCategoria + " >> " + LugarNom;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Municipio, Categoria, Lugar, Direccion, Telefono, Sitio_Web, Descripcion_General, Horarios, Servicios, Formas_de_Pago, Texto_Invitacion, Lugares_Turisticos_Cercanos, Imagen_Logo, Imagen_Lugar1, Imagen_Lugar2, Imagen_Lugar3 FROM Lugares WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "'AND  Lugar ='" + LugarNom + "'";
            int SI = Form1.NO;    
            if (SI == 2)
            {
                lugarTextBox.ReadOnly = true;
                direccionTextBox.ReadOnly = true;
                telefonoTextBox.ReadOnly = true;
                sitio_WebTextBox.ReadOnly = true;
                descripcion_GeneralTextBox.ReadOnly = true;
                horariosTextBox.ReadOnly = true;
                serviciosTextBox.ReadOnly = true;
                formas_de_PagoTextBox.ReadOnly = true;
                texto_InvitacionTextBox.ReadOnly = true;
                lugares_Turisticos_CercanosTextBox.ReadOnly = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
            conn.Open();
            try
            {                
                dtr = cmd.ExecuteReader();
                while (dtr.Read())
                {
                    municipioTextBox.Text = dtr.GetValue(0).ToString();
                    categoriaTextBox.Text = dtr.GetValue(1).ToString();
                    lugarTextBox.Text = dtr.GetValue(2).ToString();
                    direccionTextBox.Text = dtr.GetValue(3).ToString();
                    telefonoTextBox.Text = dtr.GetValue(4).ToString();
                    sitio_WebTextBox.Text = dtr.GetValue(5).ToString();
                    descripcion_GeneralTextBox.Text = dtr.GetValue(6).ToString();
                    horariosTextBox.Text = dtr.GetValue(7).ToString();
                    serviciosTextBox.Text = dtr.GetValue(8).ToString();
                    formas_de_PagoTextBox.Text = dtr.GetValue(9).ToString();
                    texto_InvitacionTextBox.Text = dtr.GetValue(10).ToString();
                    lugares_Turisticos_CercanosTextBox.Text = dtr.GetValue(11).ToString();
                    if(dtr["Imagen_Logo"]==null && dtr["Imagen_Lugar1"]==null && dtr["Imagen_Lugar2"]==null && dtr["Imagen_Lugar3"]==null)
                    {
                        MessageBox.Show("Es posible que no tenga algunas imaganes en este lugar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        imagen_LogoPictureBox.Image = matrizdebytesaimagen((byte[])dtr["Imagen_Logo"]);
                        imagen_Lugar1PictureBox.Image = matrizdebytesaimagen((byte[])dtr["Imagen_Lugar1"]);
                        imagen_Lugar2PictureBox.Image = matrizdebytesaimagen((byte[])dtr["Imagen_Lugar2"]);
                        imagen_Lugar3PictureBox.Image = matrizdebytesaimagen((byte[])dtr["Imagen_Lugar3"]);
                    }                   
                }
                dtr.Close();
            }
            catch 
            {
                MessageBox.Show("El Lugar Aun No Tiene Informacion","Información",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
            cmd.Dispose();
            MessageBox.Show("OJO: Para guardar el registro se necesita imagenes, ya sea cambiar todas la imagenes o dejarlas asi", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categorias ct = new Categorias();
            this.Close();
            ct.Show();
        }

        private void lugaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
 
        }

        private void categoriaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviciosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagen_Lugar3PictureBox_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            NombreLugar = Categorias.NombreLugar;
            NombreCategoria = Categorias.NombreCategoria;
            LugarNom = Categorias.LugarNom;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            //FileStream fs = new FileStream(imagen_LogoPictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
            //FileStream fs1 = new FileStream(imagen_Lugar1PictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
            //FileStream fs2 = new FileStream(imagen_Lugar2PictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
            //FileStream fs3 = new FileStream(imagen_Lugar3PictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
            if (guardar == true)
            {               
                try
                {  
                    cmd.CommandText = "UPDATE Lugares SET Direccion ='" + direccionTextBox.Text + "' , Telefono = '" + telefonoTextBox.Text + "', Sitio_Web='" + sitio_WebTextBox.Text + "', Descripcion_General='" + descripcion_GeneralTextBox.Text + "', Horarios='" + horariosTextBox.Text + "', Servicios='" + serviciosTextBox.Text + "', Formas_de_Pago ='" + formas_de_PagoTextBox.Text + "', Texto_Invitacion='" + texto_InvitacionTextBox.Text + "', Lugares_Turisticos_Cercanos='" + lugares_Turisticos_CercanosTextBox.Text + "', Imagen_Logo = @imagenlogo, Imagen_Lugar1= @imagen1, Imagen_Lugar2= @imagen2 , Imagen_Lugar3= @imagen3 WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "'AND  Lugar ='" + LugarNom + "'";
                    byte[] logo1;
                    using (var streamlogo = new FileStream(imagen_LogoPictureBox.ImageLocation, FileMode.Open, FileAccess.Read))
                    {
                        using (var readerlogo = new BinaryReader(streamlogo))
                        {
                            logo1 = readerlogo.ReadBytes((int)streamlogo.Length);
                        }
                    }
                    cmd.Parameters.Add("@imagenlogo", OleDbType.LongVarBinary, logo1.Length).Value = logo1;

                    byte[] img1;
                    using (var stream1 = new FileStream(imagen_Lugar1PictureBox.ImageLocation, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader1 = new BinaryReader(stream1))
                        {
                            img1 = reader1.ReadBytes((int)stream1.Length);
                        }
                    }
                    cmd.Parameters.Add("@imagen1", OleDbType.LongVarBinary, img1.Length).Value = img1;

                    byte[] img2;
                    using (var stream2 = new FileStream(imagen_Lugar2PictureBox.ImageLocation, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader2 = new BinaryReader(stream2))
                        {
                            img2 = reader2.ReadBytes((int)stream2.Length);
                        }
                    }
                    cmd.Parameters.Add("@imagen2", OleDbType.LongVarBinary, img2.Length).Value = img2;

                    byte[] img3;
                    using (var stream3 = new FileStream(imagen_Lugar3PictureBox.ImageLocation, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader3 = new BinaryReader(stream3))
                        {
                            img3 = reader3.ReadBytes((int)stream3.Length);
                        }
                    }
                    cmd.Parameters.Add("@imagen3", OleDbType.LongVarBinary, img3.Length).Value = img3;

                    //byte[] nombre = new byte[fs.Length];
                    //fs.Read(nombre, 0, Convert.ToInt32(fs.Length));
                    //cmd.Parameters.AddWithValue("@imagenlogo", nombre);
                    //byte[] nombre1 = new byte[fs.Length];
                    //fs1.Read(nombre1, 0, Convert.ToInt32(fs1.Length));
                    //cmd.Parameters.AddWithValue("@imagen1", nombre1);

                    //byte[] nombre2 = new byte[fs.Length];
                    //fs2.Read(nombre2, 0, Convert.ToInt32(fs2.Length));
                    //cmd.Parameters.AddWithValue("@imagen2", nombre2);

                    //byte[] nombre3 = new byte[fs.Length];
                    //fs3.Read(nombre3, 0, Convert.ToInt32(fs3.Length));
                    //cmd.Parameters.AddWithValue("@imagen3", nombre3);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los Datos Se Han Guardado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Causado por: " + ex + "", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                cmd.CommandText = "UPDATE Lugares SET Direccion ='" + direccionTextBox.Text + "' , Telefono = '" + telefonoTextBox.Text + "', Sitio_Web='" + sitio_WebTextBox.Text + "', Descripcion_General='" + descripcion_GeneralTextBox.Text + "', Horarios='" + horariosTextBox.Text + "', Servicios='" + serviciosTextBox.Text + "', Formas_de_Pago ='" + formas_de_PagoTextBox.Text + "', Texto_Invitacion='" + texto_InvitacionTextBox.Text + "', Lugares_Turisticos_Cercanos='" + lugares_Turisticos_CercanosTextBox.Text + "' WHERE Municipio='" + NombreLugar + "'AND  Categoria ='" + NombreCategoria + "'AND  Lugar ='" + LugarNom + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los Datos Se Han Guardado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                cmd.Dispose();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            guardar = true;
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jpg)(*jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                imagen_LogoPictureBox.ImageLocation = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("No hay imagen seleccionada", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            guardar = true;
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

        private void button4_Click(object sender, EventArgs e)
        {
            guardar = true;
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            guardar = true;
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

        private void lugaresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
