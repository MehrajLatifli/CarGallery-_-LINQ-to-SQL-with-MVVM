using CarGallery.Models.Data_Access.SQL_Server;
using CarGallery.View_Models;
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

namespace CarGallery.Views
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
            this.DataContext = new StartViewModel() { Starts = this };


            //var vm = new StartViewModel(new CarRepository());
            //this.DataContext = vm;
        }

       
    }
}
