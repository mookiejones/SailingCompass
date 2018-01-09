using System;
using System.Collections.Generic;
using System.Text;

namespace Kompass.Shared.Not_Finished
{
    [DesignerGenerated]
	public class Form1 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		public float RadianX;

		public float RadianY;

		private float x;

		private float y;

		private float Multiplicator;

		private float Multiplicator2;

		private float Multiplicator3;

		private float[] FromLeft;

		private float[] FromTop;

		private float Angle;

		private new float[] Left;

		private new float[] Top;

		private float[] aLeft;

		private float[] aTop;

		private float[] eLeft;

		private float[] eTop;

		private string missweisung;

		private string kurs_boot;

		private string grad;

		private string grad2;

		private string kurs_wind;

		private Pen blackPen;

		private Pen bluePen;

		private Pen bluePen2;

		private Pen windPen;

		private Pen windPen2;

		private Pen peilungPen;

		private Pen redPen;

		private Pen KursliniePen;

		private Pen amwindPen1;

		private Pen amwindPen2;

		private string wenewinkel;

		private string peilung;

		private float schriftgroesse;

		private float schriftgroesse2;

		private StringFormat drawFormat;

		private Point mouseOffset;

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

		public Form1()
		{
			base.Paint += new PaintEventHandler(this.Kompas_Paint);
			base.Paint += new PaintEventHandler(this.Boot_Paint);
			base.MouseDown += new MouseEventHandler(this.Me_MouseDown);
			base.MouseMove += new MouseEventHandler(this.Me_MouseMove);
			base.Paint += new PaintEventHandler(this.Wind_Paint);
			base.Load += new EventHandler(this.Form1_Load);
			Form1.__ENCAddToList(this);
			this.RadianX = 90f;
			this.RadianY = 90f;
			this.x = 0f;
			this.y = 0f;
			this.Multiplicator = 10f;
			this.Multiplicator2 = 1f;
			this.Multiplicator3 = 5f;
			this.FromLeft = new float[401];
			this.FromTop = new float[401];
			this.Angle = 0f;
			this.Left = new float[401];
			this.Top = new float[401];
			this.aLeft = new float[401];
			this.aTop = new float[401];
			this.eLeft = new float[401];
			this.eTop = new float[401];
			this.missweisung = "0";
			this.kurs_boot = "0";
			this.grad = "90";
			this.grad2 = "90";
			this.kurs_wind = "1";
			this.blackPen = new Pen(Color.Black);
			this.bluePen = new Pen(Color.Blue);
			this.bluePen2 = new Pen(Color.Blue);
			this.windPen = new Pen(Color.Blue);
			this.windPen2 = new Pen(Color.Blue, 18f);
			this.peilungPen = new Pen(Color.Firebrick);
			this.redPen = new Pen(Color.Red);
			this.KursliniePen = new Pen(Color.Firebrick, 2f);
			this.amwindPen1 = new Pen(Color.Firebrick, 30f);
			this.amwindPen2 = new Pen(Color.Green, 30f);
			this.wenewinkel = "110";
			this.peilung = "0";
			this.schriftgroesse = 10f;
			this.schriftgroesse2 = 8f;
			this.drawFormat = new StringFormat();
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form1.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form1.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form1.__ENCList[num] = Form1.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
						Form1.__ENCList.Capacity = Form1.__ENCList.Count;
					}
					Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.Timer1 = new Timer(this.components);
			this.SuspendLayout();
			this.AccessibleRole = AccessibleRole.None;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DarkGray;
			this.Cursor = Cursors.SizeAll;
			this.DataBindings.Add(new Binding("Location", MySettings.Default, "x_start", true, DataSourceUpdateMode.OnPropertyChanged));
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.Location = MySettings.Default.x_start;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.TransparencyKey = Color.DarkGray;
			this.ResumeLayout(false);
		}

		private void Me_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseOffset = checked(new Point(0 - e.X, 0 - e.Y));
		}

		private void Me_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseOffset.X, this.mouseOffset.Y);
				this.Location = mousePosition;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			int width = workingArea.Width;
			int height = workingArea.Height;
			this.FormBorderStyle = FormBorderStyle.None;
			this.Width = width;
			this.Height = height;
			this.x = (float)((double)this.Width / 2.0);
			this.y = (float)((double)this.Height / 2.0);
			this.TopMost = true;
			this.RadianX = (float)MySettingsProperty.Settings.durchmesser;
			this.RadianY = (float)MySettingsProperty.Settings.durchmesser;
			Timer timer = this.Timer1;
			timer.Enabled = true;
			timer.Interval = 300;
		}

		private void Kompas_Paint(object sender, PaintEventArgs e)
		{
			this.grad = "90";
			this.grad2 = "90";
			this.missweisung = MyProject.Forms.Menue.missweisung;
			this.kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				this.missweisung = Conversions.ToString(-Conversions.ToDouble(this.kurs_boot));
			}
			else
			{
				this.missweisung = "0";
			}
			flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 70);
			if (flag)
			{
				this.schriftgroesse = 7f;
			}
			else
			{
				flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 90);
				if (flag)
				{
					this.schriftgroesse = 8f;
				}
				else
				{
					this.schriftgroesse = 10f;
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
				this.Left[num] = (float)((double)(this.FromLeft[num] - 12f) + (double)this.RadianX * 2.5 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.Top[num] = (float)((double)(this.FromTop[num] - 8f) + (double)this.RadianY * 2.5 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				flag = (Conversions.ToDouble(this.grad) == 0.0);
				if (flag)
				{
					graphics.DrawString("360", new Font("Verdana", this.schriftgroesse, FontStyle.Bold), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
				}
				else
				{
					flag = (Conversions.ToDouble(this.grad) == 10.0 | Conversions.ToDouble(this.grad) == 20.0 | Conversions.ToDouble(this.grad) == 30.0);
					if (flag)
					{
						graphics.DrawString(" " + this.grad, new Font("Verdana", this.schriftgroesse, FontStyle.Bold), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
					}
					else
					{
						graphics.DrawString(this.grad, new Font("Verdana", this.schriftgroesse, FontStyle.Bold), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
					}
				}
				this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.35 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.35 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, this.x + this.aLeft[num], this.y + this.aTop[num], this.x + this.eLeft[num], this.y + this.eTop[num]);
				flag = (Conversions.ToDouble(this.grad) > 340.0);
				if (flag)
				{
					this.grad = "0";
				}
				else
				{
					this.grad = Conversions.ToString(Conversions.ToDouble(this.grad) + 10.0);
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
				this.aLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator2) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.aTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator2) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.28 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator2) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.28 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator2) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
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
				this.aLeft[num4] = (float)((double)this.FromLeft[num4] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num4 * this.Multiplicator3) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.aTop[num4] = (float)((double)this.FromTop[num4] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num4 * this.Multiplicator3) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eLeft[num4] = (float)((double)this.FromLeft[num4] + (double)this.RadianX * 2.32 * Math.Cos((double)this.Angle + ((double)((float)num4 * this.Multiplicator3) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				this.eTop[num4] = (float)((double)this.FromTop[num4] + (double)this.RadianY * 2.32 * Math.Sin((double)this.Angle + ((double)((float)num4 * this.Multiplicator3) + Conversions.ToDouble(this.missweisung)) * 0.017453292519943295));
				graphics.DrawLine(Pens.Gray, this.x + this.aLeft[num4], this.y + this.aTop[num4], this.x + this.eLeft[num4], this.y + this.eTop[num4]);
				checked
				{
					num4++;
					arg_881_0 = num4;
					num2 = 71;
				}
			}
			while (arg_881_0 <= num2);
			graphics.DrawEllipse(Pens.Gray, this.x - (float)((double)this.RadianX * 4.41) / 2f, this.y - (float)((double)this.RadianY * 4.41) / 2f, (float)((double)this.RadianX * 4.41), (float)((double)this.RadianY * 4.41));
			e.Graphics.DrawImageUnscaled(image, 0, 0);
			graphics.Dispose();
		}

		private void Boot_Paint(object sender, PaintEventArgs e)
		{
			this.grad = "90";
			this.grad2 = "90";
			this.wenewinkel = MyProject.Forms.Menue.ComboBox3.Text;
			this.kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				this.kurs_boot = "0";
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
				this.schriftgroesse2 = 6f;
			}
			else
			{
				flag = (MyProject.Forms.Menue.TrackBarKompass.Value < 90);
				if (flag)
				{
					this.schriftgroesse2 = 7f;
				}
				else
				{
					this.schriftgroesse2 = 8f;
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
					this.Left[num] = (float)((double)(this.FromLeft[num] - 10f) + (double)this.RadianX * 1.9 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.Top[num] = (float)((double)(this.FromTop[num] - 5f) + (double)this.RadianY * 1.9 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					string text = this.grad2.Replace("-", "");
					flag = (Conversions.ToDouble(this.grad2) == 0.0);
					if (flag)
					{
						graphics.DrawString(" " + text, new Font("Verdana", this.schriftgroesse2, FontStyle.Regular), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
					}
					else
					{
						flag = (Operators.CompareString(text, this.wenewinkel, false) == 0);
						if (flag)
						{
							graphics.DrawString(text, new Font("Verdana", this.schriftgroesse2, FontStyle.Bold), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
							this.Left[num] = (float)((double)this.FromLeft[num] + (double)(this.RadianX * 7f) * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
							this.Top[num] = (float)((double)this.FromTop[num] + (double)(this.RadianY * 7f) * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
							graphics.DrawLine(new Pen(Color.DimGray, 1f)
							{
								DashStyle = DashStyle.Dot
							}, this.x, this.y, this.x + this.Left[num], this.y + this.Top[num]);
						}
						else
						{
							this.Left[num] = (float)((double)(this.FromLeft[num] - 10f) + (double)this.RadianX * 1.9 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
							this.Top[num] = (float)((double)(this.FromTop[num] - 5f) + (double)this.RadianY * 1.9 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
							graphics.DrawString(text, new Font("Verdana", this.schriftgroesse2, FontStyle.Regular), Brushes.Blue, this.x + this.Left[num], this.y + this.Top[num], this.drawFormat);
						}
					}
					this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.1 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.1 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					graphics.DrawLine(this.bluePen, this.x + this.aLeft[num], this.y + this.aTop[num], this.x + this.eLeft[num], this.y + this.eTop[num]);
					flag = (Conversions.ToDouble(this.grad2) > 350.0);
					if (flag)
					{
						this.grad2 = "0";
					}
					else
					{
						flag = (Conversions.ToDouble(this.grad2) > 170.0 & Conversions.ToDouble(this.grad2) < 350.0);
						if (flag)
						{
							flag2 = true;
						}
						flag = !flag2;
						if (flag)
						{
							this.grad2 = Conversions.ToString(Conversions.ToDouble(this.grad2) + 10.0);
						}
						else
						{
							this.grad2 = Conversions.ToString(Conversions.ToDouble(this.grad2) - 10.0);
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
					this.aLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.15 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.aTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.15 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					graphics.DrawLine(this.bluePen, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
				}
				flag = (MyProject.Forms.Menue.CheckBox8.CheckState == CheckState.Checked);
				if (flag)
				{
					this.aLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.0 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.aTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.0 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eLeft[num3] = (float)((double)this.FromLeft[num3] + (double)this.RadianX * 2.1 * Math.Cos((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					this.eTop[num3] = (float)((double)this.FromTop[num3] + (double)this.RadianY * 2.1 * Math.Sin((double)this.Angle + ((double)((float)num3 * this.Multiplicator3) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
					flag = ((double)num3 == 54.0 - Conversions.ToDouble(this.wenewinkel) / 10.0 + 1.0);
					if (flag)
					{
						graphics.DrawLine(this.amwindPen1, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
					}
					else
					{
						flag = ((double)num3 == 54.0 + Conversions.ToDouble(this.wenewinkel) / 10.0 - 1.0);
						if (flag)
						{
							graphics.DrawLine(this.amwindPen2, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
						}
						else
						{
							flag = ((double)num3 == 54.0 - Conversions.ToDouble(this.wenewinkel) / 10.0 + 2.0);
							if (flag)
							{
								graphics.DrawLine(this.amwindPen1, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
							}
							else
							{
								flag = ((double)num3 == 54.0 + Conversions.ToDouble(this.wenewinkel) / 10.0 - 2.0);
								if (flag)
								{
									graphics.DrawLine(this.amwindPen2, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
								}
								else
								{
									flag = ((double)num3 == 54.0 - Conversions.ToDouble(this.wenewinkel) / 10.0 + 3.0);
									if (flag)
									{
										graphics.DrawLine(this.amwindPen1, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
									}
									else
									{
										flag = ((double)num3 == 54.0 + Conversions.ToDouble(this.wenewinkel) / 10.0 - 3.0);
										if (flag)
										{
											graphics.DrawLine(this.amwindPen2, this.x + this.aLeft[num3], this.y + this.aTop[num3], this.x + this.eLeft[num3], this.y + this.eTop[num3]);
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
			this.grad = "90";
			this.grad2 = "90";
			this.kurs_boot = MyProject.Forms.Menue.kurs_boot;
			bool flag = MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked;
			if (flag)
			{
				this.kurs_boot = "0";
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
				this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.1 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
				this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.1 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
				this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.1 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
				this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.1 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
				flag = (num == 18);
				if (flag)
				{
					graphics.DrawLine(this.blackPen, this.x + this.aLeft[18], this.y + this.aTop[18], this.x + this.eLeft[0], this.y + this.eTop[0]);
				}
				flag = (num == 27);
				if (flag)
				{
					graphics.DrawLine(this.blackPen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[9], this.y + this.eTop[9]);
					flag = (MyProject.Forms.Menue.CheckBox4.CheckState == CheckState.Checked);
					if (flag)
					{
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.2 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.2 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_boot)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap = new AdjustableArrowCap(2f, 5f, false);
						adjustableArrowCap.BaseCap = LineCap.Round;
						adjustableArrowCap.BaseInset = 5f;
						adjustableArrowCap.StrokeJoin = LineJoin.Bevel;
						this.KursliniePen.CustomStartCap = adjustableArrowCap;
						this.KursliniePen.Width = Conversions.ToSingle(MyProject.Forms.Menue.ComboBox1.SelectedIndex.ToString());
						this.KursliniePen.DashStyle = DashStyle.Dash;
						graphics.DrawLine(this.KursliniePen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x, this.y);
					}
					flag = (MyProject.Forms.Menue.CheckBox8.CheckState == CheckState.Checked);
					bool flag2;
					if (flag)
					{
						flag2 = (MyProject.Forms.Menue.kurs_wind != 0);
						if (flag2)
						{
							this.kurs_wind = Conversions.ToString(MyProject.Forms.Menue.kurs_wind);
						}
						else
						{
							this.kurs_wind = Conversions.ToString(MyProject.Forms.Menue.HScrollBar1.Value);
						}
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.3 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.3 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.5 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.5 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap2 = new AdjustableArrowCap(17f, 1f, false);
						adjustableArrowCap2.WidthScale = 1f;
						adjustableArrowCap2.BaseCap = LineCap.Square;
						adjustableArrowCap2.Height = (float)((double)this.RadianX * 1.9);
						this.windPen.CustomStartCap = adjustableArrowCap2;
						graphics.DrawLine(this.windPen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
						double num2 = (double)(MyProject.Forms.Menue.stark_wind_d / 10f) + 0.2;
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * num2 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * num2 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.72 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.72 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						AdjustableArrowCap adjustableArrowCap3 = new AdjustableArrowCap(5f, 1f, true);
						adjustableArrowCap3.WidthScale = 1f;
						adjustableArrowCap3.BaseCap = LineCap.Square;
						adjustableArrowCap3.Height = 5f;
						this.bluePen2.CustomStartCap = adjustableArrowCap3;
						graphics.DrawLine(this.bluePen2, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
						Pen pen = new Pen(Color.Blue, 5f);
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.5 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.5 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 0.72 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 0.72 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
						pen.Width = 8f;
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 1.18 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 1.18 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 1.2 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 1.2 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
						pen.Width = 6f;
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 1.68 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 1.68 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 1.7 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 1.7 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(pen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
						this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.15 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.15 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.21 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.21 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.kurs_wind)) * 0.017453292519943295));
						graphics.DrawLine(this.windPen2, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
					}
					flag2 = (Operators.CompareString(MyProject.Forms.Menue.TextBox1.Text, "", false) != 0);
					if (flag2)
					{
						flag = (MyProject.Forms.Menue.CheckBox6.CheckState == CheckState.Checked);
						if (flag)
						{
							this.peilung = Conversions.ToString(-Conversions.ToDouble(MyProject.Forms.Menue.kurs_boot) + Conversions.ToDouble(MyProject.Forms.Menue.TextBox1.Text));
							flag2 = (Operators.CompareString(this.peilung, "0", false) < 0);
							if (flag2)
							{
								this.peilung = Conversions.ToString(360.0 + Conversions.ToDouble(this.peilung));
							}
						}
						else
						{
							this.peilung = MyProject.Forms.Menue.TextBox1.Text;
						}
						flag2 = (Conversions.ToDouble(this.peilung) > 0.0 & Conversions.ToDouble(this.peilung) < 361.0);
						if (flag2)
						{
							this.aLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.6 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.peilung)) * 0.017453292519943295));
							this.aTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.6 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.peilung)) * 0.017453292519943295));
							this.eLeft[num] = (float)((double)this.FromLeft[num] + (double)this.RadianX * 2.65 * Math.Cos((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.peilung)) * 0.017453292519943295));
							this.eTop[num] = (float)((double)this.FromTop[num] + (double)this.RadianY * 2.65 * Math.Sin((double)this.Angle + ((double)((float)num * this.Multiplicator) + Conversions.ToDouble(this.peilung)) * 0.017453292519943295));
							AdjustableArrowCap adjustableArrowCap4 = new AdjustableArrowCap(10f, 1f, true);
							adjustableArrowCap4.WidthScale = 1f;
							adjustableArrowCap4.BaseCap = LineCap.Square;
							adjustableArrowCap4.Height = 10f;
							this.peilungPen.CustomStartCap = adjustableArrowCap4;
							graphics.DrawLine(this.peilungPen, this.x + this.aLeft[27], this.y + this.aTop[27], this.x + this.eLeft[27], this.y + this.eTop[27]);
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

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Invalidate();
		}
	}
}
