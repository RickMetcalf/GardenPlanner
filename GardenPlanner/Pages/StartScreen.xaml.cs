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
using GardenPlanner;

namespace GardenPlanner.Pages
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void CreateGarden_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            NewGardenInfo();
            this.Close();
            mainWindow.Show();
            
        }
        public void NewGardenInfo()
        {
            NewGardenDialog newGardenDialog = new NewGardenDialog();
            newGardenDialog.ShowDialog();
            
        }
    }
}
