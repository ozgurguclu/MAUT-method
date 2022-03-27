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
    public partial class Form3 : Form
    {
        public Form ReferenceForm_Form2 { get; set; }
        private DataGridView clone_MainDataTable;
        public DataGridView Clone_CriteriaWeightsDataTable;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowMainDataTable();
            comboBox_CellSelection.SelectedIndex = 0;
            comboBox_CellSelection.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ReferenceForm_Form2 != null)
                this.ReferenceForm_Form2.Show();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            CheckInfoAndContinue();
        }

        //  Hücreler kontrol edildikten sonra bir hata yoksa bir sonraki forma geçilir
        private void CheckInfoAndContinue()
        {
            if (MCDM.CheckMainDataTableCells())
            {
                if (MCDM.CheckSumOfWeightsOfCriteria(Clone_CriteriaWeightsDataTable))
                {
                    Form5 a = new Form5();
                    a.ReferenceForm_Form2 = this.ReferenceForm_Form2;
                    a.PairwiseComparisonMatrix = Clone_CriteriaWeightsDataTable;
                    MCDM.MainDataTable = clone_MainDataTable;
                    a.Show();
                    this.ReferenceForm_Form2 = null;
                    this.Close();
                }
            }
        }

        //  Karar matrisi tablosunu kullanıcıya gösterilmek üzere burada oluşturur
        private void ShowMainDataTable()
        {
            MCDM.MainDataTable.Width = 766;
            MCDM.MainDataTable.Height = 325;
            MCDM.MainDataTable.Location = new Point(7, 7);
            MCDM.GridViewDesign(MCDM.MainDataTable, false);
            MCDM.MainDataTable.MultiSelect = false;
            MCDM.MainDataTable.Columns[0].ReadOnly = true;
            panel_DecisionMatrix.Controls.Add(MCDM.MainDataTable);
            clone_MainDataTable = (DataGridView)panel_DecisionMatrix.Controls[0];
            clone_MainDataTable.CellClick += this.DataGridView_CellClick;
            clone_MainDataTable.CellDoubleClick += this.DataGridView_CellDoubleClick;
            clone_MainDataTable.CellBeginEdit += this.DataGridView_CellBeginEdit;
            clone_MainDataTable.CellEndEdit += this.DataGridView_CellEndEdit;
            clone_MainDataTable.CellValueChanged += this.DataGridView_CellValueChanged;
            clone_MainDataTable.SelectionChanged += this.DataGridView_SelectionChanged;
        }

        //  Seçilen indise göre veri tablosunda hücre seçimi yapılması
        private void comboBox_CellSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_CellValue.Text = "";
            if (comboBox_CellSelection.SelectedIndex == 0)
            {
                clone_MainDataTable.MultiSelect = false;
                clone_MainDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            else if (comboBox_CellSelection.SelectedIndex == 1)
            {
                clone_MainDataTable.MultiSelect = true;
                clone_MainDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SelectAllCells();
            }
            else if (comboBox_CellSelection.SelectedIndex == 2)
            {
                clone_MainDataTable.MultiSelect = false;
                clone_MainDataTable.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            }
            else if (comboBox_CellSelection.SelectedIndex == 3)
            {
                clone_MainDataTable.MultiSelect = false;
                clone_MainDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        //  Alternatifler sütunu ve kriterler satırı hariç tüm hücreleri seçer
        private void SelectAllCells()
        {
            for (int i = 0; i < clone_MainDataTable.RowCount; i++)
            {
                for (int j = 1; j < clone_MainDataTable.ColumnCount; j++)
                {
                    clone_MainDataTable.Rows[i].Cells[j].Selected = true;
                }
            }
            textBox_CellName.Text = "All of cells";
        }

        /*  Tüm hücreleri seçme işlemi seçildi ise herhangi bir hücreye tıklandığında
            tekrar tüm hücreleri seçer
        */
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_CellValue.Text = "";
            if (comboBox_CellSelection.SelectedIndex == 0 && clone_MainDataTable.SelectedCells.Count == 1)
            {
                if (clone_MainDataTable.SelectedCells[0].Value == null)
                    textBox_CellValue.Text = "";
                else
                    textBox_CellValue.Text = clone_MainDataTable.SelectedCells[0].Value.ToString();
                try
                {
                    textBox_CellName.Text = clone_MainDataTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper()
                    + " / " + clone_MainDataTable.Columns[e.ColumnIndex].Name.ToUpper();
                }
                catch { }
            }
            else if (comboBox_CellSelection.SelectedIndex == 1)
            {
                SelectAllCells();
            }
            else if (comboBox_CellSelection.SelectedIndex == 2 && clone_MainDataTable.SelectedColumns.Count == 1)
            {
                textBox_CellName.Text = clone_MainDataTable.Columns[e.ColumnIndex].Name.ToUpper();
            }
            else if (comboBox_CellSelection.SelectedIndex == 3 && clone_MainDataTable.SelectedRows.Count == 1)
            {
                textBox_CellName.Text = clone_MainDataTable.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            }
            else
                textBox_CellName.Text = "";
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_CellSelection.SelectedIndex == 1)
                SelectAllCells();
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(50, 50, 50);
            clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = SystemColors.ControlText;
        }

        //  Hücre içinde yazı yazıldığında eğer yazı bir sayı değilse hücreye null değeri atar
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                try
                {
                    double a = double.Parse(clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = a;
                }
                catch
                {
                    clone_MainDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
            }
        }

        /*      Tek hücre veya tüm hücreler seçilecekse bunların arasından alternatif ve kriterlerin
            bulunduğu hücreler seçimden kaldırılır
        */
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (comboBox_CellSelection.SelectedIndex == 0 || comboBox_CellSelection.SelectedIndex == 1)
            {
                if (clone_MainDataTable.SelectedCells.Count > 0 && clone_MainDataTable.SelectedCells[0].ColumnIndex == 0)
                    clone_MainDataTable.SelectedCells[0].Selected = false;
            }
            if (clone_MainDataTable.Columns[0].Selected)
                clone_MainDataTable.Columns[0].Selected = false;
        }

        /*  Textbox_deger üzerinde ENTER tuşuna basıldığında,
            veri tablosunda neyin seçildiğini kontrol edip ona göre işlem yapar
        */
        private void textBox_CellValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clone_MainDataTable.SelectionMode == DataGridViewSelectionMode.CellSelect)
                {
                    if (clone_MainDataTable.SelectedCells.Count == 0)
                    {
                        MessageBox.Show("Please select a cell to enter a value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (clone_MainDataTable.SelectedCells.Count == 1)
                    {
                        AddValue("one cell");
                    }
                    else
                    {
                        AddValue("all cells");
                    }
                }
                else if (clone_MainDataTable.SelectionMode == DataGridViewSelectionMode.FullColumnSelect)
                {
                    if (clone_MainDataTable.SelectedColumns.Count == 0)
                    {
                        MessageBox.Show("Please select a column to enter a value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AddValue("one column");
                    }
                }
                else
                {
                    if (clone_MainDataTable.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Please select a row to enter a value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AddValue("one row");
                    }
                }
            }
        }

        //  Textbox_deger nesnesinden alınan değeri veri tablosundaki boş hücrelere ekleme işlemi
        private void AddValue(string control)
        {
            try
            {
                object deger;
                if (textBox_CellValue.Text == "")
                    deger = textBox_CellValue.Text;
                else
                    deger = double.Parse(textBox_CellValue.Text);
                if (control == "one cell")
                {
                    clone_MainDataTable.SelectedCells[0].Value = deger;
                }
                else if (control == "all cells")
                {
                    for (int i = 0; i < clone_MainDataTable.RowCount; i++)
                    {
                        for (int j = 1; j < clone_MainDataTable.ColumnCount; j++)
                        {
                            if (clone_MainDataTable.Rows[i].Cells[j].Value == null)
                                clone_MainDataTable.Rows[i].Cells[j].Value = deger;
                        }
                    }
                }
                else if (control == "one column")
                {
                    for (int i = 0; i < clone_MainDataTable.RowCount; i++)
                    {
                        if (clone_MainDataTable.Rows[i].Cells[clone_MainDataTable.SelectedColumns[0].Index].Value == null)
                            clone_MainDataTable.Rows[i].Cells[clone_MainDataTable.SelectedColumns[0].Index].Value = deger;
                        else if(string.IsNullOrEmpty(clone_MainDataTable.Rows[i].Cells[clone_MainDataTable.SelectedColumns[0].Index].Value.ToString()))
                            clone_MainDataTable.Rows[i].Cells[clone_MainDataTable.SelectedColumns[0].Index].Value = deger;
                    }
                }
                else if (control == "one row")
                {
                    for (int i = 1; i < clone_MainDataTable.ColumnCount; i++)
                    {
                        if (clone_MainDataTable.Rows[clone_MainDataTable.SelectedRows[0].Index].Cells[i].Value == null)
                            clone_MainDataTable.Rows[clone_MainDataTable.SelectedRows[0].Index].Cells[i].Value = deger;
                        else if (string.IsNullOrEmpty(clone_MainDataTable.Rows[clone_MainDataTable.SelectedRows[0].Index].Cells[i].Value.ToString()))
                            clone_MainDataTable.Rows[clone_MainDataTable.SelectedRows[0].Index].Cells[i].Value = deger;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Do not enter characters other than numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /*  Tekil hücreler için silme,kesme,kopyalama,yapıştırma işlemleri
          Satır veya sütun içindeki verileri silme işlemleri(Alternatif veya kriter ismini silmez)
        */
        private void CellValueSelection(string action)
        {
            if (clone_MainDataTable.SelectedCells.Count == 1)
            {
                if (action == "delete")
                {
                    clone_MainDataTable.SelectedCells[0].Value = null;
                }
                else if (action == "copy")
                {
                    try
                    {
                        Clipboard.SetText(clone_MainDataTable.SelectedCells[0].Value.ToString());
                    }
                    catch
                    {
                        return;
                    }

                }
                else if (action == "cut")
                {
                    try
                    {
                        Clipboard.SetText(clone_MainDataTable.SelectedCells[0].Value.ToString());
                        clone_MainDataTable.SelectedCells[0].Value = null;
                    }
                    catch
                    {
                        return;
                    }
                }
                else if (action == "paste")
                {
                    try
                    {
                        double a = double.Parse(Clipboard.GetText());
                        clone_MainDataTable.SelectedCells[0].Value = a;
                    }
                    catch
                    {
                        MessageBox.Show("Do not enter characters other than numeric.", "Warning", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else if (clone_MainDataTable.SelectedColumns.Count == 1)
            {
                if (action == "delete column values")
                {
                    for (int i = 0; i < clone_MainDataTable.RowCount; i++)
                    {
                        clone_MainDataTable.Rows[i].Cells[clone_MainDataTable.SelectedCells[0].ColumnIndex].Value = null;
                    }
                }
            }
            else if (clone_MainDataTable.SelectedRows.Count == 1)
            {
                if (action == "delete row values")
                {
                    for (int i = 1; i < clone_MainDataTable.ColumnCount; i++)
                    {
                        clone_MainDataTable.Rows[clone_MainDataTable.SelectedCells[0].RowIndex].Cells[i].Value = null;
                    }
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            CellValueSelection("delete");
        }

        private void button_Cut_Click(object sender, EventArgs e)
        {
            CellValueSelection("cut");
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            CellValueSelection("copy");
        }

        private void button_Paste_Click(object sender, EventArgs e)
        {
            CellValueSelection("paste");
        }

        private void button_DeleteValuesByColumn_Click(object sender, EventArgs e)
        {
            CellValueSelection("delete column values");
        }

        private void button_DeleteValuesByRow_Click(object sender, EventArgs e)
        {
            CellValueSelection("delete row values");
        }

        private void comboBox_CellSelection_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                  new SolidBrush(SystemColors.ControlText),
                                  new Point(e.Bounds.X, e.Bounds.Y));
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor), e.Bounds);
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                  new SolidBrush(combo.ForeColor),
                                  new Point(e.Bounds.X, e.Bounds.Y));
            }
            e.DrawFocusRectangle();
        }

        private void comboBox_CellSelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel_DecisionMatrix.Focus();
        }
    }
}
