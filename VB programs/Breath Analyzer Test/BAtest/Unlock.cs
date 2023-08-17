using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BAtest
{
    public partial class Unlock : Form
    {

        public Unlock()
        {
            InitializeComponent();
        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "AIASL (AI Airport Service Limited)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, Name, Designation, Mobile  from AIASL", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
                Style1();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "ATC (Air Traffic Control)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, EmpNo, Name, Designation, Mobile from ATC", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
                Style2();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "BPCL (Bharat Petroleum Corporation Limited)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, Name, Designation, Mobile from BPCL", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
                Style1();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "CISF (Central Industrial Security Force) Driver";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, Name, Designation, Mobile from CISF", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
                Style1();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "CNS (Communication Navigation and Suveillance) & IT (Information Technology)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, EmpNo, Name, Designation, Mobile from CNSIT", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
                Style2();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "FIRE AFS(Air Freight Station) & GUJSAIL(Gujarat State Aviation Infrastucture Company Ltd.)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, Name, Designation, Mobile from FIREGUJSAIL", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
                Style1();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                label5.Text = "MT (Motor Transport)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, Name, Designation, Mobile from MT", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
                Style1();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                label4.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
            }
            catch (Exception e1)
            {
                string message = "Please select any Department first.";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }

        private void Style1()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            DataGridViewColumn SN = dataGridView1.Columns[0];
            SN.Width = 40;
            DataGridViewColumn Name = dataGridView1.Columns[1];
            Name.Width = 200;
            DataGridViewColumn Designation = dataGridView1.Columns[2];
            Designation.Width = 180;
            DataGridViewColumn Mobile = dataGridView1.Columns[3];
            Mobile.Width = 140;
        }
        private void Style2()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            DataGridViewColumn SN = dataGridView1.Columns[0];
            SN.Width = 40;
            DataGridViewColumn EmpNo = dataGridView1.Columns[1];
            EmpNo.Width = 140;
            DataGridViewColumn Name = dataGridView1.Columns[2];
            Name.Width = 200;
            DataGridViewColumn Designation = dataGridView1.Columns[3];
            Designation.Width = 160;
            DataGridViewColumn Mobile = dataGridView1.Columns[4];
            Mobile.Width = 140;
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.DefaultPageSettings.Landscape = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, 0, 0);
        }
        Bitmap memorying;
        private void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataEntry de = new DataEntry();
            de.Show();
        }
    }
}
