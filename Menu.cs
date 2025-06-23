using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

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

        private void Strip_disponiveis_Click(object sender, EventArgs e)
        {
            emprestimos abrir = new emprestimos();
            abrir.Show();
            this.Hide();
        }
    }
}
