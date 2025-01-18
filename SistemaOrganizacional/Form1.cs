namespace SistemaOrganizacional
{
    public partial class Form1 : Form
    {
        MonitorarForm monitorarForm;
        EditarForm editarForm;
        ProjetosForm projetosForm;
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
            if (this.projetosForm != null)
            {
                MessageBox.Show("Voce ja abriu essa aba.");
            }
            else
            {
                projetosForm = new ProjetosForm();
                projetosForm.ShowDialog();
            }
        }

        private void monitorarStripItem_Click(object sender, EventArgs e)
        {
            if (this.monitorarForm != null)
            {
                MessageBox.Show("Voce ja abriu essa aba.");
            }
            else
            {
                monitorarForm = new MonitorarForm();
                monitorarForm.ShowDialog();
            }
        }

        private void editarStripItem_Click(object sender, EventArgs e)
        {
            if (this.editarForm != null)
            {
                MessageBox.Show("Voce ja abriu essa aba.");
            }
            else
            {
                editarForm = new EditarForm();
                editarForm.ShowDialog();
            }
        }
    }
}
