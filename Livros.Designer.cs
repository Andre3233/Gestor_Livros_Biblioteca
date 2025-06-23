namespace Projeto_Final_M9
{
    partial class Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livros));
            this.Cb_livros = new System.Windows.Forms.ComboBox();
            this.Cb_autores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Strip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_emprestimos = new System.Windows.Forms.ToolStripMenuItem();
            this.Bt_remover = new System.Windows.Forms.Button();
            this.Bt_adicionar = new System.Windows.Forms.Button();
            this.Bt_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_livros
            // 
            this.Cb_livros.FormattingEnabled = true;
            this.Cb_livros.Location = new System.Drawing.Point(65, 67);
            this.Cb_livros.Name = "Cb_livros";
            this.Cb_livros.Size = new System.Drawing.Size(162, 21);
            this.Cb_livros.TabIndex = 30;
            // 
            // Cb_autores
            // 
            this.Cb_autores.FormattingEnabled = true;
            this.Cb_autores.Location = new System.Drawing.Point(345, 67);
            this.Cb_autores.Name = "Cb_autores";
            this.Cb_autores.Size = new System.Drawing.Size(173, 21);
            this.Cb_autores.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Autores:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_Menu,
            this.Strip_emprestimos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Strip_Menu
            // 
            this.Strip_Menu.Name = "Strip_Menu";
            this.Strip_Menu.Size = new System.Drawing.Size(50, 20);
            this.Strip_Menu.Text = "Menu";
            this.Strip_Menu.Click += new System.EventHandler(this.Strip_Menu_Click);
            // 
            // Strip_emprestimos
            // 
            this.Strip_emprestimos.Name = "Strip_emprestimos";
            this.Strip_emprestimos.Size = new System.Drawing.Size(88, 20);
            this.Strip_emprestimos.Text = "emprestimos";
            this.Strip_emprestimos.Click += new System.EventHandler(this.Strip_emprestimos_Click);
            // 
            // Bt_remover
            // 
            this.Bt_remover.Location = new System.Drawing.Point(264, 116);
            this.Bt_remover.Name = "Bt_remover";
            this.Bt_remover.Size = new System.Drawing.Size(75, 23);
            this.Bt_remover.TabIndex = 26;
            this.Bt_remover.Text = "Remover";
            this.Bt_remover.UseVisualStyleBackColor = true;
            this.Bt_remover.Click += new System.EventHandler(this.Bt_remover_Click_1);
            // 
            // Bt_adicionar
            // 
            this.Bt_adicionar.Location = new System.Drawing.Point(139, 116);
            this.Bt_adicionar.Name = "Bt_adicionar";
            this.Bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.Bt_adicionar.TabIndex = 25;
            this.Bt_adicionar.Text = "Adicionar";
            this.Bt_adicionar.UseVisualStyleBackColor = true;
            this.Bt_adicionar.Click += new System.EventHandler(this.Bt_adicionar_Click_1);
            // 
            // Bt_editar
            // 
            this.Bt_editar.Location = new System.Drawing.Point(12, 116);
            this.Bt_editar.Name = "Bt_editar";
            this.Bt_editar.Size = new System.Drawing.Size(75, 23);
            this.Bt_editar.TabIndex = 24;
            this.Bt_editar.Text = "editar";
            this.Bt_editar.UseVisualStyleBackColor = true;
            this.Bt_editar.Click += new System.EventHandler(this.Bt_editar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Livro:";
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Final_M9.Properties.Resources.imagem_de_fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cb_livros);
            this.Controls.Add(this.Cb_autores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Bt_remover);
            this.Controls.Add(this.Bt_adicionar);
            this.Controls.Add(this.Bt_editar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Livros";
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Livros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_livros;
        private System.Windows.Forms.ComboBox Cb_autores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Strip_Menu;
        private System.Windows.Forms.ToolStripMenuItem Strip_emprestimos;
        private System.Windows.Forms.Button Bt_remover;
        private System.Windows.Forms.Button Bt_adicionar;
        private System.Windows.Forms.Button Bt_editar;
        private System.Windows.Forms.Label label2;
    }
}