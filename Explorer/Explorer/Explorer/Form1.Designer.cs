namespace Explorer
{
    partial class ExplorerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            this.ef_mainMenu = new System.Windows.Forms.MenuStrip();
            this.проводникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ef_menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ef_menu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.ef_contestMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ef_listView = new System.Windows.Forms.ListView();
            this.ef_iList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ef_sbl_quantity = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ef_sbl_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.ef_treeView = new System.Windows.Forms.TreeView();
            this.ef_mainMenu.SuspendLayout();
            this.ef_contestMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ef_mainMenu
            // 
            this.ef_mainMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ef_mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ef_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проводникToolStripMenuItem});
            this.ef_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.ef_mainMenu.Name = "ef_mainMenu";
            this.ef_mainMenu.Size = new System.Drawing.Size(927, 28);
            this.ef_mainMenu.TabIndex = 0;
            this.ef_mainMenu.Text = "menuStrip1";
            // 
            // проводникToolStripMenuItem
            // 
            this.проводникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ef_menu_open,
            this.toolStripMenuItem2,
            this.ef_menu_close});
            this.проводникToolStripMenuItem.Name = "проводникToolStripMenuItem";
            this.проводникToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.проводникToolStripMenuItem.Text = "&Проводник";
            // 
            // ef_menu_open
            // 
            this.ef_menu_open.Name = "ef_menu_open";
            this.ef_menu_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ef_menu_open.Size = new System.Drawing.Size(224, 26);
            this.ef_menu_open.Text = "&Открыть";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // ef_menu_close
            // 
            this.ef_menu_close.Name = "ef_menu_close";
            this.ef_menu_close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ef_menu_close.Size = new System.Drawing.Size(224, 26);
            this.ef_menu_close.Text = "&Выход";
            // 
            // ef_contestMenu
            // 
            this.ef_contestMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ef_contestMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выйтиИзПрограммыToolStripMenuItem});
            this.ef_contestMenu.Name = "ef_contestMenu";
            this.ef_contestMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ef_contestMenu.Size = new System.Drawing.Size(281, 58);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // выйтиИзПрограммыToolStripMenuItem
            // 
            this.выйтиИзПрограммыToolStripMenuItem.Name = "выйтиИзПрограммыToolStripMenuItem";
            this.выйтиИзПрограммыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.выйтиИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.выйтиИзПрограммыToolStripMenuItem.Text = "Выйти из программы";
            this.выйтиИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПрограммыToolStripMenuItem_Click);
            // 
            // ef_listView
            // 
            this.ef_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ef_listView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ef_listView.ContextMenuStrip = this.ef_contestMenu;
            this.ef_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ef_listView.FullRowSelect = true;
            this.ef_listView.HideSelection = false;
            this.ef_listView.LargeImageList = this.ef_iList;
            this.ef_listView.Location = new System.Drawing.Point(287, 30);
            this.ef_listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ef_listView.Name = "ef_listView";
            this.ef_listView.Size = new System.Drawing.Size(639, 421);
            this.ef_listView.TabIndex = 3;
            this.ef_listView.UseCompatibleStateImageBehavior = false;
            // 
            // ef_iList
            // 
            this.ef_iList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ef_iList.ImageStream")));
            this.ef_iList.TransparentColor = System.Drawing.Color.Transparent;
            this.ef_iList.Images.SetKeyName(0, "Comic Icons_01 013.ico");
            this.ef_iList.Images.SetKeyName(1, "Comic Icons_01 030.ico");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ef_sbl_quantity,
            this.toolStripStatusLabel1,
            this.ef_sbl_path});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(927, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ef_sbl_quantity
            // 
            this.ef_sbl_quantity.Name = "ef_sbl_quantity";
            this.ef_sbl_quantity.Size = new System.Drawing.Size(183, 20);
            this.ef_sbl_quantity.Text = "Колличество элементов: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // ef_sbl_path
            // 
            this.ef_sbl_path.Name = "ef_sbl_path";
            this.ef_sbl_path.Size = new System.Drawing.Size(48, 20);
            this.ef_sbl_path.Text = "Путь: ";
            // 
            // ef_treeView
            // 
            this.ef_treeView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ef_treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ef_treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ef_treeView.Location = new System.Drawing.Point(0, 28);
            this.ef_treeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ef_treeView.Name = "ef_treeView";
            this.ef_treeView.Size = new System.Drawing.Size(277, 425);
            this.ef_treeView.TabIndex = 5;
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(927, 479);
            this.Controls.Add(this.ef_treeView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ef_listView);
            this.Controls.Add(this.ef_mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ef_mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExplorerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.ef_mainMenu.ResumeLayout(false);
            this.ef_mainMenu.PerformLayout();
            this.ef_contestMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ef_mainMenu;
        private System.Windows.Forms.ContextMenuStrip ef_contestMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ListView ef_listView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ef_sbl_quantity;
        private System.Windows.Forms.ToolStripStatusLabel ef_sbl_path;
        private System.Windows.Forms.TreeView ef_treeView;
        private System.Windows.Forms.ImageList ef_iList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem проводникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ef_menu_open;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ef_menu_close;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
    }
}

