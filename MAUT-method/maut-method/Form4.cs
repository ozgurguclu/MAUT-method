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

namespace maut_method_project
{
    public partial class Form4 : Form
    {
        public ListBox ListControl;
        public DataGridView CriteriaWeightsDataTable;
        public bool IsAlternative;
        public string Action;

        public Form4()
        {
            InitializeComponent();
        }

        private void button_AddValue_Click(object sender, EventArgs e)
        {
            AddOrEdit();
            textBox_Value.Focus();
        }

        private void textBox_Value_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddOrEdit();
                textBox_Value.Focus();
            }
        }

        private void AddOrEdit()
        {
            if (textBox_Value.Text != "")
            {
                if (Action == "add")
                    Add(textBox_Value.Text);
                else if (Action == "edit")
                    Edit(textBox_Value.Text);
            }
            else
            {
                MessageBox.Show("You can't input null value into the cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Yeni alternatif veya kriter ekleme
        private void Add(string value)
        {
            if (MCDM.MainDataTable.SelectionMode != DataGridViewSelectionMode.CellSelect)
                MCDM.MainDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            if (MCDM.MainDataTable.Columns.Count == 0)
            {
                MCDM.MainDataTable.AllowUserToAddRows = false;
                //Gridview nesnesi boş ise, yeni sütun eklenir.
                MCDM.MainDataTable.Columns.Add("A/C", "A/C");
            }
            if (IsAlternative)
            {
                MCDM.AlternativesList.Add(value);
                MCDM.MainDataTable.Rows.Add();
                MCDM.MainDataTable.Rows[MCDM.MainDataTable.RowCount - 1].Cells[0].Value = value;
                ListControl.Items.Add(value);
            }
            else
            {
                Criterion krt = new Criterion();
                krt.Name = value;
                krt.Benefit = true;
                MCDM.CriteriaList.Add(krt);
                MCDM.MainDataTable.Columns.Add(krt.Name, krt.Name);
                if (MCDM.WeightingMethod == "Simple weighting")
                {
                    CriteriaWeightsDataTable.Columns.Add(krt.Name, krt.Name);
                    if (MCDM.CriteriaList.Count == 1)
                        CriteriaWeightsDataTable.Rows.Add();
                }
                else if (MCDM.WeightingMethod == "Pairwise comparison")
                {
                    CriteriaWeightsDataTable.Columns.Add(krt.Name, krt.Name);
                    CriteriaWeightsDataTable.Rows.Add();
                    CriteriaWeightsDataTable.Rows[MCDM.CriteriaList.Count - 1].Cells[0].Value = krt.Name;
                    int cellInTheCornerRowIndex = CriteriaWeightsDataTable.RowCount - 1;
                    int cellInTheCornerColumnIndex = CriteriaWeightsDataTable.ColumnCount - 1;
                    CriteriaWeightsDataTable.Rows[cellInTheCornerRowIndex].Cells[cellInTheCornerColumnIndex].Value = 1;
                    CriteriaWeightsDataTable.Rows[cellInTheCornerRowIndex].Cells[cellInTheCornerColumnIndex].ReadOnly = true;
                }
                ListControl.Items.Add(krt.Name + " (" + krt.GetCriterionDisplay() + ")");
            }
            ListControl.SelectedIndex = ListControl.Items.Count - 1;
        }

        // Alternatif ismi veya kriter ismi düzenleme
        private void Edit(string value)
        {
            int i = ListControl.SelectedIndex;
            if (MCDM.MainDataTable.SelectionMode != DataGridViewSelectionMode.CellSelect)
                MCDM.MainDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            if (IsAlternative)
            {
                MCDM.AlternativesList[i] = value;
                MCDM.MainDataTable.Rows[i].Cells[0].Value = value;
                ListControl.Items[i] = value;
            }
            else
            {
                MCDM.CriteriaList[i].Name = value;
                MCDM.MainDataTable.Columns[i + 1].Name = value;
                MCDM.MainDataTable.Columns[i + 1].HeaderText = value;
                if (MCDM.WeightingMethod == "Simple weighting")
                {
                    CriteriaWeightsDataTable.Columns[i].Name = value;
                    CriteriaWeightsDataTable.Columns[i].HeaderText = value;
                }
                else if (MCDM.WeightingMethod == "Pairwise comparison")
                {
                    CriteriaWeightsDataTable.Columns[i + 1].Name = value;
                    CriteriaWeightsDataTable.Columns[i + 1].HeaderText = value;
                    CriteriaWeightsDataTable.Rows[i].Cells[0].Value = value;
                }
                ListControl.Items[i] = MCDM.CriteriaList[i].Name + " (" + MCDM.CriteriaList[i].GetCriterionDisplay() + ")";
            }
            ListControl.SelectedIndex = i;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Action == "edit")
            {
                if(IsAlternative)
                    textBox_Value.Text = MCDM.AlternativesList[ListControl.SelectedIndex].ToString();
                else
                    textBox_Value.Text = MCDM.CriteriaList[ListControl.SelectedIndex].Name;
                button_AddValue.Text = "Rename";
            }
        }
    }
}
