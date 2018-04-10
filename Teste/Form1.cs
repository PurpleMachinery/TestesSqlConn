using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teste
{
    public partial class frmInicial : Form
    {
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca;Data Source=TARDIS-PC");
        
        public frmInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Vazio");
                return;
            }
            String sql = "insert into livros (nome, autor) values ('"+txtNome.Text+"','"+txtAutor.Text+"')";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAutor.Text = "";
            txtNome.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Select tt = new Select();
            tt.Show();
        }
    }
}
