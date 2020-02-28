using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// DLL
using FormulaOneDLL;

namespace FormulaOneStudioWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbTools db = new DbTools();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            db = new DbTools();
            List<CardDriverDLL> driver = new List<CardDriverDLL>();
            driver = db.LoadDrivers();

            for (int i = 0; i < driver.Count; i++)
            {
            MyUserControls.CardDriver card = new MyUserControls.CardDriver();
            card.CardImage = new BitmapImage(new Uri(driver[i].PathImage));
            card.DriverName = driver[i].Name;
            card.DriverTeam = driver[i].Team;
            cardTest.Children.Add(card);
            }

        }
    }
}
