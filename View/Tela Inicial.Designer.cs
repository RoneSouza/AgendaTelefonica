
namespace Agenda.View
{
    partial class Tela_Inicial
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
            this.dgvConsultaAgenda = new System.Windows.Forms.DataGridView();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnAdicionarContato = new System.Windows.Forms.Button();
            this.btnConsultarAgenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaAgenda
            // 
            this.dgvConsultaAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultaAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAgenda.Location = new System.Drawing.Point(35, 25);
            this.dgvConsultaAgenda.Name = "dgvConsultaAgenda";
            this.dgvConsultaAgenda.Size = new System.Drawing.Size(724, 313);
            this.dgvConsultaAgenda.TabIndex = 0;
            this.dgvConsultaAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultaAgenda_CellContentClick);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarContato.Location = new System.Drawing.Point(35, 415);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(119, 23);
            this.btnEditarContato.TabIndex = 1;
            this.btnEditarContato.Text = "Editar Contato";
            this.btnEditarContato.UseVisualStyleBackColor = false;
            this.btnEditarContato.Click += new System.EventHandler(this.BtnEditarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirContato.Location = new System.Drawing.Point(336, 415);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(119, 23);
            this.btnExcluirContato.TabIndex = 2;
            this.btnExcluirContato.Text = "Excluir Contato";
            this.btnExcluirContato.UseVisualStyleBackColor = false;
            this.btnExcluirContato.Click += new System.EventHandler(this.BtnExcluirContato_Click);
            // 
            // btnAdicionarContato
            // 
            this.btnAdicionarContato.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdicionarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarContato.Location = new System.Drawing.Point(640, 415);
            this.btnAdicionarContato.Name = "btnAdicionarContato";
            this.btnAdicionarContato.Size = new System.Drawing.Size(119, 23);
            this.btnAdicionarContato.TabIndex = 3;
            this.btnAdicionarContato.Text = "Adicionar Contato";
            this.btnAdicionarContato.UseVisualStyleBackColor = false;
            this.btnAdicionarContato.Click += new System.EventHandler(this.BtnAdicionarContato_Click);
            // 
            // btnConsultarAgenda
            // 
            this.btnConsultarAgenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAgenda.Location = new System.Drawing.Point(35, 372);
            this.btnConsultarAgenda.Name = "btnConsultarAgenda";
            this.btnConsultarAgenda.Size = new System.Drawing.Size(724, 23);
            this.btnConsultarAgenda.TabIndex = 4;
            this.btnConsultarAgenda.Text = "Consultar Agenda";
            this.btnConsultarAgenda.UseVisualStyleBackColor = false;
            this.btnConsultarAgenda.Click += new System.EventHandler(this.BtnConsultarAgenda_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarAgenda);
            this.Controls.Add(this.btnAdicionarContato);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.dgvConsultaAgenda);
            this.Name = "Tela_Inicial";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Tela_Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaAgenda;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnAdicionarContato;
        private System.Windows.Forms.Button btnConsultarAgenda;
    }
}