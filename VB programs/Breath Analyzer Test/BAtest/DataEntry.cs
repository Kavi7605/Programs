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

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");

        int dept;
        String AIASL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = F:\BA\All Dept.accdb";

        private void AIASLdataGrid()
        {
            dept = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile  from AIASL", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.PeachPuff;
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
        private void ATCdataGrid()
        {
            dept = 1;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, EmpNo, Name, Designation, Mobile  from ATC", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
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
        private void BPCLdataGrid()
        {
            dept = 2;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile from BPCL", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
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
        private void CISFdataGrid()
        {
            dept = 3;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile from CISF", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
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
        private void CNSITdataGrid()
        {
            dept = 4;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, EmpNo, Name, Designation, Mobile from CNSIT", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
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
        private void FIREGUJSAILdataGrid()
        {
            dept = 5;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile from FIREGUJSAIL", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
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
        private void MTdataGrid()
        {
            dept = 6;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\BA\All Dept.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, SN, Name, Designation, Mobile from MT", con);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (dept == 0)
                {
                    String deleteData = "DELETE FROM AIASL WHERE ID = ?";
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
                    AIASLdataGrid();
                    con.Close();
                }
                else if (dept == 1)
                {
                    String deleteData = "DELETE FROM ATC WHERE ID = ?";
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
                    ATCdataGrid();
                    con.Close();
                }
                else if (dept == 2)
                {
                    String deleteData = "DELETE FROM BPCL WHERE ID = ?";
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
                    BPCLdataGrid();
                    con.Close();
                }
                else if (dept == 3)
                {
                    String deleteData = "DELETE FROM CISF WHERE ID = ?";
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
                    CISFdataGrid(); 
                    con.Close();
                }
                else if (dept == 4)
                {
                    String deleteData = "DELETE FROM CNSIT WHERE ID = ?";
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
                    CNSITdataGrid();
                    con.Close();
                }
                else if (dept == 5)
                {
                    String deleteData = "DELETE FROM FIREGUJSAIL WHERE ID = ?";
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
                    FIREGUJSAILdataGrid();
                    con.Close();
                }
                else if (dept == 6)
                {
                    String deleteData = "DELETE FROM MT WHERE ID = ?";
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
                    MTdataGrid();
                    con.Close();
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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (dept == 0)
                {
                    String insertdata = "UPDATE AIASL SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    AIASLdataGrid();
                    con.Close();
                }
                else if (dept == 1)
                {
                    String insertdata = "UPDATE ATC SET SN=@SN, EmpNo=@EmpNo, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    ATCdataGrid();
                    con.Close();
                }
                else if (dept == 2)
                {
                    String insertdata = "UPDATE BPCL SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    BPCLdataGrid();
                    con.Close();
                }
                else if (dept == 3)
                {
                    String insertdata = "UPDATE CISF SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    CISFdataGrid();
                    con.Close();
                }
                else if (dept == 4)
                {
                    String insertdata = "UPDATE CNSIT SET SN=@SN, EmpNo=@EmpNo, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    CNSITdataGrid();
                    con.Close();
                }
                else if (dept == 5)
                {
                    String insertdata = "UPDATE FIREGUJSAIL SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    FIREGUJSAILdataGrid();
                    con.Close();
                }
                else if (dept == 6)
                {
                    String insertdata = "UPDATE MT SET SN=@SN, Name=@Name, Designation=@Designation, Mobile=@Mobile WHERE ID=@ID";
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
                    MTdataGrid();
                    con.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dept == 0)
                {
                    String insertdata = "INSERT INTO AIASL (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
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
                    AIASLdataGrid();
                    con.Close();
                }
                else if (dept == 1)
                {
                    String insertdata = "INSERT INTO ATC (SN, EmpNo, Name, Designation, Mobile) values (?, ?, ?, ?, ?)";
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
                    ATCdataGrid();
                    con.Close();
                }
                else if (dept == 2)
                {
                    String insertdata = "INSERT INTO BPCL (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
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
                    BPCLdataGrid();
                    con.Close();
                }
                else if (dept == 3)
                {
                    String insertdata = "INSERT INTO CISF (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
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
                    CISFdataGrid();
                    con.Close();
                }
                else if (dept == 4)
                {
                    String insertdata = "INSERT INTO CNSIT (SN, EmpNo, Name, Designation, Mobile) values (?, ?, ?, ?, ?)";
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
                    CNSITdataGrid();
                    con.Close();
                }
                else if (dept == 5)
                {
                    String insertdata = "INSERT INTO FIREGUJSAIL (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
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
                    FIREGUJSAILdataGrid();
                    con.Close();
                }
                else if (dept == 6)
                {
                    String insertdata = "INSERT INTO MT (SN, Name, Designation, Mobile) values (?, ?, ?, ?)";
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
                    MTdataGrid();
                    con.Close();
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dept == 0)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = "";
            }
            if (dept == 1)
            {

                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (dept == 2)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = "";
            }
            if (dept == 3)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = "";
            }
            if (dept == 4)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (dept == 5)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = "";
            }
            if (dept == 6)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = "";
            }
        }
    }
}
