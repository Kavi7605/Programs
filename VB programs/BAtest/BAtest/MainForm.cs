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

namespace BAtest{
    public partial class MainForm : Form{

        public MainForm(){
            InitializeComponent();
        }

        DateTime lastClickTime;
        string[] depts = new string[7];
        int i;
        Boolean flag;
        string Fire1, Fire2, Fire3;
        string[] deptnames = { "AIASL", "ATC", "BPCL", "CISF", "CNSIT", "FIREGUJSAIL", "MT" };

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kavi\College\Programs\VB programs\Breath Analyzer Test\BAtest\All Dept.accdb");

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
        private void oledb()
        {
            int j = 0; 
            if (flag == true)
            {
                label8.Text = "";
                label9.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT SN, Name, Designation, Mobile, PA from " + deptnames[i] + "", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                if (depts[i] != null && !depts[i].Equals(""))
                    button8.Enabled = false;
                else
                    button8.Enabled = true;
                label4.Text = depts[i];
            }
            else
            {
                label8.Text = "";
                label9.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select SN, EmpNo, Name, Designation, Mobile from " + deptnames[i] +"", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                if (depts[i] != null && !depts[i].Equals(""))
                    button8.Enabled = false;
                else
                    button8.Enabled = true;
                label4.Text = depts[i];
            }
        }
        private void AIASL(object sender, EventArgs e){
            try{
                i = 0;
                flag = true;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
                Style1();
                label5.Text = "AIASL (AI Airport Service Limited)";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void ATC(object sender, EventArgs e){
            try
            {
                i = 1;
                flag = false;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
                Style2();
                label5.Text = "ATC (Air Traffic Control)";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void BPCL(object sender, EventArgs e){
            try { 
                i = 2;
                flag = true;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
                Style1();
                label5.Text = "BPCL (Bharat Petroleum Corporation Limited)";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void CISF(object sender, EventArgs e){
            try
            {
                i = 3;
                flag = true;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
                Style1();
                label5.Text = "CISF (Central Industrial Security Force) Driver";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void CNSIT(object sender, EventArgs e){
            try
            {
                i = 4;
                flag = false;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
                Style2();
                label5.Text = "CNS (Communication Navigation and Suveillance) & IT (Information Technology)";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }

        }
        private void FIREGUJSAIL(object sender, EventArgs e){
            try
            {
                i = 5;
                flag = true;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
                Style1();
                label5.Text = "FIRE AFS(Air Freight Station) & GUJSAIL(Gujarat State Aviation Infrastucture Company Ltd.)";

                if (Fire1 != null && !Fire1.Equals("") && Fire1 != null && !Fire2.Equals("") && Fire3 != null && !Fire3.Equals(""))
                    button8.Enabled = false;
                else
                    button8.Enabled = true;

                label4.Text = Fire1;
                label8.Text = Fire2;
                label9.Text = Fire3;
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void MT(object sender, EventArgs e){
            try
            {
                i = 6;
                flag = true;
                oledb();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
                Style1();
                label5.Text = "MT (Motor Transport)";
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }

        private void Generate(object sender, EventArgs e){
            try{
                lastClickTime = DateTime.Now;
                UpdateButtonState();

                Random rand = new Random();
                label4.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                depts[i] = label4.Text;
                if (i == 5){
                    label4.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                    label8.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                    while(label4.Text == label8.Text){
                        label8.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                    }
                    label9.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                    while (label4.Text == label9.Text || label8.Text == label9.Text){
                        label9.Text = (string)dataGridView1.Rows[rand.Next(0, dataGridView1.Rows.Count - 1)].Cells["Name"].Value;
                    }
                    Fire1 = label4.Text;
                    Fire2 = label8.Text;
                    Fire3 = label9.Text;
                }

                String insertdata = "INSERT INTO DATETIME (datetime) values (@value)";
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand(insertdata, con);
                cmd.Parameters.AddWithValue("@value", DateTime.Now);
                int dataInserted = cmd.ExecuteNonQuery();
                if (dataInserted > 0)
                {
                    MessageBox.Show("Data Inserted to Access File.");
                }
                con.Close();


                button8.Enabled = false;
            }
            catch (Exception e1){
                MessageBox.Show(e1.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (lastClickTime < DateTime.Today)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
                // Calculate and display remaining time
                TimeSpan remainingTime = TimeSpan.FromDays(1) - (DateTime.Now - lastClickTime);
                label10.Text = $"Button will be enabled in {remainingTime.Hours} hours and {remainingTime.Minutes} minutes and {remainingTime.Seconds} seconds.";
            }
        }
        private void Refresh_btn(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void Print(Panel pnl){
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.DefaultPageSettings.Landscape = true;
            if (printDialog1.ShowDialog() == DialogResult.OK){
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e){
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, 0, 0);
        }
        Bitmap memorying;
        private void getprintarea(Panel pnl){
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void Print_btn(object sender, EventArgs e){
            Print(this.panel1);
        }
        private void Edit_btn(object sender, EventArgs e){
            DataEntry de = new DataEntry();
            de.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
