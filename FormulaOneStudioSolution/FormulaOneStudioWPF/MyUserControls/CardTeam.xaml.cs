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
    /// Logica di interazione per CardTeam.xaml
    /// </summary>
    public partial class CardTeam : UserControl
    {
        public CardTeam()
        {
            InitializeComponent();
        }

        public ImageSource CardImage
        {
            get { return imgCard.Source; }
            set { imgCard.Source = value; }
        }

        public string TeamName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Driver1
        {
            get { return txtDriver1.Text; }
            set { txtDriver1.Text = value; }
        }

        public string Driver2
        {
            get { return txtDriver2.Text; }
            set { txtDriver2.Text = value; }
        }
    }
}
