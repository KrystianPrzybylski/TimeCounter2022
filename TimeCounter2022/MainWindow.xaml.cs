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

namespace TimeCounter2022
{
    using TimeCounter2022.Entities;

    
    public partial class MainWindow : Window
    {
        public List<Task> tasks = new List<Task>();
        public MainWindow()
        {
            InitializeComponent();

            tasks.Add(new Task { NameTask = "zadanie 1", TotalTime = DateTime.MinValue, CurrentTime = DateTime.Now });
            tasks.Add(new Task { NameTask = "zadanie 2", TotalTime = DateTime.MinValue, CurrentTime = DateTime.Now });
            tasks.Add(new Task { NameTask = "zadanie 1", TotalTime = DateTime.MinValue, CurrentTime = DateTime.Now });
            tasks.Add(new Task { NameTask = "zadanie 3", TotalTime = DateTime.MinValue, CurrentTime = DateTime.Now });

            myComboBov.ItemsSource = tasks;
        }

       
       

        private void StartBT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"tekst : { ZadanieTB.Text}");
        }
    }
   
}
