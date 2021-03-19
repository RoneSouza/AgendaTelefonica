using System;
using System.Data;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void DgvConsultaAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnConsultarAgenda_Click(object sender, EventArgs e)
        {
            AgendaBll agendaObj = new AgendaBll();
            DataTable dataTable = GetDataTable(agendaObj);
            dgvConsultaAgenda.DataSource = dataTable;
        }

        private static DataTable GetDataTable(AgendaBll agendaObj)
        {
            return agendaObj.ConsultarAgenda();
        }

        private void BtnEditarContato_Click(object sender, EventArgs e)
        {
            Editar_Contato obj = new Editar_Contato();
            obj.Show();

        }

        private void BtnExcluirContato_Click(object sender, EventArgs e)
        {
            ExcluirContato obj = new ExcluirContato();
            obj.Show();
        }

        private void BtnAdicionarContato_Click(object sender, EventArgs e)
        {
            Salvar_Contato obj = new Salvar_Contato();
            obj.Show();
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
