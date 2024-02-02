namespace QueryConstructor
{
    partial class QueryString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryString));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.copy_Button = new System.Windows.Forms.Button();
            this.query_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.copy_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.query_TextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // copy_Button
            // 
            this.copy_Button.Location = new System.Drawing.Point(0, 0);
            this.copy_Button.Margin = new System.Windows.Forms.Padding(0);
            this.copy_Button.Name = "copy_Button";
            this.copy_Button.Size = new System.Drawing.Size(101, 31);
            this.copy_Button.TabIndex = 0;
            this.copy_Button.Text = "Copy";
            this.copy_Button.UseVisualStyleBackColor = true;
            this.copy_Button.Click += new System.EventHandler(this.copy_Button_Click);
            // 
            // query_TextBox
            // 
            this.query_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.query_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query_TextBox.Location = new System.Drawing.Point(3, 34);
            this.query_TextBox.Multiline = true;
            this.query_TextBox.Name = "query_TextBox";
            this.query_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.query_TextBox.Size = new System.Drawing.Size(794, 413);
            this.query_TextBox.TabIndex = 1;
            // 
            // QueryString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query string";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button copy_Button;
        public System.Windows.Forms.TextBox query_TextBox;
    }
}