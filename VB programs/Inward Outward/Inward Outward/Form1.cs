using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inward_Outward
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Inward(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kavi\College\Programs\VB programs\Inward Outward\Inward Outward.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Inward", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        }

        private void Outward(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kavi\College\Programs\VB programs\Inward Outward\Inward Outward.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from table1", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        }

        private void Post(object sender, EventArgs e)
        {

        }
    }
}
