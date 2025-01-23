using System.Diagnostics.Eventing.Reader;

namespace SistemaOrganizacional
{
    public partial class Form1 : Form
    {
        MonitorarForm monitorarForm;
        EditarForm editarForm;
        ProjetosForm projetosForm;
        bool projetos_view = false;
        bool editar_view = false;
        bool monit_view = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairStripItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projetosStripItem_Click(object sender, EventArgs e)
        {
            if (projetosForm == null)
                projetosForm = new ProjetosForm();
            projetosForm.ShowDialog();
            projetos_view = true;
        }

        private void monitorarStripItem_Click(object sender, EventArgs e)
        {
            if (monitorarForm == null)
                monitorarForm = new MonitorarForm();
            monitorarForm.ShowDialog();
            monit_view = true;
        }

        private void editarStripItem_Click(object sender, EventArgs e)
        {
            if (editarForm == null)
                editarForm = new EditarForm();
            editarForm.ShowDialog();
            editar_view = true;
        }
    }
}
