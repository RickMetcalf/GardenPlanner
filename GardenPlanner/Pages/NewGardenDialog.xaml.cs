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
using GardenPlannerClasses;
using GardenPlanner;

namespace GardenPlanner.Pages
{
    /// <summary>
    /// Interaction logic for NewGardenDialog.xaml
    /// </summary>
    public partial class NewGardenDialog : Window
    {
        public Garden _garden;
        public bool created = false;

        public NewGardenDialog()
        {
            InitializeComponent();
            _garden = new Garden();
            
        }

        private void gardenLength_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            
            created = false;
            this.Close();
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int width;
            int length;
            bool lengthTest = int.TryParse(this.gardenLength.Text, out length);
            bool widthTest = int.TryParse(this.gardenWidth.Text, out width);

            if (string.IsNullOrEmpty(this.gardenName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            if (!widthTest || !lengthTest)
            {
                MessageBox.Show("Incorrect Entry, please enter an number in feet");
            }
            
            if(widthTest && lengthTest)
            {
                _garden.Width = width;
                _garden.Length = length;
                _garden.Name = this.gardenName.Text;
                created = true;
                this.Close();
            }
            
            
        }
    }
}
