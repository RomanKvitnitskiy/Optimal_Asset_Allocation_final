using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimal_Asset_Allocation_final
{
    public partial class Form1 : Form
    {
        int factCount;
        int varCount;
        int moneyCount;
        string[] plan;
        string[] newPlan;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) // основний розрахунок
        {
            try
            {
                int[] attachments = new int[varCount]; //Варианты вложений
                double[] Fn = new double[varCount]; // введенные значения предприятий
                double[] fn = new double[varCount]; //функции предприятий 
                double[,] plus = new double[varCount, varCount];

                plan = new string[varCount];
                newPlan = new string[varCount];

                for (int i = 0; i < attachments.Length; i++) //запись вариантов вложений
                    attachments[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);

                for (int i = 0; i < varCount; i++) //запись начального Fn
                    Fn[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);

                for (int fact = 0; fact < factCount - 1; fact++) //итерации вычислениый
                {

                    for (int i = 0; i < varCount; i++) //запись начального fn
                        fn[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[fact + 2].Value);

                    for (int i = 0; i < varCount; i++) //сложение элементов на пересечении 
                        for (int j = 0; j < varCount; j++)
                            if (attachments[varCount - 1] >= (attachments[i] + attachments[j])) plus[i, j] = fn[i] + Fn[j];

                    Array.Copy(newPlan, plan, plan.Length);

                    for (int var = 0; var < varCount; var++)
                    {
                        int variant = attachments[var];
                        double max = 0;
                        int x = 0, y = 0;

                        for (int i = 0; i < varCount; i++)
                            for (int j = 0; j < varCount; j++)
                                if (attachments[j] + attachments[i] == variant && plus[i, j] > max)
                                {
                                    max = plus[i, j];
                                    x = i;
                                    y = j;
                                }

                        Fn[var] = plus[x, y];

                        if (fact == 0)
                            newPlan[var] = attachments[y].ToString() + " " + attachments[x].ToString();
                        else
                            newPlan[var] = plan[y] + " " + attachments[x].ToString();
                    }
                }

                double max1 = 0;
                int x1 = 0;

                string res = "";

                for (int i = 0; i < varCount; i++)
                    if (Fn[i] > max1)
                    {
                        max1 = Fn[i];
                        x1 = i;
                    }

                int kolRes = 0;

                for (int i = 0; i < dataGridView.RowCount; i++)
                    if (Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value) != 0) kolRes++;

                res = "Найбільший пріріст, при " + Convert.ToString(kolRes) + " варіантів кладення між " + factCount.ToString();

                if (factCount <= 4)
                    res += " -ма підприємствами, складе " + Fn[x1].ToString() + "\n";
                else
                    res += " -ю підприємствами, складе " + Fn[x1].ToString() + "\n";
                for (int i = 0; i < factCount; i++)
                    res += (i + 1).ToString() + "-му підприємству виділити " + newPlan[x1].Split(' ')[i] + "\n";
                MessageBox.Show(res, "Відповідь", MessageBoxButtons.OK);
            }
            catch (Exception) { }
        }

        private void btnTable_Click(object sender, EventArgs e) // створення таблиці
        {
            if (nEnt.Value > 1) btnStart.Enabled = true;
            else btnStart.Enabled = false;

            int moneyPart = 0;

            try
            {
                factCount = Convert.ToInt32(nEnt.Value);
                varCount = (Convert.ToInt32(nAtt.Value) + 1);

                if (money.Text == "") moneyPart = 1;
                else
                {
                    moneyCount = Convert.ToInt32(money.Text);
                    moneyPart = moneyCount / (varCount - 1);
                }

                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "Вкладені кошти";
                dataGridView.Columns.Add(col1);

                for (int i = 1; i < factCount + 1; i++)
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = "Підпр." + i.ToString();
                    dataGridView.Columns.Add(col);
                }

                for (int i = 0; i < varCount; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridView.Rows.Add(row);
                    dataGridView.Rows[i].Cells[0].Value = (i * moneyPart).ToString();
                }

            }
            catch (Exception ex) { System.Console.WriteLine(ex.Data.ToString()); }
            foreach (DataGridViewColumn column in dataGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно хочете вийти з програми?",
             "Завершення програми",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;

            if (dataGridView.CurrentCell.ColumnIndex >= 0)
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            else
                tb.KeyPress -= tb_KeyPress;
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',')))
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete)) e.Handled = true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void money_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nEnt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nAtt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
