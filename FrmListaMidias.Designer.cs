namespace LocadoraApp2
{
    partial class FrmListaMidias
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
            DgvListaMidias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvListaMidias).BeginInit();
            SuspendLayout();
            // 
            // DgvListaMidias
            // 
            DgvListaMidias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListaMidias.Location = new Point(12, 12);
            DgvListaMidias.Name = "DgvListaMidias";
            DgvListaMidias.RowHeadersWidth = 62;
            DgvListaMidias.Size = new Size(776, 426);
            DgvListaMidias.TabIndex = 0;
            DgvListaMidias.CellContentClick += DgvListaMidias_CellContentClick;
            DgvListaMidias.DockChanged += FrmListaMidias_Load;
            // 
            // FrmListaMidias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvListaMidias);
            Name = "FrmListaMidias";
            Text = "FrmListaMidias";
            Load += FrmListaMidias_Load;
            ((System.ComponentModel.ISupportInitialize)DgvListaMidias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvListaMidias;
    }
}