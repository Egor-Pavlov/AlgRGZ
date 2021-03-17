
namespace AlgRGZ2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.StepTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoeffTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Time";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "xLog(x)";
            this.graph.Series.Add(series5);
            this.graph.Series.Add(series6);
            this.graph.Size = new System.Drawing.Size(576, 426);
            this.graph.TabIndex = 3;
            this.graph.Text = "График зависимости времени работы пирамидальной сортировки от размера массива";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество измерений:";
            // 
            // CountTB
            // 
            this.CountTB.Location = new System.Drawing.Point(6, 47);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(100, 20);
            this.CountTB.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(5, 251);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(151, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Построить график";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // StepTB
            // 
            this.StepTB.Location = new System.Drawing.Point(6, 104);
            this.StepTB.Name = "StepTB";
            this.StepTB.Size = new System.Drawing.Size(100, 20);
            this.StepTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаг увеличения\r\nразмера массива:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CoeffTB);
            this.groupBox1.Controls.Add(this.CountTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.StepTB);
            this.groupBox1.Location = new System.Drawing.Point(598, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 280);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // CoeffTB
            // 
            this.CoeffTB.Location = new System.Drawing.Point(9, 163);
            this.CoeffTB.Name = "CoeffTB";
            this.CoeffTB.Size = new System.Drawing.Size(100, 20);
            this.CoeffTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Коэффициент при xlog(x):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Исследование времени работы пирамидальной сортировки";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox StepTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CoeffTB;
    }
}

