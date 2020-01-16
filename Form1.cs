using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DZ2
{
    public partial class Form1 : Form
    {

        Him H = new Him();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grafick.Parent = null;
            _predel_B1.Text = "15";
            H._predel_B1= 15d;
            _predel_B2.Text = "17";
            H._predel_B2 = 17d;
            _predel_B3.Text = "15";
            H._predel_B1 = 15d;
            kol_A1_B1.Text = "20";
            H.kol_A1_B1 = 20d;
            kol_A1_B2.Text = "16";
            H.kol_A1_B1 = 16d;
            kol_A1_B3.Text = "15";
            H.kol_A1_B3 = 15d;
            kol_A2_B1.Text = "30";
            H.kol_A2_B1 = 30d;
            kol_A2_B2.Text = "20";
            H.kol_A2_B2 = 20d;
            kol_A2_B3.Text = "10";
            H.kol_A2_B3 = 10d;
            kol_A3_B1.Text = "10";
            H.kol_A3_B1 = 10d;
            H.X1 = 1.0625d;
            H.X2 = 0d;
            H.X3 = 0d;
            kol_A3_B2.Text = "18";
            H.kol_A3_B2 = 18d;
            kol_A3_B3.Text = "20";
            H.kol_A3_B3 = 20d;
            sto_A1.Text = "10";
            H.sto_A1 = 10d;
            sto_A2.Text = "20";
            H.sto_A2 = 20d;
            sto_A3.Text = "30";
            H.sto_A3 = 30d;
      
        }

        private void Raschot_Click(object sender, EventArgs e)
        {
            if(
            #region---
               (_predel_B1.Text == "") ||
               (_predel_B2.Text == "") ||
               (_predel_B3.Text == "") ||
               (kol_A1_B1.Text == "") ||
               (kol_A1_B2.Text == "") ||
               (kol_A1_B3.Text == "") ||
               (kol_A2_B1.Text == "") ||
               (kol_A2_B2.Text == "") ||
               (kol_A2_B3.Text == "") ||
               (kol_A3_B1.Text == "") ||
               (kol_A3_B2.Text == "") ||
               (kol_A3_B3.Text == "") ||
               (sto_A1.Text == "") ||
               (sto_A2.Text == "") ||
               (sto_A3.Text == ""))
            #endregion---
            {
                Grafick.Parent = null;
                MessageBox.Show("Не все поля заполнены!", "Ошибка");
                return;
            }
            else
            {
                Grafick.Parent = tabControl1;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                H._predel_B1 = Double.Parse(_predel_B1.Text);
                H._predel_B2 = Double.Parse(_predel_B2.Text);
                H._predel_B3 = Double.Parse(_predel_B3.Text);
                H.kol_A1_B1 = Double.Parse(kol_A1_B1.Text);
                H.kol_A1_B2 = Double.Parse(kol_A1_B2.Text);
                H.kol_A1_B3 = Double.Parse(kol_A1_B3.Text);
                H.kol_A2_B1 = Double.Parse(kol_A2_B1.Text);
                H.kol_A2_B2 = Double.Parse(kol_A2_B2.Text);
                H.kol_A2_B3 = Double.Parse(kol_A2_B3.Text);
                H.kol_A3_B1 = Double.Parse(kol_A3_B1.Text);
                H.kol_A3_B2 = Double.Parse(kol_A3_B2.Text);
                H.kol_A3_B3 = Double.Parse(kol_A3_B3.Text);
                H.sto_A1 = Double.Parse(sto_A1.Text);
                H.sto_A2 = Double.Parse(sto_A2.Text);
                H.sto_A3 = Double.Parse(sto_A3.Text);

                List<SolverRow> solverList = new List<SolverRow>();
                solverList.Add(new SolverRow { xId = 1, Koef = H.X1 });
                solverList.Add(new SolverRow { xId = 2, Koef = H.X2 });
                solverList.Add(new SolverRow { xId = 3, Koef = H.X3 });

                SolverContext context = SolverContext.GetContext();
                Model model = context.CreateModel();
                Set users = new Set(Domain.Any, "users");

                Parameter Koef = new Parameter(Domain.Real, "Koef", users);
                Koef.SetBinding(solverList, "Koef", "xId");
                model.AddParameter(Koef);

                Decision choose = new Decision(Domain.RealNonnegative, "choose", users);
                model.AddDecisions(choose);
                model.AddGoal("goal", GoalKind.Minimize, Model.Sum(Model.ForEach(users, xId => choose[xId] * Koef[xId])));

                model.AddConstraint("OgranT1", Model.Sum(Model.ForEach(users, xId => H.kol_A1_B1 * H.X1 + H.kol_A2_B1 * H.X2 + H.kol_A3_B1 * H.X3)) <= H._predel_B1);
                model.AddConstraint("OgranT2", Model.Sum(Model.ForEach(users, xId => H.kol_A1_B2 * H.X1 + H.kol_A2_B2 * H.X2 + H.kol_A3_B2 * H.X3)) <= H._predel_B2);
                model.AddConstraint("OgranT3", Model.Sum(Model.ForEach(users, xId => H.kol_A1_B3 * H.X1 + H.kol_A2_B3 * H.X2 + H.kol_A3_B3 * H.X3)) <= H._predel_B3);

                try
                {

                    Solution solution = context.Solve();
                    Report report = solution.GetReport();

                    String reportStr = "";

                    for (int i = 0; i < solverList.Count; i++)
                    {
                        reportStr += "Значение X" + (i + 1).ToString() + ": " + choose.GetDouble(solverList[i].xId) + "\n";
                    }
                    reportStr += "\n" + report.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При решении задачи оптимизации возникла исключительная ситуация.");
                }

                double X1 = Math.Round(choose.GetDouble(solverList[0].xId), 3);
                double X2 = Math.Round(choose.GetDouble(solverList[1].xId), 3);
                double X3 = Math.Round(choose.GetDouble(solverList[2].xId), 3);

                this.chart1.Series[0].Points.AddXY("", H.X1);
                this.chart1.Series[1].Points.AddXY("", H.X2);
                this.chart1.Series[2].Points.AddXY("", H.X3);

                dataGridView1.Rows.Add(H.X1, H.X2, H.X3);

               



            }
        }
    }
}
