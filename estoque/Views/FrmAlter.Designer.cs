namespace estoque.Views
{
    partial class FrmAlter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIdE = new TextBox();
            label6 = new Label();
            txtQtdeE = new TextBox();
            label5 = new Label();
            txtCorE = new TextBox();
            label4 = new Label();
            txtMedidaE = new TextBox();
            label3 = new Label();
            txtModeloE = new TextBox();
            label2 = new Label();
            picFotoE = new PictureBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ofdArquivo = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picFotoE).BeginInit();
            SuspendLayout();
            // 
            // txtIdE
            // 
            txtIdE.Location = new Point(141, 233);
            txtIdE.Name = "txtIdE";
            txtIdE.Size = new Size(100, 23);
            txtIdE.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 215);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 20;
            label6.Text = "Código:";
            // 
            // txtQtdeE
            // 
            txtQtdeE.Location = new Point(201, 338);
            txtQtdeE.Name = "txtQtdeE";
            txtQtdeE.Size = new Size(100, 23);
            txtQtdeE.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 320);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 18;
            label5.Text = "Quantidade:";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.UseMnemonic = false;
            // 
            // txtCorE
            // 
            txtCorE.Location = new Point(77, 338);
            txtCorE.Name = "txtCorE";
            txtCorE.Size = new Size(100, 23);
            txtCorE.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 320);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 16;
            label4.Text = "Cor:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMedidaE
            // 
            txtMedidaE.Location = new Point(201, 285);
            txtMedidaE.Name = "txtMedidaE";
            txtMedidaE.Size = new Size(100, 23);
            txtMedidaE.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 267);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 14;
            label3.Text = "Medida:";
            // 
            // txtModeloE
            // 
            txtModeloE.Location = new Point(76, 285);
            txtModeloE.Name = "txtModeloE";
            txtModeloE.Size = new Size(100, 23);
            txtModeloE.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 267);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Modelo:";
            // 
            // picFotoE
            // 
            picFotoE.Location = new Point(111, 43);
            picFotoE.Name = "picFotoE";
            picFotoE.Size = new Size(164, 158);
            picFotoE.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoE.TabIndex = 11;
            picFotoE.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(273, 380);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(85, 34);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(149, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 34);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ofdArquivo
            // 
            ofdArquivo.FileName = "openFileDialog1";
            // 
            // FrmAlter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 430);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtIdE);
            Controls.Add(label6);
            Controls.Add(txtQtdeE);
            Controls.Add(label5);
            Controls.Add(txtCorE);
            Controls.Add(label4);
            Controls.Add(txtMedidaE);
            Controls.Add(label3);
            Controls.Add(txtModeloE);
            Controls.Add(label2);
            Controls.Add(picFotoE);
            Name = "FrmAlter";
            Text = "Editar conteúdo";
            ((System.ComponentModel.ISupportInitialize)picFotoE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdE;
        private Label label6;
        private TextBox txtQtdeE;
        private Label label5;
        private TextBox txtCorE;
        private Label label4;
        private TextBox txtMedidaE;
        private Label label3;
        private TextBox txtModeloE;
        private Label label2;
        private PictureBox picFotoE;
        private Button btnConfirmar;
        private Button btnCancelar;
        private OpenFileDialog ofdArquivo;
    }
}