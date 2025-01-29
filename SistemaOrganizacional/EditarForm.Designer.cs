namespace SistemaOrganizacional
{
    partial class EditarForm
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
            projComboBox = new ComboBox();
            itemComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            buscarTxtBox = new TextBox();
            buscarBtn = new Button();
            info1 = new Label();
            input1 = new TextBox();
            input7 = new TextBox();
            info7 = new Label();
            input6 = new TextBox();
            info6 = new Label();
            input5 = new TextBox();
            info5 = new Label();
            input4 = new TextBox();
            info4 = new Label();
            input3 = new TextBox();
            info3 = new Label();
            input2 = new TextBox();
            info2 = new Label();
            removeBtn = new Button();
            addBtn = new Button();
            editListView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 0;
            label1.Text = "Selecione o projeto a ser modificado:";
            // 
            // projComboBox
            // 
            projComboBox.FormattingEnabled = true;
            projComboBox.Location = new Point(283, 7);
            projComboBox.Name = "projComboBox";
            projComboBox.Size = new Size(164, 23);
            projComboBox.TabIndex = 1;
            projComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // itemComboBox
            // 
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(283, 55);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(164, 23);
            itemComboBox.TabIndex = 3;
            itemComboBox.SelectedIndexChanged += itemComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 2;
            label2.Text = "Selecione o tipo de item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(454, 31);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Pesquisar:";
            // 
            // buscarTxtBox
            // 
            buscarTxtBox.Location = new Point(539, 31);
            buscarTxtBox.Name = "buscarTxtBox";
            buscarTxtBox.Size = new Size(185, 23);
            buscarTxtBox.TabIndex = 6;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(730, 32);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(65, 23);
            buscarBtn.TabIndex = 7;
            buscarBtn.Text = "buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // info1
            // 
            info1.AutoSize = true;
            info1.Font = new Font("Segoe UI", 12F);
            info1.Location = new Point(12, 113);
            info1.Name = "info1";
            info1.Size = new Size(79, 21);
            info1.TabIndex = 8;
            info1.Text = "Atributo1:";
            // 
            // input1
            // 
            input1.Location = new Point(202, 111);
            input1.Name = "input1";
            input1.Size = new Size(185, 23);
            input1.TabIndex = 9;
            // 
            // input7
            // 
            input7.Location = new Point(202, 298);
            input7.Name = "input7";
            input7.Size = new Size(185, 23);
            input7.TabIndex = 11;
            // 
            // info7
            // 
            info7.AutoSize = true;
            info7.Font = new Font("Segoe UI", 12F);
            info7.Location = new Point(12, 300);
            info7.Name = "info7";
            info7.Size = new Size(79, 21);
            info7.TabIndex = 10;
            info7.Text = "Atributo1:";
            // 
            // input6
            // 
            input6.Location = new Point(202, 268);
            input6.Name = "input6";
            input6.Size = new Size(185, 23);
            input6.TabIndex = 13;
            // 
            // info6
            // 
            info6.AutoSize = true;
            info6.Font = new Font("Segoe UI", 12F);
            info6.Location = new Point(12, 270);
            info6.Name = "info6";
            info6.Size = new Size(79, 21);
            info6.TabIndex = 12;
            info6.Text = "Atributo1:";
            // 
            // input5
            // 
            input5.Location = new Point(202, 238);
            input5.Name = "input5";
            input5.Size = new Size(185, 23);
            input5.TabIndex = 15;
            // 
            // info5
            // 
            info5.AutoSize = true;
            info5.Font = new Font("Segoe UI", 12F);
            info5.Location = new Point(12, 240);
            info5.Name = "info5";
            info5.Size = new Size(79, 21);
            info5.TabIndex = 14;
            info5.Text = "Atributo1:";
            // 
            // input4
            // 
            input4.Location = new Point(202, 208);
            input4.Name = "input4";
            input4.Size = new Size(185, 23);
            input4.TabIndex = 17;
            // 
            // info4
            // 
            info4.AutoSize = true;
            info4.Font = new Font("Segoe UI", 12F);
            info4.Location = new Point(12, 210);
            info4.Name = "info4";
            info4.Size = new Size(79, 21);
            info4.TabIndex = 16;
            info4.Text = "Atributo1:";
            // 
            // input3
            // 
            input3.Location = new Point(202, 176);
            input3.Name = "input3";
            input3.Size = new Size(185, 23);
            input3.TabIndex = 19;
            // 
            // info3
            // 
            info3.AutoSize = true;
            info3.Font = new Font("Segoe UI", 12F);
            info3.Location = new Point(12, 176);
            info3.Name = "info3";
            info3.Size = new Size(79, 21);
            info3.TabIndex = 18;
            info3.Text = "Atributo1:";
            // 
            // input2
            // 
            input2.Location = new Point(202, 144);
            input2.Name = "input2";
            input2.Size = new Size(185, 23);
            input2.TabIndex = 21;
            // 
            // info2
            // 
            info2.AutoSize = true;
            info2.Font = new Font("Segoe UI", 12F);
            info2.Location = new Point(12, 146);
            info2.Name = "info2";
            info2.Size = new Size(79, 21);
            info2.TabIndex = 20;
            info2.Text = "Atributo1:";
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(92, 348);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 51);
            removeBtn.TabIndex = 22;
            removeBtn.Text = "Remover";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(202, 348);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 51);
            addBtn.TabIndex = 23;
            addBtn.Text = "Adicionar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editListView
            // 
            editListView.Location = new Point(453, 76);
            editListView.Name = "editListView";
            editListView.Size = new Size(342, 362);
            editListView.TabIndex = 24;
            editListView.UseCompatibleStateImageBehavior = false;
            editListView.SelectedIndexChanged += editListView_SelectedIndexChanged;
            // 
            // EditarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editListView);
            Controls.Add(addBtn);
            Controls.Add(removeBtn);
            Controls.Add(input2);
            Controls.Add(info2);
            Controls.Add(input3);
            Controls.Add(info3);
            Controls.Add(input4);
            Controls.Add(info4);
            Controls.Add(input5);
            Controls.Add(info5);
            Controls.Add(input6);
            Controls.Add(info6);
            Controls.Add(input7);
            Controls.Add(info7);
            Controls.Add(input1);
            Controls.Add(info1);
            Controls.Add(buscarBtn);
            Controls.Add(buscarTxtBox);
            Controls.Add(label3);
            Controls.Add(itemComboBox);
            Controls.Add(label2);
            Controls.Add(projComboBox);
            Controls.Add(label1);
            Name = "EditarForm";
            Text = "EditarForm";
            Load += EditarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox projComboBox;
        private ComboBox itemComboBox;
        private Label label2;
        private Label label3;
        private TextBox buscarTxtBox;
        private Button buscarBtn;
        private Label info1;
        private TextBox input1;
        private TextBox input7;
        private Label info7;
        private TextBox input6;
        private Label info6;
        private TextBox input5;
        private Label info5;
        private TextBox input4;
        private Label info4;
        private TextBox input3;
        private Label info3;
        private TextBox input2;
        private Label info2;
        private Button removeBtn;
        private Button addBtn;
        private ListView editListView;
    }
}