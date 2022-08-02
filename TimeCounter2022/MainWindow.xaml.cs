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
    using TimeCounter2022.Repository;

    
    public partial class MainWindow : Window
    {
       
        public List<Task> tasks = new List<Task>();
        public MainWindow()
        {
            InitializeComponent();
            var taskRepository = new GenericRepository<Task>();
            taskRepository.Add(new Task { NameTask = "Zadanie testowe" });
            tasks.Add(new Task ());
           
            

            myComboBov.ItemsSource = tasks;
        }

       
       

        private void StartBT_Click(object sender, RoutedEventArgs e)
        {
            StartBT.IsEnabled = false;
            tasks.First().StartTime();
            ZadanieTB.Text = "Rozpoczęto mierzenie czasu dla zadania: " + tasks.First().NameTask;
            
        }

        private void StopBT_Click(object sender, RoutedEventArgs e)
        {
            tasks[0].StopTime();
            StartBT.IsEnabled = true;
            ZadanieTB.Text = $"zmierzony czas : { tasks.First().GetAllTime}";
            //MessageBox.Show($"tekst : { tasks[0].GetAllTime}");
        }
    }
   
}
