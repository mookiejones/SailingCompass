using System;
using System.Collections.Generic;
using System.Text;

namespace Kompass.Shared.Not_Finished
{
   [DesignerGenerated]
	public class Form2 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("Chart1")]
		private Chart _Chart1;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("TrackBar1")]
		private TrackBar _TrackBar1;

		private int chart_count;

		internal virtual Chart Chart1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Chart1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Chart1 = value;
			}
		}

		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		internal virtual TrackBar TrackBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TrackBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TrackBar1_ValueChanged);
				bool flag = this._TrackBar1 != null;
				if (flag)
				{
					this._TrackBar1.ValueChanged -= value2;
				}
				this._TrackBar1 = value;
				flag = (this._TrackBar1 != null);
				if (flag)
				{
					this._TrackBar1.ValueChanged += value2;
				}
			}
		}

		[DebuggerNonUserCode]
		public Form2()
		{
			base.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
			base.Load += new EventHandler(this.Form2_Load);
			Form2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form2.__ENCList.Count == Form2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form2.__ENCList[num] = Form2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form2.__ENCList.RemoveRange(num, Form2.__ENCList.Count - num);
						Form2.__ENCList.Capacity = Form2.__ENCList.Count;
					}
					Form2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
			ChartArea chartArea = new ChartArea();
			Legend legend = new Legend();
			Series series = new Series();
			DataPoint dataPoint = new DataPoint(0.0, 4.0);
			Series series2 = new Series();
			DataPoint dataPoint2 = new DataPoint(0.0, 4.0);
			this.Chart1 = new Chart();
			this.Timer1 = new Timer(this.components);
			this.TrackBar1 = new TrackBar();
			((ISupportInitialize)this.Chart1).BeginInit();
			((ISupportInitialize)this.TrackBar1).BeginInit();
			this.SuspendLayout();
			componentResourceManager.ApplyResources(this.Chart1, "Chart1");
			this.Chart1.BackColor = Color.Blue;
			this.Chart1.BackGradientStyle = GradientStyle.LeftRight;
			chartArea.CursorY.AxisType = AxisType.Secondary;
			chartArea.CursorY.IsUserEnabled = true;
			chartArea.CursorY.IsUserSelectionEnabled = true;
			chartArea.Name = "ChartArea1";
			this.Chart1.ChartAreas.Add(chartArea);
			legend.Name = "Legend1";
			this.Chart1.Legends.Add(legend);
			this.Chart1.Name = "Chart1";
			series.BorderColor = Color.Red;
			series.BorderWidth = 4;
			series.ChartArea = "ChartArea1";
			series.ChartType = SeriesChartType.Spline;
			series.Color = Color.Red;
			series.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			series.LabelForeColor = Color.Empty;
			series.Legend = "Legend1";
			series.MarkerColor = Color.FromArgb(255, 128, 128);
			series.Name = "Speed";
			dataPoint.BorderWidth = 4;
			dataPoint.IsValueShownAsLabel = false;
			dataPoint.IsVisibleInLegend = false;
			dataPoint.LabelForeColor = Color.Empty;
			series.Points.Add(dataPoint);
			series.YAxisType = AxisType.Secondary;
			series2.BorderColor = Color.Green;
			series2.BorderWidth = 2;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = SeriesChartType.StepLine;
			series2.Color = Color.Green;
			series2.Legend = "Legend1";
			series2.Name = "D1";
			dataPoint2.BorderWidth = 1;
			series2.Points.Add(dataPoint2);
			series2.YAxisType = AxisType.Secondary;
			this.Chart1.Series.Add(series);
			this.Chart1.Series.Add(series2);
			this.Timer1.Interval = 300;
			componentResourceManager.ApplyResources(this.TrackBar1, "TrackBar1");
			this.TrackBar1.BackColor = Color.Blue;
			this.TrackBar1.Minimum = 1;
			this.TrackBar1.Name = "TrackBar1";
			this.TrackBar1.Value = 1;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.Chart1);
			this.Controls.Add(this.TrackBar1);
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.TopMost = true;
			((ISupportInitialize)this.Chart1).EndInit();
			((ISupportInitialize)this.TrackBar1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Chart1.Series["Speed"].Points.Add(new double[]
			{
				Conversions.ToDouble(MyProject.Forms.Menue.speed),
				1.0
			});
			float num4;
			checked
			{
				double[] array = new double[this.Chart1.Series["Speed"].Points.Count + 1];
				int arg_9B_0 = 0;
				int num = this.Chart1.Series["Speed"].Points.Count - 1;
				int num2 = arg_9B_0;
				while (true)
				{
					int arg_E4_0 = num2;
					int num3 = num;
					if (arg_E4_0 > num3)
					{
						break;
					}
					double[] yValues = this.Chart1.Series["Speed"].Points[num2].YValues;
					array[num2] = yValues[0];
					num4 = (float)(unchecked((double)num4 + yValues[0]));
					num2++;
				}
				num4 /= (float)this.Chart1.Series["Speed"].Points.Count;
				num4 = (float)Math.Round((double)num4, 1);
				this.Chart1.Series["D1"].Points.Add(new double[]
				{
					(double)num4,
					1.0
				});
				int num5 = this.Chart1.Series["Speed"].Points.Count - this.chart_count;
				bool flag = this.Chart1.Series["Speed"].Points.Count > this.chart_count;
				if (flag)
				{
					int arg_1AD_0 = 0;
					int num6 = num5 - 1;
					int num7 = arg_1AD_0;
					while (true)
					{
						int arg_22D_0 = num7;
						int num3 = num6;
						if (arg_22D_0 > num3)
						{
							break;
						}
						bool flag2 = num5 < this.Chart1.Series["Speed"].Points.Count;
						if (flag2)
						{
							this.Chart1.Series["Speed"].Points.RemoveAt(num7);
							this.Chart1.Series["D1"].Points.RemoveAt(num7);
						}
						num7++;
					}
				}
				this.Text = " " + Conversions.ToString(this.TrackBar1.Value) + " min.  speed Ø " + Conversions.ToString(num4);
			}
			this.Chart1.ChartAreas[0].AxisY2.Maximum = Math.Round((double)num4) + 2.0;
			this.Chart1.ChartAreas[0].AxisY2.Minimum = Math.Round((double)num4) - 2.0;
			this.Chart1.ChartAreas[0].AxisY2.Interval = 1.0;
			this.Opacity = (double)MyProject.Forms.Menue.TrackBarTranspatenc.Value / 100.0;
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			MyProject.Forms.Menue.CheckBox11.CheckState = CheckState.Unchecked;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.chart_count = 60;
			this.TrackBar1.Value = 1;
			this.Timer1.Interval = 1000;
			this.Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			this.Chart1.ChartAreas["ChartArea1"].AxisY2.Interval = 1.0;
			this.Chart1.Series["Speed"].Points.Add(new double[]
			{
				0.0,
				1.0
			});
			this.Timer1.Enabled = true;
		}

		private void TrackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.chart_count = checked(60 * this.TrackBar1.Value);
		}
	}
}
