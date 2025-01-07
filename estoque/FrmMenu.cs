using System;
using System.Windows.Forms;
using estoque.Views;

namespace estoque

{
    public partial class frmEstoque : Form
    {
        Menu m;
        public frmEstoque()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtModelo.Clear();
            txtMedida.Clear();
            txtCor.Clear();
            txtQtde.Clear();
            txtConsulta.Clear();
            txtId.Clear();
            picFoto.ImageLocation = "";
        }

        void carregarGrid(string pesquisa)
        {
            m = new Menu()
            {
                modelo = pesquisa
            };
            dgvEstoque.DataSource = m.Consultar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == String.Empty) return;

            m = new Menu()
            {
                modelo = txtModelo.Text,
                medida = txtMedida.Text,
                cor = txtCor.Text,
                quantidade = txtQtde.Text,
                foto = picFoto.ImageLocation
            };
            m.Adicionar();

            limpaControles();
            carregarGrid("");
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Banco.CriarBranco();

            //dgvEstoque.Columns["foto"].Visible = false;

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmAlter form = new FrmAlter();
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir essa linha?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Menu()
                {
                    id = int.Parse(txtId.Text)
                };
                m.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsulta.Text);
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }


        private void dgvEstoque_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.RowCount > 0)
            {
                txtId.Text = dgvEstoque.CurrentRow.Cells["id"].Value.ToString();
                txtModelo.Text = dgvEstoque.CurrentRow.Cells["modelo"].Value.ToString();
                txtMedida.Text = dgvEstoque.CurrentRow.Cells["medida"].Value.ToString();
                txtCor.Text = dgvEstoque.CurrentRow.Cells["cor"].Value.ToString();
                txtQtde.Text = dgvEstoque.CurrentRow.Cells["quantidade"].Value.ToString();
                picFoto.ImageLocation = dgvEstoque.CurrentRow.Cells["foto"].Value.ToString();
            }
        }
    }
}   
