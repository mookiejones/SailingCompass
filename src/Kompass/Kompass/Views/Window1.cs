using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Kompass.Properties;

namespace Kompass.Views
{
    public class Window1:Control
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        private DispatcherTimer _timer1;
        
        

		public float RadianX=90f;

		public float RadianY=90f;

		private float x=0f;

		private float y=0f;

		private float Multiplicator=10f;

		private float Multiplicator2=1f;

		private float Multiplicator3=5f;

		private float[] FromLeft= new float[401];

		private float[] FromTop= new float[401];

		private float Angle=0f;

		private new float[] Left= new float[401];

		private new float[] Top= new float[401];

		private float[] aLeft= new float[401];

		private float[] aTop= new float[401];

		private float[] eLeft= new float[401];

		private float[] eTop= new float[401];

		private string missweisung="0";

		private string kurs_boot="0";

		private string grad="90";

		private string grad2="90";

		private string kurs_wind="1";

		private Pen blackPen = new Pen(){Brush=Brushes.Black};

		private Pen bluePen= new Pen(){Brush=Brushes.Blue};

		private Pen bluePen2= new Pen(){Brush=Brushes.Blue};

		private Pen windPen= new Pen(){Brush=Brushes.Blue};

		private Pen windPen2=new Pen(Brushes.Blue,18f);

		private Pen peilungPen= new Pen(){Brush=Brushes.Firebrick};

		private Pen redPen= new Pen(){Brush=Brushes.Red};

        private Pen KursliniePen = new Pen(Brushes.Firebrick, 2f);
        
		private Pen amwindPen1=new Pen(Brushes.Firebrick,30f);

		private Pen amwindPen2=new Pen(Brushes.Green,30f);
        
        private string wenewinkel = "110";

		private string peilung="0";

		private float schriftgroesse=10f;

		private float schriftgroesse2=8f;

		private string drawFormat;

		private Point mouseOffset;

		internal virtual DispatcherTimer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return _timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(Timer1_Tick);
				bool flag = _timer1 != null;
				if (flag)
				{
					_timer1.Tick -= value2;
				}
				_timer1 = value;
				flag = (_timer1 != null);
				if (flag)
				{
					_timer1.Tick += value2;
				}
			}
		}


        #region Overrides of UIElement

        /// <summary>When overridden in a derived class, participates in rendering operations that are directed by the layout system. The rendering instructions for this element are not used directly when this method is invoked, and are instead preserved for later asynchronous use by layout and drawing. </summary>
        /// <param name="drawingContext">The drawing instructions for a specific element. This context is provided to the layout system.</param>
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            PaintCompass(drawingContext);
//            PaintBoot(drawingContext);
//            PaintWindow(drawingContext);

        }

   

        #endregion

        public Window1()
        {
//            MouseDown += OnMouseDown;
//            MouseMove += OnMouseMove;
            Loaded += OnLoaded;


			Window1.__ENCAddToList(this);
			 
		}

        

        [DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Window1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Window1.__ENCList.Count == Window1.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Window1.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							var weakReference = Window1.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Window1.__ENCList[num] = Window1.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Window1.__ENCList.RemoveRange(num, Window1.__ENCList.Count - num);
						Window1.__ENCList.Capacity = Window1.__ENCList.Count;
					}
					Window1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}
         

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
//			this.components = new Container();
//			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Window1));
//			Timer1 = new Timer(this.components);
//			this.SuspendLayout();
//			this.AccessibleRole = AccessibleRole.None;
//			componentResourceManager.ApplyResources(this, "$this");
//			this.AutoScaleMode = AutoScaleMode.Font;
//			this.BackColor = Color.DarkGray;
//			Cursor = Cursors.SizeAll;
//			this.DataBindings.Add(new Binding("Location", MySettings.Default, "x_start", true, DataSourceUpdateMode.OnPropertyChanged));
//			this.DoubleBuffered = true;
//			this.FormBorderStyle = FormBorderStyle.None;
//			this.Location = MySettings.Default.x_start;
//			Name = "Window1";
//			this.ShowIcon = false;
//			this.ShowInTaskbar = false;
//			this.TopMost = true;
//			this.TransparencyKey = Color.DarkGray;
//			this.ResumeLayout(false);
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
		    var pos=e.GetPosition(this);
            
			mouseOffset = checked(new Point(0 - pos.X, 0 - pos.Y));
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
		    var flag = e.LeftButton == MouseButtonState.Pressed;
			if (flag)
			{
			    var mousePosition = e.GetPosition(this);

				mousePosition.Offset(mouseOffset.X, mouseOffset.Y);
//				this.Location = mousePosition;
			}
		}

        private void OnLoaded(object sender, RoutedEventArgs e)
		{
              
		    var width = this.Width;
		    var height = this.Height;
//			this.FormBorderStyle = FormBorderStyle.None;
			Width = width;
			Height = height;
			x = (float)((double)Width / 2.0);
			y = (float)((double)Height / 2.0);
//			this.TopMost = true;

			RadianX = (float)Settings.Default.durchmesser;
			RadianY = (float)Settings.Default.durchmesser;

		    var timer = Timer1;
		    timer.IsEnabled = true;
		    timer.Interval = TimeSpan.FromMilliseconds(300);

		}
        private void PaintCompass(DrawingContext drawingContext)
        {
            /*
           	grad = "90";
			grad2 = "90";

			missweisung = MyProject.Forms.Menue.missweisung;
			kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				missweisung = Conversions.ToString(-Conversions.ToDouble(kurs_boot));
			}
			else
			{
				missweisung = "0";
			}
			flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 70);
			if (flag)
			{
				schriftgroesse = 7f;
			}
			else
			{
				flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 90);
				if (flag)
				{
					schriftgroesse = 8f;
				}
				else
				{
					schriftgroesse = 10f;
				}
			}
			Bitmap image = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, e.Graphics);
			Graphics graphics = Graphics.FromImage(image);
			flag = (MyProject.Forms.Menue.CheckBox3.CheckState == CheckState.Checked);
			if (flag)
			{
				graphics.SmoothingMode = SmoothingMode.HighQuality;
			}
			int num = 0;
			int arg_524_0;
			int num2;
			do
			{
				Left[num] = (float)((double)(FromLeft[num] - 12f) + (double)RadianX * 2.5 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				Top[num] = (float)((double)(FromTop[num] - 8f) + (double)RadianY * 2.5 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				flag = (Conversions.ToDouble(grad) == 0.0);
				if (flag)
				{
					graphics.DrawString("360", new Font("Verdana", schriftgroesse, FontStyle.Bold), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
				}
				else
				{
					flag = (Conversions.ToDouble(grad) == 10.0 | Conversions.ToDouble(grad) == 20.0 | Conversions.ToDouble(grad) == 30.0);
					if (flag)
					{
						graphics.DrawString(" " + grad, new Font("Verdana", schriftgroesse, FontStyle.Bold), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
					}
					else
					{
						graphics.DrawString(grad, new Font("Verdana", schriftgroesse, FontStyle.Bold), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
					}
				}
				aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.35 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.35 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, x + aLeft[num], y + aTop[num], x + eLeft[num], y + eTop[num]);
				flag = (Conversions.ToDouble(grad) > 340.0);
				if (flag)
				{
					grad = "0";
				}
				else
				{
					grad = Conversions.ToString(Conversions.ToDouble(grad) + 10.0);
				}
				checked
				{
					num++;
					arg_524_0 = num;
					num2 = 35;
				}
			}
			while (arg_524_0 <= num2);
			int num3 = 0;
			int arg_6CA_0;
			do
			{
				aLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator2) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				aTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator2) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.28 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator2) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.28 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator2) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
				checked
				{
					num3++;
					arg_6CA_0 = num3;
					num2 = 359;
				}
			}
			while (arg_6CA_0 <= num2);
			int num4 = 0;
			int arg_881_0;
			do
			{
				aLeft[num4] = (float)((double)FromLeft[num4] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num4 * Multiplicator3) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				aTop[num4] = (float)((double)FromTop[num4] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num4 * Multiplicator3) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eLeft[num4] = (float)((double)FromLeft[num4] + (double)RadianX * 2.32 * Math.Cos((double)Angle + ((double)((float)num4 * Multiplicator3) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				eTop[num4] = (float)((double)FromTop[num4] + (double)RadianY * 2.32 * Math.Sin((double)Angle + ((double)((float)num4 * Multiplicator3) + Conversions.ToDouble(missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, x + aLeft[num4], y + aTop[num4], x + eLeft[num4], y + eTop[num4]);
				checked
				{
					num4++;
					arg_881_0 = num4;
					num2 = 71;
				}
			}
			while (arg_881_0 <= num2);
			graphics.DrawEllipse(Pens.Gray, x - (float)((double)RadianX * 4.41) / 2f, y - (float)((double)RadianY * 4.41) / 2f, (float)((double)RadianX * 4.41), (float)((double)RadianY * 4.41));
			e.Graphics.DrawImageUnscaled(image, 0, 0);
			graphics.Dispose();
            */
        }
/*

		private void Boot_Paint(object sender, PaintEventArgs e)
		{
			grad = "90";
			grad2 = "90";
			wenewinkel = MyProject.Forms.Menue.ComboBox3.Text;
			kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				kurs_boot = "0";
			}
			Bitmap image = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, e.Graphics);
			Graphics graphics = Graphics.FromImage(image);
			flag = (MyProject.Forms.Menue.CheckBox3.CheckState == CheckState.Checked);
			if (flag)
			{
				graphics.SmoothingMode = SmoothingMode.HighQuality;
			}
			flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 70);
			if (flag)
			{
				schriftgroesse2 = 6f;
			}
			else
			{
				flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 90);
				if (flag)
				{
					schriftgroesse2 = 7f;
				}
				else
				{
					schriftgroesse2 = 8f;
				}
			}
			bool flag2 = false;
			flag = (MyProject.Forms.Menue.CheckBox5.CheckState == CheckState.Checked);
			int num2;
			if (flag)
			{
				int num = 0;
				int arg_73F_0;
				do
				{
					Left[num] = (float)((double)(FromLeft[num] - 10f) + (double)RadianX * 1.9 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					Top[num] = (float)((double)(FromTop[num] - 5f) + (double)RadianY * 1.9 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					string text = grad2.Replace("-", "");
					flag = (Conversions.ToDouble(grad2) == 0.0);
					if (flag)
					{
						graphics.DrawString(" " + text, new Font("Verdana", schriftgroesse2, FontStyle.Regular), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
					}
					else
					{
						flag = (Operators.CompareString(text, wenewinkel, false) == 0);
						if (flag)
						{
							graphics.DrawString(text, new Font("Verdana", schriftgroesse2, FontStyle.Bold), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
							Left[num] = (float)((double)FromLeft[num] + (double)(RadianX * 7f) * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
							Top[num] = (float)((double)FromTop[num] + (double)(RadianY * 7f) * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
							graphics.DrawLine(new Pen(Color.DimGray, 1f)
							{
								DashStyle = DashStyle.Dot
							}, x, y, x + Left[num], y + Top[num]);
						}
						else
						{
							Left[num] = (float)((double)(FromLeft[num] - 10f) + (double)RadianX * 1.9 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
							Top[num] = (float)((double)(FromTop[num] - 5f) + (double)RadianY * 1.9 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
							graphics.DrawString(text, new Font("Verdana", schriftgroesse2, FontStyle.Regular), Brushes.Blue, x + Left[num], y + Top[num], drawFormat);
						}
					}
					aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.1 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.1 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					graphics.DrawLine(bluePen, x + aLeft[num], y + aTop[num], x + eLeft[num], y + eTop[num]);
					flag = (Conversions.ToDouble(grad2) > 350.0);
					if (flag)
					{
						grad2 = "0";
					}
					else
					{
						flag = (Conversions.ToDouble(grad2) > 170.0 & Conversions.ToDouble(grad2) < 350.0);
						if (flag)
						{
							flag2 = true;
						}
						flag = !flag2;
						if (flag)
						{
							grad2 = Conversions.ToString(Conversions.ToDouble(grad2) + 10.0);
						}
						else
						{
							grad2 = Conversions.ToString(Conversions.ToDouble(grad2) - 10.0);
						}
					}
					checked
					{
						num++;
						arg_73F_0 = num;
						num2 = 35;
					}
				}
				while (arg_73F_0 <= num2);
			}
			int num3 = 0;
			int arg_DAE_0;
			do
			{
				flag = (MyProject.Forms.Menue.CheckBox5.CheckState == CheckState.Checked);
				if (flag)
				{
					aLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.15 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					aTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.15 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					graphics.DrawLine(bluePen, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
				}
				flag = (MyProject.Forms.Menue.CheckBox8.CheckState == CheckState.Checked);
				if (flag)
				{
					aLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.0 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					aTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.0 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eLeft[num3] = (float)((double)FromLeft[num3] + (double)RadianX * 2.1 * Math.Cos((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					eTop[num3] = (float)((double)FromTop[num3] + (double)RadianY * 2.1 * Math.Sin((double)Angle + ((double)((float)num3 * Multiplicator3) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
					flag = ((double)num3 == 54.0 - Conversions.ToDouble(wenewinkel) / 10.0 + 1.0);
					if (flag)
					{
						graphics.DrawLine(amwindPen1, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
					}
					else
					{
						flag = ((double)num3 == 54.0 + Conversions.ToDouble(wenewinkel) / 10.0 - 1.0);
						if (flag)
						{
							graphics.DrawLine(amwindPen2, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
						}
						else
						{
							flag = ((double)num3 == 54.0 - Conversions.ToDouble(wenewinkel) / 10.0 + 2.0);
							if (flag)
							{
								graphics.DrawLine(amwindPen1, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
							}
							else
							{
								flag = ((double)num3 == 54.0 + Conversions.ToDouble(wenewinkel) / 10.0 - 2.0);
								if (flag)
								{
									graphics.DrawLine(amwindPen2, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
								}
								else
								{
									flag = ((double)num3 == 54.0 - Conversions.ToDouble(wenewinkel) / 10.0 + 3.0);
									if (flag)
									{
										graphics.DrawLine(amwindPen1, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
									}
									else
									{
										flag = ((double)num3 == 54.0 + Conversions.ToDouble(wenewinkel) / 10.0 - 3.0);
										if (flag)
										{
											graphics.DrawLine(amwindPen2, x + aLeft[num3], y + aTop[num3], x + eLeft[num3], y + eTop[num3]);
										}
									}
								}
							}
						}
					}
				}
				checked
				{
					num3++;
					arg_DAE_0 = num3;
					num2 = 71;
				}
			}
			while (arg_DAE_0 <= num2);
			e.Graphics.DrawImageUnscaled(image, 0, 0);
			graphics.Dispose();
		}

		private void Wind_Paint(object sender, PaintEventArgs e)
		{
			grad = "90";
			grad2 = "90";
			kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				kurs_boot = "0";
			}
			Bitmap image = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, e.Graphics);
			Graphics graphics = Graphics.FromImage(image);
			flag = (MyProject.Forms.Menue.CheckBox3.CheckState == CheckState.Checked);
			if (flag)
			{
				graphics.SmoothingMode = SmoothingMode.HighQuality;
			}
			int num = 0;
			int arg_11D3_0;
			int num3;
			do
			{
				aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.1 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
				aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.1 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
				eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.1 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
				eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.1 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
				flag = (num == 18);
				if (flag)
				{
					graphics.DrawLine(blackPen, x + aLeft[18], y + aTop[18], x + eLeft[0], y + eTop[0]);
				}
				flag = (num == 27);
				if (flag)
				{
					graphics.DrawLine(blackPen, x + aLeft[27], y + aTop[27], x + eLeft[9], y + eTop[9]);
					flag = (MyProject.Forms.Menue.CheckBox4.CheckState == CheckState.Checked);
					if (flag)
					{
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.2 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.2 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_boot)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap = new AdjustableArrowCap(2f, 5f, false);
						adjustableArrowCap.BaseCap = LineCap.Round;
						adjustableArrowCap.BaseInset = 5f;
						adjustableArrowCap.StrokeJoin = LineJoin.Bevel;
						KursliniePen.CustomStartCap = adjustableArrowCap;
						KursliniePen.Width = Conversions.ToSingle(MyProject.Forms.Menue.ComboBox1.SelectedIndex.ToString());
						KursliniePen.DashStyle = DashStyle.Dash;
						graphics.DrawLine(KursliniePen, x + aLeft[27], y + aTop[27], x, y);
					}
					flag = (MyProject.Forms.Menue.CheckBox8.CheckState == CheckState.Checked);
					bool flag2;
					if (flag)
					{
						flag2 = (MyProject.Forms.Menue.kurs_wind != 0);
						if (flag2)
						{
							kurs_wind = Conversions.ToString(MyProject.Forms.Menue.kurs_wind);
						}
						else
						{
							kurs_wind = Conversions.ToString(MyProject.Forms.Menue.HScrollBar1.Value);
						}
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.3 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.3 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.5 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.5 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap2 = new AdjustableArrowCap(17f, 1f, false);
						adjustableArrowCap2.WidthScale = 1f;
						adjustableArrowCap2.BaseCap = LineCap.Square;
						adjustableArrowCap2.Height = (float)((double)RadianX * 1.9);
						windPen.CustomStartCap = adjustableArrowCap2;
						graphics.DrawLine(windPen, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						double num2 = (double)(MyProject.Forms.Menue.stark_wind_d / 10f) + 0.2;
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * num2 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * num2 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.72 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.72 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap3 = new AdjustableArrowCap(5f, 1f, true);
						adjustableArrowCap3.WidthScale = 1f;
						adjustableArrowCap3.BaseCap = LineCap.Square;
						adjustableArrowCap3.Height = 5f;
						bluePen2.CustomStartCap = adjustableArrowCap3;
						graphics.DrawLine(bluePen2, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						Pen pen = new Pen(Color.Blue, 5f);
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.5 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.5 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 0.72 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 0.72 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						pen.Width = 8f;
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 1.18 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 1.18 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 1.2 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 1.2 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						pen.Width = 6f;
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 1.68 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 1.68 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 1.7 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 1.7 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.15 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.15 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.21 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.21 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(windPen2, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
					}
					flag2 = (Operators.CompareString(MyProject.Forms.Menue.TextBox1.Text, "", false) != 0);
					if (flag2)
					{
						flag = (MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked);
						if (flag)
						{
							peilung = Conversions.ToString(-Conversions.ToDouble(MyProject.Forms.Menue.kurs_boot) + Conversions.ToDouble(MyProject.Forms.Menue.TextBox1.Text));
							flag2 = (Operators.CompareString(peilung, "0", false) < 0);
							if (flag2)
							{
								peilung = Conversions.ToString(360.0 + Conversions.ToDouble(peilung));
							}
						}
						else
						{
							peilung = MyProject.Forms.Menue.TextBox1.Text;
						}
						flag2 = (Conversions.ToDouble(peilung) > 0.0 & Conversions.ToDouble(peilung) < 361.0);
						if (flag2)
						{
							aLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.6 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(peilung)) * 0.017453292519943295));
							aTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.6 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(peilung)) * 0.017453292519943295));
							eLeft[num] = (float)((double)FromLeft[num] + (double)RadianX * 2.65 * Math.Cos((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(peilung)) * 0.017453292519943295));
							eTop[num] = (float)((double)FromTop[num] + (double)RadianY * 2.65 * Math.Sin((double)Angle + ((double)((float)num * Multiplicator) + Conversions.ToDouble(peilung)) * 0.017453292519943295));
							AdjustableArrowCap adjustableArrowCap4 = new AdjustableArrowCap(10f, 1f, true);
							adjustableArrowCap4.WidthScale = 1f;
							adjustableArrowCap4.BaseCap = LineCap.Square;
							adjustableArrowCap4.Height = 10f;
							peilungPen.CustomStartCap = adjustableArrowCap4;
							graphics.DrawLine(peilungPen, x + aLeft[27], y + aTop[27], x + eLeft[27], y + eTop[27]);
						}
					}
				}
				checked
				{
					num++;
					arg_11D3_0 = num;
					num3 = 35;
				}
			}
			while (arg_11D3_0 <= num3);
			e.Graphics.DrawImageUnscaled(image, 0, 0);
			graphics.Dispose();
		}
        */
		private void Timer1_Tick(object sender, EventArgs e)
		{
//			this.Invalidate();
		}
    }
}
