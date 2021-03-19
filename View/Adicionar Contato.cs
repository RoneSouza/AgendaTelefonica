using System;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class Salvar_Contato : Form
    {
        public Salvar_Contato()
        {
            InitializeComponent();
        }

        
        

        private void TxtbxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtbxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvarContato_Click(object sender, EventArgs e)
        {
            AgendaBll agendaObj = new AgendaBll();
            agendaObj.Nome = txtbxNome.Text;
            agendaObj.Telefone = txtbxTelefone.Text;
            agendaObj.Adicionar_Contato(agendaObj.Nome, agendaObj.Telefone);
            txtbxNome.Text = String.Empty;
            txtbxTelefone.Text = "";
        }
        private void BtnTelaInicial_Click(object sender, EventArgs e)
        {
            Tela_Inicial obj = new Tela_Inicial();
            obj.Show();
        }

        private void Salvar_Contato_Load(object sender, EventArgs e)
        {

        }
    }
}
