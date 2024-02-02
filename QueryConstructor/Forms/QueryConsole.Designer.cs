namespace QueryConstructor
{
    partial class QueryConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryConsole));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ColumnSelection_Page = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.conString_label = new System.Windows.Forms.Label();
            this.InitialCatalog_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Server_label = new System.Windows.Forms.Label();
            this.Tables_treeView = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoosedTables_treeView = new System.Windows.Forms.TreeView();
            this.Constraints_Page = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfCondition_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aliases_Page = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ColumnName_Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionsForLinkingTables_Page = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Table1_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Table2_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TypeOfJoin_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Table1Column_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Table2Column_Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRow_Button = new System.Windows.Forms.Button();
            this.AddRow_Button = new System.Windows.Forms.Button();
            this.GenerateQuery_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ColumnSelection_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Constraints_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Aliases_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ConditionsForLinkingTables_Page.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GenerateQuery_button, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.38377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.616225F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1406, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ColumnSelection_Page);
            this.tabControl1.Controls.Add(this.Constraints_Page);
            this.tabControl1.Controls.Add(this.Aliases_Page);
            this.tabControl1.Controls.Add(this.ConditionsForLinkingTables_Page);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1406, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // ColumnSelection_Page
            // 
            this.ColumnSelection_Page.Controls.Add(this.splitContainer1);
            this.ColumnSelection_Page.Location = new System.Drawing.Point(4, 22);
            this.ColumnSelection_Page.Name = "ColumnSelection_Page";
            this.ColumnSelection_Page.Padding = new System.Windows.Forms.Padding(3);
            this.ColumnSelection_Page.Size = new System.Drawing.Size(1398, 579);
            this.ColumnSelection_Page.TabIndex = 0;
            this.ColumnSelection_Page.Text = "Сolumn selection";
            this.ColumnSelection_Page.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.conString_label);
            this.splitContainer1.Panel1.Controls.Add(this.InitialCatalog_label);
            this.splitContainer1.Panel1.Controls.Add(this.Password_label);
            this.splitContainer1.Panel1.Controls.Add(this.Login_label);
            this.splitContainer1.Panel1.Controls.Add(this.Server_label);
            this.splitContainer1.Panel1.Controls.Add(this.Tables_treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ChoosedTables_treeView);
            this.splitContainer1.Size = new System.Drawing.Size(1392, 573);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 0;
            // 
            // conString_label
            // 
            this.conString_label.AutoSize = true;
            this.conString_label.Location = new System.Drawing.Point(582, 123);
            this.conString_label.Name = "conString_label";
            this.conString_label.Size = new System.Drawing.Size(35, 13);
            this.conString_label.TabIndex = 5;
            this.conString_label.Text = "label5";
            this.conString_label.Visible = false;
            // 
            // InitialCatalog_label
            // 
            this.InitialCatalog_label.AutoSize = true;
            this.InitialCatalog_label.Location = new System.Drawing.Point(582, 97);
            this.InitialCatalog_label.Name = "InitialCatalog_label";
            this.InitialCatalog_label.Size = new System.Drawing.Size(35, 13);
            this.InitialCatalog_label.TabIndex = 4;
            this.InitialCatalog_label.Text = "label4";
            this.InitialCatalog_label.Visible = false;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(582, 69);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(35, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "label3";
            this.Password_label.Visible = false;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(582, 38);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(35, 13);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "label2";
            this.Login_label.Visible = false;
            // 
            // Server_label
            // 
            this.Server_label.AutoSize = true;
            this.Server_label.Location = new System.Drawing.Point(582, 13);
            this.Server_label.Name = "Server_label";
            this.Server_label.Size = new System.Drawing.Size(35, 13);
            this.Server_label.TabIndex = 1;
            this.Server_label.Text = "label1";
            this.Server_label.Visible = false;
            // 
            // Tables_treeView
            // 
            this.Tables_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tables_treeView.Location = new System.Drawing.Point(0, 0);
            this.Tables_treeView.Name = "Tables_treeView";
            this.Tables_treeView.Size = new System.Drawing.Size(635, 573);
            this.Tables_treeView.TabIndex = 0;
            this.Tables_treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tables_treeView_BeforeCollapse);
            this.Tables_treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tables_treeView_BeforeExpand);
            this.Tables_treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.Tables_treeView_AfterExpand);
            this.Tables_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tables_treeView_NodeMouseDoubleClick);
            this.Tables_treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tables_treeView_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(495, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 365);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "TableName";
            this.TableName.Name = "TableName";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            // 
            // ChoosedTables_treeView
            // 
            this.ChoosedTables_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoosedTables_treeView.Location = new System.Drawing.Point(0, 0);
            this.ChoosedTables_treeView.Name = "ChoosedTables_treeView";
            this.ChoosedTables_treeView.Size = new System.Drawing.Size(753, 573);
            this.ChoosedTables_treeView.TabIndex = 1;
            this.ChoosedTables_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ChoosedTables_treeView_NodeMouseDoubleClick);
            // 
            // Constraints_Page
            // 
            this.Constraints_Page.Controls.Add(this.dataGridView2);
            this.Constraints_Page.Location = new System.Drawing.Point(4, 22);
            this.Constraints_Page.Name = "Constraints_Page";
            this.Constraints_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Constraints_Page.Size = new System.Drawing.Size(1398, 579);
            this.Constraints_Page.TabIndex = 1;
            this.Constraints_Page.Text = "Constraints";
            this.Constraints_Page.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName_Column,
            this.TypeOfCondition_Column,
            this.Value_Column});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1392, 573);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // ColumnName_Column
            // 
            this.ColumnName_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName_Column.HeaderText = "Column Name";
            this.ColumnName_Column.Name = "ColumnName_Column";
            this.ColumnName_Column.ReadOnly = true;
            this.ColumnName_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeOfCondition_Column
            // 
            this.TypeOfCondition_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeOfCondition_Column.HeaderText = "Type of condition";
            this.TypeOfCondition_Column.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            ">",
            "<=",
            ">=",
            "LIKE",
            "IS NULL",
            "IS NOT NULL",
            "BETWEEN"});
            this.TypeOfCondition_Column.MaxDropDownItems = 10;
            this.TypeOfCondition_Column.Name = "TypeOfCondition_Column";
            // 
            // Value_Column
            // 
            this.Value_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value_Column.HeaderText = "Value";
            this.Value_Column.Name = "Value_Column";
            this.Value_Column.ReadOnly = true;
            this.Value_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Value_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Aliases_Page
            // 
            this.Aliases_Page.Controls.Add(this.dataGridView3);
            this.Aliases_Page.Location = new System.Drawing.Point(4, 22);
            this.Aliases_Page.Name = "Aliases_Page";
            this.Aliases_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Aliases_Page.Size = new System.Drawing.Size(1398, 579);
            this.Aliases_Page.TabIndex = 2;
            this.Aliases_Page.Text = "Aliases";
            this.Aliases_Page.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName_Column2,
            this.Alias_Column});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1392, 573);
            this.dataGridView3.TabIndex = 0;
            // 
            // ColumnName_Column2
            // 
            this.ColumnName_Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName_Column2.HeaderText = "Column Name";
            this.ColumnName_Column2.Name = "ColumnName_Column2";
            this.ColumnName_Column2.ReadOnly = true;
            // 
            // Alias_Column
            // 
            this.Alias_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alias_Column.HeaderText = "Alias";
            this.Alias_Column.Name = "Alias_Column";
            // 
            // ConditionsForLinkingTables_Page
            // 
            this.ConditionsForLinkingTables_Page.Controls.Add(this.panel2);
            this.ConditionsForLinkingTables_Page.Controls.Add(this.panel1);
            this.ConditionsForLinkingTables_Page.Location = new System.Drawing.Point(4, 22);
            this.ConditionsForLinkingTables_Page.Name = "ConditionsForLinkingTables_Page";
            this.ConditionsForLinkingTables_Page.Padding = new System.Windows.Forms.Padding(3);
            this.ConditionsForLinkingTables_Page.Size = new System.Drawing.Size(1398, 579);
            this.ConditionsForLinkingTables_Page.TabIndex = 3;
            this.ConditionsForLinkingTables_Page.Text = "Conditions for linking tables";
            this.ConditionsForLinkingTables_Page.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 547);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table1_Column,
            this.Table2_Column,
            this.TypeOfJoin_Column,
            this.Table1Column_Column,
            this.Table2Column_Column});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView4.Enabled = false;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1392, 547);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellValueChanged);
            // 
            // Table1_Column
            // 
            this.Table1_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table1_Column.HeaderText = "Table 1";
            this.Table1_Column.MaxDropDownItems = 20;
            this.Table1_Column.Name = "Table1_Column";
            // 
            // Table2_Column
            // 
            this.Table2_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table2_Column.HeaderText = "Table 2";
            this.Table2_Column.MaxDropDownItems = 20;
            this.Table2_Column.Name = "Table2_Column";
            // 
            // TypeOfJoin_Column
            // 
            this.TypeOfJoin_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeOfJoin_Column.HeaderText = "Type of join";
            this.TypeOfJoin_Column.Items.AddRange(new object[] {
            "JOIN",
            "LEFT JOIN",
            "RIGHT JOIN",
            "INNER JOIN"});
            this.TypeOfJoin_Column.MaxDropDownItems = 20;
            this.TypeOfJoin_Column.Name = "TypeOfJoin_Column";
            // 
            // Table1Column_Column
            // 
            this.Table1Column_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table1Column_Column.HeaderText = "Table 1 column";
            this.Table1Column_Column.MaxDropDownItems = 20;
            this.Table1Column_Column.Name = "Table1Column_Column";
            // 
            // Table2Column_Column
            // 
            this.Table2Column_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table2Column_Column.HeaderText = "Table 2 column";
            this.Table2Column_Column.MaxDropDownItems = 20;
            this.Table2Column_Column.Name = "Table2Column_Column";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeleteRow_Button);
            this.panel1.Controls.Add(this.AddRow_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 26);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attention: Enter the values in this table only after adding all the necessary fie" +
    "lds on the \"Column selection\" page";
            // 
            // DeleteRow_Button
            // 
            this.DeleteRow_Button.Enabled = false;
            this.DeleteRow_Button.Location = new System.Drawing.Point(77, -1);
            this.DeleteRow_Button.Name = "DeleteRow_Button";
            this.DeleteRow_Button.Size = new System.Drawing.Size(75, 25);
            this.DeleteRow_Button.TabIndex = 1;
            this.DeleteRow_Button.Text = "Delete row";
            this.DeleteRow_Button.UseVisualStyleBackColor = true;
            this.DeleteRow_Button.Click += new System.EventHandler(this.DeleteRow_Button_Click);
            // 
            // AddRow_Button
            // 
            this.AddRow_Button.Enabled = false;
            this.AddRow_Button.Location = new System.Drawing.Point(0, -1);
            this.AddRow_Button.Name = "AddRow_Button";
            this.AddRow_Button.Size = new System.Drawing.Size(75, 25);
            this.AddRow_Button.TabIndex = 0;
            this.AddRow_Button.Text = "Add row";
            this.AddRow_Button.UseVisualStyleBackColor = true;
            this.AddRow_Button.Click += new System.EventHandler(this.AddRow_Button_Click);
            // 
            // GenerateQuery_button
            // 
            this.GenerateQuery_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateQuery_button.Location = new System.Drawing.Point(3, 608);
            this.GenerateQuery_button.Name = "GenerateQuery_button";
            this.GenerateQuery_button.Size = new System.Drawing.Size(1400, 30);
            this.GenerateQuery_button.TabIndex = 1;
            this.GenerateQuery_button.Text = "Qenerate query";
            this.GenerateQuery_button.UseVisualStyleBackColor = true;
            this.GenerateQuery_button.Click += new System.EventHandler(this.GenerateQuery_button_Click);
            // 
            // QueryConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryConsole_FormClosed);
            this.Load += new System.EventHandler(this.QueryConsole_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ColumnSelection_Page.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Constraints_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Aliases_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ConditionsForLinkingTables_Page.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ColumnSelection_Page;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView Tables_treeView;
        private System.Windows.Forms.TreeView ChoosedTables_treeView;
        private System.Windows.Forms.TabPage Constraints_Page;
        public System.Windows.Forms.Label InitialCatalog_label;
        public System.Windows.Forms.Label Password_label;
        public System.Windows.Forms.Label Login_label;
        public System.Windows.Forms.Label Server_label;
        public System.Windows.Forms.Label conString_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Button GenerateQuery_button;
        private System.Windows.Forms.TabPage Aliases_Page;
        private System.Windows.Forms.TabPage ConditionsForLinkingTables_Page;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeOfCondition_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_Column;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName_Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias_Column;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Table1_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Table2_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeOfJoin_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Table1Column_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Table2Column_Column;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddRow_Button;
        private System.Windows.Forms.Button DeleteRow_Button;
        private System.Windows.Forms.Label label1;
    }
}