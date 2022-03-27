using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace maut_method_project
{
    public partial class Form1 : Form
    {
        string file;
        DataGridView dataTable;

        public Form1()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AllowDrop = true;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            file = string.Empty;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            file = files[0];
            DragFile();
        }

        private void DragFile()
        {
            string[] extensions = { ".xls", ".xlt", ".xlsx", ".xlsm", ".xltx", ".xltm" };
            for (int i = 0; i < extensions.Length; i++)
            {
                if(file.EndsWith(extensions[i]))
                {
                    UploadFile(file);
                    break;
                }
                if (i == extensions.Length - 1)
                {
                    MessageBox.Show("Please upload an excel file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        private void button_selectFile_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm";
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = openFileDialog.FileName;
                    UploadFile(file);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "The file could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UploadFile(string File)
        {
            this.dataTable = new DataGridView();
            try
            {
                var file = ExcelFile.Load(File);
                DataGridViewConverter.ExportToDataGridView(file.Worksheets.ActiveWorksheet, this.dataTable, new ExportToDataGridViewOptions() { ColumnHeaders = false });
                DisableButtons();
                seconds = 1;
                timer1.Enabled = true;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Failed to load decision matrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button_createEmpty_Click(object sender, EventArgs e)
        {
            MCDM.MainDataTable = new DataGridView();
            MCDM.AlternativesList.Clear();
            MCDM.CriteriaList.Clear();
            Form2 a = new Form2();
            a.ReferenceForm_Form1 = this;
            this.Hide();
            a.ShowDialog();
        }

        private void ContinueWithOpenedFile()
        {
            Form2 a = new Form2();
            a.ReferenceForm_Form1 = this;
            ActivateButtons();
            if (MCDM.CreateMainDataTable(true, dataTable, a.listBox_Alternatives, a.listBox_Criteria))
            {
                this.Hide();
                a.ShowDialog();
            }
        }

        int seconds;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
                ContinueWithOpenedFile();
        }

        private void DisableButtons()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void ActivateButtons()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
        }
    }
}
