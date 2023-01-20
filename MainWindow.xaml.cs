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

namespace wpfFlag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region initialization
        public MainWindow()
        {
            InitializeComponent();

            beginFlag();
        }

        public void beginFlag()
        {
            GridMaker();
            AddRedStripes();
            addBlueRect();
            blueGrid();
            evenStar();
            oddStar();
            starButtonAdder();
            stripeButtonAdder();
        }

        #endregion

        #region universal declarations
        Grid FlagGrid = new Grid();
        Grid BlueGrid = new Grid();
        #endregion

        #region Base Layer Flag

        public void GridMaker() //https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.grid?view=netframework-4.6.1&f1url=%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Windows.Controls.Grid);k(VS.XamlEditor);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.6.1)%26rd%3Dtrue
        {
            // makes basic grid for the main window/flag
            FlagGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            FlagGrid.VerticalAlignment = VerticalAlignment.Stretch;
            FlagGrid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            FlagGrid.ColumnDefinitions.Add(colDef1);
            FlagGrid.ColumnDefinitions.Add(colDef2);
            FlagGrid.ColumnDefinitions.Add(colDef3);
            FlagGrid.ColumnDefinitions.Add(colDef4);
            FlagGrid.ColumnDefinitions.Add(colDef5);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            RowDefinition rowDef6 = new RowDefinition();
            RowDefinition rowDef7 = new RowDefinition();
            RowDefinition rowDef8 = new RowDefinition();
            RowDefinition rowDef9 = new RowDefinition();
            RowDefinition rowDef10 = new RowDefinition();
            RowDefinition rowDef11 = new RowDefinition();
            RowDefinition rowDef12 = new RowDefinition();
            RowDefinition rowDef13 = new RowDefinition();
            FlagGrid.RowDefinitions.Add(rowDef1);
            FlagGrid.RowDefinitions.Add(rowDef2);
            FlagGrid.RowDefinitions.Add(rowDef3);
            FlagGrid.RowDefinitions.Add(rowDef4);
            FlagGrid.RowDefinitions.Add(rowDef5);
            FlagGrid.RowDefinitions.Add(rowDef6);
            FlagGrid.RowDefinitions.Add(rowDef7);
            FlagGrid.RowDefinitions.Add(rowDef8);
            FlagGrid.RowDefinitions.Add(rowDef9);
            FlagGrid.RowDefinitions.Add(rowDef10);
            FlagGrid.RowDefinitions.Add(rowDef11);
            FlagGrid.RowDefinitions.Add(rowDef12);
            FlagGrid.RowDefinitions.Add(rowDef13);

            Content = FlagGrid;
            Show();

        }

        private void AddRedStripes() //https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.rectangle?view=netframework-4.6.1&f1url=%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Windows.Shapes.Rectangle);k(VS.XamlEditor);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.6.1)%26rd%3Dtrue
        {
            // adds the red stripes to the grid
            for (int x = 0; x <= 13; x = x + 2)
            {
                Rectangle myRect = new System.Windows.Shapes.Rectangle();
                myRect.Stroke = System.Windows.Media.Brushes.Red;
                myRect.Fill = System.Windows.Media.Brushes.Red;
                myRect.HorizontalAlignment = HorizontalAlignment.Stretch;
                myRect.VerticalAlignment = VerticalAlignment.Stretch;
                Grid.SetRow(myRect, x);
                Grid.SetColumnSpan(myRect, 5);
                FlagGrid.Children.Add(myRect);
            }
        }

        private void addBlueRect()
        {
            // adds the blue rectangle to the top left of the grid/flag
            Rectangle myBlue = new System.Windows.Shapes.Rectangle();
            myBlue.Stroke = System.Windows.Media.Brushes.Blue;
            myBlue.Fill = System.Windows.Media.Brushes.Blue;
            myBlue.HorizontalAlignment = HorizontalAlignment.Stretch;
            myBlue.VerticalAlignment = VerticalAlignment.Stretch;
            Grid.SetRowSpan(myBlue, 7);
            Grid.SetColumnSpan(myBlue, 2);
            FlagGrid.Children.Add(myBlue);
        }

        public void blueGrid()
        {
            // overlays the blue of the rectangle with a smaller grid for the stars 
            BlueGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            BlueGrid.VerticalAlignment = VerticalAlignment.Stretch;
            BlueGrid.ShowGridLines = false;

            Grid.SetRow(BlueGrid, 0);
            Grid.SetColumn(BlueGrid, 0);
            Grid.SetRowSpan(BlueGrid, 7);
            Grid.SetColumnSpan(BlueGrid, 2);

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7 = new ColumnDefinition();
            ColumnDefinition colDef8 = new ColumnDefinition();
            ColumnDefinition colDef9 = new ColumnDefinition();
            ColumnDefinition colDef10 = new ColumnDefinition();
            ColumnDefinition colDef11 = new ColumnDefinition();
            BlueGrid.ColumnDefinitions.Add(colDef1);
            BlueGrid.ColumnDefinitions.Add(colDef2);
            BlueGrid.ColumnDefinitions.Add(colDef3);
            BlueGrid.ColumnDefinitions.Add(colDef4);
            BlueGrid.ColumnDefinitions.Add(colDef5);
            BlueGrid.ColumnDefinitions.Add(colDef6);
            BlueGrid.ColumnDefinitions.Add(colDef7);
            BlueGrid.ColumnDefinitions.Add(colDef8);
            BlueGrid.ColumnDefinitions.Add(colDef9);
            BlueGrid.ColumnDefinitions.Add(colDef10);
            BlueGrid.ColumnDefinitions.Add(colDef11);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            RowDefinition rowDef6 = new RowDefinition();
            RowDefinition rowDef7 = new RowDefinition();
            RowDefinition rowDef8 = new RowDefinition();
            RowDefinition rowDef9 = new RowDefinition();
            BlueGrid.RowDefinitions.Add(rowDef1);
            BlueGrid.RowDefinitions.Add(rowDef2);
            BlueGrid.RowDefinitions.Add(rowDef3);
            BlueGrid.RowDefinitions.Add(rowDef4);
            BlueGrid.RowDefinitions.Add(rowDef5);
            BlueGrid.RowDefinitions.Add(rowDef6);
            BlueGrid.RowDefinitions.Add(rowDef7);
            BlueGrid.RowDefinitions.Add(rowDef8);
            BlueGrid.RowDefinitions.Add(rowDef9);

            FlagGrid.Children.Add(BlueGrid);
        }

        public void evenStar() //https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.image.source?view=netframework-4.6.1
        {
            // adds the stars to all the even spaces in the blue grid
            int y = 0;
            for (int x = 0; x <= 12; x++)
            {
                Image Star = new Image(); // all stars are images

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"img\Star.PNG", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                Star.Source = bitmap;


                if (x % 2 == 0 && y % 2 == 0)
                {
                    Grid.SetRow(Star, y);
                    Grid.SetColumn(Star, x);
                    BlueGrid.Children.Add(Star);
                }

                if (x == 12)
                {
                    y++;
                    x = -2;
                }
                if (y == 11)
                {
                    break;
                }

            }



        }

        public void oddStar()
        {
            // adds stars to the odd spaces of the blue grid
            int y = 0;
            for (int x = 0; x <= 12; x++)
            {
                Image Star = new Image();

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"img\Star.PNG", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                Star.Source = bitmap;


                if (x % 2 == 0 && y % 2 == 0)
                {
                    Grid.SetRow(Star, y + 1);
                    Grid.SetColumn(Star, x + 1);
                    BlueGrid.Children.Add(Star);
                }


                if (x == 9)
                {
                    y++;
                    x = -2;
                }
                if (y == 8)
                {
                    break;
                }

            }
        }

        public void starButtonAdder()
        {
            // covers the stars with transparent buttons
            Button Button1 = new Button();
            Button Button2 = new Button();
            Button Button3 = new Button();
            Button Button4 = new Button();
            Button Button5 = new Button();
            Button Button6 = new Button();
            Button Button7 = new Button();
            Button Button8 = new Button();
            Button Button9 = new Button();
            Button Button10 = new Button();
            Button Button11 = new Button();
            Button Button12 = new Button();
            Button Button13 = new Button();
            Button Button14 = new Button();
            Button Button15 = new Button();
            Button Button16 = new Button();
            Button Button17 = new Button();
            Button Button18 = new Button();
            Button Button19 = new Button();
            Button Button20 = new Button();
            Button Button21 = new Button();
            Button Button22 = new Button();
            Button Button23 = new Button();
            Button Button24 = new Button();
            Button Button25 = new Button();
            Button Button26 = new Button();
            Button Button27 = new Button();
            Button Button28 = new Button();
            Button Button29 = new Button();
            Button Button30 = new Button();
            Button Button31 = new Button();
            Button Button32 = new Button();
            Button Button33 = new Button();
            Button Button34 = new Button();
            Button Button35 = new Button();
            Button Button36 = new Button();
            Button Button37 = new Button();
            Button Button38 = new Button();
            Button Button39 = new Button();
            Button Button40 = new Button();
            Button Button41 = new Button();
            Button Button42 = new Button();
            Button Button43 = new Button();
            Button Button44 = new Button();
            Button Button45 = new Button();
            Button Button46 = new Button();
            Button Button47 = new Button();
            Button Button48 = new Button();
            Button Button49 = new Button();
            Button Button50 = new Button();

            Grid.SetRow(Button1, 0);
            Grid.SetColumn(Button1, 0);
            Button1.Background = Brushes.Transparent;
            Button1.BorderBrush = null;
            Grid.SetRow(Button2, 0);
            Grid.SetColumn(Button2, 2);
            Button2.Background = Brushes.Transparent;
            Button2.BorderBrush = null;
            Grid.SetRow(Button3, 0);
            Grid.SetColumn(Button3, 4);
            Button3.Background = Brushes.Transparent;
            Button3.BorderBrush = null;
            Grid.SetRow(Button4, 0);
            Grid.SetColumn(Button4, 6);
            Button4.Background = Brushes.Transparent;
            Button4.BorderBrush = null;
            Grid.SetRow(Button5, 0);
            Grid.SetColumn(Button5, 8);
            Button5.Background = Brushes.Transparent;
            Button5.BorderBrush = null;
            Grid.SetRow(Button6, 0);
            Grid.SetColumn(Button6, 10);
            Button6.Background = Brushes.Transparent;
            Button6.BorderBrush = null;
            Grid.SetRow(Button7, 1);
            Grid.SetColumn(Button7, 1);
            Button7.Background = Brushes.Transparent;
            Button7.BorderBrush = null;
            Grid.SetRow(Button8, 1);
            Grid.SetColumn(Button8, 3);
            Button8.Background = Brushes.Transparent;
            Button8.BorderBrush = null;
            Grid.SetRow(Button9, 1);
            Grid.SetColumn(Button9, 5);
            Button9.Background = Brushes.Transparent;
            Button9.BorderBrush = null;
            Grid.SetRow(Button10, 1);
            Grid.SetColumn(Button10, 7);
            Button10.Background = Brushes.Transparent;
            Button10.BorderBrush = null;
            Grid.SetRow(Button11, 1);
            Grid.SetColumn(Button11, 9);
            Button11.Background = Brushes.Transparent;
            Button11.BorderBrush = null;
            Grid.SetRow(Button12, 2);
            Grid.SetColumn(Button12, 0);
            Button12.Background = Brushes.Transparent;
            Button12.BorderBrush = null;
            Grid.SetRow(Button13, 2);
            Grid.SetColumn(Button13, 2);
            Button13.Background = Brushes.Transparent;
            Button13.BorderBrush = null;
            Grid.SetRow(Button14, 2);
            Grid.SetColumn(Button14, 4);
            Button14.Background = Brushes.Transparent;
            Button14.BorderBrush = null;
            Grid.SetRow(Button15, 2);
            Grid.SetColumn(Button15, 6);
            Button15.Background = Brushes.Transparent;
            Button15.BorderBrush = null;
            Grid.SetRow(Button16, 2);
            Grid.SetColumn(Button16, 8);
            Button16.Background = Brushes.Transparent;
            Button16.BorderBrush = null;
            Grid.SetRow(Button17, 2);
            Grid.SetColumn(Button17, 10);
            Button17.Background = Brushes.Transparent;
            Button17.BorderBrush = null;
            Grid.SetRow(Button18, 3);
            Grid.SetColumn(Button18, 1);
            Button18.Background = Brushes.Transparent;
            Button18.BorderBrush = null;
            Grid.SetRow(Button19, 3);
            Grid.SetColumn(Button19, 3);
            Button19.Background = Brushes.Transparent;
            Button19.BorderBrush = null;
            Grid.SetRow(Button20, 3);
            Grid.SetColumn(Button20, 5);
            Button20.Background = Brushes.Transparent;
            Button20.BorderBrush = null;
            Grid.SetRow(Button21, 3);
            Grid.SetColumn(Button21, 7);
            Button21.Background = Brushes.Transparent;
            Button21.BorderBrush = null;
            Grid.SetRow(Button22, 3);
            Grid.SetColumn(Button22, 9);
            Button22.Background = Brushes.Transparent;
            Button22.BorderBrush = null;
            Grid.SetRow(Button23, 4);
            Grid.SetColumn(Button23, 0);
            Button23.Background = Brushes.Transparent;
            Button23.BorderBrush = null;
            Grid.SetRow(Button24, 4);
            Grid.SetColumn(Button24, 2);
            Button24.Background = Brushes.Transparent;
            Button24.BorderBrush = null;
            Grid.SetRow(Button25, 4);
            Grid.SetColumn(Button25, 4);
            Button25.Background = Brushes.Transparent;
            Button25.BorderBrush = null;
            Grid.SetRow(Button26, 4);
            Grid.SetColumn(Button26, 6);
            Button26.Background = Brushes.Transparent;
            Button26.BorderBrush = null;
            Grid.SetRow(Button27, 4);
            Grid.SetColumn(Button27, 8);
            Button27.Background = Brushes.Transparent;
            Button27.BorderBrush = null;
            Grid.SetRow(Button28, 4);
            Grid.SetColumn(Button28, 10);
            Button28.Background = Brushes.Transparent;
            Button28.BorderBrush = null;
            Grid.SetRow(Button29, 5);
            Grid.SetColumn(Button29, 1);
            Button29.Background = Brushes.Transparent;
            Button29.BorderBrush = null;
            Grid.SetRow(Button30, 5);
            Grid.SetColumn(Button30, 3);
            Button30.Background = Brushes.Transparent;
            Button30.BorderBrush = null;
            Grid.SetRow(Button31, 5);
            Grid.SetColumn(Button31, 5);
            Button31.Background = Brushes.Transparent;
            Button31.BorderBrush = null;
            Grid.SetRow(Button32, 5);
            Grid.SetColumn(Button32, 7);
            Button32.Background = Brushes.Transparent;
            Button32.BorderBrush = null;
            Grid.SetRow(Button33, 5);
            Grid.SetColumn(Button33, 9);
            Button33.Background = Brushes.Transparent;
            Button33.BorderBrush = null;
            Grid.SetRow(Button34, 6);
            Grid.SetColumn(Button1, 0);
            Button34.Background = Brushes.Transparent;
            Button34.BorderBrush = null;
            Grid.SetRow(Button35, 6);
            Grid.SetColumn(Button35, 2);
            Button35.Background = Brushes.Transparent;
            Button35.BorderBrush = null;
            Grid.SetRow(Button36, 6);
            Grid.SetColumn(Button36, 4);
            Button36.Background = Brushes.Transparent;
            Button36.BorderBrush = null;
            Grid.SetRow(Button37, 6);
            Grid.SetColumn(Button37, 6);
            Button37.Background = Brushes.Transparent;
            Button37.BorderBrush = null;
            Grid.SetRow(Button38, 6);
            Grid.SetColumn(Button38, 8);
            Button38.Background = Brushes.Transparent;
            Button38.BorderBrush = null;
            Grid.SetRow(Button39, 6);
            Grid.SetColumn(Button39, 10);
            Button39.Background = Brushes.Transparent;
            Button39.BorderBrush = null;
            Grid.SetRow(Button40, 7);
            Grid.SetColumn(Button40, 1);
            Button40.Background = Brushes.Transparent;
            Button40.BorderBrush = null;
            Grid.SetRow(Button41, 7);
            Grid.SetColumn(Button41, 3);
            Button41.Background = Brushes.Transparent;
            Button41.BorderBrush = null;
            Grid.SetRow(Button42, 7);
            Grid.SetColumn(Button42, 5);
            Button42.Background = Brushes.Transparent;
            Button42.BorderBrush = null;
            Grid.SetRow(Button43, 7);
            Grid.SetColumn(Button43, 7);
            Button43.Background = Brushes.Transparent;
            Button43.BorderBrush = null;
            Grid.SetRow(Button44, 7);
            Grid.SetColumn(Button44, 9);
            Button44.Background = Brushes.Transparent;
            Button44.BorderBrush = null;
            Grid.SetRow(Button45, 8);
            Grid.SetColumn(Button45, 0);
            Button45.Background = Brushes.Transparent;
            Button45.BorderBrush = null;
            Grid.SetRow(Button46, 8);
            Grid.SetColumn(Button46, 2);
            Button46.Background = Brushes.Transparent;
            Button46.BorderBrush = null;
            Grid.SetRow(Button47, 8);
            Grid.SetColumn(Button47, 4);
            Button47.Background = Brushes.Transparent;
            Button47.BorderBrush = null;
            Grid.SetRow(Button48, 8);
            Grid.SetColumn(Button48, 6);
            Button48.Background = Brushes.Transparent;
            Button48.BorderBrush = null;
            Grid.SetRow(Button49, 8);
            Grid.SetColumn(Button49, 8);
            Button49.Background = Brushes.Transparent;
            Button49.BorderBrush = null;
            Grid.SetRow(Button50, 8);
            Grid.SetColumn(Button50, 10);
            Button50.Background = Brushes.Transparent;
            Button50.BorderBrush = null;

            BlueGrid.Children.Add(Button1);
            BlueGrid.Children.Add(Button2);
            BlueGrid.Children.Add(Button3);
            BlueGrid.Children.Add(Button4);
            BlueGrid.Children.Add(Button5);
            BlueGrid.Children.Add(Button6);
            BlueGrid.Children.Add(Button7);
            BlueGrid.Children.Add(Button8);
            BlueGrid.Children.Add(Button9);
            BlueGrid.Children.Add(Button10);
            BlueGrid.Children.Add(Button11);
            BlueGrid.Children.Add(Button12);
            BlueGrid.Children.Add(Button13);
            BlueGrid.Children.Add(Button14);
            BlueGrid.Children.Add(Button15);
            BlueGrid.Children.Add(Button16);
            BlueGrid.Children.Add(Button17);
            BlueGrid.Children.Add(Button18);
            BlueGrid.Children.Add(Button19);
            BlueGrid.Children.Add(Button20);
            BlueGrid.Children.Add(Button21);
            BlueGrid.Children.Add(Button22);
            BlueGrid.Children.Add(Button23);
            BlueGrid.Children.Add(Button24);
            BlueGrid.Children.Add(Button25);
            BlueGrid.Children.Add(Button26);
            BlueGrid.Children.Add(Button27);
            BlueGrid.Children.Add(Button28);
            BlueGrid.Children.Add(Button29);
            BlueGrid.Children.Add(Button30);
            BlueGrid.Children.Add(Button31);
            BlueGrid.Children.Add(Button32);
            BlueGrid.Children.Add(Button33);
            BlueGrid.Children.Add(Button34);
            BlueGrid.Children.Add(Button35);
            BlueGrid.Children.Add(Button36);
            BlueGrid.Children.Add(Button37);
            BlueGrid.Children.Add(Button38);
            BlueGrid.Children.Add(Button39);
            BlueGrid.Children.Add(Button40);
            BlueGrid.Children.Add(Button41);
            BlueGrid.Children.Add(Button42);
            BlueGrid.Children.Add(Button43);
            BlueGrid.Children.Add(Button44);
            BlueGrid.Children.Add(Button45);
            BlueGrid.Children.Add(Button46);
            BlueGrid.Children.Add(Button47);
            BlueGrid.Children.Add(Button48);
            BlueGrid.Children.Add(Button49);
            BlueGrid.Children.Add(Button50);

            Button1.Click += new RoutedEventHandler(Button1_click);
            Button2.Click += new RoutedEventHandler(Button2_click);
            Button3.Click += new RoutedEventHandler(Button3_click);
            Button4.Click += new RoutedEventHandler(Button4_click);
            Button5.Click += new RoutedEventHandler(Button5_click);
            Button6.Click += new RoutedEventHandler(Button6_click);
            Button7.Click += new RoutedEventHandler(Button7_click);
            Button8.Click += new RoutedEventHandler(Button8_click);
            Button9.Click += new RoutedEventHandler(Button9_click);
            Button10.Click += new RoutedEventHandler(Button10_click);
            Button11.Click += new RoutedEventHandler(Button11_click);
            Button12.Click += new RoutedEventHandler(Button12_click);
            Button13.Click += new RoutedEventHandler(Button13_click);
            Button14.Click += new RoutedEventHandler(Button14_click);
            Button15.Click += new RoutedEventHandler(Button15_click);
            Button16.Click += new RoutedEventHandler(Button16_click);
            Button17.Click += new RoutedEventHandler(Button17_click);
            Button18.Click += new RoutedEventHandler(Button18_click);
            Button19.Click += new RoutedEventHandler(Button19_click);
            Button20.Click += new RoutedEventHandler(Button20_click);
            Button21.Click += new RoutedEventHandler(Button21_click);
            Button22.Click += new RoutedEventHandler(Button22_click);
            Button23.Click += new RoutedEventHandler(Button23_click);
            Button24.Click += new RoutedEventHandler(Button24_click);
            Button25.Click += new RoutedEventHandler(Button25_click);
            Button26.Click += new RoutedEventHandler(Button26_click);
            Button27.Click += new RoutedEventHandler(Button27_click);
            Button28.Click += new RoutedEventHandler(Button28_click);
            Button29.Click += new RoutedEventHandler(Button29_click);
            Button30.Click += new RoutedEventHandler(Button30_click);
            Button31.Click += new RoutedEventHandler(Button31_click);
            Button32.Click += new RoutedEventHandler(Button32_click);
            Button33.Click += new RoutedEventHandler(Button33_click);
            Button34.Click += new RoutedEventHandler(Button34_click);
            Button35.Click += new RoutedEventHandler(Button35_click);
            Button36.Click += new RoutedEventHandler(Button36_click);
            Button37.Click += new RoutedEventHandler(Button37_click);
            Button38.Click += new RoutedEventHandler(Button38_click);
            Button39.Click += new RoutedEventHandler(Button39_click);
            Button40.Click += new RoutedEventHandler(Button40_click);
            Button41.Click += new RoutedEventHandler(Button41_click);
            Button42.Click += new RoutedEventHandler(Button42_click);
            Button43.Click += new RoutedEventHandler(Button43_click);
            Button44.Click += new RoutedEventHandler(Button44_click);
            Button45.Click += new RoutedEventHandler(Button45_click);
            Button46.Click += new RoutedEventHandler(Button46_click);
            Button47.Click += new RoutedEventHandler(Button47_click);
            Button48.Click += new RoutedEventHandler(Button48_click);
            Button49.Click += new RoutedEventHandler(Button49_click);
            Button50.Click += new RoutedEventHandler(Button50_click);


        }

        public void stripeButtonAdder()
        {
            // covers the stripes with transparent buttons
            Button Button51 = new Button();
            Button Button52 = new Button();
            Button Button53 = new Button();
            Button Button54 = new Button();
            Button Button55 = new Button();
            Button Button56 = new Button();
            Button Button57 = new Button();
            Button Button58 = new Button();
            Button Button59 = new Button();
            Button Button60 = new Button();
            Button Button61 = new Button();
            Button Button62 = new Button();
            Button Button63 = new Button();

            Grid.SetRow(Button51, 0);
            Grid.SetColumn(Button51, 2);
            Grid.SetColumnSpan(Button51, 3);
            Button51.Background = Brushes.Transparent;
            Button51.BorderBrush = null;

            Grid.SetRow(Button52, 1);
            Grid.SetColumn(Button52, 2);
            Grid.SetColumnSpan(Button52, 3);
            Button52.Background = Brushes.Transparent;
            Button52.BorderBrush = null;

            Grid.SetRow(Button53, 2);
            Grid.SetColumn(Button53, 2);
            Grid.SetColumnSpan(Button53, 3);
            Button53.Background = Brushes.Transparent;
            Button53.BorderBrush = null;

            Grid.SetRow(Button54, 3);
            Grid.SetColumn(Button54, 2);
            Grid.SetColumnSpan(Button54, 3);
            Button54.Background = Brushes.Transparent;
            Button54.BorderBrush = null;

            Grid.SetRow(Button55, 4);
            Grid.SetColumn(Button55, 2);
            Grid.SetColumnSpan(Button55, 3);
            Button55.Background = Brushes.Transparent;
            Button55.BorderBrush = null;

            Grid.SetRow(Button56, 5);
            Grid.SetColumn(Button56, 2);
            Grid.SetColumnSpan(Button56, 3);
            Button56.Background = Brushes.Transparent;
            Button56.BorderBrush = null;

            Grid.SetRow(Button57, 6);
            Grid.SetColumn(Button57, 2);
            Grid.SetColumnSpan(Button57, 3);
            Button57.Background = Brushes.Transparent;
            Button57.BorderBrush = null;

            Grid.SetRow(Button58, 7);
            Grid.SetColumn(Button58, 0);
            Grid.SetColumnSpan(Button58, 5);
            Button58.Background = Brushes.Transparent;
            Button58.BorderBrush = null;

            Grid.SetRow(Button59, 8);
            Grid.SetColumn(Button59, 0);
            Grid.SetColumnSpan(Button59, 5);
            Button59.Background = Brushes.Transparent;
            Button59.BorderBrush = null;

            Grid.SetRow(Button60, 9);
            Grid.SetColumn(Button60, 0);
            Grid.SetColumnSpan(Button60, 5);
            Button60.Background = Brushes.Transparent;
            Button60.BorderBrush = null;

            Grid.SetRow(Button61, 10);
            Grid.SetColumn(Button61, 0);
            Grid.SetColumnSpan(Button61, 5);
            Button61.Background = Brushes.Transparent;
            Button61.BorderBrush = null;

            Grid.SetRow(Button62, 11);
            Grid.SetColumn(Button62, 0);
            Grid.SetColumnSpan(Button62, 5);
            Button62.Background = Brushes.Transparent;
            Button62.BorderBrush = null;

            Grid.SetRow(Button63, 12);
            Grid.SetColumn(Button63, 0);
            Grid.SetColumnSpan(Button63, 5);
            Button63.Background = Brushes.Transparent;
            Button63.BorderBrush = null;

            FlagGrid.Children.Add(Button51);
            FlagGrid.Children.Add(Button52);
            FlagGrid.Children.Add(Button53);
            FlagGrid.Children.Add(Button54);
            FlagGrid.Children.Add(Button55);
            FlagGrid.Children.Add(Button56);
            FlagGrid.Children.Add(Button57);
            FlagGrid.Children.Add(Button58);
            FlagGrid.Children.Add(Button59);
            FlagGrid.Children.Add(Button60);
            FlagGrid.Children.Add(Button61);
            FlagGrid.Children.Add(Button62);
            FlagGrid.Children.Add(Button63);

            Button51.Click += new RoutedEventHandler(Button51_click);
            Button52.Click += new RoutedEventHandler(Button52_click);
            Button53.Click += new RoutedEventHandler(Button53_click);
            Button54.Click += new RoutedEventHandler(Button54_click);
            Button55.Click += new RoutedEventHandler(Button55_click);
            Button56.Click += new RoutedEventHandler(Button56_click);
            Button57.Click += new RoutedEventHandler(Button57_click);
            Button58.Click += new RoutedEventHandler(Button58_click);
            Button59.Click += new RoutedEventHandler(Button59_click);
            Button60.Click += new RoutedEventHandler(Button60_click);
            Button61.Click += new RoutedEventHandler(Button61_click);
            Button62.Click += new RoutedEventHandler(Button62_click);
            Button63.Click += new RoutedEventHandler(Button63_click);
        }

        #endregion

        #region row/col Places

        // controls where the images and labels are positioned
        
        int L1R = 0; // label 1 row
        int L1RS = 2; // label 1 row span
        int L1C = 0; // label 1 column
        int L1CS = 2; // label 1 column span

        int L2R = 0; // label 2 row
        int L2RS = 2; // label 2 row span
        int L2C = 0; // label 2 column
        int L2CS = 2; // label 2 column span

        int L3R = 0; // label 3 row
        int L3RS = 2; // label 3 row span
        int L3C = 0; // label 3 column
        int L3CS = 2; //label 3 column span

        int SFR = 2; // state flag row
        int SFRS = 2; // state flag row span
        int SFC = 0; // state flag column
        int SFCS = 2; // state flag column span

        int LB1R = 0; // listbox 1 row
        int LB1RS = 4; // listbox 1 row span
        int LB1C = 2; // listbox column
        int LB1CS = 2; // listbox column span
        #endregion
        
        #region Buttons Click
        void Button1_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();  /// adds new window
            Grid s1Grid = new Grid();    ///          grid
            win1.Content = s1Grid;       /// adds grid to window
            win1.Show();                 /// shows window

            //defining grid row/columns
            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            // adds new image and specifies which image to add
            Image Star = new Image();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Alabama.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            // adds new label that contains info on the state (Capital City, Admission date, and state name)
            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Montgomery";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);
            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Admission to Statehood:  December 14, 1819 (22nd State)";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Alabama";

            // adds list box that will contain all county data
            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;

        }

        void Button2_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Alaska.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Juneau";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 2, 1927";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Alaska";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button3_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Arizona.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Pheonix";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: February 17, 1917";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Arizona";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button4_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Arkansas.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Little Rock";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: February 26, 1913";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Arkansas";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button5_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\California.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Sacramento";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: February 3, 1911";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "California";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button6_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Colorado.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Denver";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  June 5, 1911";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Colorado";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button7_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Connecticut.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Hartford";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: September 9, 1897";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Connecticut";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button8_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Delaware.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Dover";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: July 24, 1913";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Delaware";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button9_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Florida.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Tallahasse";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 21, 1985";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Florida";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button10_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Georgia.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Atlanta";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 8th, 2003";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Georgia";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button11_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Hawaii.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Honolulu";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: December 29, 1845";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Hawaii";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button12_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Idaho.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Boise";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 12, 1907";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Idaho";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button13_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Illinois.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Springfield";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  June 27, 1969";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Illinois";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button14_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Indiana.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Indianapolis";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  May 31, 1917";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Indiana";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button15_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Iowa.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Des Moines";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  March 29, 1921";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Iowa";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button16_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Kansas.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Topeka";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 23, 1927 ";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Kansas";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button17_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Kentucky.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Frankfort";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 26, 1918";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Kentucky";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button18_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Louisiana.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Baton Rouge";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: November 22, 2010";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Louisiana";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button19_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Maine.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Augusta";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  June 16, 1909";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Maine";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button20_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Maryland.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Annapolis";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 9, 1904";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Maryland";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button21_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Massachusetts.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Boston";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 21, 1908";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Massachusetts";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button22_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Michigan.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Lansing";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  June 26, 1911";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Michigan";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button23_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Minnesota.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Saint Paul";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: August 2, 1983";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Minnesota";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button24_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Mississippi.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Jackson";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 11, 2021";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Mississippi";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button25_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Missouri.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Jefferson City";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:   March 22, 1913";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Missouri";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button26_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Montana.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Helena";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: July 1, 1981";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Montana";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button27_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Nebraska.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Lincoln";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  July 16, 1963";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Nebraska";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button28_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Nevada.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Carson City";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 26, 1929";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Nevada";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button29_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New Hampshire.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Concord";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: November 30, 1931";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New Hampshire";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button30_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New Jersey.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Trenton";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 15, 1896";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New Jersey";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button31_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New Mexico.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Santa Fe";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: September 18, 1920 ";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New Mexico";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button32_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New York.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Albany";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 1, 1901";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New York";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button33_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\North Carolina.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Raleigh";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: June 24, 1991";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "North Carolina";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button34_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\North Dakota.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Bismarck";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  March 11, 1911";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "North Dakota";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button35_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Ohio.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Columbus";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 9, 1902";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Ohio";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button36_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Oklahoma.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Oklahoma";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 2, 1925 ";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Oklahoma";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button37_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Oregon.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Salem";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 15, 1925";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Oregon";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button38_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Pennsylvania.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Harrisburg";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 24, 1907";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Pennsylvania";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button39_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Rhode Island.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Providence";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  November 1, 1897";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Rhode Island";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button40_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\South Carolina.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Columbia";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 26, 1861";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "South Carolina";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button41_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\South Dakota.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Pierre";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: November 9, 1992";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "South Dakota";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button42_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Tennessee.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Nashville";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 17, 1905";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Tennessee";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button43_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Texas.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Austin";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 25, 1839";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Texas";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button44_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Utah.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Salt Lake City";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  February 16, 2011";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Utah";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button45_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Vermont.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Montpelier";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: June 1, 1923";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Vermont";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button46_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Virginia.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Richmond";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  March 28, 1912";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Virginia";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button47_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Washington.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Olympia";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 5, 1923";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Washington";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button48_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\West Virginia.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Charleston";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: November 6, 1929";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "West Virginia";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;

        }

        void Button49_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Wisconsin.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Madison";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 1, 1981";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Wisconsin";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button50_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Wyoming.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Cheyenne";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 31, 1917";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Wyoming";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button51_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Delaware.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Dover";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: July 24, 1913";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Delaware";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button52_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Pennsylvania.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Harrisburg";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 24, 1907";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Pennsylvania";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button53_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New Jersey.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Trenton";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 15, 1896";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New Jersey";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button54_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Georgia.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Atlanta";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: May 8th, 2003";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Georgia";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button55_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Connecticut.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Hartford";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: September 9, 1897";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Connecticut";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button56_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Massachusetts.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Boston";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 21, 1908";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Massachusetts";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button57_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Maryland.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Annapolis";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: March 9, 1904";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Maryland";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button58_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\South Carolina.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Columbia";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: January 26, 1861";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "South Carolina";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button59_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New Hampshire.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Concord";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: November 30, 1931";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New Hampshire";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button60_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Virginia.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Richmond";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  March 28, 1912";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Virginia";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button61_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\New York.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Albany";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: April 1, 1901";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "New York";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button62_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\North Carolina.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Raleigh";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);

            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date: June 24, 1991";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "North Carolina";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }

        void Button63_click(Object sender, EventArgs e)
        {
            Window win1 = new Window();
            Grid s1Grid = new Grid();
            win1.Content = s1Grid;
            win1.Show();

            s1Grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            s1Grid.VerticalAlignment = VerticalAlignment.Stretch;
            s1Grid.ShowGridLines = false;

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            s1Grid.ColumnDefinitions.Add(colDef1);
            s1Grid.ColumnDefinitions.Add(colDef2);
            s1Grid.ColumnDefinitions.Add(colDef3);
            s1Grid.ColumnDefinitions.Add(colDef4);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            s1Grid.RowDefinitions.Add(rowDef1);
            s1Grid.RowDefinitions.Add(rowDef2);
            s1Grid.RowDefinitions.Add(rowDef3);
            s1Grid.RowDefinitions.Add(rowDef4);

            Image Star = new Image();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"img\Rhode Island.PNG", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Star.Source = bitmap;
            Grid.SetRow(Star, SFR);
            Grid.SetRowSpan(Star, SFRS);
            Grid.SetColumn(Star, SFC);
            Grid.SetColumnSpan(Star, SFCS);
            s1Grid.Children.Add(Star);

            Label L1 = new Label();
            s1Grid.Children.Add(L1);
            Grid.SetRow(L1, L1R);
            Grid.SetRowSpan(L1, L1RS);
            Grid.SetColumn(L1, L1C);
            Grid.SetColumnSpan(L1, L1CS);
            L1.HorizontalAlignment = HorizontalAlignment.Stretch;
            L1.VerticalAlignment = VerticalAlignment.Center;
            L1.HorizontalContentAlignment = HorizontalAlignment.Center;
            L1.BorderBrush = null;
            L1.Content = "Capital City: Providence";

            Label L2 = new Label();
            s1Grid.Children.Add(L2);
            Grid.SetRow(L2, L2R);
            Grid.SetRowSpan(L2, L2RS);
            Grid.SetColumn(L2, L2C);
            Grid.SetColumnSpan(L2, L2CS);
            L2.HorizontalAlignment = HorizontalAlignment.Stretch;
            L2.VerticalAlignment = VerticalAlignment.Bottom;
            L2.HorizontalContentAlignment = HorizontalAlignment.Center;
            L2.BorderBrush = null;
            L2.Content = "Flag Adoption Date:  November 1, 1897";

            Label L3 = new Label();
            s1Grid.Children.Add(L3);
            Grid.SetRow(L3, L3R);
            Grid.SetRowSpan(L3, L3RS);
            Grid.SetColumn(L3, L3C);
            Grid.SetColumnSpan(L3, L3CS);
            L3.HorizontalAlignment = HorizontalAlignment.Stretch;
            L3.VerticalAlignment = VerticalAlignment.Top;
            L3.HorizontalContentAlignment = HorizontalAlignment.Center;
            L3.BorderBrush = null;
            L3.Content = "Rhode Island";

            ListBox LB1 = new ListBox();
            s1Grid.Children.Add(LB1);
            Grid.SetRow(LB1, LB1R);
            Grid.SetRowSpan(LB1, LB1RS);
            Grid.SetColumn(LB1, LB1C);
            Grid.SetColumnSpan(LB1, LB1CS);
            LB1.HorizontalAlignment = HorizontalAlignment.Stretch;
            LB1.VerticalAlignment = VerticalAlignment.Stretch;
        }
        #endregion
    }
}