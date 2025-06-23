using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Final_M9.Livros;
using static Projeto_Final_M9.emprestimos;
using static Projeto_Final_M9.Editar;

namespace Projeto_Final_M9
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void Bt_adicionar_Click(object sender, EventArgs e)
        {
            string titulo = Txb_titulo.Text;
            int num_paginas = (int)numericUpDown1_paginas.Value;
            string autor = Txb_autor.Text;
            int idade = (int)numericUpDown2_idade.Value;
            string genero = Cb_genero.Text;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Autor novoAutor = new Autor(autor, idade, genero); 
            Livro novoLivro = new Livro(titulo, num_paginas, novoAutor);

            Livros.lista_Livros.Add(novoLivro); 

            Livros.lista_autores.Add(novoAutor);

            Livros novaInstanciaLivros = new Livros();
            novaInstanciaLivros.AtualizarComboBox();

            Txb_titulo.Clear();
            Txb_autor.Clear();
            numericUpDown1_paginas.Value = 1;

            MessageBox.Show("Livro adicionado com sucesso!");

            Livros abrir = new Livros();
            abrir.Show();
            this.Hide();
        }

        private void Strip_emprestimos_Click(object sender, EventArgs e)
        {
            emprestimos abrir = new emprestimos();
            abrir.Show();
            this.Hide();
        }

        private void Strip_livros_Click(object sender, EventArgs e)
        {
            Livros abrir = new Livros();
            abrir.Show();
            this.Hide();
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
