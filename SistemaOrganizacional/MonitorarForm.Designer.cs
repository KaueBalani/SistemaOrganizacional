namespace SistemaOrganizacional
{
    partial class MonitorarForm
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
            label1 = new Label();
            monitProjetoBox = new ComboBox();
            monitListView = new ListView();
            atualizarBtn = new Button();
            panel1 = new Panel();
            label8 = new Label();
            listView6 = new ListView();
            listView5 = new ListView();
            label7 = new Label();
            listView4 = new ListView();
            label6 = new Label();
            listView3 = new ListView();
            label5 = new Label();
            listView2 = new ListView();
            label4 = new Label();
            listView1 = new ListView();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 11);
            label1.Name = "label1";
            label1.Size = new Size(341, 21);
            label1.TabIndex = 0;
            label1.Text = "Selecione o ID do Projeto a ser Monitorado:";
            // 
            // monitProjetoBox
            // 
            monitProjetoBox.FormattingEnabled = true;
            monitProjetoBox.Location = new Point(398, 9);
            monitProjetoBox.Name = "monitProjetoBox";
            monitProjetoBox.Size = new Size(242, 23);
            monitProjetoBox.TabIndex = 1;
            monitProjetoBox.SelectedIndexChanged += monitProjetoBox_SelectedIndexChanged;
            // 
            // monitListView
            // 
            monitListView.Location = new Point(23, 34);
            monitListView.Name = "monitListView";
            monitListView.Size = new Size(544, 95);
            monitListView.TabIndex = 2;
            monitListView.UseCompatibleStateImageBehavior = false;
            monitListView.SelectedIndexChanged += monitListView_SelectedIndexChanged;
            // 
            // atualizarBtn
            // 
            atualizarBtn.Location = new Point(665, 398);
            atualizarBtn.Name = "atualizarBtn";
            atualizarBtn.Size = new Size(105, 40);
            atualizarBtn.TabIndex = 3;
            atualizarBtn.Text = "Atualizar";
            atualizarBtn.UseVisualStyleBackColor = true;
            atualizarBtn.Click += atualizarBtn_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(listView6);
            panel1.Controls.Add(listView5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(listView4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(listView3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(listView2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(monitListView);
            panel1.Location = new Point(66, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 386);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(254, 742);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 16;
            label8.Text = "Progresso";
            // 
            // listView6
            // 
            listView6.Location = new Point(23, 644);
            listView6.Name = "listView6";
            listView6.Size = new Size(544, 95);
            listView6.TabIndex = 15;
            listView6.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            listView5.Location = new Point(26, 766);
            listView5.Name = "listView5";
            listView5.Size = new Size(544, 95);
            listView5.TabIndex = 14;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(254, 620);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 14;
            label7.Text = "Recursos";
            // 
            // listView4
            // 
            listView4.Location = new Point(23, 522);
            listView4.Name = "listView4";
            listView4.Size = new Size(544, 95);
            listView4.TabIndex = 13;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(263, 498);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 12;
            label6.Text = "Custos";
            // 
            // listView3
            // 
            listView3.Location = new Point(23, 400);
            listView3.Name = "listView3";
            listView3.Size = new Size(544, 95);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(257, 376);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 10;
            label5.Text = "Membros";
            // 
            // listView2
            // 
            listView2.Location = new Point(23, 278);
            listView2.Name = "listView2";
            listView2.Size = new Size(544, 95);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(257, 254);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 8;
            label4.Text = "Equipes";
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 158);
            listView1.Name = "listView1";
            listView1.Size = new Size(544, 95);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(248, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "Subtarefas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(259, 10);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 5;
            label2.Text = "Tarefas";
            // 
            // MonitorarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(782, 461);
            Controls.Add(panel1);
            Controls.Add(atualizarBtn);
            Controls.Add(monitProjetoBox);
            Controls.Add(label1);
            Name = "MonitorarForm";
            Text = "MonitorarForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox monitProjetoBox;
        private ListView monitListView;
        private Button atualizarBtn;
        private Panel panel1;
        private ListView listView1;
        private Label label3;
        private Label label2;
        private ListView listView3;
        private Label label5;
        private ListView listView2;
        private Label label4;
        private ListView listView4;
        private Label label6;
        private Label label7;
        private ListView listView5;
        private Label label8;
        private ListView listView6;
    }
}