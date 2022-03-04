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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDoodleBoard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UpdateUI();
        }

        private void UpdateUI()
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.red);
        }

        private void buttonDraw_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.draw);
        }

        private void buttonEraser_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.eraser);
        }

        private void buttonLine_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.line);
        }

        private void buttonRect_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.rect);
        }

        private void buttonCircle_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.circle);
        }

        private void buttonArrow_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.arrow);
        }

        private void buttonCube_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.cube);
        }

        private void buttonCylinder_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.cylinder);
        }

        private void buttonCone_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawType(Doodle.DoodleEnum.DoodleEnumType.cone);
        }




        private void buttonBlack_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.black);
        }

        private void buttonBlue_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.blue);
        }

        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.red);
        }

        private void buttonGreen_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.green);
        }

        private void buttonOrange_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.purple);
        }

        private void buttonBrush3_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawWidth(Doodle.DoodleEnum.DoodleEnumBrushType.middle);
        }

        private void buttonBrush4_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetDrawWidth(Doodle.DoodleEnum.DoodleEnumBrushType.big);
        }



        private void buttonModeDraw_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetCanDraw();
            UpdateUI();
        }

        private void buttonModeSelect_Click(object sender, RoutedEventArgs e)
        {
            doodle.SetCanSelect();
            UpdateUI();
        }

		private void doodle_Loaded_1(object sender, RoutedEventArgs e)
		{
            this.WindowState = System.Windows.WindowState.Normal;//还原窗口（非最小化和最大化）
            this.WindowStyle = System.Windows.WindowStyle.None; //仅工作区可见，不显示标题栏和边框
            this.ResizeMode = System.Windows.ResizeMode.NoResize;//不显示最大化和最小化按钮
            this.Topmost = true;    //窗口在最前

            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
        }

		private void buttonExit_Click(object sender, RoutedEventArgs e)
		{
            Start start = new Start();
            start.Show();
            this.Close();
        }

		private void buttonClearAll_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

		private void buttonPurple_Click(object sender, RoutedEventArgs e)
		{
            doodle.SetDrawColor(Doodle.DoodleEnum.DoodleEnumColor.purple);
        }
	}
}
