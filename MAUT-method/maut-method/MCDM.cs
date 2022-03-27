using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace maut_method_project
{
    class MCDM
    {
        public static DataGridView MainDataTable = new DataGridView();
        public static ArrayList AlternativesList = new ArrayList();
        public static List<Criterion> CriteriaList = new List<Criterion>();
        public static string WeightingMethod;
        public static string EntropyNormalizationMethod;
        public static double SumOfSimpleweights;
        public static double[] PairwiseComparisonConsistencyValues = new double[4];

        /*  Excel dosyasından çekilen veri tablosundaki alternatif ve kriterleri listeleme işlemleri
            Form_giris ekranında bu metot çağırılır ve return değerine göre bu Form ile devam edip etmeyeceğini belirlemiş olur
        */
        public static bool CreateMainDataTable(bool isThereFile, DataGridView table, ListBox alternativesList, ListBox criteriaList)
        {
            if (isThereFile)
            {
                try
                {
                    MainDataTable = new DataGridView();
                    CopyDataTable(table, MainDataTable, false);
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        if (i == 0 && table.Rows[0].Cells[i].Value == null)
                            MainDataTable.Columns[i].Name = "";
                        else if (table.Rows[0].Cells[i].Value == null)
                            MainDataTable.Columns[i].Name = "Criterion";
                        else
                            MainDataTable.Columns[i].Name = table.Rows[0].Cells[i].Value.ToString();
                    }
                    MainDataTable.Rows.RemoveAt(0);
                    AlternativesList.Clear();
                    CriteriaList.Clear();
                    for (int i = 0; i < MainDataTable.Rows.Count; i++)
                    {
                        if(MainDataTable.Rows[i].Cells[0].Value == null)
                        {
                            MainDataTable.Rows[i].Cells[0].Value = "Alternative";
                            AlternativesList.Add("Alternative");
                            alternativesList.Items.Add("Alternative");
                        }
                        else
                        {
                            string a = MainDataTable.Rows[i].Cells[0].Value.ToString();
                            AlternativesList.Add(a);
                            alternativesList.Items.Add(a);
                        }
                    }
                    for (int i = 1; i < MainDataTable.Columns.Count; i++)
                    {
                        string k = MainDataTable.Columns[i].Name;
                        Criterion krt = new Criterion();
                        krt.Name = k;
                        krt.Benefit = true;
                        CriteriaList.Add(krt);
                        criteriaList.Items.Add(krt.Name + " (" + krt.GetCriterionDisplay() + ")");
                    }
                }
                catch
                {
                    MessageBox.Show("Please fill in the blank cells", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        /*  İşleme devam etmeden önce tablodaki verilerin boş olup olmadığını veya
            Numerik olmayan karakterlerin kullanıldığını tespit etmek için kullanılır
        */
        public static bool CheckMainDataTableCells()
        {
            try
            {
                if (CriteriaList.Count >= 2 && AlternativesList.Count >= 2 && MainDataTable.ColumnCount == CriteriaList.Count + 1 && MainDataTable.RowCount == AlternativesList.Count)
                {
                    for (int i = 0; i < MainDataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < MainDataTable.Columns.Count; j++)
                        {
                            if (j == 0)
                                MainDataTable.Rows[i].Cells[j].Value = MainDataTable.Rows[i].Cells[j].Value.ToString();
                            else
                            {
                                double a = double.Parse(MainDataTable.Rows[i].Cells[j].Value.ToString());
                                MainDataTable.Rows[i].Cells[j].Value = a;
                            }
                        }
                    }
                }
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Please fill in the blank cells\nMake sure the cells contain numeric data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckDataTableCellsOfPairwiseComparison(DataGridView table)
        {
            try
            {
                for (int i = 0; i < table.RowCount; i++)
                {
                    for (int j = 1; j < table.ColumnCount; j++)
                    {
                        double a = Convert.ToDouble(table.Rows[i].Cells[j].Value);
                        if (a == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool CheckWeightsOfCriteria()
        {
            bool b = true;
            for (int i = 0; i < CriteriaList.Count; i++)
            {
                if (CriteriaList[i].Weight == 0)
                    b = false;
            }
            return b;
        }

        public static bool CheckSumOfWeightsOfCriteria(DataGridView criteriaWeightingTable)
        {
            if (WeightingMethod == "Simple Weighting")
            {
                if (SumOfSimpleweights < -0.9999999999 || SumOfSimpleweights > 1.0000000001)
                {
                    MessageBox.Show("The sum of the criteria weights must be 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (CheckValuesOfWeightingTable(criteriaWeightingTable) == false && SumOfSimpleweights == 1)
                {
                    MessageBox.Show("There are criteria that have not been assigned a weight value.\nThe weights of the criteria should be between 0-1.\nThe sum of the criteria weights must be 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (CheckValuesOfWeightingTable(criteriaWeightingTable) == false && SumOfSimpleweights < 1)
                {
                    DialogResult msg = new DialogResult();
                    msg = MessageBox.Show("There are criteria that have not been assigned a weight value.\nYou can put more" + (1 - SumOfSimpleweights).ToString() + " weight values.\nWould you like to split the weight value equally across unassigned criteria?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        SplitTheWeightValueEqually(criteriaWeightingTable);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if(WeightingMethod == "Pairwise Comparison")
            {
                if (CheckDataTableCellsOfPairwiseComparison(criteriaWeightingTable))
                {
                    double consistencyRatio = CalculateTheConsistencyRatio(criteriaWeightingTable);
                    if (consistencyRatio <= 0.1)
                    {
                        DialogResult msg = new DialogResult();
                        msg = MessageBox.Show("The consistency ratio of the pairwise comparison: %" + (Math.Round(consistencyRatio, 5) * 100).ToString() + "\nDo you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                        if (msg == DialogResult.Yes)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        DialogResult msg = new DialogResult();
                        msg = MessageBox.Show("The consistency ratio of the pairwise comparison: %" + (Math.Round(consistencyRatio, 5) * 100).ToString() + "\nThe consistency ratio must be 10% or less.\nDo you want to continue?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (msg == DialogResult.Yes)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please compare the criteria.\nRate with a number between 1 to 9.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (!CheckWeightsOfCriteria() && WeightingMethod != "Entropy")
            {
                MessageBox.Show("There are criteria that have not been assigned a weight value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private static bool CheckValuesOfWeightingTable(DataGridView criteriaWeightingTable) 
        {
            for (int i = 0; i < criteriaWeightingTable.ColumnCount; i++)
            {
                if (criteriaWeightingTable.Rows[0].Cells[i].Value == null || criteriaWeightingTable.Rows[0].Cells[i].Value.ToString() == "")
                    return false;
                else
                {
                    try
                    {
                        double weight = Convert.ToDouble(criteriaWeightingTable.Rows[0].Cells[i].Value);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void SplitTheWeightValueEqually(DataGridView criteriaWeightingTable)
        {
            double availableWeight = 1 - SumOfSimpleweights;
            double resultValue = 0; 
            int numberOfUnassignedWeights = 0;
            for (int i = 0; i < criteriaWeightingTable.ColumnCount; i++)
            {
                if (criteriaWeightingTable.Rows[0].Cells[i].Value == null || criteriaWeightingTable.Rows[0].Cells[i].Value.ToString() == "")
                {
                    numberOfUnassignedWeights++;
                }
            }
            resultValue = availableWeight / numberOfUnassignedWeights;
            for (int i = 0; i < criteriaWeightingTable.ColumnCount; i++)
            {
                if (criteriaWeightingTable.Rows[0].Cells[i].Value == null || criteriaWeightingTable.Rows[0].Cells[i].Value.ToString() == "")
                {
                    criteriaWeightingTable.Rows[0].Cells[i].Value = resultValue;
                }
            }
        }

        public static double CalculateTheConsistencyRatio(DataGridView table)
        {
            DataGridView newTable = new DataGridView();
            DataGridView normalizedTable = new DataGridView();
            CopyDataTable(table, newTable, true);
            CopyDataTable(newTable, normalizedTable, true);
            int numberOfCriteria = CriteriaList.Count;
            double[] Wj = new double[numberOfCriteria];
            double[] priorityVector = new double[numberOfCriteria];
            for (int i = 1; i < newTable.ColumnCount; i++)
            {
                double sumXj = 0;
                for (int j = 0; j < newTable.RowCount; j++)
                {
                    sumXj += Convert.ToDouble(newTable.Rows[j].Cells[i].Value);
                }
                for (int j = 0; j < newTable.RowCount; j++)
                {
                    normalizedTable.Rows[j].Cells[i].Value = Convert.ToDouble(newTable.Rows[j].Cells[i].Value) / sumXj;
                }
            }
            for (int i = 0; i < normalizedTable.RowCount; i++)
            {
                double sumYj = 0;
                for (int j = 1; j < normalizedTable.ColumnCount; j++)
                {
                    sumYj += Convert.ToDouble(normalizedTable.Rows[i].Cells[j].Value);
                }
                Wj[i] = sumYj / numberOfCriteria;
            }
            for (int i = 0; i < newTable.RowCount; i++)
            {
                for (int j = 1; j < newTable.ColumnCount; j++)
                {
                    priorityVector[i] += Convert.ToDouble(newTable.Rows[i].Cells[j].Value) * Wj[j - 1];
                }
            }
            double RI = 0;
            double[] randomIndex = { 0, 0, 0.58, 0.90, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49, 1.51, 1.54, 1.56, 1.57, 1.59 };
            if (numberOfCriteria >= randomIndex.Length)
                RI = randomIndex[randomIndex.Length - 1];
            else
                RI = randomIndex[numberOfCriteria - 1];
            newTable.Rows.Add();
            double lambdaMax = 0;
            for (int i = 0; i < numberOfCriteria; i++)
            {
                lambdaMax += priorityVector[i] / Wj[i];
            }
            double averageLambdaMax = lambdaMax / numberOfCriteria;
            double CI = (averageLambdaMax - numberOfCriteria) / (numberOfCriteria - 1);
            double CR = CI / RI;
            PairwiseComparisonConsistencyValues[0] = averageLambdaMax;
            PairwiseComparisonConsistencyValues[1] = CI;
            PairwiseComparisonConsistencyValues[2] = RI;
            PairwiseComparisonConsistencyValues[3] = CR;
            return CR;
        }

        public static void GridViewDesign(DataGridView dataTable, bool orderColumns)
        {
            dataTable.RowHeadersVisible = false;
            dataTable.BackgroundColor = Color.FromArgb(50, 50, 50);
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataTable.EnableHeadersVisualStyles = false;
            dataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataTable.ColumnHeadersHeight = 50;
            dataTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.AllowUserToAddRows = false;
            dataTable.AllowUserToDeleteRows = false;
            if (orderColumns)
            {
                dataTable.AllowUserToOrderColumns = true;
                foreach (DataGridViewColumn column in dataTable.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            else
            {
                dataTable.AllowUserToOrderColumns = false;
                foreach (DataGridViewColumn column in dataTable.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        public static void CopyDataTable(DataGridView dataTable, DataGridView newDataTable, bool addRow)
        {
            newDataTable.ColumnCount = dataTable.ColumnCount;
            if (addRow)
                newDataTable.RowCount = dataTable.RowCount + 1;
            else
                newDataTable.RowCount = dataTable.RowCount;
            for (int i = 0; i < dataTable.RowCount; i++)
            {
                for (int j = 0; j < dataTable.ColumnCount; j++)
                {
                    newDataTable.Rows[i].Cells[j].Value = dataTable.Rows[i].Cells[j].Value;
                }
            }
            newDataTable.AllowUserToAddRows = false;
            for (int i = 0; i < dataTable.ColumnCount; i++)
            {
                newDataTable.Columns[i].Name = dataTable.Columns[i].Name;
            }
        }

        public class MenuDesign : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                e.Item.ForeColor = Color.White;
                e.ToolStrip.BackColor = Color.FromArgb(100, 100, 100);
                Rectangle rcd = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected || e.Item.Pressed ? Color.FromArgb(100, 100, 100) : Color.FromArgb(50, 50, 50);
                Color d = e.Item.Selected || e.Item.Pressed ? Color.FromArgb(50, 50, 50) : Color.FromArgb(100, 100, 100);
                if (e.Item.Text == "Start" || e.Item.Text == "Weighting Methods" || e.Item.Text == "Result" || e.Item.Text == "Details")
                {
                    using (SolidBrush brush = new SolidBrush(d))
                        e.Graphics.FillRectangle(brush, rcd);
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(c))
                        e.Graphics.FillRectangle(brush, rcd);
                }
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }

        public static void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.White);//Choose the color

                // Draw the background of the ListBox control for each item.
                e.DrawBackground();
                // Draw the current item text
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
            else
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Default,
                                          e.ForeColor,
                                          Color.FromArgb(50, 50, 50));//Choose the color

                // Draw the background of the ListBox control for each item.
                e.DrawBackground();
                // Draw the current item text
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
        }

        public static ToolTip InfoMsg(string title, string info, Control control)
        {
            ToolTip infoTip = new ToolTip();
            infoTip.Active = true;
            infoTip.BackColor = Color.White;
            infoTip.ForeColor = Color.FromArgb(50, 50, 50);
            infoTip.ToolTipIcon = ToolTipIcon.Info;
            infoTip.ToolTipTitle = title;
            infoTip.UseFading = true;
            infoTip.UseAnimation = true;
            infoTip.IsBalloon = true;
            infoTip.ShowAlways = true;
            infoTip.AutoPopDelay = 7000;
            infoTip.ReshowDelay = 3500;
            infoTip.InitialDelay = 1000;
            infoTip.SetToolTip(control, info);
            return infoTip;
        }
    }
}