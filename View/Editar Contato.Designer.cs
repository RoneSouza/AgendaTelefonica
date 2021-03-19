
namespace Agenda.View
{
    partial class Editar_Contato
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
            this.cmbboxContatos = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.txtbxTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGravarAlteracao = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbboxContatos
            // 
            this.cmbboxContatos.FormattingEnabled = true;
            this.cmbboxContatos.Location = new System.Drawing.Point(53, 76);
            this.cmbboxContatos.Name = "cmbboxContatos";
            this.cmbboxContatos.Size = new System.Drawing.Size(238, 21);
            this.cmbboxContatos.TabIndex = 0;
            this.cmbboxContatos.SelectedIndexChanged += new System.EventHandler(this.cmbboxContatos_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(335, 73);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(53, 169);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(238, 20);
            this.txtbxNome.TabIndex = 2;
            this.txtbxNome.TextChanged += new System.EventHandler(this.txtbxNome_TextChanged);
            // 
            // txtbxTelefone
            // 
            this.txtbxTelefone.Location = new System.Drawing.Point(335, 169);
            this.txtbxTelefone.Name = "txtbxTelefone";
            this.txtbxTelefone.Size = new System.Drawing.Size(135, 20);
            this.txtbxTelefone.TabIndex = 3;
            this.txtbxTelefone.TextChanged += new System.EventHandler(this.txtbxTelefone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone: ";
            // 
            // btnGravarAlteracao
            // 
            this.btnGravarAlteracao.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGravarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarAlteracao.Location = new System.Drawing.Point(216, 224);
            this.btnGravarAlteracao.Name = "btnGravarAlteracao";
            this.btnGravarAlteracao.Size = new System.Drawing.Size(194, 23);
            this.btnGravarAlteracao.TabIndex = 6;
            this.btnGravarAlteracao.Text = "Gravar Alteração";
            this.btnGravarAlteracao.UseVisualStyleBackColor = false;
            this.btnGravarAlteracao.Click += new System.EventHandler(this.btnGravarAlteracao_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.Location = new System.Drawing.Point(579, 364);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(118, 23);
            this.btnTelaInicial.TabIndex = 7;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // Editar_Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.btnGravarAlteracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTelefone);
            this.Controls.Add(this.txtbxNome);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cmbboxContatos);
            this.Name = "Editar_Contato";
            this.Text = "Editar Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxContatos;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.TextBox txtbxTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGravarAlteracao;
        private System.Windows.Forms.Button btnTelaInicial;
    }
}