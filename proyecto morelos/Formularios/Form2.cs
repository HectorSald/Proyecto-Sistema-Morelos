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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                if(textBox1.Text=="1234")
                {
                    RegistroUsuarios ru = new RegistroUsuarios();
                    ru.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta, dirijase con la persona autorizada", "Contraseña Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    f1.Show();
                }
            }
        }
    }
}
