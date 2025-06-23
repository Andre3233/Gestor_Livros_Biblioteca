namespace Projeto_Final_M9
{
    partial class emprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emprestimos));
            this.Cb_disponiveis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Strip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Cb_requesitados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_requesitar = new System.Windows.Forms.Button();
            this.Bt_desponibilizar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_disponiveis
            // 
            this.Cb_disponiveis.FormattingEnabled = true;
            this.Cb_disponiveis.Location = new System.Drawing.Point(99, 64);
            this.Cb_disponiveis.Name = "Cb_disponiveis";
            this.Cb_disponiveis.Size = new System.Drawing.Size(191, 21);
            this.Cb_disponiveis.TabIndex = 16;
            this.Cb_disponiveis.SelectedIndexChanged += new System.EventHandler(this.Cb_disponiveis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Disponiveis:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_Menu,
            this.Strip_livros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Strip_Menu
            // 
            this.Strip_Menu.Name = "Strip_Menu";
            this.Strip_Menu.Size = new System.Drawing.Size(50, 20);
            this.Strip_Menu.Text = "Menu";
            this.Strip_Menu.Click += new System.EventHandler(this.Strip_Menu_Click);
            // 
            // Strip_livros
            // 
            this.Strip_livros.Name = "Strip_livros";
            this.Strip_livros.Size = new System.Drawing.Size(50, 20);
            this.Strip_livros.Text = "Livros";
            this.Strip_livros.Click += new System.EventHandler(this.Strip_livros_Click);
            // 
            // Cb_requesitados
            // 
            this.Cb_requesitados.FormattingEnabled = true;
            this.Cb_requesitados.Location = new System.Drawing.Point(388, 64);
            this.Cb_requesitados.Name = "Cb_requesitados";
            this.Cb_requesitados.Size = new System.Drawing.Size(191, 21);
            this.Cb_requesitados.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Requesitados:";
            // 
            // Bt_requesitar
            // 
            this.Bt_requesitar.Location = new System.Drawing.Point(99, 151);
            this.Bt_requesitar.Name = "Bt_requesitar";
            this.Bt_requesitar.Size = new System.Drawing.Size(75, 23);
            this.Bt_requesitar.TabIndex = 19;
            this.Bt_requesitar.Text = "Requesitar";
            this.Bt_requesitar.UseVisualStyleBackColor = true;
            this.Bt_requesitar.Click += new System.EventHandler(this.Bt_requesitar_Click);
            // 
            // Bt_desponibilizar
            // 
            this.Bt_desponibilizar.Location = new System.Drawing.Point(388, 151);
            this.Bt_desponibilizar.Name = "Bt_desponibilizar";
            this.Bt_desponibilizar.Size = new System.Drawing.Size(89, 23);
            this.Bt_desponibilizar.TabIndex = 20;
            this.Bt_desponibilizar.Text = "Desponibilizar";
            this.Bt_desponibilizar.UseVisualStyleBackColor = true;
            this.Bt_desponibilizar.Click += new System.EventHandler(this.Bt_desponibilizar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Final_M9.Properties.Resources.imagem_de_fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Bt_desponibilizar);
            this.Controls.Add(this.Bt_requesitar);
            this.Controls.Add(this.Cb_requesitados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_disponiveis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emprestimos";
            this.Text = "emprestimos";
            this.Load += new System.EventHandler(this.emprestimos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cb_disponiveis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Strip_Menu;
        private System.Windows.Forms.ToolStripMenuItem Strip_livros;
        private System.Windows.Forms.ComboBox Cb_requesitados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_requesitar;
        private System.Windows.Forms.Button Bt_desponibilizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}