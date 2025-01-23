using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrganizacional
{
    public partial class ProjetosForm : Form
    {
        MySqlConnection conexao;
        MySqlDataReader reader;

        public ProjetosForm()
        {
            InitializeComponent();

            projetosList.View = View.Details;
            projetosList.LabelEdit = true;
            projetosList.AllowColumnReorder = true;
            projetosList.FullRowSelect = true;
            projetosList.GridLines = true;

            projetosList.Columns.Add("ID");
            projetosList.Columns.Add("Nome");

            atualizar();
        }

        private void ProjetosForm_Load(object sender, EventArgs e)
        {

        }

        private void atualizar()
        {
            projetosList.Items.Clear();
            conectar("select id_projeto, nome from projeto");
            while (reader.Read())
            {
                string[] linha =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1)
                };
                ListViewItem item = new ListViewItem(linha);
                projetosList.Items.Add(item);
            }
            conexao.Close();
        }

        private void conectar(string command)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=root;database=sisorgdata";
                conexao = new MySqlConnection(data_source);
                MySqlCommand comando = new MySqlCommand(command, conexao);
                conexao.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            projetosList.Items.Clear();

            String busca = "select id_projeto, nome from projeto where nome like '%" + buscarTxtBox.Text + "%'";

            conectar(busca);
            while (reader.Read())
            {
                string[] linha =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1)
                };
                ListViewItem item = new ListViewItem(linha);
                projetosList.Items.Add(item);
            }
            conexao.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String add = "insert into projeto (data_inicio, tipo, status, nome, descricao, data_termino, orcamento) ";
            String values = "values('" + inicioTxtBox.Text + "', '" + tipoTxtBox.Text + "', '" + statusTxtBox.Text + "', '" + nomeTxtBox.Text + "', '" + descTxtBox.Text + "', '" + fimTxtBox.Text + "', " + orcaTxtBox.Text + ")";
            conectar(add + values);
            conexao.Close();

            atualizar();            
        }
    }
}
