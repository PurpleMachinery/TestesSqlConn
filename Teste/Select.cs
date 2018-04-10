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
    public partial class Select : Form
    {
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca;Data Source=TARDIS-PC");
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            String sql = "select * from livros";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conn);
            DataSet insersor = new DataSet();
            adaptador.Fill(insersor);
            dataLivros.DataSource = insersor;
            dataLivros.DataMember = insersor.Tables[0].TableName;

            conn.Close();
        }
    }
}
