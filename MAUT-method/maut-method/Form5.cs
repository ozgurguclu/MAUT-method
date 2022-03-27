using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System.Reflection;

namespace maut_method_project
{
    public partial class Form5 : Form
    {
        public Form ReferenceForm_Form2 { get; set; }
        public DataGridView PairwiseComparisonMatrix = new DataGridView();

        private Panel simplePanel;
        private Panel[] panels = new Panel[12];
        private DataGridView dataTable_MaxAndMinValuesInTheCriteria = new DataGridView();
        private DataGridView dataTable_NormalizedValuesForMAUT = new DataGridView();
        private DataGridView dataTable_NormalizedValuesForEntropy = new DataGridView();
        private DataGridView dataTable_PairwiseComparisonByTheCriteria = new DataGridView();
        private DataGridView dataTable_NormalizedPairwiseComparisonValues = new DataGridView();
        private DataGridView dataTable_CalculatedLogarithmValuesForEntropy = new DataGridView();
        private DataGridView dataTable_CalculatedPriorityVectorForPairwiseComparison = new DataGridView();
        private DataGridView dataTable_CalculatedConsistencyValuesForPairwiseComparison = new DataGridView();
        private DataGridView dataTable_CalculatedEntropyValues = new DataGridView();
        private DataGridView dataTable_CalculatedWeightsOfCriteria = new DataGridView();
        private DataGridView dataTable_CalculatedBenefitOfAlternatives = new DataGridView();
        private DataGridView dataTable_SortingAlternatives = new DataGridView();

        public Form5()
        {
            InitializeComponent();
        }

        private void CreatePanels()
        {
            panels[0] = CopySimplePanel("Sorting alternatives");
            panels[1] = CopySimplePanel("Maximum and minimum values in the criteria");
            panels[2] = CopySimplePanel("Normalized data (Max-Min)");
            panels[3] = CopySimplePanel("Normalized data for entropy");
            panels[4] = CopySimplePanel("Logarithm values for entropy");
            panels[5] = CopySimplePanel("Entropy values");
            panels[6] = CopySimplePanel("Pairwise comparison by the criteria");
            panels[7] = CopySimplePanel("Normalized pairwise comparison data");
            panels[8] = CopySimplePanel("The priority vector for the pairwise comparison");
            panels[9] = CopySimplePanel("The consistency values for the pairwise comparison");
            panels[10] = CopySimplePanel("The weights of the criteria");
            panels[11] = CopySimplePanel("The benefits of the criteria");

            simplePanel.Visible = false;

            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].Parent = this;
                panels[i].Location = new Point(12, 38);
                foreach (var item in panels[i].Controls)
                {
                    if (item is Button)
                        ((Button)item).Click += Button_SaveFile_Click;
                }
            }
        }

        private Panel CopySimplePanel(string title)
        {
            Panel p = new Panel();
            Label l = new Label();
            Button b = new Button();
            p = simplePanel.Clone();
            foreach (var item in simplePanel.Controls)
            {
                if (item is Label)
                {
                    l = ((Label)item).Clone();
                    p.Controls.Add(l);
                }

            }
            foreach (var item in simplePanel.Controls)
            {
                if (item is Button)
                {
                    b = ((Button)item).Clone();
                    p.Controls.Add(b);
                }
            }
            SetTitleOfPanel(p, title);
            return p;
        }

        private void SetTitleOfPanel(Panel panel, string text)
        {
            foreach(var item in panel.Controls)
            {
                if (item is Label)
                    ((Label)item).Text = text;
            }
        }

        private void CreateDataTables()
        {
            dataTable_MaxAndMinValuesInTheCriteria = Methods.FindMaxAndMinValuesInTheCriteria(MCDM.MainDataTable);
            dataTable_NormalizedValuesForMAUT = Methods.NormalizeDataWithLinearMaxMinTechnique(MCDM.MainDataTable);
            if(MCDM.WeightingMethod == "Entropy")
            {
                dataTable_NormalizedValuesForEntropy = Methods.NormalizeDataForEntropy(MCDM.MainDataTable, MCDM.EntropyNormalizationMethod);
                dataTable_CalculatedLogarithmValuesForEntropy = Methods.CalculateLogarithmValuesForEntropy(dataTable_NormalizedValuesForEntropy);
                dataTable_CalculatedEntropyValues = Methods.CalculateEntropyValues(dataTable_CalculatedLogarithmValuesForEntropy);
            }
            else if(MCDM.WeightingMethod == "Pairwise Comparison")
            {
                dataTable_PairwiseComparisonByTheCriteria = Methods.ShowPairwiseComparisonData(PairwiseComparisonMatrix);
                dataTable_NormalizedPairwiseComparisonValues = Methods.NormalizeDataForPairWiseComparison(PairwiseComparisonMatrix);
                dataTable_CalculatedPriorityVectorForPairwiseComparison = Methods.CalculatePriorityVectorForPairwiseComparison(PairwiseComparisonMatrix);
                dataTable_CalculatedConsistencyValuesForPairwiseComparison = Methods.ShowPairwiseComparisonConsistencyValues();
            }
            if (MCDM.WeightingMethod != "Entropy")
            {
                ToolStripMenuItem_Details3.Visible = false;
                ToolStripMenuItem_Details4.Visible = false;
                ToolStripMenuItem_Details5.Visible = false;
            }
            if (MCDM.WeightingMethod != "Pairwise Comparison")
            {
                ToolStripMenuItem_Details6.Visible = false;
                ToolStripMenuItem_Details7.Visible = false;
                ToolStripMenuItem_Details8.Visible = false;
                ToolStripMenuItem_Details9.Visible = false;
            }
            dataTable_CalculatedWeightsOfCriteria = Methods.ShowWeightsOfCriteria();
            dataTable_CalculatedBenefitOfAlternatives = Methods.CalculateBenefitsWithMAUT(dataTable_NormalizedValuesForMAUT);
            dataTable_SortingAlternatives = Methods.SortAlternatives(dataTable_CalculatedBenefitOfAlternatives);
            CreateDataTable(dataTable_MaxAndMinValuesInTheCriteria, 1);
            CreateDataTable(dataTable_NormalizedValuesForMAUT, 2);
            CreateDataTable(dataTable_NormalizedValuesForEntropy, 3);
            CreateDataTable(dataTable_CalculatedLogarithmValuesForEntropy, 4);
            CreateDataTable(dataTable_CalculatedEntropyValues, 5);
            CreateDataTable(dataTable_PairwiseComparisonByTheCriteria, 6);
            CreateDataTable(dataTable_NormalizedPairwiseComparisonValues, 7);
            CreateDataTable(dataTable_CalculatedPriorityVectorForPairwiseComparison, 8);
            CreateDataTable(dataTable_CalculatedConsistencyValuesForPairwiseComparison, 9);
            CreateDataTable(dataTable_CalculatedWeightsOfCriteria, 10);
            CreateDataTable(dataTable_CalculatedBenefitOfAlternatives, 11);
            CreateDataTable(dataTable_SortingAlternatives, 0);
        }

        private void Form_mautSonuc_Load(object sender, EventArgs e)
        {
            simplePanel = panel_Simple;
            CreatePanels();
            CreateDataTables();
            ShowPanel(0);
            menuStrip_Results.Renderer = new MCDM.MenuDesign();
        }

        private void ShowPanel(int index)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                if (i == index)
                    panels[i].Visible = true;
                else
                    panels[i].Visible = false;
            }
        }

        private void CreateDataTable(DataGridView table, int panelIndex)
        {
            table.Width = 806;
            table.Height = 350;
            table.Location = new Point(7, 23);
            MCDM.GridViewDesign(table, true);
            table.MultiSelect = false;
            table.ReadOnly = true;
            panels[panelIndex].Controls.Add(table);
        }

        private void SaveFile(object sender)
        {
            string directory = @"c:\MAUT App";
            if (Directory.Exists(directory) == false)
            {
                Directory.CreateDirectory(directory);
            }
            if (Directory.Exists(directory) == true)
            {
                try
                {
                    int panel = 0;
                    int table = 0;
                    for (int i = 0; i < panels.Length; i++)
                    {
                        if (((Button)sender).Parent == panels[i])
                            panel = i;
                    }
                    for (int i = 0; i < panels[panel].Controls.Count; i++)
                    {
                        if (panels[panel].Controls[i] is DataGridView)
                            table = i;
                    }
                    var save = new SaveFileDialog();
                    save.InitialDirectory = @"c:\MAUT App";
                    save.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX files (*.xltx)|*.xltx|XLTM files (*.xltm)|*.xltm";
                    save.FilterIndex = 3;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        var workbook = new ExcelFile();
                        var worksheet = workbook.Worksheets.Add("Page1");
                        DataGridViewConverter.ImportFromDataGridView(worksheet, (DataGridView)panels[panel].Controls[table], new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                        workbook.Save(save.FileName);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("The file could not be saved." + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void SaveAllFiles()
        {
            string directory = @"c:\MAUT App";
            if (Directory.Exists(directory) == false)
            {
                Directory.CreateDirectory(directory);
            }
            if (Directory.Exists(directory) == true)
            {
                try
                {
                    var save = new SaveFileDialog();
                    save.InitialDirectory = @"c:\MAUT App";
                    save.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX files (*.xltx)|*.xltx|XLTM files (*.xltm)|*.xltm";
                    save.FilterIndex = 3;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        int row = 0;
                        var workbook = new ExcelFile();
                        var worksheet = workbook.Worksheets.Add("Page1");
                        DataGridViewConverter.ImportFromDataGridView(worksheet, dataTable_SortingAlternatives, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                        var worksheet2 = workbook.Worksheets.Add("Page2");
                        DataGridViewConverter.ImportFromDataGridView(worksheet2, dataTable_MaxAndMinValuesInTheCriteria, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                        row += dataTable_MaxAndMinValuesInTheCriteria.RowCount + 3;
                        DataGridViewConverter.ImportFromDataGridView(worksheet2, dataTable_NormalizedValuesForMAUT, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                        row += dataTable_NormalizedValuesForMAUT.RowCount + 3;
                        DataGridViewConverter.ImportFromDataGridView(worksheet2, dataTable_CalculatedWeightsOfCriteria, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                        row += dataTable_CalculatedWeightsOfCriteria.RowCount + 3;
                        DataGridViewConverter.ImportFromDataGridView(worksheet2, dataTable_CalculatedBenefitOfAlternatives, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                        if (MCDM.WeightingMethod == "Entropy")
                        {
                            row = 0;
                            var worksheet3 = workbook.Worksheets.Add("Page3");
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_NormalizedValuesForEntropy, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                            row += dataTable_NormalizedValuesForEntropy.RowCount + 3;
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_CalculatedLogarithmValuesForEntropy, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                            row += dataTable_CalculatedLogarithmValuesForEntropy.RowCount + 3;
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_CalculatedEntropyValues, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                        }
                        else if (MCDM.WeightingMethod == "Pairwise comparison")
                        {
                            row = 0;
                            var worksheet3 = workbook.Worksheets.Add("Page3");
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_PairwiseComparisonByTheCriteria, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                            row += dataTable_PairwiseComparisonByTheCriteria.RowCount + 3;
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_NormalizedPairwiseComparisonValues, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                            row += dataTable_NormalizedPairwiseComparisonValues.RowCount + 3;
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_CalculatedPriorityVectorForPairwiseComparison, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                            row += dataTable_CalculatedPriorityVectorForPairwiseComparison.RowCount + 3;
                            DataGridViewConverter.ImportFromDataGridView(worksheet3, dataTable_CalculatedConsistencyValuesForPairwiseComparison, new ImportFromDataGridViewOptions() { ColumnHeaders = true, StartRow = row });
                        }
                        workbook.Save(save.FileName);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("The file could not be saved." + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Form_sonuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ReferenceForm_Form2.Show();
        }

        private void ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White;
        }

        private void ToolStripMenuItem_Result_Click(object sender, EventArgs e)
        {
            ShowPanel(0);
        }

        private void ToolStripMenuItem_Details1_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void ToolStripMenuItem_Details2_Click(object sender, EventArgs e)
        {
            ShowPanel(2);
        }

        private void ToolStripMenuItem_Details3_Click(object sender, EventArgs e)
        {
            ShowPanel(3);
        }

        private void ToolStripMenuItem_Details4_Click(object sender, EventArgs e)
        {
            ShowPanel(4);
        }

        private void ToolStripMenuItem_Details5_Click(object sender, EventArgs e)
        {
            ShowPanel(5);
        }

        private void ToolStripMenuItem_Details6_Click(object sender, EventArgs e)
        {
            ShowPanel(6);
        }

        private void ToolStripMenuItem_Details7_Click(object sender, EventArgs e)
        {
            ShowPanel(7);
        }

        private void ToolStripMenuItem_Details8_Click(object sender, EventArgs e)
        {
            ShowPanel(8);
        }

        private void ToolStripMenuItem_Details9_Click(object sender, EventArgs e)
        {
            ShowPanel(9);
        }

        private void ToolStripMenuItem_Details10_Click(object sender, EventArgs e)
        {
            ShowPanel(10);
        }

        private void ToolStripMenuItem_Details11_Click(object sender, EventArgs e)
        {
            ShowPanel(11);
        }

        private void Button_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile(sender);
        }

        private void ToolStripMenuItem_SaveAll_Click(object sender, EventArgs e)
        {
            SaveAllFiles();
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
