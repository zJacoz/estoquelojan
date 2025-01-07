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
            grbInfo = new GroupBox();
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
            picFoto = new PictureBox();
            txtConsulta = new TextBox();
            label1 = new Label();
            btnPesquisa = new Button();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            dgvEstoque = new DataGridView();
            grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // grbInfo
            // 
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
            grbInfo.Controls.Add(picFoto);
            grbInfo.Location = new Point(528, 51);
            grbInfo.Name = "grbInfo";
            grbInfo.Size = new Size(259, 347);
            grbInfo.TabIndex = 1;
            grbInfo.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 202);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 184);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Código:";
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(141, 299);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(100, 23);
            txtQtde.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 281);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 7;
            label5.Text = "Quantidade:";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseMnemonic = false;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(17, 299);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 281);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Cor:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(141, 246);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(100, 23);
            txtMedida.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 228);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Medida:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(16, 246);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 228);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(51, 21);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(164, 158);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(12, 30);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(510, 23);
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
            btnPesquisa.Location = new Point(528, 30);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(75, 23);
            btnPesquisa.TabIndex = 4;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(712, 404);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 53);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(621, 404);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 53);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(528, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 53);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(12, 59);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.Size = new Size(510, 398);
            dgvEstoque.TabIndex = 8;
            dgvEstoque.CellClick += dgvEstoque_CellClick_1;
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 469);
            Controls.Add(dgvEstoque);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisa);
            Controls.Add(label1);
            Controls.Add(txtConsulta);
            Controls.Add(grbInfo);
            Name = "frmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            WindowState = FormWindowState.Maximized;
            Load += frmEstoque_Load;
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
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
        private PictureBox picFoto;
        private TextBox txtQtde;
        private Label label5;
        private TextBox txtCor;
        private Label label4;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnExcluir;
        private TextBox txtId;
        private Label label6;
        private DataGridView dgvEstoque;
    }
}
