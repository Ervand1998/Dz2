namespace DZ2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Vhodnie_danie = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sto_A3 = new System.Windows.Forms.TextBox();
            this.kol_A3_B3 = new System.Windows.Forms.TextBox();
            this.kol_A3_B2 = new System.Windows.Forms.TextBox();
            this.kol_A3_B1 = new System.Windows.Forms.TextBox();
            this.sto_A2 = new System.Windows.Forms.TextBox();
            this.kol_A2_B3 = new System.Windows.Forms.TextBox();
            this.kol_A2_B2 = new System.Windows.Forms.TextBox();
            this.kol_A2_B1 = new System.Windows.Forms.TextBox();
            this.sto_A1 = new System.Windows.Forms.TextBox();
            this.kol_A1_B3 = new System.Windows.Forms.TextBox();
            this.kol_A1_B2 = new System.Windows.Forms.TextBox();
            this.kol_A1_B1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._predel_B3 = new System.Windows.Forms.TextBox();
            this._predel_B2 = new System.Windows.Forms.TextBox();
            this._predel_B1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grafick = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raschot = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Vhodnie_danie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Grafick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Vhodnie_danie);
            this.tabControl1.Controls.Add(this.Grafick);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 361);
            this.tabControl1.TabIndex = 3;
            // 
            // Vhodnie_danie
            // 
            this.Vhodnie_danie.Controls.Add(this.groupBox1);
            this.Vhodnie_danie.Location = new System.Drawing.Point(4, 22);
            this.Vhodnie_danie.Name = "Vhodnie_danie";
            this.Vhodnie_danie.Padding = new System.Windows.Forms.Padding(3);
            this.Vhodnie_danie.Size = new System.Drawing.Size(884, 346);
            this.Vhodnie_danie.TabIndex = 0;
            this.Vhodnie_danie.Text = "Входные данные";
            this.Vhodnie_danie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.sto_A3);
            this.groupBox1.Controls.Add(this.kol_A3_B3);
            this.groupBox1.Controls.Add(this.kol_A3_B2);
            this.groupBox1.Controls.Add(this.kol_A3_B1);
            this.groupBox1.Controls.Add(this.sto_A2);
            this.groupBox1.Controls.Add(this.kol_A2_B3);
            this.groupBox1.Controls.Add(this.kol_A2_B2);
            this.groupBox1.Controls.Add(this.kol_A2_B1);
            this.groupBox1.Controls.Add(this.sto_A1);
            this.groupBox1.Controls.Add(this.kol_A1_B3);
            this.groupBox1.Controls.Add(this.kol_A1_B2);
            this.groupBox1.Controls.Add(this.kol_A1_B1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._predel_B3);
            this.groupBox1.Controls.Add(this._predel_B2);
            this.groupBox1.Controls.Add(this._predel_B1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // sto_A3
            // 
            this.sto_A3.Location = new System.Drawing.Point(668, 218);
            this.sto_A3.Name = "sto_A3";
            this.sto_A3.Size = new System.Drawing.Size(53, 20);
            this.sto_A3.TabIndex = 24;
            // 
            // kol_A3_B3
            // 
            this.kol_A3_B3.Location = new System.Drawing.Point(668, 148);
            this.kol_A3_B3.Name = "kol_A3_B3";
            this.kol_A3_B3.Size = new System.Drawing.Size(53, 20);
            this.kol_A3_B3.TabIndex = 23;
            // 
            // kol_A3_B2
            // 
            this.kol_A3_B2.Location = new System.Drawing.Point(668, 116);
            this.kol_A3_B2.Name = "kol_A3_B2";
            this.kol_A3_B2.Size = new System.Drawing.Size(53, 20);
            this.kol_A3_B2.TabIndex = 22;
            // 
            // kol_A3_B1
            // 
            this.kol_A3_B1.Location = new System.Drawing.Point(668, 85);
            this.kol_A3_B1.Name = "kol_A3_B1";
            this.kol_A3_B1.Size = new System.Drawing.Size(53, 20);
            this.kol_A3_B1.TabIndex = 21;
            // 
            // sto_A2
            // 
            this.sto_A2.Location = new System.Drawing.Point(573, 218);
            this.sto_A2.Name = "sto_A2";
            this.sto_A2.Size = new System.Drawing.Size(53, 20);
            this.sto_A2.TabIndex = 20;
            // 
            // kol_A2_B3
            // 
            this.kol_A2_B3.Location = new System.Drawing.Point(573, 148);
            this.kol_A2_B3.Name = "kol_A2_B3";
            this.kol_A2_B3.Size = new System.Drawing.Size(53, 20);
            this.kol_A2_B3.TabIndex = 19;
            // 
            // kol_A2_B2
            // 
            this.kol_A2_B2.Location = new System.Drawing.Point(573, 116);
            this.kol_A2_B2.Name = "kol_A2_B2";
            this.kol_A2_B2.Size = new System.Drawing.Size(53, 20);
            this.kol_A2_B2.TabIndex = 18;
            // 
            // kol_A2_B1
            // 
            this.kol_A2_B1.Location = new System.Drawing.Point(573, 85);
            this.kol_A2_B1.Name = "kol_A2_B1";
            this.kol_A2_B1.Size = new System.Drawing.Size(53, 20);
            this.kol_A2_B1.TabIndex = 17;
            // 
            // sto_A1
            // 
            this.sto_A1.Location = new System.Drawing.Point(487, 218);
            this.sto_A1.Name = "sto_A1";
            this.sto_A1.Size = new System.Drawing.Size(53, 20);
            this.sto_A1.TabIndex = 16;
            // 
            // kol_A1_B3
            // 
            this.kol_A1_B3.Location = new System.Drawing.Point(487, 148);
            this.kol_A1_B3.Name = "kol_A1_B3";
            this.kol_A1_B3.Size = new System.Drawing.Size(53, 20);
            this.kol_A1_B3.TabIndex = 15;
            // 
            // kol_A1_B2
            // 
            this.kol_A1_B2.Location = new System.Drawing.Point(487, 116);
            this.kol_A1_B2.Name = "kol_A1_B2";
            this.kol_A1_B2.Size = new System.Drawing.Size(53, 20);
            this.kol_A1_B2.TabIndex = 14;
            // 
            // kol_A1_B1
            // 
            this.kol_A1_B1.Location = new System.Drawing.Point(487, 85);
            this.kol_A1_B1.Name = "kol_A1_B1";
            this.kol_A1_B1.Size = new System.Drawing.Size(53, 20);
            this.kol_A1_B1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Количество единиц вещества,содержащего в 1 кг сырья соответствующего вида,ед.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "А1";
            // 
            // _predel_B3
            // 
            this._predel_B3.Location = new System.Drawing.Point(186, 152);
            this._predel_B3.Name = "_predel_B3";
            this._predel_B3.Size = new System.Drawing.Size(45, 20);
            this._predel_B3.TabIndex = 7;
            // 
            // _predel_B2
            // 
            this._predel_B2.Location = new System.Drawing.Point(186, 120);
            this._predel_B2.Name = "_predel_B2";
            this._predel_B2.Size = new System.Drawing.Size(45, 20);
            this._predel_B2.TabIndex = 6;
            // 
            // _predel_B1
            // 
            this._predel_B1.Location = new System.Drawing.Point(186, 89);
            this._predel_B1.Name = "_predel_B1";
            this._predel_B1.Size = new System.Drawing.Size(45, 20);
            this._predel_B1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Нижний предел содержания вещества в смеси,ед.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "B1";
            // 
            // Grafick
            // 
            this.Grafick.Controls.Add(this.chart1);
            this.Grafick.Controls.Add(this.dataGridView1);
            this.Grafick.Location = new System.Drawing.Point(4, 22);
            this.Grafick.Name = "Grafick";
            this.Grafick.Padding = new System.Windows.Forms.Padding(3);
            this.Grafick.Size = new System.Drawing.Size(884, 335);
            this.Grafick.TabIndex = 1;
            this.Grafick.Text = "График";
            this.Grafick.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.X3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 115);
            this.dataGridView1.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "B3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "B2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "А2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "А3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Стоимость 1кг сырья соответсвтующего вида ,у.е.";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(414, 6);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "X1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "X2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "X3";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(461, 334);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            // 
            // X3
            // 
            this.X3.HeaderText = "X3";
            this.X3.Name = "X3";
            // 
            // Raschot
            // 
            this.Raschot.Location = new System.Drawing.Point(774, 375);
            this.Raschot.Name = "Raschot";
            this.Raschot.Size = new System.Drawing.Size(106, 31);
            this.Raschot.TabIndex = 5;
            this.Raschot.Text = "Расчёт";
            this.Raschot.UseVisualStyleBackColor = true;
            this.Raschot.Click += new System.EventHandler(this.Raschot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 410);
            this.Controls.Add(this.Raschot);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Vhodnie_danie.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grafick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Vhodnie_danie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox sto_A3;
        private System.Windows.Forms.TextBox kol_A3_B3;
        private System.Windows.Forms.TextBox kol_A3_B2;
        private System.Windows.Forms.TextBox kol_A3_B1;
        private System.Windows.Forms.TextBox sto_A2;
        private System.Windows.Forms.TextBox kol_A2_B3;
        private System.Windows.Forms.TextBox kol_A2_B2;
        private System.Windows.Forms.TextBox kol_A2_B1;
        private System.Windows.Forms.TextBox sto_A1;
        private System.Windows.Forms.TextBox kol_A1_B3;
        private System.Windows.Forms.TextBox kol_A1_B2;
        private System.Windows.Forms.TextBox kol_A1_B1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _predel_B3;
        private System.Windows.Forms.TextBox _predel_B2;
        private System.Windows.Forms.TextBox _predel_B1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Grafick;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.Button Raschot;
    }
}

