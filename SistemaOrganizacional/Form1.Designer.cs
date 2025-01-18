namespace SistemaOrganizacional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menusToolStripMenuItem = new ToolStripMenuItem();
            projetosStripItem = new ToolStripMenuItem();
            monitorarStripItem = new ToolStripMenuItem();
            editarStripItem = new ToolStripMenuItem();
            sairStripItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menusToolStripMenuItem, sairStripItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menusToolStripMenuItem
            // 
            menusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projetosStripItem, monitorarStripItem, editarStripItem });
            menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            menusToolStripMenuItem.Size = new Size(55, 20);
            menusToolStripMenuItem.Text = "Menus";
            // 
            // projetosStripItem
            // 
            projetosStripItem.Name = "projetosStripItem";
            projetosStripItem.Size = new Size(180, 22);
            projetosStripItem.Text = "Projetos";
            projetosStripItem.Click += projetosStripItem_Click;
            // 
            // monitorarStripItem
            // 
            monitorarStripItem.Name = "monitorarStripItem";
            monitorarStripItem.Size = new Size(180, 22);
            monitorarStripItem.Text = "Monitorar";
            monitorarStripItem.Click += monitorarStripItem_Click;
            // 
            // editarStripItem
            // 
            editarStripItem.Name = "editarStripItem";
            editarStripItem.Size = new Size(180, 22);
            editarStripItem.Text = "Editar";
            editarStripItem.Click += editarStripItem_Click;
            // 
            // sairStripItem
            // 
            sairStripItem.Name = "sairStripItem";
            sairStripItem.Size = new Size(38, 20);
            sairStripItem.Text = "Sair";
            sairStripItem.Click += sairStripItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menusToolStripMenuItem;
        private ToolStripMenuItem projetosStripItem;
        private ToolStripMenuItem monitorarStripItem;
        private ToolStripMenuItem editarStripItem;
        private ToolStripMenuItem sairStripItem;
    }
}
