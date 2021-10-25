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
    /// Interaction logic for AdminView_UC.xaml
    /// </summary>
    public partial class AdminView_UC : UserControl
    {
        public AdminView_UC()
        {
            InitializeComponent();

            var repository = new CarRepository();

            var vm = new AdminViewModel_UC(new CarRepository(), new AdminRepository(), new CustomerRepository(), new CarBrandsandModelsRepository(), new ManufactureYearsRepository(), new CarBodyStyllesRepository(), new CarColorsRepository(), new CarEnginesRepository(), new CarEnginePowersRepository(), new CarFueltTypesRepository(), new CarKilometresRepositorycs(), new CarGearBoxesRepositorycs(), new CarTransmitionsRepositorycs(), new NewCarsRepository(), new CarPrisesRepositorycs(), new CarQuantitiesRepository()) { AdminView_UCs =this};
            this.DataContext = vm;
        }
    }
}
