using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Exclusive_injector.Properties;

namespace Exclusive_injector
{
	public class MainWindow : Window, IComponentConnector
	{
		private delegate int IntReturner();

		private const uint PAGE_EXECUTE_READWRITE = 64u;

		private const uint MEM_COMMIT = 4096u;

		private bool mouseDown;

		private Point startMouseRelativePos;

		internal TextBlock tbTitle;

		internal GradientStop tblEffectCol;

		internal TextBlock textboxTitle;

		internal Button btnInject;

		private bool _contentLoaded;

		public MainWindow()
		{
			InitializeComponent();
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		private void btnInject_Click(object sender, RoutedEventArgs e)
		{
			string[] array = new string[5] { "Last injection: Module not found", "Last injection: Successful", "Last injection: Dll not found", "Last injection: Process not found", "Last injection: Unknown error" };
			string currentDirectory = Directory.GetCurrentDirectory();
			string text = "excl\\tmp.exe";
			string text2 = "excl\\Exclusive csgo.dll";
			string path = "excl\\fonts\\GOTHIC.TTF";
			string path2 = "excl\\fonts\\GOTHICI.TTF";
			string path3 = "excl\\bg\\artbg.png";
			if (!Directory.Exists("excl"))
			{
				Directory.CreateDirectory("excl");
			}
			if (!Directory.Exists("excl\\fonts"))
			{
				Directory.CreateDirectory("excl\\fonts");
			}
			if (!Directory.Exists("excl\\bg"))
			{
				Directory.CreateDirectory("excl\\bg");
			}
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Exclusive_injector.Properties.Resources.Arg_Jnjector_x86);
			}
			if (!File.Exists(text2))
			{
				File.WriteAllBytes(text2, Exclusive_injector.Properties.Resources.Exclusive_csgo);
			}
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, Exclusive_injector.Properties.Resources.GOTHIC);
			}
			if (!File.Exists(path2))
			{
				File.WriteAllBytes(path2, Exclusive_injector.Properties.Resources.GOTHICI);
			}
			if (!File.Exists(path3))
			{
				File.WriteAllBytes(path3, Exclusive_injector.Properties.Resources.artbgfile);
			}
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = text;
			process.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\"", currentDirectory + "\\" + text2, "csgo.exe");
			process.Start();
			process.WaitForExit();
			textboxTitle.Text = array[process.ExitCode];
		}

		private void topPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			mouseDown = true;
			startMouseRelativePos = e.GetPosition(this);
		}

		private void topPanel_PreviewMouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton != MouseButtonState.Pressed)
			{
				mouseDown = false;
			}
			if (mouseDown)
			{
				base.Left = GetMousePos().X - startMouseRelativePos.X;
				base.Top = GetMousePos().Y - startMouseRelativePos.Y;
				UpdateLayout();
			}
			Point GetMousePos()
			{
				return PointToScreen(Mouse.GetPosition(this));
			}
		}

		private void topPanel_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{
			mouseDown = false;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown(228);
		}

		private void Window_Activated(object sender, EventArgs e)
		{
			base.Opacity = 1.0;
		}

		private void Window_Deactivated(object sender, EventArgs e)
		{
			base.Opacity = 0.5;
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!_contentLoaded)
			{
				_contentLoaded = true;
				Uri resourceLocator = new Uri("/Exclusive csgo injector;component/mainwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((MainWindow)target).Activated += Window_Activated;
				((MainWindow)target).Deactivated += Window_Deactivated;
				break;
			case 2:
				tbTitle = (TextBlock)target;
				break;
			case 3:
				tblEffectCol = (GradientStop)target;
				break;
			case 4:
				textboxTitle = (TextBlock)target;
				break;
			case 5:
				((Button)target).PreviewMouseDown += topPanel_PreviewMouseDown;
				((Button)target).PreviewMouseMove += topPanel_PreviewMouseMove;
				((Button)target).PreviewMouseUp += topPanel_PreviewMouseUp;
				break;
			case 6:
				((Button)target).Click += Button_Click_1;
				break;
			case 7:
				((Button)target).Click += Button_Click;
				break;
			case 8:
				btnInject = (Button)target;
				btnInject.Click += btnInject_Click;
				break;
			default:
				_contentLoaded = true;
				break;
			}
		}
	}
}
