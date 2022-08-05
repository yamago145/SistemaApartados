using MySql.Data.MySqlClient;
using SistemaApartados.BaseDatos;
using SistemaApartados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaApartados.Interfaz
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDconexion jok =new BDconexion();
           
            try
            {
                string user = Txtusuario.Text;
                string pass = Txtcontra.Text;
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; Pwd = 1234; database = sistema_apartado");
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from usuario where nombre = '" +
                    user + "' and contrasenna = '" + pass + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Frm_Principal o = new Frm_Principal();
                    //o.Close();
                    o.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error de usuario/contraseña");
                }
            }
            catch
            {
                MessageBox.Show("Error! Su contraseña y/o usuario son inválidos");
            }
            this.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Registrar go = new Frm_Registrar();
            go.Show();
        }
    }
}
