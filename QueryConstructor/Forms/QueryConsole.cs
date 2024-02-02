using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace QueryConstructor
{
    public partial class QueryConsole : Form
    {
        public QueryConsole()
        {
            InitializeComponent();
        }

        private void QueryConsole_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns["Value_Column"].DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToDeleteRows= false;
            dataGridView4.AllowUserToDeleteRows= false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;

            SqlConnection con = new SqlConnection(conString_label.Text);
            con.Open();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selectdb = new SqlCommand($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG= '{InitialCatalog_label.Text}';", con);
            adapter.SelectCommand = selectdb;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Tables_treeView.Nodes.Add((string)table.Rows[i]["TABLE_NAME"]);
                Tables_treeView.Nodes[i].Nodes.Add("fake");
            }
        }

        private void Tables_treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();

            SqlConnection con = new SqlConnection(conString_label.Text);
            con.Open();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selectdb = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{e.Node.Text}';", con);
            adapter.SelectCommand = selectdb;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Tables_treeView.Nodes[e.Node.Index].Nodes.Add((string)table.Rows[i]["COLUMN_NAME"]);
            }
        }

        private void Tables_treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                string NodeName = "[" + e.Node.Parent.Text + "].[" + e.Node.Text + "]";
                bool duplicate = false;
                int RowsCount = dataGridView1.Rows.Count - 1;
                for (int i = 0; i < RowsCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == e.Node.Parent.Text && dataGridView1.Rows[i].Cells[1].Value.ToString() == e.Node.Text)
                    {
                        duplicate = true;
                    }
                }
                if (duplicate == true)
                {
                    MessageBox.Show($"The '{NodeName}' column is already present in the list");
                }
                else
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[RowsCount].Cells[0].Value = e.Node.Parent.Text;
                    dataGridView1.Rows[RowsCount].Cells[1].Value = e.Node.Text;
                    ChoosedTables_treeView.Nodes.Add(NodeName);
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[RowsCount].Cells[0].Value = NodeName;
                    dataGridView3.Rows.Add();
                    dataGridView3.Rows[RowsCount].Cells[0].Value = NodeName;
                    dataGridView4.Rows.Clear();
                    dataGridView4.AllowUserToAddRows = false;
                    EnableConditionsForLinkingTables();
                }
            }
            else
            {
                e.Node.Nodes.Clear();

                SqlConnection con = new SqlConnection(conString_label.Text);
                con.Open();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand selectdb = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{e.Node.Text}';", con);
                adapter.SelectCommand = selectdb;
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Tables_treeView.Nodes[e.Node.Index].Nodes.Add((string)table.Rows[i]["COLUMN_NAME"]);
                }

                for (int i = 0; i < e.Node.Nodes.Count; i++)
                {
                    string NodeName = "[" + e.Node.Text + "].[" + e.Node.Nodes[i].Text + "]";
                    bool duplicate = false;
                    int RowsCount = dataGridView1.Rows.Count - 1;
                    for (int j = 0; j < RowsCount; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[0].Value.ToString() == e.Node.Text && dataGridView1.Rows[j].Cells[1].Value.ToString() == e.Node.Nodes[i].Text)
                        {
                            duplicate = true;
                        }
                    }
                    if (duplicate != true)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[RowsCount].Cells[0].Value = e.Node.Text;
                        dataGridView1.Rows[RowsCount].Cells[1].Value = e.Node.Nodes[i].Text;
                        ChoosedTables_treeView.Nodes.Add(NodeName);
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[RowsCount].Cells[0].Value = NodeName;
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[RowsCount].Cells[0].Value = NodeName;
                        dataGridView4.Rows.Clear();
                        dataGridView4.AllowUserToAddRows = false;
                        EnableConditionsForLinkingTables();
                    }
                }
            }

            List<string> tablesList = getTables();
        }

        private bool isDoubleClick = false;

        private void Tables_treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (isDoubleClick && e.Action == TreeViewAction.Collapse)
                e.Cancel = true;
        }

        private void Tables_treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (isDoubleClick && e.Action == TreeViewAction.Expand)
                e.Cancel = true;
        }

        private void Tables_treeView_MouseDown(object sender, MouseEventArgs e)
        {
            isDoubleClick = e.Clicks > 1;
        }

        private void ChoosedTables_treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int nodeIndex = e.Node.Index;
            e.Node.Remove();
            dataGridView1.Rows.RemoveAt(nodeIndex);
            dataGridView2.Rows.RemoveAt(nodeIndex);
            dataGridView3.Rows.RemoveAt(nodeIndex);
            dataGridView4.Rows.Clear();

            List<string> tablesList = getTables();

            if (tablesList.Count == 0)
            {
                DisableConditionsForLinkingTables();
            }
        }

        List<string> getTables()
        {
            List<string> tables = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string currentCell = dataGridView1.Rows[i].Cells[0].Value.ToString();

                if (tables.Contains(currentCell))
                {

                }
                else
                {
                    tables.Add(currentCell);
                }
            }

            return tables;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView2.Rows.Count > 1)
            {
                string conditionCellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int RowIndex = e.RowIndex;
                if (conditionCellValue == "IS NULL" || conditionCellValue == "IS NOT NULL")
                {
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = null;
                    DisableCell(RowIndex);

                }
                else if (conditionCellValue == "BETWEEN")
                {
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = "'value1' and 'value2'";
                    EnableCell(RowIndex);
                }
                else if (conditionCellValue == "LIKE")
                {
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = "%value%";
                    EnableCell(RowIndex);
                }
                else if (conditionCellValue != string.Empty)
                {
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = null;
                    EnableCell(RowIndex);
                }
                else
                {
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = string.Empty;
                    DisableCell(RowIndex);
                }
            }
        }

        private void EnableCell(int RowIndex)
        {
            dataGridView2.Rows[RowIndex].Cells[2].ReadOnly = false;
            dataGridView2.Rows[RowIndex].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void DisableCell(int RowIndex)
        {
            dataGridView2.Rows[RowIndex].Cells[2].ReadOnly = true;
            dataGridView2.Rows[RowIndex].Cells[2].Style.BackColor = Color.FromArgb(225, 225, 225);
        }

        private void AddRow_Button_Click(object sender, EventArgs e)
        {
            List<string> tablesList = getTables();
            List<string> tablesForCell = new List<string>();
            if (tablesList.Count > 1)
            {
                if (dataGridView4.Rows.Count == 0)
                {
                    dataGridView4.Rows.Add();
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView4.Rows[0].Cells[0];
                    cell.Items.Clear();
                    cell.Items.Add(tablesList[0]);
                }
                else
                {
                    try
                    {
                        int cellValueError = 0;
                        for (int i = 0; i < dataGridView4.Rows.Count; i++)
                        {
                            if (dataGridView4.Rows[i].Cells[0].Value != null && dataGridView4.Rows[i].Cells[1].Value != null)
                            {
                                if (!tablesForCell.Contains(dataGridView4.Rows[i].Cells[0].Value.ToString())) 
                                { 
                                    tablesForCell.Add(dataGridView4.Rows[i].Cells[0].Value.ToString());
                                }

                                if (!tablesForCell.Contains(dataGridView4.Rows[i].Cells[1].Value.ToString())) 
                                {
                                    tablesForCell.Add(dataGridView4.Rows[i].Cells[1].Value.ToString());
                                }
                            }
                            else
                            {
                                cellValueError = cellValueError + 1;
                            }
                        }

                        if (cellValueError == 0)
                        {
                            dataGridView4.Rows.Add();
                            DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView4.Rows[dataGridView4.Rows.Count - 1].Cells[0];
                            cell.Items.Clear();

                            for (int i = 0; i < tablesForCell.Count; i++)
                            {
                                cell.Items.Add(tablesForCell[i]);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error \r\n(Check the correctness of the data entered above)");
                    }
                }
            }
            else
            {
                MessageBox.Show("Only 1 table is used in the query");
            }
        }

        private void EnableConditionsForLinkingTables()
        {
            AddRow_Button.Enabled = true;
            DeleteRow_Button.Enabled = true;
            dataGridView4.Enabled = true;
        }

        private void DisableConditionsForLinkingTables()
        {
            AddRow_Button.Enabled = false;
            DeleteRow_Button.Enabled = false;
            dataGridView4.Enabled = false;
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridView4.Rows[0].Cells[0].Value != null)
            {
                List<string> tables2List = getTables();
                for (int i = 0; i < tables2List.Count; i++)
                {
                    if (tables2List[i].Equals(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        tables2List.RemoveAt(i);
                    }
                }

                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView4.Rows[e.RowIndex].Cells[1];
                cell.Items.Clear();

                for (int i = 0; i < tables2List.Count; i++)
                {
                    cell.Items.Add(tables2List[i]);
                }

                DataGridViewComboBoxCell table1Cell = (DataGridViewComboBoxCell)dataGridView4.Rows[e.RowIndex].Cells[3];
                table1Cell.Items.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        table1Cell.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                    }
                }
            }
            else if (e.ColumnIndex == 1 && dataGridView4.Rows[0].Cells[1].Value != null)
            {
                DataGridViewComboBoxCell table2Cell = (DataGridViewComboBoxCell)dataGridView4.Rows[e.RowIndex].Cells[4];
                table2Cell.Items.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        table2Cell.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                    }
                }

                if (e.RowIndex < dataGridView4.Rows.Count - 1)
                {
                    while (dataGridView4.Rows.Count > e.RowIndex + 1)
                    {
                        dataGridView4.Rows.RemoveAt(dataGridView4.Rows.Count - 1);
                    }
                }
            }
        }

        private void GenerateQuery_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Select the fields!");
            }
            else
            {
                int condError = 0;
                int tablesConError = 0;
                int tablesCountConError = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[1].Value != null && dataGridView2.Rows[i].Cells[1].Value.ToString() != "IS NOT NULL" && dataGridView2.Rows[i].Cells[1].Value.ToString() != "IS NULL" && dataGridView2.Rows[i].Cells[2].Value == null)
                    {
                        condError = condError + 1;
                    }
                }

                List<string> tablesList = getTables();

                if (tablesList.Count > 1)
                {
                    if (dataGridView4.Rows.Count == 0)
                    {
                        tablesConError = tablesConError + 1;
                    }
                    else if (dataGridView4.Rows[0].Cells[0].Value != null)
                    {
                        for (int i = 0; i < dataGridView4.Rows.Count; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (dataGridView4.Rows[i].Cells[j].Value == null)
                                {
                                    tablesConError = tablesConError + 1;
                                }
                            }
                        }

                        List<string> tablesForCheck = new List<string>();

                        for (int i = 0; i < dataGridView4.Rows.Count; i++)
                        {
                            tablesForCheck.Add(dataGridView4.Rows[i].Cells[0].Value.ToString());
                            tablesForCheck.Add(dataGridView4.Rows[i].Cells[1].Value.ToString());
                        }

                        string[] tablesForCheckDistinct = tablesForCheck.Distinct().ToArray();

                        if (tablesForCheckDistinct.Length != tablesList.Count)
                        {
                            tablesCountConError = tablesCountConError + 1;
                        }
                    }
                    else
                    {
                        tablesConError = tablesConError + 1;
                    }
                }

                if (condError != 0)
                {
                    MessageBox.Show("Enter all fields on the \"Constraints\" page");
                }
                else if (tablesConError != 0)
                {
                    MessageBox.Show("Enter all fields on the \"Conditions for linking tables\" page");
                }
                else if (tablesCountConError != 0)
                {
                    MessageBox.Show("Specify the joins between all the tables used!");
                }
                else
                {
                    string selectString = string.Empty;

                    for (int i = 0; i < ChoosedTables_treeView.Nodes.Count; i++)
                    {
                        selectString = selectString + ChoosedTables_treeView.Nodes[i].Text;

                        if (dataGridView3.Rows[i].Cells[1].Value != null)
                        {
                            selectString = selectString + " AS '" + dataGridView3.Rows[i].Cells[1].Value.ToString() + "'";
                        }
                        selectString = selectString + ", ";
                    }

                    int stringLenght = selectString.Length - 2;
                    selectString = "SELECT " + selectString.Remove(stringLenght, 2); // Часть "SELECT"

                    string fromString = " FROM " + tablesList[0]; // Часть "FROM"

                    string joinString = string.Empty;

                    for (int i = 0; i < dataGridView4.Rows.Count; i++)
                    {
                        joinString = joinString + " " + dataGridView4.Rows[i].Cells[2].Value.ToString() + " " + dataGridView4.Rows[i].Cells[1].Value.ToString() + " ON " + dataGridView4.Rows[i].Cells[1].Value.ToString() + "." + dataGridView4.Rows[i].Cells[4].Value.ToString() + " = " + dataGridView4.Rows[i].Cells[0].Value.ToString() + "." + dataGridView4.Rows[i].Cells[3].Value.ToString();
                        // Часть "JOIN"
                    }

                    string whereString = string.Empty;

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[1].Value != null)
                        {
                            if (whereString == string.Empty)
                            {
                                whereString = " WHERE " + dataGridView2.Rows[i].Cells[0].Value.ToString() + " " + dataGridView2.Rows[i].Cells[1].Value.ToString();// + " " + dataGridView2.Rows[i].Cells[2].Value.ToString();

                                if (dataGridView2.Rows[i].Cells[2].Value != null)
                                {
                                    whereString = whereString + " " + dataGridView2.Rows[i].Cells[2].Value.ToString();
                                }

                                whereString = whereString.TrimEnd(' '); // Часть WHERE
                            }
                            else
                            {
                                whereString = whereString + " AND WHERE " + dataGridView2.Rows[i].Cells[0].Value.ToString() + " " + dataGridView2.Rows[i].Cells[1].Value.ToString();// + " " + dataGridView2.Rows[i].Cells[2].Value.ToString();

                                if (dataGridView2.Rows[i].Cells[2].Value != null)
                                {
                                    whereString = whereString + " " + dataGridView2.Rows[i].Cells[2].Value.ToString();
                                }

                                whereString = whereString.TrimEnd(' '); // Часть WHERE
                            }
                        }
                    }

                    string queryString = selectString + fromString + joinString + whereString;
                    MessageBox.Show(queryString);
                }
            }
        }

        private void DeleteRow_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView4.SelectedRows)
                {
                    dataGridView4.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Select a row!");
            }
        }

        private void QueryConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var editingControl = this.dataGridView2.EditingControl as DataGridViewComboBoxEditingControl;
            if (editingControl != null)
                editingControl.DroppedDown = true;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var editingControl = this.dataGridView4.EditingControl as DataGridViewComboBoxEditingControl;
            if (editingControl != null)
                editingControl.DroppedDown = true;
        }
    }
}
