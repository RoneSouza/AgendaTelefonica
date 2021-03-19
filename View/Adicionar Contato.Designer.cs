
namespace Agenda.View
{
    partial class Salvar_Contato
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
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.txtbxTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarContato = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(45, 72);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(173, 20);
            this.txtbxNome.TabIndex = 0;
            this.txtbxNome.TextChanged += new System.EventHandler(this.TxtbxNome_TextChanged);
            // 
            // txtbxTelefone
            // 
            this.txtbxTelefone.Location = new System.Drawing.Point(357, 72);
            this.txtbxTelefone.Name = "txtbxTelefone";
            this.txtbxTelefone.Size = new System.Drawing.Size(167, 20);
            this.txtbxTelefone.TabIndex = 1;
            this.txtbxTelefone.TextChanged += new System.EventHandler(this.TxtbxTelefone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone: ";
            // 
            // btnSalvarContato
            // 
            this.btnSalvarContato.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSalvarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarContato.Location = new System.Drawing.Point(184, 165);
            this.btnSalvarContato.Name = "btnSalvarContato";
            this.btnSalvarContato.Size = new System.Drawing.Size(185, 22);
            this.btnSalvarContato.TabIndex = 4;
            this.btnSalvarContato.Text = "Salvar Contato";
            this.btnSalvarContato.UseVisualStyleBackColor = false;
            this.btnSalvarContato.Click += new System.EventHandler(this.BtnSalvarContato_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.Location = new System.Drawing.Point(590, 365);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(118, 23);
            this.btnTelaInicial.TabIndex = 8;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            this.btnTelaInicial.Click += new System.EventHandler(this.BtnTelaInicial_Click);
            // 
            // Salvar_Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.btnSalvarContato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTelefone);
            this.Controls.Add(this.txtbxNome);
            this.Name = "Salvar_Contato";
            this.Text = "Adicionar Contato";
            this.Load += new System.EventHandler(this.Salvar_Contato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.TextBox txtbxTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarContato;
        private System.Windows.Forms.Button btnTelaInicial;
    }
}