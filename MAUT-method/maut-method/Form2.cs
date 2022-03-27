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
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace maut_method_project
{
    public partial class Form2 : Form
    {
        public Form ReferenceForm_Form1 { get; set; }
        private DataGridView criteriaWeightsDataTable;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ReferenceForm_Form1.Show();
        }

        private void button_EditDataTable_Click(object sender, EventArgs e)
        {
            if (MCDM.MainDataTable.Rows.Count >= 1 && MCDM.MainDataTable.Columns.Count >= 2)
            {
                Form3 a = new Form3();
                a.ReferenceForm_Form2 = this;
                a.Clone_CriteriaWeightsDataTable = criteriaWeightsDataTable;
                this.Hide();
                a.ShowDialog();
            }
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            CheckInfoAndContinue();
        }

        private void CheckInfoAndContinue()
        {
            if (MCDM.CheckMainDataTableCells())
            {
                if (MCDM.CheckSumOfWeightsOfCriteria(criteriaWeightsDataTable))
                {
                    Form5 a = new Form5();
                    a.ReferenceForm_Form2 = this;
                    a.PairwiseComparisonMatrix = criteriaWeightsDataTable;
                    this.Hide();
                    a.ShowDialog();
                }
            }
        }

        /*  Form_degerEkle(Form4) açılır ve orada ilgili textboxa alternatif girilir
            Eğer kriterler hiç yoksa önce bir kriter oluşturulması istenir
        */
        private void button_AddAlternative_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            if (MCDM.CriteriaList.Count == 0)
            {
                a.ListControl = listBox_Criteria;
                a.CriteriaWeightsDataTable = criteriaWeightsDataTable;
                a.IsAlternative = false;
                a.Action = "add";
                a.Text = "You must add criteria first";
            }
            else
            {
                a.ListControl = listBox_Alternatives;
                a.IsAlternative = true;
                a.Action = "add";
                a.Text = "Add alternative";
            }
            a.ShowDialog();
        }

        //  Form_degerEkle(Form4) açılır ve orada ilgili textboxa kriter girilir
        private void button_AddCriterion_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ListControl = listBox_Criteria;
            a.CriteriaWeightsDataTable = criteriaWeightsDataTable;
            a.IsAlternative = false;
            a.Action = "add";
            a.Text = "Add criterion";
            a.ShowDialog();
        }

        private void button_EditAlternative_Click(object sender, EventArgs e)
        {
            if (listBox_Alternatives.SelectedIndex > -1)
            {
                Form4 a = new Form4();
                a.ListControl = listBox_Alternatives;
                a.IsAlternative = true;
                a.Action = "edit";
                a.Text = "Rename alternative";
                a.ShowDialog();
            }
        }

        private void button_EditCriterion_Click(object sender, EventArgs e)
        {
            if (listBox_Criteria.SelectedIndex > -1)
            {
                Form4 a = new Form4();
                a.ListControl = listBox_Criteria;
                a.CriteriaWeightsDataTable = criteriaWeightsDataTable;
                a.IsAlternative = false;
                a.Action = "edit";
                a.Text = "Rename criterion";
                a.ShowDialog();
            }
        }

        //  Alternatifler array listesinden bir alternatif çıkarılır
        private void button_RemoveAlternative_Click(object sender, EventArgs e)
        {
            if (listBox_Alternatives.SelectedIndex != -1)
                RemoveFromList(listBox_Alternatives.SelectedIndex, listBox_Alternatives, true);
        }

        //  Kriterler array listesinden bir kriter çıkarılır
        private void button_RemoveCriterion_Click(object sender, EventArgs e)
        {
            if (listBox_Criteria.SelectedIndex != -1)
                RemoveFromList(listBox_Criteria.SelectedIndex, listBox_Criteria, false);
        }

        /*  Her bir kriter için en iyi değerlerin belirlenebilmesi için
            Fayda veya maliyet kriteri olduğu belirlenmelidir.
         */
        private void BenefitOrCostCriterion(int index)
        {
            if (MCDM.CriteriaList[index].Benefit == true)
                MCDM.CriteriaList[index].Benefit = false;
            else
                MCDM.CriteriaList[index].Benefit = true;
            listBox_Criteria.Items[index] = MCDM.CriteriaList[index].Name + " (" + MCDM.CriteriaList[index].GetCriterionDisplay() + ")";
        }

        private void button_BenefitOrCost_Click(object sender, EventArgs e)
        {
            if (listBox_Criteria.SelectedIndex != -1)
                BenefitOrCostCriterion(listBox_Criteria.SelectedIndex);
        }

        /*  Listeden ve gridview nesnesinden alternatif veya kriteri çıkarma işlemleri
            Önce array dizisinden silinir, sonra array dizisinin tamamı listbox'a aktarılır
        */
        private void RemoveFromList(int index, ListBox list, bool isAlternative)
        {
            list.Items.RemoveAt(index);
            if (isAlternative)
            {
                MCDM.AlternativesList.RemoveAt(index);
                MCDM.MainDataTable.Rows.RemoveAt(index);
            }
            else
            {
                MCDM.CriteriaList.RemoveAt(index);
                MCDM.MainDataTable.Columns.RemoveAt(index + 1);
                if (MCDM.WeightingMethod == "Equal Weighting")
                    DetermineEqualWeights();
                else if (MCDM.WeightingMethod == "Simple Weighting" || MCDM.WeightingMethod == "Pairwise Comparison")
                    RemoveCriterionFromWeightingDataTable(index);
            }
            if (list.Items.Count - 1 > index)
                list.SelectedIndex = index;
            else
                list.SelectedIndex = list.Items.Count - 1;
        }

        private void ToolStripMenuItem_CreateNew_Click(object sender, EventArgs e)
        {
            this.ReferenceForm_Form1.Show();
            this.Close();
        }

        private void RemoveCriteriaWeightingDataTable()
        {
            for (int i = 0; i < panel_CriteriaWeighting.Controls.Count; i++)
            {
                if (panel_CriteriaWeighting.Controls[i] is DataGridView)
                    panel_CriteriaWeighting.Controls.Remove((DataGridView)panel_CriteriaWeighting.Controls[i]);
            }
        }

        private void RemoveWeightsOfCriteria()
        {
            for (int i = 0; i < MCDM.CriteriaList.Count; i++)
            {
                MCDM.CriteriaList[i].Weight = 0;
            }
            MCDM.SumOfSimpleweights = 0;
        }

        private void DetermineEqualWeights()
        {
            RemoveCriteriaWeightingDataTable();
            double weight = 1 / Convert.ToDouble(MCDM.CriteriaList.Count);
            label_NumberOfCriteriaValue.Text = MCDM.CriteriaList.Count.ToString();
            if (MCDM.CriteriaList.Count == 0)
                label_CalculatedWeightValue.Text = "0";
            else
                label_CalculatedWeightValue.Text = weight.ToString();
            for (int i = 0; i < MCDM.CriteriaList.Count; i++)
            {
                MCDM.CriteriaList[i].Weight = weight;
            }
        }

        private void RemoveCriterionFromWeightingDataTable(int index)
        {
            int a = 0;
            for (int i = 0; i < panel_CriteriaWeighting.Controls.Count; i++)
            {
                if (panel_CriteriaWeighting.Controls[i] is DataGridView)
                {
                    a = i;
                    break;
                }
            }
            if (MCDM.WeightingMethod == "Simple Weighting")
            {
                try
                {
                    double weight = Convert.ToDouble(((DataGridView)panel_CriteriaWeighting.Controls[a]).Rows[0].Cells[index].Value);
                    MCDM.SumOfSimpleweights -= weight;
                    label_SumWeightValue.Text = MCDM.SumOfSimpleweights.ToString();
                }
                catch { }
                ((DataGridView)panel_CriteriaWeighting.Controls[a]).Columns.RemoveAt(index);
            }
            else if (MCDM.WeightingMethod == "Pairwise Comparison")
            {
                ((DataGridView)panel_CriteriaWeighting.Controls[a]).Columns.RemoveAt(index + 1);
                ((DataGridView)panel_CriteriaWeighting.Controls[a]).Rows.RemoveAt(index);
            }
        }

        private void CreateCriteriaWeightingDataTable(string weightingMethod)
        {
            RemoveCriteriaWeightingDataTable();
            DataGridView newDataTable = new DataGridView();
            newDataTable.Width = 773;
            if (weightingMethod == "Simple Weighting")
                newDataTable.Height = 68;
            else if (weightingMethod == "Pairwise Comparison")
                newDataTable.Height = 188;
            else
                newDataTable.Height = 230;
            newDataTable.Location = new Point(7, 23);
            newDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            newDataTable.MultiSelect = false;
            if (weightingMethod == "Simple Weighting")
            {
                for (int i = 0; i < MCDM.CriteriaList.Count; i++)
                {
                    newDataTable.Columns.Add("", MCDM.CriteriaList[i].Name);
                }
                if (MCDM.CriteriaList.Count != 0)
                    newDataTable.Rows.Add();
            }
            else if (weightingMethod == "Pairwise Comparison")
            {
                newDataTable.Columns.Add("", "");
                for (int i = 1; i < MCDM.CriteriaList.Count + 1; i++)
                {
                    newDataTable.Columns.Add(MCDM.CriteriaList[i - 1].Name, MCDM.CriteriaList[i - 1].Name);
                    newDataTable.Rows.Add();
                    newDataTable.Rows[i - 1].Cells[0].Value = MCDM.CriteriaList[i - 1].Name;
                }
                newDataTable.Columns[0].ReadOnly = true;
                for (int i = 0; i < MCDM.CriteriaList.Count; i++)
                {
                    newDataTable.Rows[i].Cells[i + 1].Value = 1;
                    newDataTable.Rows[i].Cells[i + 1].Style.BackColor = Color.LimeGreen;
                    newDataTable.Rows[i].Cells[i + 1].Style.ForeColor = Color.White;
                    newDataTable.Rows[i].Cells[i + 1].ReadOnly = true;
                }
            }
            MCDM.GridViewDesign(newDataTable, false);
            if (weightingMethod == "Simple Weighting")
                newDataTable.ColumnHeadersHeight = 30;
            panel_CriteriaWeighting.Controls.Add(newDataTable);
            for (int i = 0; i < panel_CriteriaWeighting.Controls.Count; i++)
            {
                if (panel_CriteriaWeighting.Controls[i] is DataGridView)
                    criteriaWeightsDataTable = (DataGridView)panel_CriteriaWeighting.Controls[i];
            }
            criteriaWeightsDataTable.CellPainting += this.CriteriaWeightsDataTable_CellPainting;
            criteriaWeightsDataTable.CellBeginEdit += this.CriteriaWeightsDataTable_CellBeginEdit;
            criteriaWeightsDataTable.CellEndEdit += this.CriteriaWeightsDataTable_CellEndEdit;
            criteriaWeightsDataTable.CellValueChanged += this.CriteriaWeightsDataTable_CellValueChanged;
            criteriaWeightsDataTable.SelectionChanged += this.CriteriaWeightsDataTable_SelectionChanged;
        }

        private void ChangeView(string weightingMethod)
        {
            if (weightingMethod == "Equal Weighting")
            {
                panel_CriteriaWeighting.Visible = true;
                panel_CriteriaWeighting.Height = 80;
                this.MaximumSize = new Size(830, 400);
                this.MinimumSize = new Size(830, 400);
                ShowHideElementsEqualWeighting(true);
                ShowHideElementsSimpleWeighting(false);
                ShowHideElementsEntropy(false);
                ShowHideElementsPairwiseComparison(false);
            }
            else if (weightingMethod == "Simple Weighting")
            {
                panel_CriteriaWeighting.Visible = true;
                panel_CriteriaWeighting.Height = 120;
                this.MaximumSize = new Size(830, 440);
                this.MinimumSize = new Size(830, 440);
                ShowHideElementsEqualWeighting(false);
                ShowHideElementsSimpleWeighting(true);
                ShowHideElementsEntropy(false);
                ShowHideElementsPairwiseComparison(false);
            }
            else if (weightingMethod == "Entropy")
            {
                panel_CriteriaWeighting.Visible = true;
                panel_CriteriaWeighting.Height = 150;
                this.MaximumSize = new Size(830, 470);
                this.MinimumSize = new Size(830, 470);
                ShowHideElementsEqualWeighting(false);
                ShowHideElementsSimpleWeighting(false);
                ShowHideElementsEntropy(true);
                ShowHideElementsPairwiseComparison(false);
            }
            else if (weightingMethod == "Pairwise Comparison")
            {
                panel_CriteriaWeighting.Visible = true;
                panel_CriteriaWeighting.Height = 260;
                this.MaximumSize = new Size(830, 580);
                this.MinimumSize = new Size(830, 580);
                ShowHideElementsEqualWeighting(false);
                ShowHideElementsSimpleWeighting(false);
                ShowHideElementsEntropy(false);
                ShowHideElementsPairwiseComparison(true);
            }
            else
            {
                panel_CriteriaWeighting.Visible = false;
                this.MaximumSize = new Size(830, 310);
                this.MinimumSize = new Size(830, 310);
            }
        }

        private void CriteriaWeightsDataTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.White, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 1;
                        rect.Height -= 1;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }

        private void CriteriaWeightsDataTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(50, 50, 50);
            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
        }

        private void CriteriaWeightsDataTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (MCDM.WeightingMethod == "Simple Weighting")
            {
                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = SystemColors.ControlText;
            }
            else if (MCDM.WeightingMethod == "Pairwise Comparison")
            {
                if (criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = SystemColors.ControlText;
                }
                else if (double.Parse(criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == 1)
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LimeGreen;
                }
                else if (double.Parse(criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 1)
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.OrangeRed;
                }
                else
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DodgerBlue;
                }
            }
        }

        private void CriteriaWeightsDataTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (MCDM.WeightingMethod == "Simple Weighting")
            {
                try
                {
                    if (e.RowIndex != -1)
                    {
                        int slashCharIndex = 0;
                        string value = "";
                        value = criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value.Substring(i, 1) == "/")
                            {
                                slashCharIndex = i;
                                break;
                            }
                        }
                        if (slashCharIndex > 0)
                        {
                            double num1 = double.Parse(value.Substring(0, slashCharIndex));
                            double num2 = double.Parse(value.Substring(slashCharIndex + 1));
                            double result = num1 / num2;
                            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = result;
                        }
                        else
                        {
                            double a = double.Parse(criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = a;
                        }
                        MCDM.SumOfSimpleweights = 0;
                        for (int i = 0; i < MCDM.CriteriaList.Count; i++)
                        {
                            try
                            {
                                double cellValue = double.Parse(criteriaWeightsDataTable.Rows[0].Cells[i].Value.ToString());
                                MCDM.CriteriaList[i].Weight = cellValue;
                                MCDM.SumOfSimpleweights += cellValue;
                            }
                            catch { }
                        }
                        label_SumWeightValue.Text = MCDM.SumOfSimpleweights.ToString();
                    }
                }
                catch
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    MCDM.SumOfSimpleweights = MCDM.SumOfSimpleweights - MCDM.CriteriaList[e.ColumnIndex].Weight;
                    MCDM.CriteriaList[e.ColumnIndex].Weight = 0;
                    label_SumWeightValue.Text = MCDM.SumOfSimpleweights.ToString();
                }
            }
            else if (MCDM.WeightingMethod == "Pairwise Comparison")
            {
                try
                {
                    if (e.ColumnIndex != 0 && e.RowIndex != -1)
                    {
                        int num = Convert.ToInt32(criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (num > 0 && num < 10)
                        {
                            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = num;
                            if (num == 1)
                            {
                                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LimeGreen;
                                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.BackColor = Color.LimeGreen;
                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.ForeColor = Color.White;
                                criteriaWeightsDataTable.CellValueChanged -= this.CriteriaWeightsDataTable_CellValueChanged;
                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Value = 1;
                                criteriaWeightsDataTable.CellValueChanged += this.CriteriaWeightsDataTable_CellValueChanged;
                            }
                            else
                            {
                                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DodgerBlue;
                                criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;

                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.BackColor = Color.OrangeRed;
                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.ForeColor = Color.White;
                                criteriaWeightsDataTable.CellValueChanged -= this.CriteriaWeightsDataTable_CellValueChanged;
                                criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Value = 1 / (double)num;
                                criteriaWeightsDataTable.CellValueChanged += this.CriteriaWeightsDataTable_CellValueChanged;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rate a number between 1 to 9", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        }
                    }
                }
                catch
                {
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = criteriaWeightsDataTable.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = SystemColors.ControlText;
                    criteriaWeightsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;

                    criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.BackColor = criteriaWeightsDataTable.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Style.ForeColor = SystemColors.ControlText;
                    criteriaWeightsDataTable.Rows[e.ColumnIndex - 1].Cells[e.RowIndex + 1].Value = null;
                }
            }
        }

        private void CriteriaWeightsDataTable_SelectionChanged(object sender, EventArgs e)
        {
            if (MCDM.WeightingMethod == "Simple Weighting" && criteriaWeightsDataTable.CurrentCell != null && criteriaWeightsDataTable.CurrentCell.ColumnIndex == MCDM.CriteriaList.Count)
                criteriaWeightsDataTable.CurrentCell.Selected = false;
        }

        private void ToolStripMenuItem_EqualWeighting_Click(object sender, EventArgs e)
        {
            MCDM.WeightingMethod = "Equal Weighting"; 
            ChangeView(MCDM.WeightingMethod);
            RemoveWeightsOfCriteria();
            DetermineEqualWeights();
            label_SelectedWeightingMethod.Text = MCDM.WeightingMethod;
            label_Weighting.Text = MCDM.WeightingMethod;
        }

        private void ToolStripMenuItem_SimpleWeighting_Click(object sender, EventArgs e)
        {
            MCDM.WeightingMethod = "Simple Weighting";
            ChangeView(MCDM.WeightingMethod);
            CreateCriteriaWeightingDataTable(MCDM.WeightingMethod);
            label_SelectedWeightingMethod.Text = MCDM.WeightingMethod;
            label_Weighting.Text = MCDM.WeightingMethod;
            label_SumWeightValue.Text = "0";
            RemoveWeightsOfCriteria();
        }

        private void ToolStripMenuItem_Entropy_Click(object sender, EventArgs e)
        {
            MCDM.WeightingMethod = "Entropy";
            MCDM.EntropyNormalizationMethod = "Direct Calculation";
            ChangeView(MCDM.WeightingMethod);
            label_SelectedWeightingMethod.Text = MCDM.WeightingMethod;
            label_Weighting.Text = MCDM.WeightingMethod;
            radioButton_EntropyDirectCalculation.Checked = true;
            panel_EntropyIndirectCalculationMethods.Enabled = false;
            foreach (RadioButton item in panel_EntropyIndirectCalculationMethods.Controls)
            {
                item.Checked = false;
            }
            RemoveWeightsOfCriteria();
            RemoveCriteriaWeightingDataTable();
        }

        private void ToolStripMenuItem_PairwiseComparison_Click(object sender, EventArgs e)
        {
            MCDM.WeightingMethod = "Pairwise Comparison";
            ChangeView(MCDM.WeightingMethod);
            CreateCriteriaWeightingDataTable(MCDM.WeightingMethod);
            label_SelectedWeightingMethod.Text = MCDM.WeightingMethod;
            label_Weighting.Text = MCDM.WeightingMethod;
            label_PairwiseComparisonConsistencyValue.Text = "Not calculated";
            RemoveWeightsOfCriteria();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MCDM.WeightingMethod = "Equal Weighting";
            MCDM.EntropyNormalizationMethod = "Direct Calculation";
            ChangeView(MCDM.WeightingMethod);
            DetermineEqualWeights();
            label_SelectedWeightingMethod.Text = MCDM.WeightingMethod;
            label_Weighting.Text = MCDM.WeightingMethod;

            listBox_Criteria.SelectedIndexChanged += this.CriteriaList_IndexChanged;

            listBox_Alternatives.DrawItem += MCDM.listBox_DrawItem;
            listBox_Criteria.DrawItem += MCDM.listBox_DrawItem;
            menuStrip.Renderer = new MCDM.MenuDesign();
        }

        private void CriteriaList_IndexChanged(object sender, EventArgs e)
        {
            if (MCDM.WeightingMethod == "Equal Weighting")
                DetermineEqualWeights();
        }

        private void ShowHideElementsEqualWeighting(bool a)
        {
            panel_EqualWeighting.Visible = a;
        }

        private void ShowHideElementsSimpleWeighting(bool a)
        {
            label_SumWeight.Visible = a;
            label_SumWeightValue.Visible = a;
        }

        private void ShowHideElementsEntropy(bool a)
        {
            panel_NormalizationMethodsForEntropy.Visible = a;
            panel_EntropyIndirectCalculationMethods.Visible = a;
        }

        private void ShowHideElementsPairwiseComparison(bool a)
        {
            panel_PairwiseComparisonColors.Visible = a;
            panel_PairwiseComparisonConsistency.Visible = a;
        }

        private void SelectNormalizationMethodForEntropy(object sender, EventArgs e)
        {
            if (sender == radioButton_EntropyDirectCalculation)
                MCDM.EntropyNormalizationMethod = "Direct Calculation";
            else if (sender == radioButton_EntropyNormalizationMax)
                MCDM.EntropyNormalizationMethod = "Max";
            else if (sender == radioButton_EntropyNormalizationMaxMin)
                MCDM.EntropyNormalizationMethod = "Max-Min";
            else
                MCDM.EntropyNormalizationMethod = "Direct Calculation";
        }

        private void radioButton_EntropyIndirectCalculation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_EntropyIndirectCalculation.Checked)
            {
                panel_EntropyIndirectCalculationMethods.Enabled = true;
                radioButton_EntropyNormalizationMax.Checked = true;
                MCDM.EntropyNormalizationMethod = "Max";
            }
            else
            {
                panel_EntropyIndirectCalculationMethods.Enabled = false;
                foreach (RadioButton item in panel_EntropyIndirectCalculationMethods.Controls)
                {
                    item.Checked = false;
                }
            }
        }

        private void button_CalculatePairwiseComparisonConsistency_Click(object sender, EventArgs e)
        {
            if (MCDM.CheckDataTableCellsOfPairwiseComparison(criteriaWeightsDataTable))
                label_PairwiseComparisonConsistencyValue.Text = MCDM.CalculateTheConsistencyRatio(criteriaWeightsDataTable).ToString();
            else
                MessageBox.Show("Make a pairwise comparison between the criteria.\nPlease rate with a number between 1 to 9.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_UploadPairwiseComparisonFile_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm";
                openFileDialog.FilterIndex = 2;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataGridView newDataTable = new DataGridView();
                    newDataTable.AllowUserToAddRows = false;
                    string fileName = openFileDialog.FileName;
                    var file = ExcelFile.Load(fileName);
                    DataGridViewConverter.ExportToDataGridView(file.Worksheets.ActiveWorksheet, newDataTable, new ExportToDataGridViewOptions() { ColumnHeaders = false });
                    for (int i = 1; i < newDataTable.Columns.Count; i++)
                    {
                        newDataTable.Columns[i].Name = MCDM.CriteriaList[i - 1].Name;
                        newDataTable.Columns[i].HeaderText = MCDM.CriteriaList[i - 1].Name;
                        newDataTable.Rows[i].Cells[0].Value = MCDM.CriteriaList[i - 1].Name;
                    }
                    newDataTable.Columns[0].Name = "";
                    newDataTable.Columns[0].HeaderText = "";
                    newDataTable.Columns[0].ReadOnly = true;
                    newDataTable.Rows.RemoveAt(0);
                    newDataTable.Width = 773;
                    newDataTable.Height = 188;
                    newDataTable.Location = new Point(7, 23);
                    newDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    newDataTable.MultiSelect = false;
                    MCDM.GridViewDesign(newDataTable, false);
                    if (newDataTable.RowCount == MCDM.CriteriaList.Count && newDataTable.ColumnCount == MCDM.CriteriaList.Count + 1)
                    {
                        double[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        for (int i = 0; i < MCDM.CriteriaList.Count; i++)
                        {
                            newDataTable.Rows[i].Cells[i + 1].Value = 1;
                            newDataTable.Rows[i].Cells[i + 1].Style.BackColor = Color.LimeGreen;
                            newDataTable.Rows[i].Cells[i + 1].Style.ForeColor = Color.White;
                            newDataTable.Rows[i].Cells[i + 1].ReadOnly = true;
                        }
                        for (int i = 0; i < newDataTable.RowCount; i++)
                        {
                            for (int j = i + 2; j < newDataTable.ColumnCount; j++)
                            {
                                try
                                {
                                    double a = Convert.ToDouble(newDataTable.Rows[i].Cells[j].Value);
                                    for (int k = 0; k < values.Length; k++)
                                    {
                                        if (a == 1)
                                        {
                                            newDataTable.Rows[i].Cells[j].Style.BackColor = Color.LimeGreen;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Style.BackColor = Color.LimeGreen;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Value = a;
                                        }
                                        else if (a == values[k])
                                        {

                                            newDataTable.Rows[i].Cells[j].Style.BackColor = Color.DodgerBlue;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Style.BackColor = Color.OrangeRed;
                                            newDataTable.Rows[i].Cells[j].Value = a;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Value = 1 / a;
                                        }
                                        else if (a == 1 / values[k])
                                        {
                                            newDataTable.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Style.BackColor = Color.DodgerBlue;
                                            newDataTable.Rows[i].Cells[j].Value = a;
                                            newDataTable.Rows[j - 1].Cells[i + 1].Value = values[k];
                                        }
                                        newDataTable.Rows[j - 1].Cells[i + 1].Style.ForeColor = Color.White;
                                        newDataTable.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                    }
                                }
                                catch
                                {
                                    newDataTable.Rows[i].Cells[j].Value = null;
                                    newDataTable.Rows[j - 1].Cells[i + 1].Value = null;
                                }
                            }
                        }
                        RemoveCriteriaWeightingDataTable();
                        panel_CriteriaWeighting.Controls.Add(newDataTable);
                        for (int i = 0; i < panel_CriteriaWeighting.Controls.Count; i++)
                        {
                            if (panel_CriteriaWeighting.Controls[i] is DataGridView)
                                criteriaWeightsDataTable = (DataGridView)panel_CriteriaWeighting.Controls[i];
                        }
                        criteriaWeightsDataTable.CellPainting += this.CriteriaWeightsDataTable_CellPainting;
                        criteriaWeightsDataTable.CellBeginEdit += this.CriteriaWeightsDataTable_CellBeginEdit;
                        criteriaWeightsDataTable.CellEndEdit += this.CriteriaWeightsDataTable_CellEndEdit;
                        criteriaWeightsDataTable.CellValueChanged += this.CriteriaWeightsDataTable_CellValueChanged;
                        criteriaWeightsDataTable.SelectionChanged += this.CriteriaWeightsDataTable_SelectionChanged;
                    }
                    else
                    {
                        MessageBox.Show("The number of rows and columns are not equal to the number of criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                criteriaWeightsDataTable = new DataGridView();
                MessageBox.Show(error.Message, "The file could not be loaded.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
