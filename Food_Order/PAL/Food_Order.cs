using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Food_Order.BAL;

namespace Food_Order
{
    public partial class Form1 : Form
    {
        
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            rdDinner.Checked = true;
        }

        public void food_order()
        {
            _food obj = new food();
            
            dt = new DataTable();
            DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
            dt = obj.food_Order(date);
            //-------------------------------------------------------------------------------------------------------------------
            //--------------------------------------Columns added in the gridview------------------------------------------------

            dGV1.Columns[0].Name = "Column1";
            dGV1.Columns[0].HeaderText = "EmployeeName";
            dGV1.Columns[0].DataPropertyName = "EmployeeName";

            dGV1.Columns[1].Name = "Column2";
            dGV1.Columns[1].HeaderText = "EmployeeCode";
            dGV1.Columns[1].DataPropertyName = "EmployeeCode";

            dGV1.Columns[2].Name = "Column3";
            dGV1.Columns[2].HeaderText = "Project";
            dGV1.Columns[2].DataPropertyName = "Project";

            dGV1.Columns[3].Name = "Column4";
            dGV1.Columns[3].HeaderText = "Department";
            dGV1.Columns[3].DataPropertyName = "Department";

            dGV1.Columns[4].Name = "Column5";
            dGV1.Columns[4].HeaderText = "Todays_InTime";
            dGV1.Columns[4].DataPropertyName = "Todays_InTime";

            dGV1.Columns[5].Name = "Column6";
            dGV1.Columns[5].HeaderText = "OrderTime";
            dGV1.Columns[5].DataPropertyName = "OrderTime";

            dGV1.Columns[6].Name = "Column7";
            dGV1.Columns[6].HeaderText = "Food_Requested";
            dGV1.Columns[6].DataPropertyName = "Food_Requested";

            dGV1.Columns[7].Name = "Column8";
            dGV1.Columns[7].HeaderText = "FlNight";
            dGV1.Columns[7].DataPropertyName = "FlNight";

            dGV1.Columns[8].Name = "Column9";
            dGV1.Columns[8].HeaderText = "Ramadan";
            dGV1.Columns[8].DataPropertyName = "Ramadan";

            dGV1.Columns[9].Name = "Column10";
            dGV1.Columns[9].HeaderText = "EmpID";
            dGV1.Columns[9].DataPropertyName = "EmpID";

            //-------------------------------------------------------------------------------------------------------------------
            dGV1.Rows.Clear();

            //---------------------------------------------------Rows addition according to RadioBtn Checks----------------------


            foreach (DataRow Dr in dt.Rows)
            {
                if (rdDinner.Checked)
                {
                    if (Dr["Food_Requested"].ToString() != "" && Dr["Food_Requested"].ToString() != null)
                    {

                        dGV1.Rows.Add(Dr["EmployeeName"].ToString(), Dr["EmployeeCode"].ToString(), Dr["Project"].ToString(), Dr["Department"].ToString(), Dr["Todays_InTime"].ToString(), Dr["OrderTime"].ToString(), Dr["Food_Requested"].ToString(), Dr["FlNight"].ToString(), Dr["Ramadan"].ToString(), Dr["EmpID"].ToString(), false);
                        
                    }
                }
                else if (rdLunch.Checked)
                {
                    if (Dr["FlNight"].ToString() == "True")
                    {

                        dGV1.Rows.Add(Dr["EmployeeName"].ToString(), Dr["EmployeeCode"].ToString(), Dr["Project"].ToString(), Dr["Department"].ToString(), Dr["Todays_InTime"].ToString(), Dr["OrderTime"].ToString(), Dr["Food_Requested"].ToString(), Dr["FlNight"].ToString(), Dr["Ramadan"].ToString(), Dr["EmpID"].ToString(), false);
                    }

                }
                else
                    if (rdIftar.Checked)
                    {
                        if (Dr["Ramadan"].ToString() == "1" || Dr["Ramadan"].ToString() == "3")
                        {

                            dGV1.Rows.Add(Dr["EmployeeName"].ToString(), Dr["EmployeeCode"].ToString(), Dr["Project"].ToString(), Dr["Department"].ToString(), Dr["Todays_InTime"].ToString(), Dr["OrderTime"].ToString(), Dr["Food_Requested"].ToString(), Dr["FlNight"].ToString(), Dr["Ramadan"].ToString(), Dr["EmpID"].ToString(), false);
                        }
                    }
                    else
                        if (rdSehri.Checked)
                        {
                            if (Dr["Ramadan"].ToString() == "2" || Dr["Ramadan"].ToString() == "3")
                            {

                                dGV1.Rows.Add(Dr["EmployeeName"].ToString(), Dr["EmployeeCode"].ToString(), Dr["Project"].ToString(), Dr["Department"].ToString(), Dr["Todays_InTime"].ToString(), Dr["OrderTime"].ToString(), Dr["Food_Requested"].ToString(), Dr["FlNight"].ToString(), Dr["Ramadan"].ToString(), Dr["EmpID"].ToString(), false);
                            }
                        }

                //------------------------------------------------------------------------------------------------------------------------------------------------

            }
            
           // dGV1.DataSource = dt;
            dGV1.Refresh();
        }
           

        private void btnEnter_Click(object sender, EventArgs e)
        {
            food_order();
            groupBox1.Visible = true;
            //------------Hiding last 2 columns---------
            dGV1.Columns[7].Visible = false;
            dGV1.Columns[8].Visible = false;
            dGV1.Columns[9].Visible = false;
        }
        //-------------------------------------------------------Excel Work-----------------------------------------------
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd_") + "Employee_" + getOrderType().ToUpper() +  "_Order_List.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ToCsV(dGV1,  sfd.FileName);
            }  
        }

        private void ToCsV(DataGridView dGV1, string filename)
        {
            try
            {
                String which_order = getOrderType().ToUpperInvariant();
                //string n = string.Format("text-{0:yyyy-MM-dd_hh-mm-ss-tt}",DateTime.Now);
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV1.Columns.Count-3; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV1.Columns[j].HeaderText) + ", ";
                stOutput += sHeaders + " \n";
                // Export data.
                for (int i = 0; i < dGV1.RowCount - 1; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV1.Rows[i].Cells.Count-3; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV1.Rows[i].Cells[j].Value) + ", ";
                    stOutput += stLine + " \n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                // byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                StreamWriter st = new StreamWriter(fs);
                //BinaryWriter bw = new BinaryWriter(fs);
                st.Write("-------------------------ICE ANIMATIONS----------------------------- \n");
                st.Write(which_order + " order \n");
                st.Write("Date: " + DateTime.Now.ToString("yyyy-MM-dd") + "\n");
                st.Write("Time: " + DateTime.Now.ToString("hh:mm:ss") + "\n\n");
                st.Write(stOutput, 0, stOutput.Length); //write the encoded file
                st.Flush();
                st.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private String getOrderType()
        {
            String which_order = "";

            if (rdDinner.Checked == true) which_order = "dinner";
            else if (rdIftar.Checked == true) which_order = "iftar";
            else if (rdLunch.Checked == true) which_order = "lunch";
            else if (rdSehri.Checked == true) which_order = "sehri";

            return which_order;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _food obj = new food();

            String which_order = getOrderType();
            
            //obj.Delete(label2.Text, Convert.ToDateTime(dateTimePicker1.Text), label3.Text);
            foreach (DataGridViewRow oneRow in dGV1.SelectedRows)
            {
                obj.Delete(Convert.ToInt32( oneRow.Cells[9].Value), Convert.ToDateTime(dateTimePicker1.Text), which_order);
                dGV1.Rows.RemoveAt(oneRow.Index);
            }
            
        }

        private void dGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
