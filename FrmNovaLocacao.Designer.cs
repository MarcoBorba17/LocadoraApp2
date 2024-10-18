namespace LocadoraApp2
{
    partial class FrmNovaLocacao
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            mtxtCPF = new MaskedTextBox();
            label3 = new Label();
            mtxtTelefone = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mtxtCPF);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1398, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Left;
            txtNomeCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(17, 63);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(681, 34);
            txtNomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // mtxtCPF
            // 
            mtxtCPF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mtxtCPF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtCPF.Location = new Point(17, 125);
            mtxtCPF.Mask = "999.999.999-99";
            mtxtCPF.Name = "mtxtCPF";
            mtxtCPF.Size = new Size(681, 34);
            mtxtCPF.TabIndex = 2;
            mtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Anchor = AnchorStyles.Left;
            mtxtTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefone.Location = new Point(29, 227);
            mtxtTelefone.Mask = "(99) 0000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(686, 34);
            mtxtTelefone.TabIndex = 3;
            mtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtTelefone.MaskInputRejected += mtxtTelefone_MaskInputRejected;
            // 
            // FrmNovaLocacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 520);
            Controls.Add(mtxtTelefone);
            Controls.Add(groupBox1);
            Name = "FrmNovaLocacao";
            Text = "FrmNovaLocacao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtxtCPF;
        private Label label2;
        private TextBox txtNomeCliente;
        private Label label1;
        private MaskedTextBox mtxtTelefone;
        private Label label3;
    }
}