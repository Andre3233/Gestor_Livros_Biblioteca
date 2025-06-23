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

namespace Projeto_Final_M9
{
    public partial class emprestimos : Form
    {
        public static List<emprestimos> lista_emprestimos = new List<emprestimos>();
        public emprestimos()
        {
            InitializeComponent();
        }

        public class Emprestimos
        {
            public DateTime Data_emprestimo { get; set; }
            public DateTime Data_devolucao { get; set; }
            public Emprestimos(DateTime data_emprestimo)
            {
                Data_emprestimo = data_emprestimo;
                Data_devolucao = data_emprestimo.AddDays(10);
            }
        }

        private void emprestimos_Load(object sender, EventArgs e)
        {
            Cb_disponiveis.Items.Clear();
            foreach (var livro in Livros.lista_Livros)  // ALTERAÇÃO
            {
                Cb_disponiveis.Items.Add(livro);  // ALTERAÇÃO
            }
        }

        private void Bt_adicionar_Click(object sender, EventArgs e)
        {
        }

        private void Strip_Menu_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Hide();
        }

        private void Strip_livros_Click(object sender, EventArgs e)
        {
            Livros abrir = new Livros();
            abrir.Show();
            this.Hide();
        }

        private void Bt_requesitar_Click(object sender, EventArgs e)
        {
            if (Cb_disponiveis.SelectedItem != null)
            {

                // Declara explicitamente o tipo Livro para o item selecionado
                Livro livroSelecionado = (Livro)Cb_disponiveis.SelectedItem;

                DateTime dataEmprestimo = dateTimePicker1.Value;
                Emprestimos novoEmprestimo = new Emprestimos(dataEmprestimo);



                
                Cb_disponiveis.Items.Remove(livroSelecionado);
                Cb_requesitados.Items.Add(livroSelecionado);

                // Opcional: Você pode mostrar uma mensagem de sucesso
                MessageBox.Show("Livro requisitado");

                MessageBox.Show($"Livro requisitado em {novoEmprestimo.Data_emprestimo.ToShortDateString()}.\n" + //ALTERAÇÃO
                        $"Data de devolução: {novoEmprestimo.Data_devolucao.ToShortDateString()}",
                        "Empréstimo Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Se nenhum livro estiver selecionado
                MessageBox.Show("Selecione um livro disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_desponibilizar_Click(object sender, EventArgs e)
        {
            if (Cb_requesitados.SelectedItem != null)
            {
                // Declara explicitamente o tipo Livro para o item selecionado
                Livro livroSelecionado = (Livro)Cb_requesitados.SelectedItem;

                // Remove o livro da ComboBox de disponíveis
                Cb_requesitados.Items.Remove(livroSelecionado);

                // Adiciona o livro à ComboBox de requisitados
                Cb_disponiveis.Items.Add(livroSelecionado);

                // Opcional: Você pode mostrar uma mensagem de sucesso
                MessageBox.Show("Livro disponibilizado");
            }
            else
            {
                // Se nenhum livro estiver selecionado
                MessageBox.Show("Selecione um livro disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Cb_disponiveis.SelectedItem != null)
            {
                if (dateTimePicker1.Value != DateTime.MinValue)
                {
                    Livro livroSelecionado = (Livro)Cb_disponiveis.SelectedItem;

                    Cb_disponiveis.Items.Remove(livroSelecionado);

                    Cb_requesitados.Items.Add(livroSelecionado);

                    MessageBox.Show($"Livro requisitado em {dateTimePicker1.Value.ToShortDateString()}");
                }
                else
                {
                    MessageBox.Show("Seleciona a data de requisição no calendário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Escolhe um livro disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void Cb_disponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
