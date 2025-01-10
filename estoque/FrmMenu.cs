using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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

        void inicio()
        {
            grbInfo.Enabled = false;
            btnSalvar.Visible = false;
            txtId.Enabled = false;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnAdicionar.Visible = true;

            limpaControles();
            carregarGrid("");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            grbInfo.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionar.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;

            limpaControles();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Banco.CriarBranco();

            inicio();
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
                dgvEstoque.Refresh();
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsulta.Text);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvEstoque.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar.";
            dgvEstoque.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvEstoque_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEstoque.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["cor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstoque.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dgvEstoque.Columns)
            {
                switch (coluna.Name)
                {
                    case "modelo":
                        coluna.Width = 140;
                        coluna.HeaderText = "Modelo";
                        break;
                    case "medida":
                        coluna.Width = 70;
                        coluna.HeaderText = "Medida";
                        break;
                    case "cor":
                        coluna.Width = 70;
                        coluna.HeaderText = "Cor";
                        break;
                    case "quantidade":
                        coluna.Width = 80;
                        coluna.HeaderText = "Quantidade";
                        break;
                    case "foto":
                        coluna.Width = 140;
                        coluna.HeaderText = "Imagem";
                        break;
                    case "editar":
                        coluna.Width = 45;
                        coluna.DisplayIndex = 6;
                        coluna.HeaderText = "Editar";
                        break;
                    case "excluir":
                        coluna.Width = 45;
                        coluna.DisplayIndex = 7;
                        coluna.HeaderText = "Excluir";
                        break;
                    default:
                        coluna.Visible = false;
                        break;
                }
            }

        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.Columns[e.ColumnIndex] == dgvEstoque.Columns["editar"])
            {
                grbInfo.Enabled = true;
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
            }
            else if (dgvEstoque.Columns[e.ColumnIndex] == dgvEstoque.Columns["excluir"])
            {
                this.btnExcluir_Click(null, null);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
                if (txtId.Text == String.Empty) return;

                m = new Menu()
                {
                    id = int.Parse(txtId.Text),
                    modelo = txtModelo.Text,
                    medida = txtMedida.Text,
                    cor = txtCor.Text,
                    quantidade = txtQtde.Text,
                    foto = picFoto.ImageLocation
                };
                m.Alterar();

            inicio();
            dgvEstoque.Refresh();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == String.Empty || txtMedida.Text == String.Empty || txtCor.Text == String.Empty || txtQtde.Text == String.Empty || picFoto.ImageLocation == "") return;

            m = new Menu()
            {
                modelo = txtModelo.Text,
                medida = txtMedida.Text,
                cor = txtCor.Text,
                quantidade = txtQtde.Text,
                foto = picFoto.ImageLocation
            };
            m.Adicionar();

            inicio();
            limpaControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }
    }
}   
