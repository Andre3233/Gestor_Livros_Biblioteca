namespace Projeto_Final_M9
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.Cb_livros = new System.Windows.Forms.ComboBox();
            this.Cb_autores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Strip_livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_emprestimos = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_livros
            // 
            this.Cb_livros.FormattingEnabled = true;
            this.Cb_livros.Location = new System.Drawing.Point(112, 90);
            this.Cb_livros.Name = "Cb_livros";
            this.Cb_livros.Size = new System.Drawing.Size(162, 21);
            this.Cb_livros.TabIndex = 34;
            // 
            // Cb_autores
            // 
            this.Cb_autores.FormattingEnabled = true;
            this.Cb_autores.Location = new System.Drawing.Point(392, 90);
            this.Cb_autores.Name = "Cb_autores";
            this.Cb_autores.Size = new System.Drawing.Size(173, 21);
            this.Cb_autores.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Autores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Livro:";
            // 
            // Bt_guardar
            // 
            this.Bt_guardar.Location = new System.Drawing.Point(76, 160);
            this.Bt_guardar.Name = "Bt_guardar";
            this.Bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.Bt_guardar.TabIndex = 35;
            this.Bt_guardar.Text = "Guardar";
            this.Bt_guardar.UseVisualStyleBackColor = true;
            this.Bt_guardar.Click += new System.EventHandler(this.Bt_guardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_livros,
            this.Strip_emprestimos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 36;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 42);
            this.label3.TabIndex = 37;
            this.label3.Text = "Editar";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Final_M9.Properties.Resources.imagem_de_fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Bt_guardar);
            this.Controls.Add(this.Cb_livros);
            this.Controls.Add(this.Cb_autores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_livros;
        private System.Windows.Forms.ComboBox Cb_autores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Strip_livros;
        private System.Windows.Forms.ToolStripMenuItem Strip_emprestimos;
        private System.Windows.Forms.Label label3;
    }
}