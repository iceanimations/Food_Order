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
            food_order();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void food_order() 
        {
            _food obj = new food();
            dt = new DataTable();
            //dt = obj.food_Order(convert.datetime(datetimepicker1.text));
            dt = obj.food_Order(Convert.ToDateTime(dateTimePicker1.Text));

            dGV1.DataSource = dt;

            
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            food_order();
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Employee_List.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ToCsV(dGV1, sfd.FileName);
            }  
        }

        private void ToCsV(DataGridView dGV1, string filename)
        {
            try
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV1.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV1.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV1.RowCount - 1; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV1.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV1.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
