namespace LocadoraApp2
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            midissToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            locaçõesToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem1 = new ToolStripMenuItem();
            listaToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { midissToolStripMenuItem, locaçõesToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // midissToolStripMenuItem
            // 
            midissToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, listaToolStripMenuItem });
            midissToolStripMenuItem.Name = "midissToolStripMenuItem";
            midissToolStripMenuItem.Size = new Size(80, 29);
            midissToolStripMenuItem.Text = "Midias";
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.Size = new Size(270, 34);
            novaToolStripMenuItem.Text = "Nova";
            novaToolStripMenuItem.Click += novaToolStripMenuItem_Click;
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(270, 34);
            listaToolStripMenuItem.Text = "Lista";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // locaçõesToolStripMenuItem
            // 
            locaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem1, listaToolStripMenuItem1 });
            locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            locaçõesToolStripMenuItem.Size = new Size(100, 29);
            locaçõesToolStripMenuItem.Text = "Locações";
            // 
            // novaToolStripMenuItem1
            // 
            novaToolStripMenuItem1.Name = "novaToolStripMenuItem1";
            novaToolStripMenuItem1.Size = new Size(156, 34);
            novaToolStripMenuItem1.Text = "Nova";
            // 
            // listaToolStripMenuItem1
            // 
            listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            listaToolStripMenuItem1.Size = new Size(156, 34);
            listaToolStripMenuItem1.Text = "Lista";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(57, 29);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem midissToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem1;
        private ToolStripMenuItem listaToolStripMenuItem1;
    }
}
