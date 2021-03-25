using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoBD
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=127.0.0.1;Initial Catalog=testebd_c;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Salvo com sucesso");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não está funcionando"+ex);
            }
        }
    }
}
