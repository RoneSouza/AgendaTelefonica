using System;
using System.Data;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class ExcluirContato : Form
    {
        public ExcluirContato()
        {
            InitializeComponent();
        }
        private void CmbboxSelecionaContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluirContato_Click(object sender, EventArgs e)
        {
            AgendaBll objagenda = new AgendaBll();
            DataRowView drv = (DataRowView)cmbboxSelecionaContato.SelectedItem;
            int id = int.Parse(drv.Row.ItemArray[0].ToString());

            //Propriedades da caixa de confimação de exclusão 
            const string message = "Tem certeza que quer excluir ?";
            const string caption = "Exclusão de contato";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Excluo após uma confirmação do usuário ...
            if (result == DialogResult.No)
            {
                MessageBox.Show("voce desistiu de excluir");

            }
            else
            {
                objagenda.ExcluirContato(id);
                MessageBox.Show("Você excluiu o contato, atualize a lista em run");

            }
        }

        private void BtnTelaInicial_Click(object sender, EventArgs e)
        {
            Tela_Inicial obj = new Tela_Inicial();
            obj.Show();
        }
               
        private void btnRun_Click(object sender, EventArgs e)
        {
            AgendaBll objagenda = new AgendaBll();
            DataTable datatable = objagenda.ConsultarAgenda();
            cmbboxSelecionaContato.DataSource = datatable;
            cmbboxSelecionaContato.ValueMember = "id";
            cmbboxSelecionaContato.DisplayMember = "Nome";
        }

        private void ExcluirContato_Load(object sender, EventArgs e)
        {

        }
    }
}
