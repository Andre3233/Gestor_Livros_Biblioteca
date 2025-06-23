using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Final_M9
{
    public partial class Livros : Form
    {
        public static List<Livro> lista_Livros = new List<Livro>();
        public static List<Autor> lista_autores = new List<Autor>();
        public Livros()
        {
            InitializeComponent();
        }

        private void Livros_Load(object sender, EventArgs e)
        {
            AtualizarComboBox();
        }

        
        public class Livro 
        {
            public string Titulo { get; set; }
            public int Num_paginas { get; set; }
            public Autor Autor { get; set; }

            public Livro(string titulo, int num_paginas, Autor autor)
            {
                Titulo = titulo;
                Num_paginas = num_paginas;
                Autor = autor;
            }

            public override string ToString()
            {
                return $"{Titulo} - {Num_paginas} páginas";
            }
        }

        public class Autor
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Genero { get; set; }
            public Autor(string nome, int idade, string genero)
            {
                Nome = nome;
                Idade = idade;
                Genero = genero;
            }

            public override string ToString()
            {
                return $"{Nome} - {Idade} anos - {Genero}"; 
            }
        }

        public void AtualizarComboBox()
        {
 
            foreach (var livro in lista_Livros)
            {
                Cb_livros.Items.Add(livro);
            }

            foreach (var autor in lista_autores)
            {
                if (!Cb_autores.Items.Contains(autor))  
                {
                    Cb_autores.Items.Add(autor); 
                }
            }
        }

        private void Bt_editar_Click_1(object sender, EventArgs e)
        {
            Editar abir = new Editar();
            abir.ShowDialog();

            AtualizarComboBox();
        }

        private void Bt_adicionar_Click_1(object sender, EventArgs e)
        {
            Adicionar abir = new Adicionar();
            abir.ShowDialog();

            AtualizarComboBox();
        }

        private void Bt_remover_Click_1(object sender, EventArgs e)
        {
            Livro livroSelecionado = (Livro)Cb_livros.SelectedItem;  
            Autor autorSelecionado = (Autor)Cb_autores.SelectedItem; 

            if (livroSelecionado != null)  
            {
                lista_Livros.Remove(livroSelecionado);  
                Cb_livros.Items.Remove(livroSelecionado);  

                AtualizarComboBox();  

                MessageBox.Show($"Livro '{livroSelecionado.Titulo}' removido com sucesso.");  
            }
            else if (autorSelecionado != null)  
            {
                
                lista_Livros.RemoveAll(l => l.Autor == autorSelecionado);  
                lista_autores.Remove(autorSelecionado);  
                Cb_autores.Items.Remove(autorSelecionado);  

                AtualizarComboBox();  

                MessageBox.Show($"Autor '{autorSelecionado.Nome}' removido com sucesso.");
            }         
            else
            {
                MessageBox.Show("Por favor, selecione um livro para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<string> Tituloslivros()
        {
            return lista_Livros.Select(l => l.ToString()).ToList();
        }

        private void Strip_emprestimos_Click(object sender, EventArgs e)
        {
            emprestimos abrir = new emprestimos();
            abrir.Show();
            this.Hide();
        }

        private void Strip_Menu_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Hide();
        }
    }
}
