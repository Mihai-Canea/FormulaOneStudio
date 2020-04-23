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
using FormulaOneDLL.Entities;

namespace FormulaOneStudioWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DriverDLL db = new DriverDLL();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            db = new DriverDLL();
            List<CardDriverDLL> driver = new List<CardDriverDLL>();
            // driver = db.LoadDrivers(cmbYear.SelectionBoxItem.ToString());

            //List<testClass> driver = new List<testClass>();
            driver = db.LoadDrivers(cmbYear.SelectionBoxItem.ToString());
            dgvDriver.ItemsSource = db.LoadTableDrivers(cmbYear.SelectionBoxItem.ToString());

            for (int i = 0; i < driver.Count; i++)
            {
                MyUserControls.CardDriver card = new MyUserControls.CardDriver();
                if (driver[i].PathImage == "")
                    card.CardImage = new BitmapImage(new Uri("https://www.shareicon.net/data/512x512/2016/04/10/747353_people_512x512.png"));
                else
                    card.CardImage = new BitmapImage(new Uri(driver[i].PathImage));
                card.DriverName = driver[i].Name;
                card.DriverTeam = driver[i].Team;
                cardTest.Children.Add(card);
            }
        }

        private void cmbYear_DropDownClosed(object sender, EventArgs e)
        {
            cardTest.Children.Clear();
            dgvDriver.ItemsSource = db.LoadTableDrivers(cmbYear.SelectionBoxItem.ToString());
            List<CardDriverDLL> driver = new List<CardDriverDLL>();
            driver = db.LoadDrivers(cmbYear.SelectionBoxItem.ToString());
            for (int i = 0; i < driver.Count; i++)
            {
                MyUserControls.CardDriver card = new MyUserControls.CardDriver();
                if (driver[i].PathImage == "")
                    card.CardImage = new BitmapImage(new Uri("https://www.shareicon.net/data/512x512/2016/04/10/747353_people_512x512.png"));
                else
                    card.CardImage = new BitmapImage(new Uri(driver[i].PathImage));
                card.DriverName = driver[i].Name;
                card.DriverTeam = driver[i].Team;
                cardTest.Children.Add(card);
            }
        }

        private void btnCircuits_Click(object sender, RoutedEventArgs e)
        {
            CircuitsDLL cir = new CircuitsDLL();
            dgvCircuits.ItemsSource = cir.LoadTableCircuits(cmbYear.SelectionBoxItem.ToString());
            circuitsDoc.IsActive = true;
        }
    }
}
