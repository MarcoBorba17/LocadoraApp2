namespace LocadoraApp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaMidia frmNovaMidia = new FrmNovaMidia();
            frmNovaMidia.Show();
        }
    }
}
