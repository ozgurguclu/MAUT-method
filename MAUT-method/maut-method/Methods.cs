using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace maut_method_project
{
    class Methods
    {
        private static Dictionary<int, double> theHighestValuesInTheCriteria;
        private static Dictionary<int, double> theLowestValuesInTheCriteria;

        public static DataGridView ShowWeightsOfCriteria()
        {
            DataGridView newDataTable = new DataGridView();
            newDataTable.ColumnCount = MCDM.CriteriaList.Count;
            newDataTable.Rows.Add();
            for (int i = 0; i < MCDM.CriteriaList.Count; i++)
            {
                newDataTable.Columns[i].Name = MCDM.CriteriaList[i].Name;
                newDataTable.Rows[0].Cells[i].Value = MCDM.CriteriaList[i].Weight;
            }
            return newDataTable;
        }

        public static DataGridView FindMaxAndMinValuesInTheCriteria(DataGridView table)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(table, newDataTable, true);
            newDataTable.Columns[0].Name = "Xij";
            theHighestValuesInTheCriteria = new Dictionary<int, double>();
            theLowestValuesInTheCriteria = new Dictionary<int, double>();
            double highestValue = 0;
            double lowestValue = 0;
            for (int i = 1; i < newDataTable.ColumnCount; i++)
            {
                for (int j = 0; j < newDataTable.RowCount; j++)
                {
                    double currentValue = double.Parse(newDataTable.Rows[j].Cells[i].Value.ToString());
                    if (j == 0)
                    {
                        highestValue = double.Parse(newDataTable.Rows[j].Cells[i].Value.ToString());
                        lowestValue = double.Parse(newDataTable.Rows[j].Cells[i].Value.ToString());
                    }
                    if (lowestValue > currentValue)
                    {
                        lowestValue = currentValue;
                    }
                    if (highestValue < currentValue)
                    {
                        highestValue = currentValue;
                    }
                    if (theHighestValuesInTheCriteria.ContainsKey(i))
                        theHighestValuesInTheCriteria[i] = highestValue;
                    else
                        theHighestValuesInTheCriteria.Add(i, highestValue);
                    if (theLowestValuesInTheCriteria.ContainsKey(i))
                        theLowestValuesInTheCriteria[i] = lowestValue;
                    else
                        theLowestValuesInTheCriteria.Add(i, lowestValue);
                }
                highestValue = 0;
                lowestValue = 0;
            }
            for (int i = 1; i < newDataTable.ColumnCount; i++)
            {
                for (int j = 0; j < newDataTable.RowCount; j++)
                {
                    DataGridViewCell dvc = newDataTable.Rows[j].Cells[i];
                    if (double.Parse(dvc.Value.ToString()) == theHighestValuesInTheCriteria[i])
                    {
                        dvc.Style.BackColor = Color.LimeGreen;
                        dvc.Style.ForeColor = Color.White;
                        dvc.Style.Font = new Font(newDataTable.Font, FontStyle.Bold);
                    }
                    else if (double.Parse(dvc.Value.ToString()) == theLowestValuesInTheCriteria[i])
                    {
                        dvc.Style.BackColor = Color.Red;
                        dvc.Style.ForeColor = Color.White;
                        dvc.Style.Font = new Font(newDataTable.Font, FontStyle.Bold);
                    }
                    else
                    {
                        dvc.Style.BackColor = Color.White;
                        dvc.Style.ForeColor = Color.Black;
                        dvc.Style.Font = new Font(newDataTable.Font, FontStyle.Regular);
                    }
                }
            }
            return newDataTable;
        }

        public static DataGridView NormalizeDataWithLinearMaxMinTechnique(DataGridView table)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(table, newDataTable, true);
            newDataTable.Columns[0].Name = "Yij";
            for (int i = 1; i < newDataTable.ColumnCount; i++)
            {
                for (int j = 0; j < newDataTable.RowCount; j++)
                {
                    if (MCDM.CriteriaList[i - 1].Benefit == true)
                        newDataTable.Rows[j].Cells[i].Value =
                            (Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) - theLowestValuesInTheCriteria[i]) /
                            (theHighestValuesInTheCriteria[i] - theLowestValuesInTheCriteria[i]);
                    else
                        newDataTable.Rows[j].Cells[i].Value =
                            (theHighestValuesInTheCriteria[i] - Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)) /
                            (theHighestValuesInTheCriteria[i] - theLowestValuesInTheCriteria[i]);
                    if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                        newDataTable.Rows[j].Cells[i].Value = 0;
                }
            }
            return newDataTable;
        }

        public static DataGridView CalculateBenefitsWithMAUT(DataGridView normalizedDataTable)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(normalizedDataTable, newDataTable, true);
            newDataTable.Columns[0].Name = "Yij.Wj";
            newDataTable.Columns.Add("Total Benefit", "Total Benefit");
            newDataTable.Columns[newDataTable.ColumnCount - 1].DefaultCellStyle.Font = new Font(newDataTable.DefaultCellStyle.Font, FontStyle.Bold);
            double totalUtiltiyValue;
            for (int i = 0; i < normalizedDataTable.RowCount; i++)
            {
                totalUtiltiyValue = 0;
                for (int j = 1; j < normalizedDataTable.ColumnCount; j++)
                {
                    double currentBenefitValue = MCDM.CriteriaList[j - 1].Weight * Convert.ToDouble(normalizedDataTable.Rows[i].Cells[j].Value);
                    totalUtiltiyValue += currentBenefitValue;
                    newDataTable.Rows[i].Cells[j].Value = currentBenefitValue;
                    if (j == normalizedDataTable.ColumnCount - 1)
                        newDataTable.Rows[i].Cells[newDataTable.ColumnCount - 1].Value = totalUtiltiyValue;
                }
            }
            return newDataTable;
        }

        public static DataGridView SortAlternatives(DataGridView calculatedBenefitsDataTable)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(calculatedBenefitsDataTable, newDataTable, true);
            int a = newDataTable.ColumnCount - 1;
            for (int i = 1; i < a; i++)
            {
                newDataTable.Columns.RemoveAt(i);
                i = i - 1;
                a--;
            }
            newDataTable.Columns[0].Name = "Alternative";
            newDataTable.Sort(newDataTable.Columns[newDataTable.ColumnCount - 1], ListSortDirection.Descending);
            return newDataTable;
        }

        public static DataGridView NormalizeDataForEntropy(DataGridView dataTable, string normalizationMethod)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(dataTable, newDataTable, true);
            newDataTable.Columns[0].Name = "Yij";
            for (int i = 1; i < newDataTable.ColumnCount; i++)
            {
                if (normalizationMethod == "Direct Calculation")
                {
                    double sumXj = 0;
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        sumXj += Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value);
                    }
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        newDataTable.Rows[j].Cells[i].Value = Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / sumXj;
                        if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                            newDataTable.Rows[j].Cells[i].Value = 0;
                    }
                }
                else if (normalizationMethod == "Max")
                {
                    double sumRj = 0;
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        if (MCDM.CriteriaList[i - 1].Benefit == true)
                            newDataTable.Rows[j].Cells[i].Value = Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / theHighestValuesInTheCriteria[i];
                        else
                            newDataTable.Rows[j].Cells[i].Value = 1 - Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / theHighestValuesInTheCriteria[i];
                        if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                            newDataTable.Rows[j].Cells[i].Value = 0;
                        sumRj += Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value);
                    }
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        newDataTable.Rows[j].Cells[i].Value = Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / sumRj;
                        if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                            newDataTable.Rows[j].Cells[i].Value = 0;
                    }
                }
                else if (normalizationMethod == "Max-Min")
                {
                    double sumRj = 0;
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        if (MCDM.CriteriaList[i - 1].Benefit == true)
                            newDataTable.Rows[j].Cells[i].Value =
                                (Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) - theLowestValuesInTheCriteria[i]) /
                                (theHighestValuesInTheCriteria[i] - theLowestValuesInTheCriteria[i]);
                        else
                            newDataTable.Rows[j].Cells[i].Value =
                                (theHighestValuesInTheCriteria[i] - Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)) /
                                (theHighestValuesInTheCriteria[i] - theLowestValuesInTheCriteria[i]);
                        if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                            newDataTable.Rows[j].Cells[i].Value = 0;
                        sumRj += Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value);
                    }
                    for (int j = 0; j < newDataTable.RowCount; j++)
                    {
                        newDataTable.Rows[j].Cells[i].Value = Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / sumRj;
                        if (double.IsNaN(Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value)))
                            newDataTable.Rows[j].Cells[i].Value = 0;
                    }
                }
            }
            return newDataTable;
        }

        public static DataGridView CalculateLogarithmValuesForEntropy(DataGridView normalizedDataTableForEntropy)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(normalizedDataTableForEntropy, newDataTable, true);
            newDataTable.Columns[0].Name = "Yij.ln(Yij)";
            for (int i = 0; i < newDataTable.RowCount; i++)
            {
                for (int j = 1; j < newDataTable.ColumnCount; j++)
                {
                    double pij = Convert.ToDouble(newDataTable.Rows[i].Cells[j].Value);
                    if (pij != 0)
                        newDataTable.Rows[i].Cells[j].Value = pij * Math.Log(pij);
                }
            }
            return newDataTable;
        }

        public static DataGridView CalculateEntropyValues(DataGridView entropyLogDataTable)
        {
            DataGridView newDataTable = new DataGridView();
            for (int i = 0; i < MCDM.CriteriaList.Count; i++)
            {
                newDataTable.Columns.Add(MCDM.CriteriaList[i].Name, MCDM.CriteriaList[i].Name);
            }
            newDataTable.Rows.Add();
            double k = 1 / Math.Log(MCDM.AlternativesList.Count);
            double Dj = 0;
            for (int i = 1; i < entropyLogDataTable.ColumnCount; i++)
            {
                double sumLog = 0;
                for (int j = 0; j < entropyLogDataTable.RowCount; j++)
                {
                    sumLog += Convert.ToDouble(entropyLogDataTable.Rows[j].Cells[i].Value);
                }
                double Ej = -k * sumLog;
                Dj += 1 - Ej;
                newDataTable.Rows[0].Cells[i - 1].Value = Ej;
            }
            for (int i = 0; i < newDataTable.ColumnCount; i++)
            {
                double Wj = (1 - Convert.ToDouble(newDataTable.Rows[0].Cells[i].Value)) / Dj;
                if (Wj < 0)
                    Wj = 0;
                MCDM.CriteriaList[i].Weight = Wj;
            }
            return newDataTable;
        }

        public static DataGridView ShowPairwiseComparisonData(DataGridView dataTable)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(dataTable, newDataTable, true);
            newDataTable.Columns[0].Name = "Xij";
            return newDataTable;
        }

        public static DataGridView NormalizeDataForPairWiseComparison(DataGridView dataTable)
        {
            DataGridView newDataTable = new DataGridView();
            MCDM.CopyDataTable(dataTable, newDataTable, true);
            newDataTable.Columns[0].Name = "Yij";
            for (int i = 1; i < newDataTable.ColumnCount; i++)
            {
                double sumAj = 0;
                for (int j = 0; j < newDataTable.RowCount; j++)
                {
                    sumAj += Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value);
                }
                for (int j = 0; j < newDataTable.RowCount; j++)
                {
                    newDataTable.Rows[j].Cells[i].Value = Convert.ToDouble(newDataTable.Rows[j].Cells[i].Value) / sumAj;
                }
            }
            newDataTable.Columns.Add("Average weight", "Average weight");
            newDataTable.Columns[newDataTable.ColumnCount - 1].DefaultCellStyle.Font = new Font(newDataTable.DefaultCellStyle.Font, FontStyle.Bold);
            for (int i = 0; i < newDataTable.RowCount; i++)
            {
                double sumBj = 0;
                for (int j = 1; j < newDataTable.ColumnCount - 1; j++)
                {
                    sumBj += Convert.ToDouble(newDataTable.Rows[i].Cells[j].Value);
                }
                double Wj = sumBj / MCDM.CriteriaList.Count;
                newDataTable.Rows[i].Cells[newDataTable.ColumnCount - 1].Value = Wj;
                MCDM.CriteriaList[i].Weight = Wj;
            }
            return newDataTable;
        }

        public static DataGridView CalculatePriorityVectorForPairwiseComparison(DataGridView normalizedDataTable)
        {
            DataGridView newDataTable = new DataGridView();
            newDataTable.AllowUserToAddRows = false;
            int numberOfCriteria = MCDM.CriteriaList.Count;
            newDataTable.ColumnCount = 1;
            newDataTable.RowCount = numberOfCriteria;
            newDataTable.Columns[0].Name = "[Xij].[Wj] Multiplying Matrices";
            double[] priorityVector = new double[numberOfCriteria];
            for (int i = 0; i < normalizedDataTable.RowCount; i++)
            {
                for (int j = 1; j < normalizedDataTable.ColumnCount; j++)
                {
                    priorityVector[i] += Convert.ToDouble(normalizedDataTable.Rows[i].Cells[j].Value) * MCDM.CriteriaList[j - 1].Weight;
                }
            }
            for (int i = 0; i < numberOfCriteria; i++)
            {
                newDataTable.Rows[i].Cells[0].Value = priorityVector[i];
            }
            return newDataTable;
        }

        public static DataGridView ShowPairwiseComparisonConsistencyValues()
        {
            DataGridView newDataTable = new DataGridView();
            newDataTable.ColumnCount = 4;
            newDataTable.Rows.Add();
            newDataTable.Columns[0].Name = "LambdaMax";
            newDataTable.Columns[1].Name = "CI";
            newDataTable.Columns[2].Name = "RI";
            newDataTable.Columns[3].Name = "CR";
            for (int i = 0; i < 4; i++)
            {
                newDataTable.Rows[0].Cells[i].Value = MCDM.PairwiseComparisonConsistencyValues[i];
            }
            return newDataTable;
        }
    }
}
