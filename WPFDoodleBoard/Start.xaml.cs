using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDoodleBoard
{
	/// <summary>
	/// Start.xaml 的交互逻辑
	/// </summary>
	public partial class Start : Window
	{
		public Start()
		{
			InitializeComponent();
			var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
			this.Left = desktopWorkingArea.Right - this.Width;
			this.Top = desktopWorkingArea.Bottom - this.Height;

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			this.Close();
			mainWindow.Show();
		}
	}
}
