using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryConstructor
{
    public partial class QueryString : Form
    {
        public QueryString()
        {
            InitializeComponent();
        }

        private void copy_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(query_TextBox.Text);
        }
    }
}
