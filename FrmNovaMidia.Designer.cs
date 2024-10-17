namespace LocadoraApp2
{
    partial class FrmNovaMidia
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
            label1 = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbGenero = new ComboBox();
            label4 = new Label();
            numCodigo = new NumericUpDown();
            cmbClassificacao = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numDuracao = new NumericUpDown();
            label8 = new Label();
            txtSinopse = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnEditar = new Button();
            btnApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 110);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(376, 31);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(396, 110);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(392, 31);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 144);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Gênero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Ação", "Terror", "Comédia", "Romance", "Anime" });
            cmbGenero.Location = new Point(12, 172);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(376, 33);
            cmbGenero.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 12);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 6;
            label4.Text = "Código";
            // 
            // numCodigo
            // 
            numCodigo.Location = new Point(17, 51);
            numCodigo.Name = "numCodigo";
            numCodigo.ReadOnly = true;
            numCodigo.Size = new Size(375, 31);
            numCodigo.TabIndex = 7;
            // 
            // cmbClassificacao
            // 
            cmbClassificacao.FormattingEnabled = true;
            cmbClassificacao.Items.AddRange(new object[] { "Livre", "+18", "Ninguém" });
            cmbClassificacao.Location = new Point(396, 172);
            cmbClassificacao.Name = "cmbClassificacao";
            cmbClassificacao.Size = new Size(392, 33);
            cmbClassificacao.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 144);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 8;
            label5.Text = "Classificação Indicativa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 207);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 10;
            label6.Text = "Ano Lançamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 207);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 12;
            label7.Text = "Duração (Minutos)";
            // 
            // numDuracao
            // 
            numDuracao.Location = new Point(396, 235);
            numDuracao.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(392, 31);
            numDuracao.TabIndex = 13;
            numDuracao.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 269);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 14;
            label8.Text = "Sinopse";
            // 
            // txtSinopse
            // 
            txtSinopse.Location = new Point(7, 297);
            txtSinopse.Multiline = true;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(781, 68);
            txtSinopse.TabIndex = 15;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(513, 389);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 49);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(660, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 49);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(14, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(366, 389);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(141, 49);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button1_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(219, 389);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(141, 49);
            btnApagar.TabIndex = 21;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // FrmNovaMidia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtSinopse);
            Controls.Add(label8);
            Controls.Add(numDuracao);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbClassificacao);
            Controls.Add(label5);
            Controls.Add(numCodigo);
            Controls.Add(label4);
            Controls.Add(cmbGenero);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Name = "FrmNovaMidia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Midia";
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label label2;
        private Label label3;
        private ComboBox cmbGenero;
        private Label label4;
        private NumericUpDown numCodigo;
        private ComboBox cmbClassificacao;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numDuracao;
        private Label label8;
        private TextBox txtSinopse;
        private Button btnSalvar;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker1;
        private Button btnEditar;
        private Button btnApagar;
    }
}