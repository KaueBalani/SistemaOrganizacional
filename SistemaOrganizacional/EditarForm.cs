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
using MySql.Data.MySqlClient;

namespace SistemaOrganizacional
{ 
    public partial class EditarForm : Form
    {
        MySqlConnection conexao;
        MySqlDataReader reader;
        public EditarForm()
        {
            InitializeComponent();
            editListView.View = View.Details;
            editListView.LabelEdit = true;
            editListView.AllowColumnReorder = true;
            editListView.FullRowSelect = true;
            editListView.GridLines = true;
            
            conectar("select * from projeto");
            while (reader.Read())
            {
                string linha = reader.GetInt32(0).ToString();

                projComboBox.Items.Add(linha);
            }
            conexao.Close();

            itemComboBox.Items.Add("Equipe");
            itemComboBox.Items.Add("Membro");
            itemComboBox.Items.Add("Tarefa");
            itemComboBox.Items.Add("Subtarefa");
            itemComboBox.Items.Add("Recurso");
            itemComboBox.Items.Add("Custo");
            itemComboBox.Items.Add("Progresso");
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {

        }

        private void escolher_tipo()
        {
            if (itemComboBox.Text == "Equipe")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Nome");
                editListView.Columns.Add("Qte membros");
                editListView.Columns.Add("Tempo");
                editListView.Columns.Add("Preco p/ tempo");
                editListView.Columns.Add("ID progresso");
                editListView.Columns.Add("ID projeto");

                editListView.Items.Clear();

                conectar("select * from equipe where id_projeto = " + projComboBox.Text);

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
                        reader.GetFloat(6).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Membro")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("CPF");
                editListView.Columns.Add("Nome");
                editListView.Columns.Add("Cargo");
                editListView.Columns.Add("ID equipe");

                editListView.Items.Clear();
                conectar("select * from membro where id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(2),
                        reader.GetString(1),
                        reader.GetInt32(3).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Tarefa")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Titulo");
                editListView.Columns.Add("Prazo");
                editListView.Columns.Add("Status");
                editListView.Columns.Add("CPF");
                editListView.Columns.Add("ID Progresso");
                editListView.Columns.Add("ID projeto");

                editListView.Items.Clear();
                conectar("select * from tarefas where id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(2),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Subtarefa")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Titulo");
                editListView.Columns.Add("Prazo");
                editListView.Columns.Add("Status");
                editListView.Columns.Add("ID tarefa");

                editListView.Items.Clear();
                conectar("select * from subtarefa where id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(3),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Recurso")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Qte utilizada");
                editListView.Columns.Add("Qte disponivel");
                editListView.Columns.Add("Preco unitario");
                editListView.Columns.Add("Tipo");
                editListView.Columns.Add("ID custo");
                editListView.Columns.Add("ID projeto");

                editListView.Items.Clear();
                conectar("select * from recurso where id_projeto = " + projComboBox.Text);

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
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Custo")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Valor");
                editListView.Columns.Add("Tipo");
                editListView.Columns.Add("ID progresso");
                editListView.Columns.Add("ID projeto");

                editListView.Items.Clear();
                conectar("select * from custo where id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetFloat(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(4).ToString(),
                        reader.GetInt32(3).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Progresso")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID");
                editListView.Columns.Add("Financeiro");
                editListView.Columns.Add("Conclusao tarefas%");
                editListView.Columns.Add("Status equipe%");
                editListView.Columns.Add("ID projeto");

                editListView.Items.Clear();
                conectar("select * from progresso where id_projeto = " + projComboBox.Text);

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
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (itemComboBox.Text == "Equipe")
            {
                
                editListView.Items.Clear();

                conectar("select * from equipe where id_projeto = " + projComboBox.Text + " and id_equipe like '%" + buscarTxtBox.Text + "%'");

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
                        reader.GetFloat(6).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Membro")
            {
                
                editListView.Items.Clear();
                conectar("select * from membro where id_projeto = " + projComboBox.Text + " and cpf like '%" + buscarTxtBox.Text + "%'");

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(2),
                        reader.GetString(1),
                        reader.GetInt32(3).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Tarefa")
            {
                
                editListView.Items.Clear();
                conectar("select * from tarefas where id_projeto = " + projComboBox.Text + " and id_tarefas like '%" + buscarTxtBox.Text + "%'");

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(2),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Subtarefa")
            {
                
                editListView.Items.Clear();
                conectar("select * from subtarefa where id_projeto = " + projComboBox.Text + " and id_subtarefa like '%" + buscarTxtBox.Text + "%'");

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(3),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Recurso")
            {
                editListView.Items.Clear();
                conectar("select * from recurso where id_projeto = " + projComboBox.Text + " and id_recurso like '%" + buscarTxtBox.Text + "%'");

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
                        reader.GetInt32(6).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Custo")
            {
                conectar("select * from recurso where id_projeto = " + projComboBox.Text + " and id_custo like '%" + buscarTxtBox.Text + "%'");
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetFloat(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(4).ToString(),
                        reader.GetInt32(3).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Progresso")
            {
                editListView.Items.Clear();
                conectar("select * from progresso where id_projeto = " + projComboBox.Text + " and id_progresso like '%" + buscarTxtBox.Text + "%'");

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetFloat(1).ToString(),
                        reader.GetFloat(2).ToString(),
                        reader.GetFloat(3).ToString(),
                        reader.GetInt32(4).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            escolher_tipo();
        }
    }
}
