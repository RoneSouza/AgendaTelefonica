using System;
using System.Data;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class Editar_Contato : Form
    {
        public Editar_Contato()
        {
            InitializeComponent();
        }

        private void cmbboxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)cmbboxContatos.SelectedItem);
            txtbxNome.Text = drv.Row.ItemArray[1].ToString();
            txtbxTelefone.Text = drv.Row.ItemArray[2].ToString();

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            AgendaBll objagenda = new AgendaBll();
            DataTable datatable = objagenda.ConsultarAgenda();
            cmbboxContatos.DataSource = datatable;
            cmbboxContatos.ValueMember = "Id";
            cmbboxContatos.DisplayMember = "Nome";
        }

        private void txtbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravarAlteracao_Click(object sender, EventArgs e)
        {
            AgendaBll fornecedorBll = new AgendaBll();
            DataRowView drv = ((DataRowView)cmbboxContatos.SelectedItem);
            int id = int.Parse(drv.Row.ItemArray[0].ToString());
            fornecedorBll.EditarContato(id, txtbxNome.Text, txtbxTelefone.Text);
            txtbxNome.Text = "";
            txtbxTelefone.Text = "";
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            Tela_Inicial obj = new Tela_Inicial();
            obj.Show();
        }
    }
}
