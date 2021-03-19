
namespace Agenda.View
{
    partial class ExcluirContato
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
            this.cmbboxSelecionaContato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbboxSelecionaContato
            // 
            this.cmbboxSelecionaContato.FormattingEnabled = true;
            this.cmbboxSelecionaContato.Location = new System.Drawing.Point(38, 81);
            this.cmbboxSelecionaContato.Name = "cmbboxSelecionaContato";
            this.cmbboxSelecionaContato.Size = new System.Drawing.Size(271, 21);
            this.cmbboxSelecionaContato.TabIndex = 0;
            this.cmbboxSelecionaContato.SelectedIndexChanged += new System.EventHandler(this.CmbboxSelecionaContato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o contato para excluir";
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirContato.Location = new System.Drawing.Point(542, 79);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(120, 23);
            this.btnExcluirContato.TabIndex = 2;
            this.btnExcluirContato.Text = "Excluir Contato";
            this.btnExcluirContato.UseVisualStyleBackColor = false;
            this.btnExcluirContato.Click += new System.EventHandler(this.BtnExcluirContato_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.Location = new System.Drawing.Point(568, 356);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(118, 23);
            this.btnTelaInicial.TabIndex = 8;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            this.btnTelaInicial.Click += new System.EventHandler(this.BtnTelaInicial_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(354, 82);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // ExcluirContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbboxSelecionaContato);
            this.Name = "ExcluirContato";
            this.Text = "Excluir Contato";
            this.Load += new System.EventHandler(this.ExcluirContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxSelecionaContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnTelaInicial;
        private System.Windows.Forms.Button btnRun;
    }
}