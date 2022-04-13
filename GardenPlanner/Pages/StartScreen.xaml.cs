using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using GardenPlanner;
using GardenPlannerClasses;

namespace GardenPlanner.Pages
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public bool created = false;
        public Garden garden;
       
        public StartScreen()
        {
            InitializeComponent();
        }

        private void CreateGarden_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            NewGardenDialog newGarden = new NewGardenDialog();
            NewGardenInfo(newGarden);
            if(newGarden.created)
            {
                garden = newGarden._garden;
                mainWindow.gardenMain = garden;
                mainWindow.PopulateGarden();
                this.Close();
                mainWindow.Show();
                
            }
            
            
        }
        public void NewGardenInfo(NewGardenDialog newGardenDialog)
        {
            
            newGardenDialog.ShowDialog();
            
        }
    }
}
