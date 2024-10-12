﻿using LocadoraApp2.Classes;
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
    public partial class FrmNovaMidia : Form
    {
        public FrmNovaMidia()
        {
            InitializeComponent();
        }

        private void NovaMidia(
            string titulo,
            string autor,
            string sinopse,
            string genero,
            string classificacaoIndicativa,
            int duracao,
            int ano
        )
        {
            //Iniciamos a conexão com o banco
            using (var contexto = new LocadoraAppDbContext())
            {
                //cria uma nova instancia de Midia, com os dados da função
                Midia novaMidia = new Midia
                {
                    Titulo = titulo,
                    Autor = autor,
                    Sinopse = sinopse,
                    Genero = genero,
                    ClassicacaoIndicativa = classificacaoIndicativa,
                    Duracao = duracao,
                    Ano = ano
                };

                // Adiciona uma nova mídia ao contexto
                contexto.Midias.Add(novaMidia);

                //Salvando as alterações do contexto
                int res = contexto.SaveChanges();

                if (res == 0)
                {
                    MessageBox.Show("Erro ao Salvar a mídia!");
                }
                else
                {
                    MessageBox.Show("Mídia criada com sucesso!");
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtSinopse.Clear();
                    cmbGenero.SelectedItem = null;
                    cmbClassificacao.SelectedItem = null;
                    numDuracao.Value = 0;   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaMidia(
                txtTitulo.Text,
                txtAutor.Text,
                txtSinopse.Text,
                cmbGenero.SelectedItem.ToString(),
                cmbClassificacao.SelectedItem.ToString(),
                (int)numDuracao.Value,
                2024
            );
        }
        /*
         Salvar uma nova mídia no banco de dados
         */
        

    }
}
      
