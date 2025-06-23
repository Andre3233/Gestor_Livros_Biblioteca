namespace Projeto_Final_M9
{
    partial class Adicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
            this.numericUpDown1_paginas = new System.Windows.Forms.NumericUpDown();
            this.Txb_autor = new System.Windows.Forms.TextBox();
            this.Bt_adicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_titulo = new System.Windows.Forms.Label();
            this.Txb_titulo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Strip_livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_emprestimos = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown2_idade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_genero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_paginas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_idade)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1_paginas
            // 
            this.numericUpDown1_paginas.Location = new System.Drawing.Point(86, 167);
            this.numericUpDown1_paginas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1_paginas.Name = "numericUpDown1_paginas";
            this.numericUpDown1_paginas.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1_paginas.TabIndex = 30;
            // 
            // Txb_autor
            // 
            this.Txb_autor.Location = new System.Drawing.Point(439, 121);
            this.Txb_autor.Name = "Txb_autor";
            this.Txb_autor.Size = new System.Drawing.Size(168, 20);
            this.Txb_autor.TabIndex = 29;
            // 
            // Bt_adicionar
            // 
            this.Bt_adicionar.Location = new System.Drawing.Point(232, 204);
            this.Bt_adicionar.Name = "Bt_adicionar";
            this.Bt_adicionar.Size = new System.Drawing.Size(88, 48);
            this.Bt_adicionar.TabIndex = 28;
            this.Bt_adicionar.Text = "Adicionar";
            this.Bt_adicionar.UseVisualStyleBackColor = true;
            this.Bt_adicionar.Click += new System.EventHandler(this.Bt_adicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nome do autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Paginas:";
            // 
            // Lb_titulo
            // 
            this.Lb_titulo.AutoSize = true;
            this.Lb_titulo.Location = new System.Drawing.Point(45, 128);
            this.Lb_titulo.Name = "Lb_titulo";
            this.Lb_titulo.Size = new System.Drawing.Size(36, 13);
            this.Lb_titulo.TabIndex = 25;
            this.Lb_titulo.Text = "Titulo:";
            // 
            // Txb_titulo
            // 
            this.Txb_titulo.Location = new System.Drawing.Point(86, 124);
            this.Txb_titulo.Name = "Txb_titulo";
            this.Txb_titulo.Size = new System.Drawing.Size(100, 20);
            this.Txb_titulo.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_livros,
            this.Strip_emprestimos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Strip_livros
            // 
            this.Strip_livros.Name = "Strip_livros";
            this.Strip_livros.Size = new System.Drawing.Size(50, 20);
            this.Strip_livros.Text = "Livros";
            this.Strip_livros.Click += new System.EventHandler(this.Strip_livros_Click);
            // 
            // Strip_emprestimos
            // 
            this.Strip_emprestimos.Name = "Strip_emprestimos";
            this.Strip_emprestimos.Size = new System.Drawing.Size(88, 20);
            this.Strip_emprestimos.Text = "Emprestimos";
            this.Strip_emprestimos.Click += new System.EventHandler(this.Strip_emprestimos_Click);
            // 
            // numericUpDown2_idade
            // 
            this.numericUpDown2_idade.Location = new System.Drawing.Point(391, 159);
            this.numericUpDown2_idade.Name = "numericUpDown2_idade";
            this.numericUpDown2_idade.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown2_idade.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Idade:";
            // 
            // Cb_genero
            // 
            this.Cb_genero.FormattingEnabled = true;
            this.Cb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.Cb_genero.Location = new System.Drawing.Point(403, 210);
            this.Cb_genero.Name = "Cb_genero";
            this.Cb_genero.Size = new System.Drawing.Size(121, 21);
            this.Cb_genero.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 39;
            this.label2.Text = "Adicionar";
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Final_M9.Properties.Resources.imagem_de_fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_genero);
            this.Controls.Add(this.numericUpDown2_idade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numericUpDown1_paginas);
            this.Controls.Add(this.Txb_autor);
            this.Controls.Add(this.Bt_adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_titulo);
            this.Controls.Add(this.Txb_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_paginas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1_paginas;
        private System.Windows.Forms.TextBox Txb_autor;
        private System.Windows.Forms.Button Bt_adicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_titulo;
        private System.Windows.Forms.TextBox Txb_titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Strip_livros;
        private System.Windows.Forms.ToolStripMenuItem Strip_emprestimos;
        private System.Windows.Forms.NumericUpDown numericUpDown2_idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_genero;
        private System.Windows.Forms.Label label2;
    }
}