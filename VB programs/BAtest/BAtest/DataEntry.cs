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

namespace BAtest
{
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kavi\College\Programs\VB programs\Breath Analyzer Test\BAtest\All Dept.accdb");

        int num;
        Boolean flag;
        string[] deptnames = { "AIASL", "ATC", "BPCL", "CISF", "CNSIT", "FIREGUJSAIL", "MT" };

        private void Oledb()
        {
            if (flag == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile  from " + deptnames[num] + "", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                DataGridViewColumn ID = dataGridView1.Columns[0];
                DataGridViewColumn SN = dataGridView1.Columns[1];
                DataGridViewColumn Name = dataGridView1.Columns[2];
                DataGridViewColumn Designation = dataGridView1.Columns[3];
                DataGridViewColumn Mobile = dataGridView1.Columns[4];
                ID.Width = 40;
                SN.Width = 40;
                Name.Width = 230;
                Designation.Width = 180;
                Mobile.Width = 140;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select ID, SN, EmpNo, Name, Designation, Mobile from " + deptnames[num] + "", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                con.Close();
                dataGridView1.DataSource = dt;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 11, FontStyle.Bold);
                DataGridViewColumn ID = dataGridView1.Columns[0];
                DataGridViewColumn SN = dataGridView1.Columns[1];
                DataGridViewColumn EmpNo = dataGridView1.Columns[2];
                DataGridViewColumn Name = dataGridView1.Columns[3];
                DataGridViewColumn Designation = dataGridView1.Columns[4];
                DataGridViewColumn Mobile = dataGridView1.Columns[5];
                ID.Width = 40;
                SN.Width = 40;
                EmpNo.Width = 80;
                Name.Width = 230;
                Designation.Width = 180;
                Mobile.Width = 140;
            }
        }
        private void AIASLdataGrid()
        {
            num = 0;
            flag = true;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
        }
        private void ATCdataGrid()
        {
            num = 1;
            flag = false;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
        }
        private void BPCLdataGrid()
        {
            num = 2;
            flag = true;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
        }
        private void CISFdataGrid()
        {
            num = 3;
            flag = true;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
        }
        private void CNSITdataGrid()
        {
            num = 4;
            flag = false;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
        }
        private void FIREGUJSAILdataGrid()
        {
            num = 5;
            flag = true;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
        }
        private void MTdataGrid()
        {
            num = 6;
            flag = true;
            Oledb();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
        }

        private void Deletedb()
        {
            String deleteData = "DELETE FROM " + deptnames[num] +" WHERE ID = ?";
            con.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(deleteData, con);
            cmd.Parameters.AddWithValue("ID", OleDbType.VarChar).Value = Convert.ToInt16(textBox4.Text);
            int dataInserted = cmd.ExecuteNonQuery();
            if (dataInserted > 0)
            {
                MessageBox.Show("Data Deleted from Access File.");
                clearInputFields();
            }
            con.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (num == 0)
                {
                    Deletedb();
                    AIASLdataGrid();
                }
                else if (num == 1)
                {
                    Deletedb();
                    ATCdataGrid();
                }
                else if (num == 2)
                {
                    Deletedb();
                    BPCLdataGrid();
                }
                else if (num == 3)
                {
                    Deletedb();
                    CISFdataGrid();
                }
                else if (num == 4)
                {
                    Deletedb();
                    CNSITdataGrid();
                }
                else if (num == 5)
                {
                    Deletedb();
                    FIREGUJSAILdataGrid();
                }
                else if (num == 6)
                {
                    Deletedb();
                    MTdataGrid();
                }
                else
                {
                    MessageBox.Show("Else Condition is Excecuted.");
                }
            }
            catch (Exception e1)
            {
                con.Close();
                MessageBox.Show(e1.Message);
            }
        }

        private void clearInputFields()
        {
            try
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Updatedb()
        {
            if (flag == true)
            {
                String insertdata = "UPDATE " + deptnames[num] + " SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand(insertdata, con);
                cmd.Parameters.AddWithValue("SN", OleDbType.Numeric).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.AddWithValue("Designation", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("Mobile", OleDbType.Numeric).Value = textBox3.Text;
                cmd.Parameters.AddWithValue("ID", Convert.ToInt32(textBox4.Text));
                int dataInserted = cmd.ExecuteNonQuery();
                if (dataInserted > 0)
                {
                    MessageBox.Show("Data Updated to Access File.");
                }
                con.Close();
            }
            else
            {
                String insertdata = "UPDATE " + deptnames[num] + " SET SN=@SN, EmpNo=@EmpNo, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand(insertdata, con);
                cmd.Parameters.AddWithValue("SN", OleDbType.Numeric).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("EmpNo", OleDbType.Numeric).Value = textBox6.Text;
                cmd.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.AddWithValue("Designation", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("Mobile", OleDbType.Numeric).Value = textBox3.Text;
                cmd.Parameters.AddWithValue("ID", Convert.ToInt32(textBox4.Text));
                int dataInserted = cmd.ExecuteNonQuery();
                if (dataInserted > 0)
                {
                    MessageBox.Show("Data Updated to Access File.");
                }
                con.Close();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (num == 0)
                {
                    flag = true;
                    Updatedb();
                    AIASLdataGrid();
                }
                else if (num == 1)
                {
                    flag = false;
                    Updatedb();
                    ATCdataGrid();
                }
                else if (num == 2)
                {
                    flag = true;
                    Updatedb();
                    BPCLdataGrid();
                }
                else if (num == 3)
                {
                    flag = true;
                    Updatedb();
                    CISFdataGrid();
                }
                else if (num == 4)
                {
                    flag = false;
                    Updatedb();
                    CNSITdataGrid();
                }
                else if (num == 5)
                {
                    flag = true;
                    Updatedb();
                    FIREGUJSAILdataGrid();
                }
                else if (num == 6)
                {
                    flag = true;
                    Updatedb();
                    MTdataGrid();
                }
                else
                {
                    MessageBox.Show("Else Condition is Excecuted.");
                }
            }
            catch (Exception e1)
            {
                con.Close();
                MessageBox.Show(e1.Message);
            }
        }
        private void Insertdb()
        {
            if (flag == true)
            {
                String insertdata = "INSERT INTO " + deptnames[num] + " (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand(insertdata, con);
                cmd.Parameters.AddWithValue("SN", OleDbType.Numeric).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.AddWithValue("Designation", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("Mobile", OleDbType.Numeric).Value = textBox3.Text;
                int dataInserted = cmd.ExecuteNonQuery();
                if (dataInserted > 0)
                {
                    MessageBox.Show("Data Inserted to Access File.");
                }
                con.Close();
            }
            else
            {
                String insertdata = "INSERT INTO " + deptnames[num] +" (SN, EmpNo, Name, Designation, Mobile) values (?, ?, ?, ?, ?)";
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand(insertdata, con);
                cmd.Parameters.AddWithValue("SN", OleDbType.Numeric).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("EmpNo", OleDbType.Numeric).Value = textBox6.Text;
                cmd.Parameters.AddWithValue("Name", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.AddWithValue("Designation", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("Mobile", OleDbType.Numeric).Value = textBox3.Text;
                int dataInserted = cmd.ExecuteNonQuery();
                if (dataInserted > 0)
                {
                    MessageBox.Show("Data Inserted to Access File.");
                }
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (num == 0)
                {
                    flag = true;
                    Insertdb();
                    AIASLdataGrid();
                }
                else if (num == 1)
                {
                    flag = false;
                    Insertdb();
                    ATCdataGrid();
                }
                else if (num == 2)
                {
                    flag = true;
                    Insertdb();
                    BPCLdataGrid();
                }
                else if (num == 3)
                {
                    flag = true;
                    Insertdb();
                    CISFdataGrid();
                }
                else if (num == 4)
                {
                    flag = false;
                    Insertdb();
                    CNSITdataGrid();
                }
                else if (num == 5)
                {
                    flag = true;
                    Insertdb();
                    FIREGUJSAILdataGrid();
                }
                else if (num == 6)
                {
                    flag = true;
                    Insertdb();
                    MTdataGrid();
                }
                else
                {
                    MessageBox.Show("Else Condition is Excecuted.");
                }
            }
            catch (Exception e1)
            {
                con.Close();
                MessageBox.Show(e1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AIASLdataGrid();
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
                ATCdataGrid();
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
                BPCLdataGrid();
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
                CISFdataGrid();
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
                CNSITdataGrid();
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
                FIREGUJSAILdataGrid();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                MTdataGrid();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Display()
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (num == 0)
            {
                Display();
                textBox6.Text = "";
            }
            if (num == 1)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (num == 2)
            {
                Display();
                textBox6.Text = "";
            }
            if (num == 3)
            {
                Display();
                textBox6.Text = "";
            }
            if (num == 4)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (num == 5)
            {
                Display();
                textBox6.Text = "";
            }
            if (num == 6)
            {
                Display();
                textBox6.Text = "";
            }
        }
    }
}
