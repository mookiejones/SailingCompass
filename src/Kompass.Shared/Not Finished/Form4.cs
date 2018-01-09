using System;
using System.Collections.Generic;
using System.Text;

namespace Kompass.Shared.Not_Finished
{
  	[DesignerGenerated]
	public class Form4 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("DateTimePicker1")]
		private DateTimePicker _DateTimePicker1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		[AccessedThroughProperty("Timer3")]
		private Timer _Timer3;

		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		[AccessedThroughProperty("LatLongEinfügenToolStripMenuItem")]
		private ToolStripMenuItem _LatLongEinfügenToolStripMenuItem;

		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		[AccessedThroughProperty("PasteLatlongOpenCPNToolStripMenuItem")]
		private ToolStripMenuItem _PasteLatlongOpenCPNToolStripMenuItem;

		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		[AccessedThroughProperty("StartlinieToolStripMenuItem")]
		private ToolStripMenuItem _StartlinieToolStripMenuItem;

		[AccessedThroughProperty("ÖffnenToolStripMenuItem")]
		private ToolStripMenuItem _ÖffnenToolStripMenuItem;

		[AccessedThroughProperty("SpeichernToolStripMenuItem")]
		private ToolStripMenuItem _SpeichernToolStripMenuItem;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("ProgressBar2")]
		private ProgressBar _ProgressBar2;

		[AccessedThroughProperty("startbahn")]
		private PictureBox _startbahn;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		private int XStart_Pfeil;

		private int Boot_Pfeil;

		private int Boot_Pfeil_start;

		private double stepp;

		private double sek_zum_ziel;

		private StringFormat drawFormat;

		private int sound_abspielen_sek;

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

		internal virtual DateTimePicker DateTimePicker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateTimePicker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateTimePicker1 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				bool flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick -= value2;
				}
				this._Timer2 = value;
				flag = (this._Timer2 != null);
				if (flag)
				{
					this._Timer2.Tick += value2;
				}
			}
		}

		internal virtual Timer Timer3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer3_Tick);
				bool flag = this._Timer3 != null;
				if (flag)
				{
					this._Timer3.Tick -= value2;
				}
				this._Timer3 = value;
				flag = (this._Timer3 != null);
				if (flag)
				{
					this._Timer3.Tick += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				bool flag = this._CheckBox1 != null;
				if (flag)
				{
					this._CheckBox1.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				flag = (this._CheckBox1 != null);
				if (flag)
				{
					this._CheckBox1.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				bool flag = this._CheckBox2 != null;
				if (flag)
				{
					this._CheckBox2.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				flag = (this._CheckBox2 != null);
				if (flag)
				{
					this._CheckBox2.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		internal virtual TextBox TextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox4 = value;
			}
		}

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				bool flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				flag = (this._Button2 != null);
				if (flag)
				{
					this._Button2.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox5 = value;
			}
		}

		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		internal virtual ToolStripMenuItem LatLongEinfügenToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LatLongEinfügenToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LatLongEinfügenToolStripMenuItem_Click);
				bool flag = this._LatLongEinfügenToolStripMenuItem != null;
				if (flag)
				{
					this._LatLongEinfügenToolStripMenuItem.Click -= value2;
				}
				this._LatLongEinfügenToolStripMenuItem = value;
				flag = (this._LatLongEinfügenToolStripMenuItem != null);
				if (flag)
				{
					this._LatLongEinfügenToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip2 = value;
			}
		}

		internal virtual ToolStripMenuItem PasteLatlongOpenCPNToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasteLatlongOpenCPNToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteLatlongOpenCPNToolStripMenuItem_Click);
				bool flag = this._PasteLatlongOpenCPNToolStripMenuItem != null;
				if (flag)
				{
					this._PasteLatlongOpenCPNToolStripMenuItem.Click -= value2;
				}
				this._PasteLatlongOpenCPNToolStripMenuItem = value;
				flag = (this._PasteLatlongOpenCPNToolStripMenuItem != null);
				if (flag)
				{
					this._PasteLatlongOpenCPNToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual SaveFileDialog SaveFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		internal virtual OpenFileDialog OpenFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		internal virtual MenuStrip MenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		internal virtual ToolStripMenuItem StartlinieToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StartlinieToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StartlinieToolStripMenuItem = value;
			}
		}

		internal virtual ToolStripMenuItem ÖffnenToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ÖffnenToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ÖffnenToolStripMenuItem_Click_1);
				bool flag = this._ÖffnenToolStripMenuItem != null;
				if (flag)
				{
					this._ÖffnenToolStripMenuItem.Click -= value2;
				}
				this._ÖffnenToolStripMenuItem = value;
				flag = (this._ÖffnenToolStripMenuItem != null);
				if (flag)
				{
					this._ÖffnenToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem SpeichernToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SpeichernToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SpeichernToolStripMenuItem_Click_1);
				bool flag = this._SpeichernToolStripMenuItem != null;
				if (flag)
				{
					this._SpeichernToolStripMenuItem.Click -= value2;
				}
				this._SpeichernToolStripMenuItem = value;
				flag = (this._SpeichernToolStripMenuItem != null);
				if (flag)
				{
					this._SpeichernToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual ProgressBar ProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		internal virtual ProgressBar ProgressBar2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar2 = value;
			}
		}

		internal virtual PictureBox startbahn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._startbahn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.startbahn_1);
				bool flag = this._startbahn != null;
				if (flag)
				{
					this._startbahn.Paint -= value2;
				}
				this._startbahn = value;
				flag = (this._startbahn != null);
				if (flag)
				{
					this._startbahn.Paint += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form4.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form4.__ENCList.Count == Form4.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form4.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form4.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form4.__ENCList[num] = Form4.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form4.__ENCList.RemoveRange(num, Form4.__ENCList.Count - num);
						Form4.__ENCList.Capacity = Form4.__ENCList.Count;
					}
					Form4.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
			this.Timer1 = new Timer(this.components);
			this.DateTimePicker1 = new DateTimePicker();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.TextBox1 = new TextBox();
			this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
			this.LatLongEinfügenToolStripMenuItem = new ToolStripMenuItem();
			this.TextBox2 = new TextBox();
			this.Timer2 = new Timer(this.components);
			this.Timer3 = new Timer(this.components);
			this.TextBox3 = new TextBox();
			this.ContextMenuStrip2 = new ContextMenuStrip(this.components);
			this.PasteLatlongOpenCPNToolStripMenuItem = new ToolStripMenuItem();
			this.TextBox4 = new TextBox();
			this.Label8 = new Label();
			this.Button1 = new Button();
			this.TextBox5 = new TextBox();
			this.Label9 = new Label();
			this.Label10 = new Label();
			this.SaveFileDialog1 = new SaveFileDialog();
			this.OpenFileDialog1 = new OpenFileDialog();
			this.MenuStrip1 = new MenuStrip();
			this.StartlinieToolStripMenuItem = new ToolStripMenuItem();
			this.ÖffnenToolStripMenuItem = new ToolStripMenuItem();
			this.SpeichernToolStripMenuItem = new ToolStripMenuItem();
			this.Label1 = new Label();
			this.ProgressBar1 = new ProgressBar();
			this.ProgressBar2 = new ProgressBar();
			this.PictureBox1 = new PictureBox();
			this.startbahn = new PictureBox();
			this.CheckBox1 = new CheckBox();
			this.Button2 = new Button();
			this.CheckBox2 = new CheckBox();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.Label11 = new Label();
			this.Label12 = new Label();
			this.ContextMenuStrip1.SuspendLayout();
			this.ContextMenuStrip2.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			((ISupportInitialize)this.startbahn).BeginInit();
			this.SuspendLayout();
			this.Timer1.Enabled = true;
			componentResourceManager.ApplyResources(this.DateTimePicker1, "DateTimePicker1");
			this.DateTimePicker1.Format = DateTimePickerFormat.Time;
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.ShowUpDown = true;
			DateTimePicker arg_2B8_0 = this.DateTimePicker1;
			DateTime value = new DateTime(2012, 10, 5, 17, 46, 0, 0);
			arg_2B8_0.Value = value;
			this.Label2.BackColor = Color.Silver;
			this.Label2.BorderStyle = BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.Label2, "Label2");
			this.Label2.ForeColor = Color.Black;
			this.Label2.Name = "Label2";
			componentResourceManager.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			componentResourceManager.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.ContextMenuStrip = this.ContextMenuStrip1;
			this.TextBox1.Name = "TextBox1";
			this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.LatLongEinfügenToolStripMenuItem
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			componentResourceManager.ApplyResources(this.ContextMenuStrip1, "ContextMenuStrip1");
			this.LatLongEinfügenToolStripMenuItem.Name = "LatLongEinfügenToolStripMenuItem";
			componentResourceManager.ApplyResources(this.LatLongEinfügenToolStripMenuItem, "LatLongEinfügenToolStripMenuItem");
			componentResourceManager.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.ContextMenuStrip = this.ContextMenuStrip1;
			this.TextBox2.Name = "TextBox2";
			this.Timer2.Enabled = true;
			this.Timer3.Enabled = true;
			componentResourceManager.ApplyResources(this.TextBox3, "TextBox3");
			this.TextBox3.ContextMenuStrip = this.ContextMenuStrip2;
			this.TextBox3.Name = "TextBox3";
			this.ContextMenuStrip2.Items.AddRange(new ToolStripItem[]
			{
				this.PasteLatlongOpenCPNToolStripMenuItem
			});
			this.ContextMenuStrip2.Name = "ContextMenuStrip2";
			componentResourceManager.ApplyResources(this.ContextMenuStrip2, "ContextMenuStrip2");
			this.PasteLatlongOpenCPNToolStripMenuItem.Name = "PasteLatlongOpenCPNToolStripMenuItem";
			componentResourceManager.ApplyResources(this.PasteLatlongOpenCPNToolStripMenuItem, "PasteLatlongOpenCPNToolStripMenuItem");
			componentResourceManager.ApplyResources(this.TextBox4, "TextBox4");
			this.TextBox4.ContextMenuStrip = this.ContextMenuStrip2;
			this.TextBox4.Name = "TextBox4";
			this.Label8.BackColor = Color.Gray;
			this.Label8.BorderStyle = BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.Label8, "Label8");
			this.Label8.ForeColor = Color.Yellow;
			this.Label8.Name = "Label8";
			componentResourceManager.ApplyResources(this.Button1, "Button1");
			this.Button1.Name = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.TextBox5, "TextBox5");
			this.TextBox5.Name = "TextBox5";
			componentResourceManager.ApplyResources(this.Label9, "Label9");
			this.Label9.Name = "Label9";
			componentResourceManager.ApplyResources(this.Label10, "Label10");
			this.Label10.Name = "Label10";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.MenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.StartlinieToolStripMenuItem
			});
			componentResourceManager.ApplyResources(this.MenuStrip1, "MenuStrip1");
			this.MenuStrip1.Name = "MenuStrip1";
			this.StartlinieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ÖffnenToolStripMenuItem,
				this.SpeichernToolStripMenuItem
			});
			this.StartlinieToolStripMenuItem.Name = "StartlinieToolStripMenuItem";
			componentResourceManager.ApplyResources(this.StartlinieToolStripMenuItem, "StartlinieToolStripMenuItem");
			this.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem";
			componentResourceManager.ApplyResources(this.ÖffnenToolStripMenuItem, "ÖffnenToolStripMenuItem");
			this.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem";
			componentResourceManager.ApplyResources(this.SpeichernToolStripMenuItem, "SpeichernToolStripMenuItem");
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			componentResourceManager.ApplyResources(this.ProgressBar1, "ProgressBar1");
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.Value = 1;
			componentResourceManager.ApplyResources(this.ProgressBar2, "ProgressBar2");
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Step = 1;
			this.ProgressBar2.Value = 1;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackColor = Color.Black;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.startbahn, "startbahn");
			this.startbahn.Name = "startbahn";
			this.startbahn.TabStop = false;
			componentResourceManager.ApplyResources(this.CheckBox1, "CheckBox1");
			this.CheckBox1.Image = Resources._0014_Pin;
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Button2, "Button2");
			this.Button2.BackColor = Color.White;
			this.Button2.Image = Resources.start1;
			this.Button2.Name = "Button2";
			this.Button2.UseVisualStyleBackColor = false;
			componentResourceManager.ApplyResources(this.CheckBox2, "CheckBox2");
			this.CheckBox2.Image = Resources._0014_Pin;
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			componentResourceManager.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			componentResourceManager.ApplyResources(this.Label6, "Label6");
			this.Label6.Name = "Label6";
			componentResourceManager.ApplyResources(this.Label7, "Label7");
			this.Label7.Name = "Label7";
			componentResourceManager.ApplyResources(this.Label11, "Label11");
			this.Label11.Name = "Label11";
			componentResourceManager.ApplyResources(this.Label12, "Label12");
			this.Label12.Name = "Label12";
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.ProgressBar2);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.startbahn);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox5);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.CheckBox2);
			this.MinimizeBox = false;
			this.Name = "Form4";
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ContextMenuStrip2.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			((ISupportInitialize)this.PictureBox1).EndInit();
			((ISupportInitialize)this.startbahn).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public Form4()
		{
			base.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
			base.Load += new EventHandler(this.Form4_Load);
			base.Paint += new PaintEventHandler(this.Pfeile_Paint);
			Form4.__ENCAddToList(this);
			this.XStart_Pfeil = 0;
			this.Boot_Pfeil = 0;
			this.Boot_Pfeil_start = 0;
			this.sek_zum_ziel = 0.0;
			this.drawFormat = new StringFormat();
			this.sound_abspielen_sek = 10;
			this.InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.UpdateStyles();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				TimeSpan timeSpan = TimeSpan.FromSeconds(Conversions.ToDouble((checked((int)Math.Round(DateTime.Now.Subtract(this.DateTimePicker1.Value).TotalSeconds))).ToString()));
				this.Boot_Pfeil = 0;
				this.stepp = (double)this.startbahn.Width / (Conversions.ToDouble(this.TextBox5.Text) * 60.0);
				double num = Conversions.ToDouble(this.TextBox5.Text) * 60.0;
				bool flag = Operators.CompareString(Conversions.ToString(timeSpan.ToString()[0]), "-", false) == 0;
				if (flag)
				{
					this.Label2.Text = Strings.Replace(timeSpan.ToString(), "-", "", 1, -1, CompareMethod.Binary);
					this.sek_zum_ziel = Conversions.ToDouble(Strings.Replace(Conversions.ToString(timeSpan.TotalSeconds), "-", "", 1, -1, CompareMethod.Binary));
					double num2 = this.sek_zum_ziel * this.stepp;
					this.XStart_Pfeil = checked((int)Math.Round(unchecked((double)(checked((int)Math.Round(unchecked(this.stepp * num)))) - num2)));
				}
				else
				{
					this.Label2.Text = "00:00:00";
					this.XStart_Pfeil = 0;
				}
				flag = (Operators.CompareString(this.Label2.Text, "00:00:00", false) == 0);
				if (flag)
				{
					this.Button2.Image = Resources.start1;
				}
				else
				{
					this.Button2.Image = Resources.start2;
				}
				flag = (MyProject.Forms.Menue.Start1.is_set() & MyProject.Forms.Menue.Start2.is_set() & MyProject.Forms.Menue.ShipPos.is_set());
				if (flag)
				{
					this.Label8.Text = Funktionen.Time2Go(MyProject.Forms.Menue.Start1, MyProject.Forms.Menue.Start2, MyProject.Forms.Menue.ShipPos, Conversions.ToDouble(MyProject.Forms.Menue.kurs_boot), Conversions.ToDouble(MyProject.Forms.Menue.speed));
					string text = this.Label8.Text;
					string[] array = text.Split(new char[]
					{
						':'
					});
					string value = array[0];
					string value2 = array[1];
					string value3 = array[2];
					text = Conversions.ToString(Conversions.ToDouble(value) * 60.0 * 60.0 + Conversions.ToDouble(value2) * 60.0 + Conversions.ToDouble(value3));
					double num3 = Conversions.ToDouble(text);
					flag = (num3 < num);
					if (flag)
					{
						double num4 = num3 * this.stepp;
						this.Boot_Pfeil = checked((int)Math.Round(unchecked((double)(checked((int)Math.Round(unchecked(this.stepp * num)))) - num4)));
					}
				}
				else
				{
					this.Label8.Text = "00:00:00";
				}
				string text2 = this.Label2.Text;
				string text3 = this.Label8.Text;
				DateTime d;
				DateTime d2;
				flag = (DateTime.TryParse(text2, out d) && DateTime.TryParse(text3, out d2));
				checked
				{
					if (flag)
					{
						TimeSpan timeSpan2 = d2 - d;
						int hours = timeSpan2.Hours;
						int minutes = timeSpan2.Minutes;
						int seconds = timeSpan2.Seconds;
						int num5 = (int)Math.Round(timeSpan2.TotalSeconds);
						flag = (num5 < 0);
						if (flag)
						{
							num5 = Conversions.ToInteger(Strings.Replace(num5.ToString(), "-", "", 1, -1, CompareMethod.Binary));
							this.ProgressBar1.Maximum = num5 + 30;
							this.ProgressBar1.Value = num5;
							this.ProgressBar2.Value = 0;
						}
						else
						{
							this.ProgressBar2.Maximum = num5 + 30;
							this.ProgressBar2.Value = num5;
							this.ProgressBar1.Value = 0;
						}
					}
					this.startbahn.Invalidate();
				}
			}
			catch (Exception expr_430)
			{
				ProjectData.SetProjectError(expr_430);
				ProjectData.ClearProjectError();
			}
		}

		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
		{
			MyProject.Forms.Menue.Start1.stop_set();
			MyProject.Forms.Menue.Start2.stop_set();
			MyProject.Forms.Menue.CheckBox10.CheckState = CheckState.Unchecked;
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			string format = "HH:mm:ss";
			this.DateTimePicker1.Text = now.ToString(format);
			this.TopMost = true;
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				string text = MyProject.Forms.Menue.Latitude.Substring(0, 2) + " " + MyProject.Forms.Menue.Latitude.Substring(2, 6);
				string text2 = MyProject.Forms.Menue.Longitude.Substring(0, 3) + " " + MyProject.Forms.Menue.Longitude.Substring(3, 6);
				this.TextBox1.Text = text.Replace(",", ".");
				this.TextBox2.Text = text2.Replace(",", ".");
			}
			catch (Exception expr_B6)
			{
				ProjectData.SetProjectError(expr_B6);
				ProjectData.ClearProjectError();
			}
		}

		private void Timer3_Tick(object sender, EventArgs e)
		{
			try
			{
				string text = MyProject.Forms.Menue.Latitude.Substring(0, 2) + " " + MyProject.Forms.Menue.Latitude.Substring(2, 6);
				string text2 = MyProject.Forms.Menue.Longitude.Substring(0, 3) + " " + MyProject.Forms.Menue.Longitude.Substring(3, 6);
				this.TextBox3.Text = text.Replace(",", ".");
				this.TextBox4.Text = text2.Replace(",", ".");
			}
			catch (Exception expr_B6)
			{
				ProjectData.SetProjectError(expr_B6);
				ProjectData.ClearProjectError();
			}
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.CheckBox1.CheckState == CheckState.Checked;
			if (flag)
			{
				this.Timer2.Enabled = false;
				this.TextBox1.Enabled = false;
				this.TextBox2.Enabled = false;
				this.CheckBox1.Image = Resources._0015_Pin;
			}
			else
			{
				string punkt1loeschen = ResourceText.Punkt1loeschen;
				string startlineloeschen = ResourceText.Startlineloeschen;
				this.Timer2.Enabled = true;
				this.TextBox1.Enabled = true;
				this.TextBox2.Enabled = true;
				MyProject.Forms.Menue.Start1.stop_set();
				MyProject.Forms.Menue.Start2.stop_set();
				this.CheckBox1.Image = Resources._0014_Pin;
				this.CheckBox1.CheckState = CheckState.Unchecked;
			}
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.CheckBox2.CheckState == CheckState.Checked;
			if (flag)
			{
				this.Timer3.Enabled = false;
				this.TextBox3.Enabled = false;
				this.TextBox4.Enabled = false;
				this.CheckBox2.Image = Resources._0015_Pin;
			}
			else
			{
				string punkt2loeschen = ResourceText.Punkt2loeschen;
				string startlineloeschen = ResourceText.Startlineloeschen;
				this.Timer3.Enabled = true;
				this.TextBox3.Enabled = true;
				this.TextBox4.Enabled = true;
				MyProject.Forms.Menue.Start1.stop_set();
				MyProject.Forms.Menue.Start2.stop_set();
				this.CheckBox2.Image = Resources._0014_Pin;
				this.CheckBox2.CheckState = CheckState.Unchecked;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.Timer2.Enabled & !this.Timer3.Enabled & Operators.CompareString(this.TextBox1.Text, "", false) != 0 & Operators.CompareString(this.TextBox2.Text, "", false) != 0 & Operators.CompareString(this.TextBox3.Text, "", false) != 0 & Operators.CompareString(this.TextBox4.Text, "", false) != 0 & Operators.CompareString(this.TextBox1.Text, this.TextBox3.Text, false) != 0;
				if (flag)
				{
					MyProject.Forms.Menue.Start1.set_from_Textbox(this.TextBox1, this.TextBox2);
					MyProject.Forms.Menue.Start2.set_from_Textbox(this.TextBox3, this.TextBox4);
				}
				else
				{
					string latLongUasOpenCPNeinfügen = ResourceText.LatLongUasOpenCPNeinfügen;
					string startAbfahrenPinnadelKlick = ResourceText.StartAbfahrenPinnadelKlick;
					Interaction.MsgBox(latLongUasOpenCPNeinfügen + "\r\n\r\n" + startAbfahrenPinnadelKlick, MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception expr_124)
			{
				ProjectData.SetProjectError(expr_124);
				string latLongUasOpenCPNeinfügen2 = ResourceText.LatLongUasOpenCPNeinfügen;
				string startAbfahrenPinnadelKlick2 = ResourceText.StartAbfahrenPinnadelKlick;
				Interaction.MsgBox(latLongUasOpenCPNeinfügen2 + "\r\n\r\n" + startAbfahrenPinnadelKlick2, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.sound_abspielen_sek = 10;
			try
			{
				int num = Conversions.ToInteger(this.TextBox5.Text);
				DateTime dateTime = DateTime.Now;
				dateTime += TimeSpan.FromMinutes((double)num);
				this.DateTimePicker1.Text = Conversions.ToString(dateTime);
			}
			catch (Exception expr_43)
			{
				ProjectData.SetProjectError(expr_43);
				string xStartMsgBox = ResourceText.XStartMsgBox;
				Interaction.MsgBox(xStartMsgBox, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void LatLongEinfügenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.CheckBox1.CheckState = CheckState.Checked;
				string[] array = Strings.Split(Clipboard.GetText(), "\t", -1, CompareMethod.Binary);
				string[] array2 = Strings.Split(array[0], " ", -1, CompareMethod.Binary);
				this.TextBox1.Text = array2[0] + " " + array2[1];
				string[] array3 = Strings.Split(array[1], " ", -1, CompareMethod.Binary);
				this.TextBox2.Text = array3[0] + " " + array3[1];
			}
			catch (Exception expr_7B)
			{
				ProjectData.SetProjectError(expr_7B);
				this.CheckBox1.CheckState = CheckState.Unchecked;
				this.TextBox1.Text = "";
				this.TextBox2.Text = "";
				string keinLatLongAusOpenCPN = ResourceText.keinLatLongAusOpenCPN;
				Interaction.MsgBox(keinLatLongAusOpenCPN, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void PasteLatlongOpenCPNToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.CheckBox2.CheckState = CheckState.Checked;
				string[] array = Strings.Split(Clipboard.GetText(), "\t", -1, CompareMethod.Binary);
				string[] array2 = Strings.Split(array[0], " ", -1, CompareMethod.Binary);
				this.TextBox3.Text = array2[0] + " " + array2[1];
				string[] array3 = Strings.Split(array[1], " ", -1, CompareMethod.Binary);
				this.TextBox4.Text = array3[0] + " " + array3[1];
			}
			catch (Exception expr_7B)
			{
				ProjectData.SetProjectError(expr_7B);
				this.CheckBox2.CheckState = CheckState.Unchecked;
				this.TextBox3.Text = "";
				this.TextBox4.Text = "";
				string keinLatLongAusOpenCPN = ResourceText.keinLatLongAusOpenCPN;
				Interaction.MsgBox(keinLatLongAusOpenCPN, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void ÖffnenToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "txt files (*.txt)|*.txt";
				openFileDialog.Title = "";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.CheckBox1.CheckState = CheckState.Checked;
					this.CheckBox2.CheckState = CheckState.Checked;
					string[] array = File.ReadAllLines(openFileDialog.FileName);
					string[] array2 = Strings.Split(array[0], "#", -1, CompareMethod.Binary);
					this.TextBox1.Text = array2[1];
					this.TextBox2.Text = array2[2];
					this.TextBox3.Text = array2[3];
					this.TextBox4.Text = array2[4];
					this.TextBox5.Text = array2[5];
					this.Button1.PerformClick();
				}
			}
			catch (Exception expr_C2)
			{
				ProjectData.SetProjectError(expr_C2);
				this.CheckBox1.CheckState = CheckState.Unchecked;
				this.CheckBox2.CheckState = CheckState.Unchecked;
				string dateiKeineStartdaten = ResourceText.DateiKeineStartdaten;
				Interaction.MsgBox(dateiKeineStartdaten, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void SpeichernToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "txt files (*.txt)|*.txt";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = Operators.CompareString(saveFileDialog.FileName, "", false) != 0;
				if (flag2)
				{
					FileSystem.FileOpen(1, saveFileDialog.FileName, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
					FileSystem.PrintLine(1, new object[]
					{
						string.Concat(new string[]
						{
							"Startlinie#",
							this.TextBox1.Text,
							"#",
							this.TextBox2.Text,
							"#",
							this.TextBox3.Text,
							"#",
							this.TextBox4.Text,
							"#",
							this.TextBox5.Text
						})
					});
					FileSystem.FileClose(new int[]
					{
						1
					});
				}
			}
		}

		private void Pfeile_Paint(object sender, PaintEventArgs e)
		{
		}

		private void startbahn_1(object sender, PaintEventArgs e)
		{
			Bitmap image = new Bitmap(this.startbahn.Width, this.startbahn.Height, e.Graphics);
			Graphics graphics = Graphics.FromImage(image);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			Pen pen = new Pen(Color.Yellow, 80f);
			bool flag = this.XStart_Pfeil > this.Boot_Pfeil;
			if (flag)
			{
				pen.Color = Color.Yellow;
				this.Label8.ForeColor = Color.Yellow;
			}
			else
			{
				pen.Color = Color.Red;
				this.Label8.ForeColor = Color.Red;
			}
			graphics.DrawLine(pen, this.Boot_Pfeil, 110, 2, 110);
			Pen pen2 = new Pen(Color.Black, 5f);
			graphics.DrawLine(pen2, this.XStart_Pfeil, 20, this.XStart_Pfeil, 349);
			checked
			{
				graphics.DrawString(this.sek_zum_ziel.ToString(), new Font("Verdana", 12f, FontStyle.Regular), Brushes.Black, (float)(this.XStart_Pfeil - 12), 0f, this.drawFormat);
				flag = (this.sek_zum_ziel == (double)this.sound_abspielen_sek & this.sek_zum_ziel > -1.0);
				if (flag)
				{
					MyProject.Computer.Audio.Play(Resources._1bells, AudioPlayMode.Background);
					this.sound_abspielen_sek = (int)Math.Round(unchecked(this.sek_zum_ziel - 1.0));
				}
				Rectangle rect = new Rectangle(0, 0, this.startbahn.Width, 230);
				LinearGradientBrush brush = new LinearGradientBrush(rect, Color.White, Color.Blue, LinearGradientMode.ForwardDiagonal);
				e.Graphics.FillRectangle(brush, rect);
				e.Graphics.DrawImageUnscaled(image, 0, 0);
				graphics.Dispose();
			}
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}
	}
}
