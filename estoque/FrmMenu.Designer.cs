namespace estoque
{
    partial class frmEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grbInfo = new GroupBox();
            picFoto = new PictureBox();
            txtId = new TextBox();
            label6 = new Label();
            txtQtde = new TextBox();
            label5 = new Label();
            txtCor = new TextBox();
            label4 = new Label();
            txtMedida = new TextBox();
            label3 = new Label();
            txtModelo = new TextBox();
            label2 = new Label();
            txtConsulta = new TextBox();
            label1 = new Label();
            btnPesquisa = new Button();
            btnAdicionar = new Button();
            dgvEstoque = new DataGridView();
            editar = new DataGridViewImageColumn();
            excluir = new DataGridViewImageColumn();
            btnFechar = new Button();
            btnSalvar = new Button();
            ofdArquivo = new OpenFileDialog();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            bancoBindingSource = new BindingSource(components);
            grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grbInfo
            // 
            grbInfo.Controls.Add(picFoto);
            grbInfo.Controls.Add(txtId);
            grbInfo.Controls.Add(label6);
            grbInfo.Controls.Add(txtQtde);
            grbInfo.Controls.Add(label5);
            grbInfo.Controls.Add(txtCor);
            grbInfo.Controls.Add(label4);
            grbInfo.Controls.Add(txtMedida);
            grbInfo.Controls.Add(label3);
            grbInfo.Controls.Add(txtModelo);
            grbInfo.Controls.Add(label2);
            grbInfo.Location = new Point(647, 59);
            grbInfo.Name = "grbInfo";
            grbInfo.Size = new Size(263, 436);
            grbInfo.TabIndex = 1;
            grbInfo.TabStop = false;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(43, 47);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(177, 171);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 11;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 268);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 250);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Código:";
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(144, 365);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(100, 23);
            txtQtde.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 347);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 7;
            label5.Text = "Quantidade:";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseMnemonic = false;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(20, 365);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 347);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Cor:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(144, 312);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(100, 23);
            txtMedida.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 294);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Medida:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(19, 312);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 294);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(12, 30);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(495, 23);
            txtConsulta.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar modelo:";
            // 
            // btnPesquisa
            // 
            btnPesquisa.Image = Properties.Resources.Search1;
            btnPesquisa.Location = new Point(508, 26);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(30, 30);
            btnPesquisa.TabIndex = 4;
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(835, 510);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 53);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { editar, excluir });
            dgvEstoque.Location = new Point(12, 59);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.Size = new Size(629, 436);
            dgvEstoque.TabIndex = 8;
            dgvEstoque.CellClick += dgvEstoque_CellClick_1;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
            dgvEstoque.CellFormatting += dgvEstoque_CellFormatting;
            dgvEstoque.DataBindingComplete += dgvEstoque_DataBindingComplete;
            // 
            // editar
            // 
            editar.FillWeight = 45F;
            editar.HeaderText = "";
            editar.Image = Properties.Resources.edit_icon;
            editar.ImageLayout = DataGridViewImageCellLayout.Stretch;
            editar.Name = "editar";
            editar.ReadOnly = true;
            editar.Resizable = DataGridViewTriState.True;
            editar.SortMode = DataGridViewColumnSortMode.Automatic;
            editar.ToolTipText = "Clique aqui para editar.";
            editar.Width = 30;
            // 
            // excluir
            // 
            excluir.FillWeight = 45F;
            excluir.HeaderText = "";
            excluir.Image = Properties.Resources.delete_icon;
            excluir.ImageLayout = DataGridViewImageCellLayout.Stretch;
            excluir.Name = "excluir";
            excluir.ReadOnly = true;
            excluir.SortMode = DataGridViewColumnSortMode.Automatic;
            excluir.ToolTipText = "Clique aqui para editar.";
            excluir.Width = 30;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(15, 510);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 53);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(835, 510);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 53);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // ofdArquivo
            // 
            ofdArquivo.FileName = "openFileDialog1";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(835, 510);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 53);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(754, 510);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 53);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // bancoBindingSource
            // 
            bancoBindingSource.DataSource = typeof(Banco);
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 575);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            Controls.Add(dgvEstoque);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisa);
            Controls.Add(label1);
            Controls.Add(txtConsulta);
            Controls.Add(grbInfo);
            Name = "frmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            Load += frmEstoque_Load;
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbInfo;
        private TextBox txtConsulta;
        private Label label1;
        private Button btnPesquisa;
        private TextBox txtMedida;
        private Label label3;
        private TextBox txtModelo;
        private Label label2;
        private TextBox txtQtde;
        private Label label5;
        private TextBox txtCor;
        private Label label4;
        private Button btnAdicionar;
        private TextBox txtId;
        private Label label6;
        private DataGridView dgvEstoque;
        private PictureBox picFoto;
        private Button btnFechar;
        private Button btnSalvar;
        private OpenFileDialog ofdArquivo;
        private Button btnConfirmar;
        private Button btnCancelar;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn excluir;
        private BindingSource bancoBindingSource;
    }
}
