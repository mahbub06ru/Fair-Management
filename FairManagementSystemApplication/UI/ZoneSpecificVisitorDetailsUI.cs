using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.Model;
using FairManagementSystemApplication.BLL;

namespace FairManagementSystemApplication.UI
{
    public partial class ZoneSpecificVisitorDetailsUI : Form
    {
        public ZoneSpecificVisitorDetailsUI()
        {
            InitializeComponent();
            LoadZoneType();
        }
        ZoneManager zoneManager = new ZoneManager();
        VisitorZoneInformationViewManager visitorZoneInformationViewManager = new VisitorZoneInformationViewManager();
        private void LoadZoneType()
        {
            List<Zone> zoneList = zoneManager.GetAllZoneTypeList();
            zoneComboBox.DataSource = null;
            zoneComboBox.DataSource = zoneList;
            zoneComboBox.ValueMember = "id";
            zoneComboBox.DisplayMember = "Zone_Name";
        }


        private void showButton_Click_1(object sender, EventArgs e)
        {
            zoneSpecificVisitorDetailsListView.Items.Clear();
            zoneSpecificTotalVisitorTextBox.Clear();
            int zoneId = int.Parse(zoneComboBox.SelectedValue.ToString());
            List<VisitorZoneInformationView> visitorZoneInformationViewList = visitorZoneInformationViewManager.GetVisitorZoneByZoneId(zoneId);
            int total = 0;
            foreach (var index in visitorZoneInformationViewList)
            {
                ListViewItem listViewItem = new ListViewItem(index.VisitorName);
                listViewItem.SubItems.Add(index.VisitorEmail);
                listViewItem.SubItems.Add(index.VisitorContactNumber);
                zoneSpecificVisitorDetailsListView.Items.Add(listViewItem);
                total++;
            }
            zoneSpecificTotalVisitorTextBox.Text = total.ToString();

        }

        private void ZoneSpecificVisitorDetailsUI_Load(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            int row = 0;
            int col = 0;
            int row2 = 0;
            int col2 = 0;
            int ch = 0;
            int ctr = 0;

            ctr = 0;
            row2 = 1;
            col2 = 3;

            row = 3;
            col = 3;

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.Application.Workbooks.Add(Type.Missing);
            oExcel.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook oBook =
                oExcel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet oSheet =
                (Microsoft.Office.Interop.Excel.Worksheet)oExcel.ActiveSheet;


            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Excel File|*.xlsx|Word File|*.doc|Text File|*.txt";
            SaveFileDialog1.Title = "Save As";

            if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (SaveFileDialog1.FilterIndex)
                {
                    case 1:
                        {
                            for (ch = 1; ch <= zoneSpecificVisitorDetailsListView.Columns.Count; ch++)
                            {
                                oSheet.Cells[row2, col2] = zoneSpecificVisitorDetailsListView.Columns[ctr].Text;

                                col2 = col2 + 1;
                                ctr = ctr + 1;
                            }

                            foreach (ListViewItem lview in zoneSpecificVisitorDetailsListView.Items)
                            {
                                foreach (ListViewItem.ListViewSubItem lview2 in lview.SubItems)
                                {
                                    oSheet.Cells[row, col] = lview2.Text;
                                    col = col + 1;
                                }

                                col = 3;
                                row = row + 1;
                            }

                            oBook.SaveAs(SaveFileDialog1.InitialDirectory.ToString() + SaveFileDialog1.FileName);
                            oExcel.Quit();
                            SaveFileDialog1.Dispose();
                            MessageBox.Show("Data has been successfully saved", string.Empty, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            break;
                        }
                }

            }
        }
    }
}
