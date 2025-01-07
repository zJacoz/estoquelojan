using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace estoque.Views
{
    public partial class FrmAlter : Form
    {
        Menu m;
        public FrmAlter()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtModeloE.Clear();
            txtMedidaE.Clear();
            txtCorE.Clear();
            txtQtdeE.Clear();
            txtIdE.Clear();
            picFotoE.ImageLocation = "";
        }

        void carregarGrid(string pesquisa)
        {
            m = new Menu()
            {
                modelo = pesquisa
            };
            ;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtModeloE.Text == String.Empty || txtMedidaE.Text == String.Empty || txtCorE.Text == String.Empty || txtQtdeE.Text == String.Empty || picFotoE.ImageLocation == "") return;

            m = new Menu()
            {
                modelo = txtModeloE.Text,
                medida = txtMedidaE.Text,
                cor = txtCorE.Text,
                quantidade = txtQtdeE.Text,
                foto = picFotoE.ImageLocation
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }
    }
}
