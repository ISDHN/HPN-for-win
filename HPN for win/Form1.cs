using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace HPN_for_win
{
	
	public partial class Form1 : Form
	{
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool IsWindowVisible(IntPtr hWnd);
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		static   extern bool SetWindowText(IntPtr hwnd, String lpString);
		[DllImport("user32.dll", SetLastError = true )]
		static extern IntPtr GetDesktopWindow();
		public Fireworks[] fireworks = new Fireworks[8];
		public PictureBox[] pictures = new PictureBox[8];
		public System.Threading.Thread movefirework ;
		public System.Threading.Thread seteachwindowtext;
		public System.Media.SoundPlayer player = new System.Media.SoundPlayer
		{
			Stream = Properties.Resources._12316
		};
		public Form1()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			Top = 0;
			Left = 0;
			Width = (int)SystemParameters.PrimaryScreenWidth;
			Height = (int)SystemParameters.PrimaryScreenHeight;
			for (int i = 0; i <fireworks.Length; i++)
			{
				fireworks[i] = new Fireworks
				{
					Left =  ((int)SystemParameters.PrimaryScreenWidth / 8) * i,
					Top = Height - Fireworks.defaultHeight,
				};
				pictures[i] = new PictureBox {
					Left = ((int)SystemParameters.PrimaryScreenWidth / 8) * i,
					Top = 100,
					Size = new Size(119,119),
					SizeMode = PictureBoxSizeMode.Zoom,
					Image =Properties.Resources.flower,				
			};
				Controls.Add(fireworks[i]);
				Controls.Add(pictures[i]);
			}
			message.Location = new Point(Width / 2 - message.Width / 2, Height / 2 - message.Height / 2);
			message1.Location = new Point(Width / 2 - message1.Width / 2, message.Top - message1.Height);
			esc.Location = new Point(Width - esc.Width, Height - esc.Height);
			movefirework = new System.Threading.Thread(Up);
			seteachwindowtext = new System.Threading.Thread(SetText);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			movefirework.Start();
		}
		private void AfterToTop()
		{
			message.Visible = true;
			message1.Visible = true;
			esc.Show();
			foreach (PictureBox picture in pictures)
				picture.Show();			
		}
		private void Up()
		{
			esc.Hide();
			message.Hide();
			message1.Hide();
			foreach (PictureBox p in pictures) p.Hide();
			while (fireworks[7].Top>0){
				for (int i = 0; i < fireworks.Length; i++)
				{
				 fireworks[i].Top --;
				}			
			}
			player.Play();
			foreach (Fireworks firework in fireworks)
				firework.Hide();
			AfterToTop();
		}
		private void SetText()
		{
			IntPtr desktop = GetDesktopWindow();
				while(true){
					for(IntPtr window=GetWindow(desktop,5); window!= IntPtr.Zero; window = GetWindow(window, 2))
					{
						if (IsWindowVisible(window))
							SetWindowText(window, "祝您2020身体健康，万事如意，中考取得好成绩！2020一定行！");
					}
				}
		}

		private void Esc_Click(object sender, EventArgs e)
		{
			Hide();
			seteachwindowtext.Start();
		}
	}
}
