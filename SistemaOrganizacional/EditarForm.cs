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
            itemComboBox.Items.Add("Tarefas");
            itemComboBox.Items.Add("Subtarefa");
            itemComboBox.Items.Add("Recurso");
            itemComboBox.Items.Add("Custo");
            itemComboBox.Items.Add("Progresso");
            itemComboBox.Items.Add("Custo_Equipe");

            info1.Text = "Indisponível";
            info2.Text = "Indisponível";
            info3.Text = "Indisponível";
            info4.Text = "Indisponível";
            info5.Text = "Indisponível";
            info6.Text = "Indisponível";
            info7.Text = "Indisponível";

            input1.Enabled = false;
            input2.Enabled = false;
            input3.Enabled = false;
            input4.Enabled = false;
            input5.Enabled = false;
            input6.Enabled = false;
            input7.Enabled = false;
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {

        }

        private void escolher_tipo()
        {
            if (itemComboBox.Text == "Equipe")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID_equipe");
                editListView.Columns.Add("Nome");
                editListView.Columns.Add("Qte_membros");
                editListView.Columns.Add("Tempo");
                editListView.Columns.Add("Preco_temp");
                editListView.Columns.Add("ID_progresso");
                editListView.Columns.Add("ID_projeto");

                info1.Text = "ID:";
                info2.Text = "Nome:";
                info3.Text = "Qte_membros:";
                info4.Text = "Tempo:";
                info5.Text = "Preço p/ tempo:";
                info6.Text = "ID_Progresso:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;
                input5.Enabled = true;
                input6.Enabled = true;

                info7.Text = "Indisponível";
                input7.Enabled = false;

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
                editListView.Columns.Add("ID_equipe");

                info1.Text = "CPF:";
                info2.Text = "Nome:";
                info3.Text = "Cargo:";
                info4.Text = "ID_equipe:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;


                info5.Text = "Indisponível";
                info6.Text = "Indisponível";
                info7.Text = "Indisponível";
                input5.Enabled = false;
                input6.Enabled = false;
                input7.Enabled = false;

                editListView.Items.Clear();
                conectar("select membro.*, equipe.id_equipe, equipe.id_projeto from membro, equipe where membro.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text);

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
            else if (itemComboBox.Text == "Tarefas")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID_tarefas");
                editListView.Columns.Add("Titulo");
                editListView.Columns.Add("Prazo");
                editListView.Columns.Add("Status");
                editListView.Columns.Add("CPF");
                editListView.Columns.Add("ID_Progresso");
                editListView.Columns.Add("ID_projeto");

                info1.Text = "ID:";
                info2.Text = "Titulo:";
                info3.Text = "Prazo:";
                info4.Text = "Status:";
                info5.Text = "CPF:";
                info6.Text = "ID_Progresso:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;
                input5.Enabled = true;
                input6.Enabled = true;


                info7.Text = "Indisponível";
                input7.Enabled = false;

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
                editListView.Columns.Add("ID_subtarefa");
                editListView.Columns.Add("Titulo");
                editListView.Columns.Add("Prazo");
                editListView.Columns.Add("Status");
                editListView.Columns.Add("ID_tarefas");

                info1.Text = "ID:";
                info2.Text = "Titulo:";
                info3.Text = "Prazo:";
                info4.Text = "Status:";
                info5.Text = "ID_tarefa:";


                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;
                input5.Enabled = true;

                info6.Text = "Indisponível";
                info7.Text = "Indisponível";
                input6.Enabled = false;
                input7.Enabled = false;

                editListView.Items.Clear();
                conectar("select subtarefa.*, tarefas.id_projeto from subtarefa, tarefas where subtarefa.id_tarefas = tarefas.id_tarefas and tarefas.id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(3),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(4).ToString()
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Recurso")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID_recurso");
                editListView.Columns.Add("Qte_util");
                editListView.Columns.Add("Qte_disp");
                editListView.Columns.Add("Preco_unit");
                editListView.Columns.Add("Tipo");
                editListView.Columns.Add("ID_custo");
                editListView.Columns.Add("ID_projeto");

                info1.Text = "ID:";
                info2.Text = "Qte_utilizada:";
                info3.Text = "Qte_disponível:";
                info4.Text = "Preço unitário:";
                info5.Text = "Tipo:";
                info6.Text = "ID_custo:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;
                input5.Enabled = true;
                input6.Enabled = true;

                info7.Text = "Indisponível";
                input7.Enabled = false;

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
                editListView.Columns.Add("ID_custo");
                editListView.Columns.Add("Valor");
                editListView.Columns.Add("Tipo");
                editListView.Columns.Add("ID_progresso");
                editListView.Columns.Add("ID_projeto");

                info1.Text = "ID:";
                info2.Text = "Valor:";
                info3.Text = "Tipo:";
                info4.Text = "ID_progresso:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;

                info5.Text = "Indisponível";
                info6.Text = "Indisponível";
                info7.Text = "Indisponível";
                input5.Enabled = false;
                input6.Enabled = false;
                input7.Enabled = false;

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
                editListView.Columns.Add("ID_progresso");
                editListView.Columns.Add("Financeiro");
                editListView.Columns.Add("Porcent_tarefa");
                editListView.Columns.Add("Status_equipe");
                editListView.Columns.Add("ID_projeto");

                info1.Text = "ID:";
                info2.Text = "Financeiro:";
                info3.Text = "Conclusão_tarefas%:";
                info4.Text = "Status_equipe%:";

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;
                input4.Enabled = true;

                info5.Text = "Indisponível";
                info6.Text = "Indisponível";
                info7.Text = "Indisponível";
                input5.Enabled = false;
                input6.Enabled = false;
                input7.Enabled = false;

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
            else if (itemComboBox.Text == "Custo_Equipe")
            {
                editListView.Columns.Clear();
                editListView.Columns.Add("ID_equipe");
                editListView.Columns.Add("ID_custo");

                info1.Text = "ID_equipe:";
                info2.Text = "ID_custo:";
                

                input1.Enabled = true;
                input2.Enabled = true;
                input3.Enabled = true;

                info3.Text = "Indisponível";
                info4.Text = "Indisponível";
                info5.Text = "Indisponível";
                info6.Text = "Indisponível";
                info7.Text = "Indisponível";
                input3.Enabled = false;
                input4.Enabled = false;
                input5.Enabled = false;
                input6.Enabled = false;
                input7.Enabled = false;

                editListView.Items.Clear();
                conectar("select custo_equipe.*, equipe.id_equipe, equipe.id_projeto from custo_equipe, equipe where custo_equipe.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetInt32(1).ToString(),
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

        private void atualizar()
        {
            if (itemComboBox.Text == "Equipe")
            {

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
                conectar("select membro.*, equipe.id_equipe, equipe.id_projeto from membro, equipe where membro.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text);

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
            else if (itemComboBox.Text == "Tarefas")
            {

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
                conectar("select subtarefa.*, tarefas.id_projeto from subtarefa, tarefas where subtarefa.id_tarefas = tarefas.id_tarefas and tarefas.id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(3),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(4).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Recurso")
            {
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
                        reader.GetInt32(6).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
            else if (itemComboBox.Text == "Custo")
            {
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
                conectar("select * from progresso where id_projeto = " + projComboBox.Text);

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
            else if (itemComboBox.Text == "Custo_Equipe")
            {
                editListView.Items.Clear();
                conectar("select custo_equipe.*, equipe.id_equipe, equipe.id_projeto from custo_equipe, equipe where custo_equipe.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text);

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetInt32(1).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
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
                conectar("select membro.*, equipe.id_equipe, equipe.id_projeto from membro, equipe where membro.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text + " and membro.cpf like '%" + buscarTxtBox.Text + "%'");

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
            else if (itemComboBox.Text == "Tarefas")
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
                conectar("select subtarefa.*, tarefas.id_projeto from subtarefa, tarefas where subtarefa.id_tarefas = tarefas.id_tarefas and tarefas.id_projeto = " + projComboBox.Text + " and subtarefa.id_subtarefa like '%" + buscarTxtBox.Text + "%'");

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(3),
                        reader.GetDateTime(1).ToString(),
                        reader.GetString(2),
                        reader.GetInt32(4).ToString()
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
                editListView.Items.Clear();
                conectar("select * from custo where id_projeto = " + projComboBox.Text + " and id_custo like '%" + buscarTxtBox.Text + "%'");
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
            else if (itemComboBox.Text == "Custo_Equipe")
            {
                editListView.Items.Clear();
                conectar("select custo_equipe.*, equipe.id_equipe, equipe.id_projeto from custo_equipe, equipe where custo_equipe.id_equipe = equipe.id_equipe and equipe.id_projeto = " + projComboBox.Text + " and custo_equipe.id_custo like '%" + buscarTxtBox.Text + "%' or custo_equipe.id_equipe like '%" + buscarTxtBox.Text + "%'");
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetInt32(1).ToString(),
                    };
                    ListViewItem item = new ListViewItem(linha);
                    editListView.Items.Add(item);
                }
                conexao.Close();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (editListView.SelectedItems.Count > 0)
            {
                var item = editListView.SelectedItems[0];
                if (itemComboBox.Text == "Membro")
                    conectar("Delete from " + itemComboBox.Text + " where CPF = " + item.SubItems[0].Text);
                else if (itemComboBox.Text == "Custo_Equipe")
                {
                    conectar("Delete from " + itemComboBox.Text + " where id_equipe = " + item.SubItems[0].Text + " and id_custo = " + item.SubItems[1].Text);
                }
                else
                    conectar("Delete from " + itemComboBox.Text + " where id_" + itemComboBox.Text + " = " + item.SubItems[0].Text);
                conexao.Close();

                atualizar();

            }
            else
                MessageBox.Show("Selecione um item primeiro!");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TextBox[] array = {
                input1,
                input2,
                input3,
                input4,
                input5,
                input6,
                input7
            };

            int c1 = 0, c2 = 0;

            foreach (var i in array)
            {
                if (i.Enabled)
                {
                    c1++;
                    if (i.Text != "")
                        c2++;
                }
            }
            if (c1 == c2)
            {
                String v = "";
                String v2 = "";

                int i = 0;
                int j = 0;
                var co = editListView.Columns;
                for (i = 0; i < co.Count; i++)
                {
                    if (array[j].Enabled)
                    {
                        if (co[i].Text == "ID" || co[i].Text == "Qte_membros" || co[i].Text == "Tempo" || co[i].Text == "Preco_temp"
                        || co[i].Text == "ID_progresso" || co[i].Text == "ID_tarefas" || co[i].Text == "ID_custo" || co[i].Text == "ID_equipe"
                        || co[i].Text == "Qte_utilizada" || co[i].Text == "Qte_disp" || co[i].Text == "Preco_unit" || co[i].Text == "Valor"
                        || co[i].Text == "Financeiro" || co[i].Text == "Porcent_tarefa" || co[i].Text == "Status_equipe" || co[i].Text == "ID_subtarefa"
                        || co[i].Text == "ID_recurso")
                            v2 += array[j].Text + ", ";
                        else
                            v2 += "'" + array[j].Text + "', ";
                    }
                    v += co[i].Text + ", ";
                    j++;
                }

                v = v.Remove(v.Length - 2);

                if (itemComboBox.Text == "Membro")
                {
                    conectar("insert into Membro(cpf, nome, cargo, id_equipe) " + "values (" + v2.Remove(v2.Length - 2) + ")");
                }
                else if (itemComboBox.Text == "Subtarefa")
                {
                    conectar("insert into subtarefa(id_subtarefa, titulo, prazo, status, id_tarefas) " + "values (" + v2.Remove(v2.Length - 2) + ")");
                }
                else if (itemComboBox.Text == "Custo_Equipe")
                {
                    conectar("insert into custo_equipe(id_equipe, id_custo) " + "values (" + v2.Remove(v2.Length - 2) + ")");
                }
                else
                    conectar("insert into " + itemComboBox.Text + "(" + v + ") "
                        + "values(" + v2 + projComboBox.Text + ")");
                conexao.Close();

                atualizar();
            }
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
            input4.Text = "";
            input5.Text = "";
            input6.Text = "";
            input7.Text = "";
            escolher_tipo();
        }

        private void editListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
