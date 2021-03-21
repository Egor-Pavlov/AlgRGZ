using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AlgRGZ2
{
	public partial class Form1 : Form
	{
		HeapSort HS = new HeapSort();

		public List<(uint, double)> Result = new List<(uint, double)>();//пары размер,время сортировки

		//количество замеров времени, размер массива на этапе эксперимента
		uint ExpCount = 0, size;

		//суммарное время эксперимента
		double ExpTime = 0;
		double Coeff = 0;
		//массив для сортировки
		List<int> array = new List<int>();

		uint step;//шаг увеличения размера массива

		public Form1()
		{
			InitializeComponent();
		}
		private void Save()
        {
			string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
			Directory.CreateDirectory(completedPath);

			string filePath = Path.Combine(completedPath, "Count=_" + Result.Count.ToString() + "_step=_" + step.ToString() + ".xls");

			//запись в файл
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				for (uint i = 0; i < ExpCount; i++)
				{
					writer.WriteLine(Result[(int)i].Item1.ToString() + "\t" + Result[(int)i].Item2.ToString());
				}
			}
		}
		private void Draw()
		{
			//List<double> c = new List<double>();
			//double C = 0;
			//for (int i = 0; i < Result.Count; i++)
   //         {
			//	c.Add(Result[i].Item2 / (Result[i].Item1 * Math.Log(Convert.ToDouble(Result[i].Item1), 2)));
			//	C += c[i];
			//}
			//C = C / c.Count; 
			
			graph.Series[0].Points.Clear();
			graph.Series[1].Points.Clear();

			for (int i = 0; i < Result.Count; i++)
			{
				graph.Series[0].Points.AddXY(Result[i].Item1, Result[i].Item2);
				graph.Series[1].Points.AddXY(Result[i].Item1, Coeff * (Convert.ToDouble(Result[i].Item1)) * Math.Log(Convert.ToDouble(Result[i].Item1), 2));
			}

			graph.ChartAreas[0].AxisX.Title = "Размер массива";
			graph.ChartAreas[0].AxisX.Interval = step;

			graph.ChartAreas[0].AxisY.Title = "Время сортировки, С";
		}

		private bool CheckInput()
        {
			if (!uint.TryParse(StepTB.Text, out step))
			{
				MessageBox.Show("Введено недопустимое значение!", "Ошибка");
				StepTB.Clear();
				return false;
			}
			if (!uint.TryParse(CountTB.Text, out ExpCount))
			{
				MessageBox.Show("Введено недопустимое значение!", "Ошибка");
				CountTB.Clear();
				return false;
			}
			if(CoeffTB.Text != "")
			{ 
				if (!double.TryParse(CoeffTB.Text, out Coeff))
				{
					MessageBox.Show("Введено недопустимое значение!", "Ошибка");
					CoeffTB.Clear();
					return false;
				}
			}
			if(CoeffTB.Text == "")
            {
				Coeff = 0;
			}
			return true;
		}
		private void Start_Click(object sender, EventArgs e)
		{
			ExpTime = 0;
			if (!CheckInput())//проверка входных данных
            {
                return;
            }
            Random random = new Random();
            Result.Clear();//массив пар размер-время сортировки

            for (uint i = 1; i <= ExpCount; i++)
            {
                size = i * step;//step - шаг, с которым будет происходить увеличение размера массива

                array.Clear();

                for (uint j = 0; j < size; j++)
                {
                    array.Add(random.Next());//генерация массива заданной размерности, заполненного случайными числами
                }

                Stopwatch stopWatch = new Stopwatch(); // секундомер
                stopWatch.Start(); // запустить секундомер

                array = HeapSort.HSort(array.Count(), array);//функция, осуществляющая пирамидальную сортировку

                stopWatch.Stop(); // остановить секундомер
                double elapseTime = stopWatch.Elapsed.TotalSeconds;//время сортировки
                ExpTime += elapseTime;//вычисление времени эксперимента
                Result.Add((size, elapseTime));//запись размера массива и времени сортировки в контейнер
            }
            label3.Text = "Суммарное время сортировок:\n" + ExpTime.ToString();
			
            Draw();//отрисовка графика
            Save();//сохранение результатов эксперимента
        }
	}
}
