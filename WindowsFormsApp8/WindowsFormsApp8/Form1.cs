using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Contracts]";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Александр\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Database3.mdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Contracts]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void database3DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                       this.contractsTableAdapter.Fill(this.database3DataSet.Contracts);
        }
    }
}
