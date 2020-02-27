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

namespace FormulaOneStudioWPF.MyUserControls
{
    /// <summary>
    /// Logica di interazione per CardDriver.xaml
    /// </summary>
    public partial class CardDriver : UserControl
    {
        public CardDriver()
        {
            InitializeComponent();
        }

        public ImageSource CardImage
        {
            get { return imgCard.Source; }
            set { imgCard.Source = value; }
        }

        public string DriverName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string DriverTeam
        {
            get { return txtTeam.Text; }
            set { txtTeam.Text = value; }
        }
    }
}
