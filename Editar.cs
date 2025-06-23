using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Final_M9.emprestimos;
using static Projeto_Final_M9.Livros;

namespace Projeto_Final_M9
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            foreach (var livro in Livros.lista_Livros)
            {
                Cb_livros.Items.Add(livro);
            }

            foreach (var autor in Livros.lista_autores)
            {
                Cb_autores.Items.Add(autor);
            }
        }

        public void Bt_guardar_Click(object sender, EventArgs e)
        {
            if (Cb_livros.SelectedItem != null)
            {
                Livro livroSelecionado = (Livro)Cb_livros.SelectedItem;
                livroSelecionado.Titulo = Cb_livros.Text;  
            
                Livros novaInstanciaLivros = new Livros();
                novaInstanciaLivros.AtualizarComboBox();  

                

                MessageBox.Show("Livro atualizado com sucesso!");
                this.Close();  
            }
            else if (Cb_autores.SelectedItem != null)
            {
                Autor autorSelecionado = (Autor)Cb_autores.SelectedItem;
                autorSelecionado.Nome = Cb_autores.Text; 

                Livros novaInstanciaLivros = new Livros();
                novaInstanciaLivros.AtualizarComboBox(); 

                

                MessageBox.Show("Autor atualizado com sucesso!");
                this.Close();  
            }
            else
            {
                MessageBox.Show("Seleciona um livro ou autor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Strip_livros_Click(object sender, EventArgs e)
        {
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
    }
}
