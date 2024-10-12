using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraApp2
{
    public partial class FrmListaMidias : Form
    {
        public FrmListaMidias()
        {
            InitializeComponent();
        }

        private List<Midia> GetMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                //Retorna todas as mídias do banco de dados
                return contexto.Midias.ToList();
            }
        }

        private void FrmListaMidias_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }
        private void CarregaDadosDGV()

        {
            //Carregando os dados para DGV
            DgvListaMidias.DataSource = GetMidias();

            //Personalizar o DGV
            DgvListaMidias.Columns["MidiaID"].HeaderText = "Código";
            DgvListaMidias.Columns["Título"].HeaderText = "Título";
            DgvListaMidias.Columns["Genero"].HeaderText = "Gênero";

            DgvListaMidias.Columns["Ano"].Visible = false;
            DgvListaMidias.Columns["Duracao"].Visible = false;
            DgvListaMidias.Columns["ClassificacaoIndicativa"].Visible = false;
            DgvListaMidias.Columns["Sinopse"].Visible = false;
            //Redimenciona as colunas
            DgvListaMidias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DgvListaMidias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar se clicou em uma linha válida
            if (e.RowIndex == 0) 
            {
                //Pega a linha selecionada pelo usuário
                DataGridViewRow linha = DgvListaMidias.Rows[e.RowIndex];

                int MidiaId = (int)linha.Cells["MidiaId"].Value;

                MessageBox.Show($"ID {MidiaId}");
        }
    }
}
