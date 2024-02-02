namespace QueryConstructor
{
    partial class Authentication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.UserID_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Server_label = new System.Windows.Forms.Label();
            this.InitialCatalog_label = new System.Windows.Forms.Label();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Server_comboBox = new System.Windows.Forms.ComboBox();
            this.InitialCatalog_comboBox = new System.Windows.Forms.ComboBox();
            this.CheckConnection_button = new System.Windows.Forms.Button();
            this.ConnectionStatus_label = new System.Windows.Forms.Label();
            this.Authentication_label = new System.Windows.Forms.Label();
            this.Authentication_comboBox = new System.Windows.Forms.ComboBox();
            this.OpenProgram_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserID_label
            // 
            this.UserID_label.AutoSize = true;
            this.UserID_label.Location = new System.Drawing.Point(106, 99);
            this.UserID_label.Name = "UserID_label";
            this.UserID_label.Size = new System.Drawing.Size(43, 13);
            this.UserID_label.TabIndex = 1;
            this.UserID_label.Text = "User ID";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(97, 125);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Server_label
            // 
            this.Server_label.AutoSize = true;
            this.Server_label.Location = new System.Drawing.Point(111, 72);
            this.Server_label.Name = "Server_label";
            this.Server_label.Size = new System.Drawing.Size(38, 13);
            this.Server_label.TabIndex = 3;
            this.Server_label.Text = "Server";
            // 
            // InitialCatalog_label
            // 
            this.InitialCatalog_label.AutoSize = true;
            this.InitialCatalog_label.Enabled = false;
            this.InitialCatalog_label.Location = new System.Drawing.Point(80, 153);
            this.InitialCatalog_label.Name = "InitialCatalog_label";
            this.InitialCatalog_label.Size = new System.Drawing.Size(70, 13);
            this.InitialCatalog_label.TabIndex = 5;
            this.InitialCatalog_label.Text = "Initial Catalog";
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Location = new System.Drawing.Point(156, 96);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(166, 20);
            this.UserID_textBox.TabIndex = 7;
            this.UserID_textBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(156, 122);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(166, 20);
            this.Password_textBox.TabIndex = 8;
            // 
            // Server_comboBox
            // 
            this.Server_comboBox.FormattingEnabled = true;
            this.Server_comboBox.Items.AddRange(new object[] {
            "localhost"});
            this.Server_comboBox.Location = new System.Drawing.Point(156, 69);
            this.Server_comboBox.Name = "Server_comboBox";
            this.Server_comboBox.Size = new System.Drawing.Size(166, 21);
            this.Server_comboBox.TabIndex = 9;
            this.Server_comboBox.SelectedIndexChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            this.Server_comboBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // InitialCatalog_comboBox
            // 
            this.InitialCatalog_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialCatalog_comboBox.Enabled = false;
            this.InitialCatalog_comboBox.FormattingEnabled = true;
            this.InitialCatalog_comboBox.Location = new System.Drawing.Point(156, 150);
            this.InitialCatalog_comboBox.Name = "InitialCatalog_comboBox";
            this.InitialCatalog_comboBox.Size = new System.Drawing.Size(166, 21);
            this.InitialCatalog_comboBox.TabIndex = 11;
            this.InitialCatalog_comboBox.SelectedIndexChanged += new System.EventHandler(this.InitialCatalog_comboBox_SelectedIndexChanged);
            // 
            // CheckConnection_button
            // 
            this.CheckConnection_button.Location = new System.Drawing.Point(328, 67);
            this.CheckConnection_button.Name = "CheckConnection_button";
            this.CheckConnection_button.Size = new System.Drawing.Size(127, 23);
            this.CheckConnection_button.TabIndex = 12;
            this.CheckConnection_button.Text = "Check connection";
            this.CheckConnection_button.UseVisualStyleBackColor = true;
            this.CheckConnection_button.Click += new System.EventHandler(this.CheckConnection_button_Click);
            // 
            // ConnectionStatus_label
            // 
            this.ConnectionStatus_label.AutoSize = true;
            this.ConnectionStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionStatus_label.Location = new System.Drawing.Point(328, 48);
            this.ConnectionStatus_label.Name = "ConnectionStatus_label";
            this.ConnectionStatus_label.Size = new System.Drawing.Size(107, 13);
            this.ConnectionStatus_label.TabIndex = 13;
            this.ConnectionStatus_label.Text = "ConnectionStatus";
            // 
            // Authentication_label
            // 
            this.Authentication_label.AutoSize = true;
            this.Authentication_label.Location = new System.Drawing.Point(74, 45);
            this.Authentication_label.Name = "Authentication_label";
            this.Authentication_label.Size = new System.Drawing.Size(75, 13);
            this.Authentication_label.TabIndex = 15;
            this.Authentication_label.Text = "Authentication";
            // 
            // Authentication_comboBox
            // 
            this.Authentication_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Authentication_comboBox.FormattingEnabled = true;
            this.Authentication_comboBox.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.Authentication_comboBox.Location = new System.Drawing.Point(155, 42);
            this.Authentication_comboBox.Name = "Authentication_comboBox";
            this.Authentication_comboBox.Size = new System.Drawing.Size(166, 21);
            this.Authentication_comboBox.TabIndex = 16;
            this.Authentication_comboBox.SelectedIndexChanged += new System.EventHandler(this.Authentication_comboBox_SelectedIndexChanged);
            this.Authentication_comboBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // OpenProgram_button
            // 
            this.OpenProgram_button.Enabled = false;
            this.OpenProgram_button.Location = new System.Drawing.Point(201, 177);
            this.OpenProgram_button.Name = "OpenProgram_button";
            this.OpenProgram_button.Size = new System.Drawing.Size(121, 23);
            this.OpenProgram_button.TabIndex = 17;
            this.OpenProgram_button.Text = "Open query contructor";
            this.OpenProgram_button.UseVisualStyleBackColor = true;
            this.OpenProgram_button.Click += new System.EventHandler(this.OpenProgram_button_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 238);
            this.Controls.Add(this.OpenProgram_button);
            this.Controls.Add(this.Authentication_comboBox);
            this.Controls.Add(this.Authentication_label);
            this.Controls.Add(this.ConnectionStatus_label);
            this.Controls.Add(this.CheckConnection_button);
            this.Controls.Add(this.InitialCatalog_comboBox);
            this.Controls.Add(this.Server_comboBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserID_textBox);
            this.Controls.Add(this.InitialCatalog_label);
            this.Controls.Add(this.Server_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserID_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecting to the database";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserID_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Server_label;
        private System.Windows.Forms.Label InitialCatalog_label;
        private System.Windows.Forms.TextBox UserID_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.ComboBox Server_comboBox;
        private System.Windows.Forms.ComboBox InitialCatalog_comboBox;
        private System.Windows.Forms.Button CheckConnection_button;
        private System.Windows.Forms.Label ConnectionStatus_label;
        private System.Windows.Forms.Label Authentication_label;
        private System.Windows.Forms.ComboBox Authentication_comboBox;
        private System.Windows.Forms.Button OpenProgram_button;
    }
}

