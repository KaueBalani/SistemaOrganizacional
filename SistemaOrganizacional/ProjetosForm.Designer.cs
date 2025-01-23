namespace SistemaOrganizacional
{
    partial class ProjetosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            orcaTxtBox = new TextBox();
            label10 = new Label();
            tipoTxtBox = new TextBox();
            statusTxtBox = new TextBox();
            descTxtBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            nomeTxtBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            inicioTxtBox = new TextBox();
            fimTxtBox = new TextBox();
            addBtn = new Button();
            buscarBtn = new Button();
            buscarTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            projetosList = new ListView();
            atualizarBtn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(buscarBtn);
            panel1.Controls.Add(buscarTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(projetosList);
            panel1.Location = new Point(118, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 426);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(153, 440);
            label4.Name = "label4";
            label4.Size = new Size(189, 21);
            label4.TabIndex = 4;
            label4.Text = "Cadastrar novo projeto:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2514172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.74858F));
            tableLayoutPanel1.Controls.Add(orcaTxtBox, 1, 6);
            tableLayoutPanel1.Controls.Add(label10, 0, 6);
            tableLayoutPanel1.Controls.Add(tipoTxtBox, 1, 5);
            tableLayoutPanel1.Controls.Add(statusTxtBox, 1, 4);
            tableLayoutPanel1.Controls.Add(descTxtBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(nomeTxtBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(inicioTxtBox, 1, 2);
            tableLayoutPanel1.Controls.Add(fimTxtBox, 1, 3);
            tableLayoutPanel1.Controls.Add(addBtn, 1, 7);
            tableLayoutPanel1.Location = new Point(0, 464);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4819279F));
            tableLayoutPanel1.Size = new Size(529, 306);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // orcaTxtBox
            // 
            orcaTxtBox.Location = new Point(126, 192);
            orcaTxtBox.Name = "orcaTxtBox";
            orcaTxtBox.Size = new Size(208, 23);
            orcaTxtBox.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(3, 189);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 12;
            label10.Text = "Orçamento:";
            // 
            // tipoTxtBox
            // 
            tipoTxtBox.Location = new Point(126, 158);
            tipoTxtBox.Name = "tipoTxtBox";
            tipoTxtBox.Size = new Size(208, 23);
            tipoTxtBox.TabIndex = 10;
            // 
            // statusTxtBox
            // 
            statusTxtBox.Location = new Point(126, 126);
            statusTxtBox.Name = "statusTxtBox";
            statusTxtBox.Size = new Size(208, 23);
            statusTxtBox.TabIndex = 9;
            // 
            // descTxtBox
            // 
            descTxtBox.Location = new Point(126, 35);
            descTxtBox.Name = "descTxtBox";
            descTxtBox.Size = new Size(208, 23);
            descTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 32);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 2;
            label5.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // nomeTxtBox
            // 
            nomeTxtBox.Location = new Point(126, 3);
            nomeTxtBox.Name = "nomeTxtBox";
            nomeTxtBox.Size = new Size(208, 23);
            nomeTxtBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 63);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 3;
            label6.Text = "Data de Início:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 93);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 4;
            label7.Text = "Data do Fim:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 123);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 5;
            label8.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 155);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 6;
            label9.Text = "Tipo:";
            // 
            // inicioTxtBox
            // 
            inicioTxtBox.Location = new Point(126, 66);
            inicioTxtBox.Name = "inicioTxtBox";
            inicioTxtBox.Size = new Size(208, 23);
            inicioTxtBox.TabIndex = 2;
            // 
            // fimTxtBox
            // 
            fimTxtBox.Location = new Point(126, 96);
            fimTxtBox.Name = "fimTxtBox";
            fimTxtBox.Size = new Size(208, 23);
            fimTxtBox.TabIndex = 8;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Control;
            addBtn.FlatAppearance.BorderColor = Color.Black;
            addBtn.FlatAppearance.BorderSize = 3;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Location = new Point(126, 223);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(208, 74);
            addBtn.TabIndex = 11;
            addBtn.Text = "Adicionar";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(449, 14);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(68, 23);
            buscarBtn.TabIndex = 2;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // buscarTxtBox
            // 
            buscarTxtBox.Location = new Point(88, 14);
            buscarTxtBox.Name = "buscarTxtBox";
            buscarTxtBox.Size = new Size(355, 23);
            buscarTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(220, 55);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Projetos:";
            // 
            // projetosList
            // 
            projetosList.Location = new Point(0, 79);
            projetosList.Name = "projetosList";
            projetosList.Size = new Size(529, 347);
            projetosList.TabIndex = 0;
            projetosList.UseCompatibleStateImageBehavior = false;
            // 
            // atualizarBtn
            // 
            atualizarBtn.Location = new Point(653, 399);
            atualizarBtn.Name = "atualizarBtn";
            atualizarBtn.Size = new Size(135, 39);
            atualizarBtn.TabIndex = 1;
            atualizarBtn.Text = "Atualizar";
            atualizarBtn.UseVisualStyleBackColor = true;
            atualizarBtn.Click += button1_Click;
            // 
            // ProjetosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atualizarBtn);
            Controls.Add(panel1);
            Name = "ProjetosForm";
            Text = "ProjetosForm";
            Load += ProjetosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView projetosList;
        private Label label1;
        private Label label2;
        private TextBox buscarTxtBox;
        private Button atualizarBtn;
        private Button buscarBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox nomeTxtBox;
        private TextBox tipoTxtBox;
        private TextBox statusTxtBox;
        private TextBox descTxtBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox inicioTxtBox;
        private TextBox fimTxtBox;
        private Button addBtn;
        private TextBox orcaTxtBox;
        private Label label10;
    }
}