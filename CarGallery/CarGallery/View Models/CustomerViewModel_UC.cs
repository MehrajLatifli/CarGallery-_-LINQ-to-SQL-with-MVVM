using CarGallery.Commands;
using CarGallery.Models.Abstraction;
using CarGallery.Models.Data_Access.SQL_Server;
using CarGallery.Views;
using CarGallery.Views.User_control;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarGallery.View_Models
{
    public class CustomerViewModel_UC:BaseViewModel
    {
        public CustomerView_UC CustomerView_UCs { get; set; }
        public StartViewModel StartViewModel { get; set; }

        int adminId = 0;
        string adminIdcheck = string.Empty;

        private readonly IRepository<Car> _repoCar;

        private ObservableCollection<Car> allCars;

        public ObservableCollection<Car> AllCars
        {
            get { return allCars; }
            set { allCars = value; OnPropertyChanged(); }
        }

        private Car currentCar;

        public Car CurrentCar
        {
            get { return currentCar; }
            set { currentCar = value; OnPropertyChanged(); }
        }


        private readonly IRepository<Admin> _repoadmin;

        private ObservableCollection<Admin> alladmin;

        public ObservableCollection<Admin> AllAdmins
        {
            get { return alladmin; }
            set { alladmin = value; OnPropertyChanged(); }
        }

        private Admin currentAdmin;

        public Admin CurrentAdmin
        {
            get { return currentAdmin; }
            set { currentAdmin = value; OnPropertyChanged(); }
        }

        private readonly IRepository<Customer> _repoCustomer;

        private ObservableCollection<Customer> allCustomer;

        public ObservableCollection<Customer> AllCustomer
        {
            get { return allCustomer; }
            set { allCustomer = value; OnPropertyChanged(); }
        }

        private Customer currentCustomer;

        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; OnPropertyChanged(); }
        }
        private readonly IRepository<CarBrandsandModel> _repoICarBrandsandModel;

        private ObservableCollection<CarBrandsandModel> allCarBrandsandModel;

        public ObservableCollection<CarBrandsandModel> AllCarBrandsandModel
        {
            get { return allCarBrandsandModel; }
            set { allCarBrandsandModel = value; OnPropertyChanged(); }
        }

        private CarBrandsandModel currentCarBrandsandModel;

        public CarBrandsandModel CurrentCarBrandsandModel
        {
            get { return currentCarBrandsandModel; }
            set { currentCarBrandsandModel = value; OnPropertyChanged(); }
        }


        private readonly IRepository<ManufactureYear> _repoManufactureYear;

        private ObservableCollection<ManufactureYear> allManufactureYear;

        public ObservableCollection<ManufactureYear> AllManufactureYear
        {
            get { return allManufactureYear; }
            set { allManufactureYear = value; OnPropertyChanged(); }
        }

        private ManufactureYear currentManufactureYear;

        public ManufactureYear CurrentManufactureYear
        {
            get { return currentManufactureYear; }
            set { currentManufactureYear = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarBodyStyle> _repoCarBodyStyle;

        private ObservableCollection<CarBodyStyle> allCarBodyStyle;

        public ObservableCollection<CarBodyStyle> AllCarBodyStyle
        {
            get { return allCarBodyStyle; }
            set { allCarBodyStyle = value; OnPropertyChanged(); }
        }

        private CarBodyStyle currentCarBodyStyle;

        public CarBodyStyle CurrentCarBodyStyle
        {
            get { return currentCarBodyStyle; }
            set { currentCarBodyStyle = value; OnPropertyChanged(); }
        }



        private readonly IRepository<CarColor> _repoCarColor;

        private ObservableCollection<CarColor> allCarColor;

        public ObservableCollection<CarColor> AllCarColor
        {
            get { return allCarColor; }
            set { allCarColor = value; OnPropertyChanged(); }
        }

        private CarColor currentCarColor;

        public CarColor CurrentCarColor
        {
            get { return currentCarColor; }
            set { currentCarColor = value; OnPropertyChanged(); }
        }

        private readonly IRepository<CarEngine> _repoCarEngine;

        private ObservableCollection<CarEngine> allCarEngine;

        public ObservableCollection<CarEngine> AllCarEngine
        {
            get { return allCarEngine; }
            set { allCarEngine = value; OnPropertyChanged(); }
        }

        private CarEngine currentCarEngine;

        public CarEngine CurrentCarEngine
        {
            get { return currentCarEngine; }
            set { currentCarEngine = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarEnginePower> _repoCarEnginePower;

        private ObservableCollection<CarEnginePower> allCarEnginePower;

        public ObservableCollection<CarEnginePower> AllCarEnginePower
        {
            get { return allCarEnginePower; }
            set { allCarEnginePower = value; OnPropertyChanged(); }
        }

        private CarEnginePower currentCarEnginePower;

        public CarEnginePower CurrentCarEnginePower
        {
            get { return currentCarEnginePower; }
            set { currentCarEnginePower = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarFueltype> _repoCarFueltType;

        private ObservableCollection<CarFueltype> allCarFueltType;

        public ObservableCollection<CarFueltype> AllCarFueltType
        {
            get { return allCarFueltType; }
            set { allCarFueltType = value; OnPropertyChanged(); }
        }

        private CarFueltype currentCarFueltType;

        public CarFueltype CurrentCarFueltType
        {
            get { return currentCarFueltType; }
            set { currentCarFueltType = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarKilometre> _repoCarKilometres;

        private ObservableCollection<CarKilometre> allCarKilometres;

        public ObservableCollection<CarKilometre> AllCarKilometres
        {
            get { return allCarKilometres; }
            set { allCarKilometres = value; OnPropertyChanged(); }
        }

        private CarKilometre currentCarKilometres;

        public CarKilometre CurrentCarKilometres
        {
            get { return currentCarKilometres; }
            set { currentCarKilometres = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarGearbox> _repoCarGearbox;

        private ObservableCollection<CarGearbox> allCarGearbox;

        public ObservableCollection<CarGearbox> AllCarGearbox
        {
            get { return allCarGearbox; }
            set { allCarGearbox = value; OnPropertyChanged(); }
        }

        private CarGearbox currentCarGearbox;

        public CarGearbox CurrentCarGearbox
        {
            get { return currentCarGearbox; }
            set { currentCarGearbox = value; OnPropertyChanged(); }
        }


        private readonly IRepository<CarTransmission> _repoCarTransmission;

        private ObservableCollection<CarTransmission> allCarTransmission;

        public ObservableCollection<CarTransmission> AllCarTransmission
        {
            get { return allCarTransmission; }
            set { allCarTransmission = value; OnPropertyChanged(); }
        }

        private CarTransmission currentCarTransmission;

        public CarTransmission CurrentCarTransmission
        {
            get { return currentCarTransmission; }
            set { currentCarTransmission = value; OnPropertyChanged(); }
        }

        private readonly IRepository<NewCar> _repoNewCar;

        private ObservableCollection<NewCar> allNewCar;

        public ObservableCollection<NewCar> AllNewCar
        {
            get { return allNewCar; }
            set { allNewCar = value; OnPropertyChanged(); }
        }

        private NewCar currentNewCar;

        public NewCar CurrentNewCar
        {
            get { return currentNewCar; }
            set { currentNewCar = value; OnPropertyChanged(); }
        }

        private readonly IRepository<CarPrice> _repoCarPrice;

        private ObservableCollection<CarPrice> allCarPrice;

        public ObservableCollection<CarPrice> AllCarPrice
        {
            get { return allCarPrice; }
            set { allCarPrice = value; OnPropertyChanged(); }
        }

        private CarPrice currentCarPrice;

        public CarPrice CurrentCarPrice
        {
            get { return currentCarPrice; }
            set { currentCarPrice = value; OnPropertyChanged(); }
        }

        private readonly IRepository<CarQuantity> _repoCarQuantity;

        private ObservableCollection<CarQuantity> allCarQuantity;

        public ObservableCollection<CarQuantity> AllCarQuantity
        {
            get { return allCarQuantity; }
            set { allCarQuantity = value; OnPropertyChanged(); }
        }

        private CarQuantity currentCarQuantity;

        public CarQuantity CurrentCarQuantity
        {
            get { return currentCarQuantity; }
            set { currentCarQuantity = value; OnPropertyChanged(); }
        }



       
        public RelayCommand LoadedCommand { get; set; }

        public RelayCommand SelectInfoCarCommand { get; set; }

        public RelayCommand FilterCommand { get; set; }





        public int adminIdRead()
        {
            try
            {
                StartViewModel = new StartViewModel();

                using (FileStream fs = new FileStream("AdminNameCheck.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    byte[] bytes = new byte[(int)fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    StartViewModel.adminIdText = Encoding.Default.GetString(bytes);
                    adminId = int.Parse(StartViewModel.adminIdText);
                }

            }
            catch (Exception)
            {

            }

            return adminId;
        }

        public CustomerViewModel_UC(ICarRepository repocar, IAdminRepository adminRepository, ICustomerRepository customerRepository, ICarBrandsandModelsRepository carBrandsandModelsRepository, IManufactureYearsRepository manufactureYearsRepository, ICarBodyStylesRepository carBodyStylesRepository, ICarColorsRepository carColorsRepository, ICarEnginesRepository carEnginesRepository, ICarEnginePowersRepository carEnginePowersRepository, ICarFueltypesRepository carFueltypesRepository, ICarKilometresRepository carKilometresRepository, ICarGearBoxesRepository carGearBoxesRepository, ICarTransmitionsRepository carTransmitionsRepository, INewCarsRepository newCarsRepository, ICarPricesRepository carPricesRepository, ICarQuantitesRepository carQuantitesRepository)
        {
            _repoCar = repocar;
            AllCars = _repoCar.GetAllData();
            CurrentCar = new Car();

            _repoadmin = adminRepository;
            AllAdmins = _repoadmin.GetAllData();
            CurrentAdmin = new Admin();

            _repoCustomer = customerRepository;
            AllCustomer = _repoCustomer.GetAllData();
            CurrentCustomer = new Customer();

            _repoICarBrandsandModel = carBrandsandModelsRepository;
            AllCarBrandsandModel = _repoICarBrandsandModel.GetAllData();
            CurrentCarBrandsandModel = new CarBrandsandModel();


            _repoManufactureYear = manufactureYearsRepository;
            AllManufactureYear = _repoManufactureYear.GetAllData();
            CurrentManufactureYear = new ManufactureYear();

            _repoCarBodyStyle = carBodyStylesRepository;
            AllCarBodyStyle = _repoCarBodyStyle.GetAllData();
            CurrentCarBodyStyle = new CarBodyStyle();

            _repoCarColor = carColorsRepository;
            AllCarColor = _repoCarColor.GetAllData();
            CurrentCarColor = new CarColor();

            _repoCarEngine = carEnginesRepository;
            AllCarEngine = _repoCarEngine.GetAllData();
            CurrentCarEngine = new CarEngine();

            _repoCarEnginePower = carEnginePowersRepository;
            AllCarEnginePower = _repoCarEnginePower.GetAllData();
            CurrentCarEnginePower = new CarEnginePower();

            _repoCarFueltType = carFueltypesRepository;
            AllCarFueltType = _repoCarFueltType.GetAllData();
            CurrentCarFueltType = new CarFueltype();

            _repoCarKilometres = carKilometresRepository;
            AllCarKilometres = _repoCarKilometres.GetAllData();
            CurrentCarKilometres = new CarKilometre();

            _repoCarGearbox = carGearBoxesRepository;
            AllCarGearbox = _repoCarGearbox.GetAllData();
            CurrentCarGearbox = new CarGearbox();

            _repoCarTransmission = carTransmitionsRepository;
            AllCarTransmission = _repoCarTransmission.GetAllData();
            CurrentCarTransmission = new CarTransmission();

            _repoNewCar = newCarsRepository;
            AllNewCar = _repoNewCar.GetAllData();
            currentNewCar = new NewCar();

            _repoCarPrice = carPricesRepository;
            AllCarPrice = _repoCarPrice.GetAllData();
            CurrentCarPrice = new CarPrice();

            _repoCarQuantity = carQuantitesRepository;
            AllCarQuantity = _repoCarQuantity.GetAllData();
            CurrentCarQuantity = new CarQuantity();


            //CurrentCar = new Car();

            List<string> carinfo = new List<string>();

            carinfo.Add("Short info");
            carinfo.Add("Full info");

            List<string> carfilter = new List<string>();

            carfilter.Add("Car Brands and Models");
            carfilter.Add("Car Colors");


            LoadedCommand = new RelayCommand((sender) =>
            {
                CustomerView_UCs.CarorOwnerComboBox.ItemsSource = carinfo;

                CustomerView_UCs.FilterCombobox.ItemsSource = carfilter;

                //  MessageBox.Show($"{adminIdRead()}");

                //     
                //CurrentCar = new Car();


                //CurrentAdmin = new Admin();


                //CurrentCustomer = new Customer();

                //CurrentCarBrandsandModel = new CarBrandsandModel();



                //CurrentManufactureYear = new ManufactureYear();


                //CurrentCarBodyStyle = new CarBodyStyle();


                //CurrentCarColor = new CarColor();

                //CurrentCarEngine = new CarEngine();


                //CurrentCarEnginePower = new CarEnginePower();


                //CurrentCarFueltType = new CarFueltype();

                //CurrentCarKilometres = new CarKilometre();


                //CurrentCarGearbox = new CarGearbox();

                //CurrentCarTransmission = new CarTransmission();


                //currentNewCar = new NewCar();


                //CurrentCarPrice = new CarPrice();


                //CurrentCarQuantity = new CarQuantity();


                //CurrentDetailsofOrder = new DetailsofOrder();

                //CurrentOrder = new Order();

            });




            SelectInfoCarCommand = new RelayCommand((sender) =>
            {

                if (CustomerView_UCs.CarorOwnerComboBox.SelectedIndex == 1)
                {
                    CustomerView_UCs.fullcardatalistview.Visibility = Visibility.Visible;
                    CustomerView_UCs.shortcardatalistview.Visibility = Visibility.Hidden;


                }

                if (CustomerView_UCs.CarorOwnerComboBox.SelectedIndex == 0)
                {
                    CustomerView_UCs.fullcardatalistview.Visibility = Visibility.Hidden;
                    CustomerView_UCs.shortcardatalistview.Visibility = Visibility.Visible;
                }

            });



            FilterCommand = new RelayCommand((sender) =>
            {

                if (CustomerView_UCs.CarorOwnerComboBox.SelectedIndex == 1)
                {
                    if (CustomerView_UCs.FilterCombobox.SelectedIndex == 0)
                    {


                        var y = AllCars.Where(
                            x =>
                               x.CarBrandsandModel.BrandsandModels_of_car == CustomerView_UCs.TextTXT.Text
                           );

                        CustomerView_UCs.fullcardatalistview.ItemsSource = y;
                    }

                    if (CustomerView_UCs.FilterCombobox.SelectedIndex == 1)
                    {


                        var y = AllCars.Where( x =>x.CarColor.Name_of_Car_Color == CustomerView_UCs.TextTXT.Text);

                        CustomerView_UCs.fullcardatalistview.ItemsSource = y;
                    }

                    if (string.IsNullOrEmpty(CustomerView_UCs.TextTXT.Text))
                    {
                        var y = AllCars.Where(x => x.CarColor.Name_of_Car_Color != CustomerView_UCs.TextTXT.Text);

                        CustomerView_UCs.fullcardatalistview.ItemsSource = y;
                    }
                }


                if (CustomerView_UCs.CarorOwnerComboBox.SelectedIndex == 0)
                {
                    if (CustomerView_UCs.FilterCombobox.SelectedIndex == 0)
                    {


                        var y = AllCars.Where(
                            x =>
                               x.CarBrandsandModel.BrandsandModels_of_car == CustomerView_UCs.TextTXT.Text
                           );

                        CustomerView_UCs.shortcardatalistview.ItemsSource = y;
                    }

                    if (CustomerView_UCs.FilterCombobox.SelectedIndex == 1)
                    {


                        var y = AllCars.Where(x => x.CarColor.Name_of_Car_Color == CustomerView_UCs.TextTXT.Text);

                        CustomerView_UCs.shortcardatalistview.ItemsSource = y;
                    }

                    if (string.IsNullOrEmpty(CustomerView_UCs.TextTXT.Text))
                    {
                        var y = AllCars.Where(x => x.CarColor.Name_of_Car_Color != CustomerView_UCs.TextTXT.Text);

                        CustomerView_UCs.shortcardatalistview.ItemsSource = y;
                    }
                }

            });

        }





        public CustomerViewModel_UC()
        {



        }
    }
}
