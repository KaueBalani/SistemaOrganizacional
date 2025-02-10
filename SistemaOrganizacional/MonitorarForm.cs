using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SistemaOrganizacional
{
    public partial class MonitorarForm : Form
    {
        MySqlConnection conexao;
        MySqlDataReader reader;
        public MonitorarForm()
        {
            InitializeComponent();
            initListView(monitListView);
            initListView(listView1);
            initListView(listView2);
            initListView(listView3);
            initListView(listView4);
            initListView(listView5);
            initListView(listView6);

            conectar("select * from projeto");
            monitProjetoBox.Items.Clear();

            while (reader.Read())
            {
                string linha = reader.GetInt32(0).ToString();

                monitProjetoBox.Items.Add(linha);
            }
            conexao.Close();

            monitListView.Columns.Add("ID");
            monitListView.Columns.Add("Prazo");
            monitListView.Columns.Add("Titulo");
            monitListView.Columns.Add("Status");
            monitListView.Columns.Add("CPF_Membro");
            monitListView.Columns.Add("ID_Progresso");
            monitListView.Columns.Add("ID_Projeto");

            listView1.Columns.Add("ID");
            listView1.Columns.Add("Prazo");
            listView1.Columns.Add("Status");
            listView1.Columns.Add("Titulo");
            listView1.Columns.Add("ID_Tarefa");

            listView2.Columns.Add("ID");
            listView2.Columns.Add("Nome");
            listView2.Columns.Add("Qte_Membros");
            listView2.Columns.Add("Tempo");
            listView2.Columns.Add("Preco_Temp");
            listView2.Columns.Add("ID_Progresso");
            listView2.Columns.Add("ID_Projeto");

            listView3.Columns.Add("CPF");
            listView3.Columns.Add("Cargo");
            listView3.Columns.Add("Nome");
            listView3.Columns.Add("ID_Equipe");

            listView4.Columns.Add("ID_Custo");
            listView4.Columns.Add("Valor");
            listView4.Columns.Add("Tipo");
            listView4.Columns.Add("ID_Projeto");
            listView4.Columns.Add("ID_Progresso");

            listView5.Columns.Add("ID_Recurso");
            listView5.Columns.Add("Qte_Util");
            listView5.Columns.Add("Qte_disp");
            listView5.Columns.Add("Preço_Unit");
            listView5.Columns.Add("Tipo");
            listView5.Columns.Add("ID_Custo");
            listView5.Columns.Add("ID_Projeto");

            listView6.Columns.Add("ID_Progresso");
            listView6.Columns.Add("Financeiro");
            listView6.Columns.Add("Porcent_Tarefas");
            listView6.Columns.Add("Status_equipes");
            listView6.Columns.Add("ID_Projeto");
        }

        private void initListView(ListView a)
        {
            a.View = View.Details;
            a.LabelEdit = true;
            a.AllowColumnReorder = true;
            a.FullRowSelect = true;
            a.GridLines = true;
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

        private void monitProjetoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monitListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            conectar("select * from projeto");
            monitProjetoBox.Items.Clear();

            while (reader.Read())
            {
                string linha = reader.GetInt32(0).ToString();

                monitProjetoBox.Items.Add(linha);
            }
            conexao.Close();
            if (monitProjetoBox.Text != "")
            {
                monitListView.Items.Clear();
                conectar("select * from tarefas where id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString()
                    };
                    var item = new ListViewItem(linha);
                    monitListView.Items.Add(item);
                }
                conexao.Close();

                listView1.Items.Clear();
                conectar("select subtarefa.*, tarefas.id_projeto from subtarefa, tarefas where subtarefa.id_tarefas = tarefas.id_tarefas and tarefa.id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView1.Items.Add(item);
                }
                conexao.Close();

                listView2.Items.Clear();
                conectar("select * from equipe where id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetInt32(2).ToString(),
                        reader.GetFloat(3).ToString(),
                        reader.GetFloat(4).ToString(),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView2.Items.Add(item);
                }
                conexao.Close();

                listView3.Items.Clear();
                conectar("select membro.*, equipe.id_equipe, equipe.id_projeto from membro, equipe where membro.id_equipe = equipe.id_equipe and equipe.id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString(),
                        reader.GetInt32(4).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView3.Items.Add(item);
                }
                conexao.Close();

                listView4.Items.Clear();
                conectar("select * from custo where id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetFloat(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString(),
                        reader.GetInt32(4).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView4.Items.Add(item);
                }
                conexao.Close();

                listView5.Items.Clear();
                conectar("select * from recurso where id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetInt32(1).ToString(),
                        reader.GetInt32(2).ToString(),
                        reader.GetFloat(3).ToString(),
                        reader.GetString(4),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView5.Items.Add(item);
                }
                conexao.Close();

                listView6.Items.Clear();
                conectar("select * from progresso where id_projeto = " + monitProjetoBox.Text);
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetFloat(1).ToString(),
                        reader.GetFloat(2).ToString(),
                        reader.GetFloat(3).ToString(),
                        reader.GetInt32(4).ToString()
                    };
                    var item = new ListViewItem(linha);
                    listView6.Items.Add(item);
                }
                conexao.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void MonitorarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
