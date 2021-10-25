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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarGallery.Views.User_control
{
    /// <summary>
    /// Interaction logic for CustomerView_UC.xaml
    /// </summary>
    public partial class CustomerView_UC : UserControl
    {
        public CustomerView_UC()
        {
            InitializeComponent();

            var repository = new CarRepository();


            var vm = new CustomerViewModel_UC(new CarRepository(), new AdminRepository(), new CustomerRepository(), new CarBrandsandModelsRepository(), new ManufactureYearsRepository(), new CarBodyStyllesRepository(), new CarColorsRepository(), new CarEnginesRepository(), new CarEnginePowersRepository(), new CarFueltTypesRepository(), new CarKilometresRepositorycs(), new CarGearBoxesRepositorycs(), new CarTransmitionsRepositorycs(), new NewCarsRepository(), new CarPrisesRepositorycs(), new CarQuantitiesRepository()) { CustomerView_UCs = this };
            this.DataContext = vm;
        }
    }
}
