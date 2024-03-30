using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace пр12
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddFraction_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumerator.Text, out int numerator) && int.TryParse(textBoxDenominator.Text, out int denominator))
            {
                dataGridView1.Rows.Add(numerator, denominator);
            }
            else
            {
                MessageBox.Show("Неверный формат числителя или знаменателя.");
            }
        }

        private void ButtonProcessFractions_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    string numerator = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string denominator = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    if (IsImproperFraction(numerator, denominator))
                    {
                        int num = int.Parse(numerator);
                        int den = int.Parse(denominator);

                        int wholePart = num / den;
                        int newNumerator = num % den;

                        if (newNumerator != 0) 
                        {
                            dataGridView2.Rows.Add(wholePart, newNumerator, den);

                            dataGridView1.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        private bool IsImproperFraction(string numeratorStr, string denominatorStr)
        {
            if (int.TryParse(numeratorStr, out int numerator) && int.TryParse(denominatorStr, out int denominator))
            {
                return numerator >= denominator;
            }
            return false;
        }

        private void ButtonSortDescending_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Descending);
            dataGridView2.Sort(dataGridView2.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }



    }
}