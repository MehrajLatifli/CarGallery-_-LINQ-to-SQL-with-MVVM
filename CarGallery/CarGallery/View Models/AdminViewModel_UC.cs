using CarGallery.Commands;
using CarGallery.Models.Abstraction;
using CarGallery.Models.Additional_Classes;
using CarGallery.Models.Data_Access.SQL_Server;
using CarGallery.Views.User_control;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace CarGallery.View_Models
{
    class AdminViewModel_UC : BaseViewModel
    {
        public AdminView_UC AdminView_UCs { get; set; }
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

        public RelayCommand AddCarCommand { get; set; }

        public RelayCommand UpdateCarCommand { get; set; }

        public RelayCommand DeleteCarCommand { get; set; }



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

        public AdminViewModel_UC(ICarRepository repocar, IAdminRepository adminRepository, ICustomerRepository customerRepository, ICarBrandsandModelsRepository carBrandsandModelsRepository, IManufactureYearsRepository manufactureYearsRepository, ICarBodyStylesRepository carBodyStylesRepository, ICarColorsRepository carColorsRepository, ICarEnginesRepository carEnginesRepository, ICarEnginePowersRepository carEnginePowersRepository, ICarFueltypesRepository carFueltypesRepository, ICarKilometresRepository carKilometresRepository, ICarGearBoxesRepository carGearBoxesRepository, ICarTransmitionsRepository carTransmitionsRepository, INewCarsRepository newCarsRepository, ICarPricesRepository carPricesRepository, ICarQuantitesRepository carQuantitesRepository)
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


            LoadedCommand = new RelayCommand((sender) =>
            {
                AdminView_UCs.CarorOwnerComboBox.ItemsSource = carinfo;

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
                if (AdminView_UCs.CarorOwnerComboBox.SelectedIndex == 1)
                {
                    AdminView_UCs.fullcardatalistview.Visibility = Visibility.Visible;
                    AdminView_UCs.shortcardatalistview.Visibility = Visibility.Hidden;


                }

                if (AdminView_UCs.CarorOwnerComboBox.SelectedIndex == 0)
                {
                    AdminView_UCs.fullcardatalistview.Visibility = Visibility.Hidden;
                    AdminView_UCs.shortcardatalistview.Visibility = Visibility.Visible;
                }
            });


            AddCarCommand = new RelayCommand((sender) =>
             {

                 try
                 {
                     if (AdminView_UCs.CarBrandsandModelsComboBox.SelectedIndex != -1 && AdminView_UCs.ManufactureYearsComboBox.SelectedIndex != -1 
                     && AdminView_UCs.CarBodyStylesComboBox.SelectedIndex != -1
                    && AdminView_UCs.CarColorsComboBox.SelectedIndex != -1 && AdminView_UCs.NewCarsComboBox.SelectedIndex != -1
                    && AdminView_UCs.CarEnginesComboBox.SelectedIndex != -1 && AdminView_UCs.CarFueltypesComboBox.SelectedIndex != -1
                    && AdminView_UCs.CarGearboxesComboBox.SelectedIndex != -1 && AdminView_UCs.CarPricesComboBox.SelectedIndex != -1
                    && AdminView_UCs.CarEnginePowersComboBox.SelectedIndex != -1 && AdminView_UCs.CarKilometresComboBox.SelectedIndex != -1
                    && AdminView_UCs.CarTransmissionsComboBox.SelectedIndex != -1 && AdminView_UCs.CarQuantitiesComboBox.SelectedIndex != -1)
                     {

                         CurrentCar.CarBrandsandModelsId = CurrentCarBrandsandModel.IdCarBrandsandModels;
                         CurrentCar.ManufactureYearsId = CurrentManufactureYear.IdManufactureYears;
                         CurrentCar.CarBodyStylesId = CurrentCarBodyStyle.IdCarBodyStyles;
                         CurrentCar.CarColorsId = CurrentCarColor.IdCarColors;
                         CurrentCar.CarEnginesId = CurrentCarEngine.IdCarEngines;
                         CurrentCar.CarEnginePowersId = CurrentCarEnginePower.IdCarEnginePowers;
                         CurrentCar.CarFueltypesId = CurrentCarFueltType.IdCarFueltypes;
                         CurrentCar.CarKilometresId = CurrentCarKilometres.IdCarKilometres;
                         CurrentCar.CarGearboxesId = CurrentCarGearbox.IdCarGearboxes;
                         CurrentCar.CarTransmissionsId = CurrentCarTransmission.IdCarTransmissions;
                         CurrentCar.NewCarsId = CurrentNewCar.IdNewCars;
                         CurrentCar.CarPricesId = CurrentCarPrice.IdCarPrices;
                         CurrentCar.CarQuantitiesId = CurrentCarQuantity.IdCarQuantities;
                         CurrentCar.AdminsId = 1;

                         _repoCar.AddData(CloneHelper.CloneCar(CurrentCar));
                         AllCars = _repoCar.GetAllData();


                         CurrentCar = new Car();


                         CurrentAdmin = new Admin();


                         CurrentCustomer = new Customer();

                         CurrentCarBrandsandModel = new CarBrandsandModel();



                         CurrentManufactureYear = new ManufactureYear();


                         CurrentCarBodyStyle = new CarBodyStyle();


                         CurrentCarColor = new CarColor();

                         CurrentCarEngine = new CarEngine();


                         CurrentCarEnginePower = new CarEnginePower();


                         CurrentCarFueltType = new CarFueltype();

                         CurrentCarKilometres = new CarKilometre();


                         CurrentCarGearbox = new CarGearbox();

                         CurrentCarTransmission = new CarTransmission();


                         CurrentNewCar = new NewCar();


                         CurrentCarPrice = new CarPrice();


                         CurrentCarQuantity = new CarQuantity();


                     }

                 }
                 catch (Exception)
                 {


                 }
             });

            UpdateCarCommand = new RelayCommand((sender) =>
            {


                try
                {
                    if (AdminView_UCs.CarBrandsandModelsComboBox.SelectedIndex != -1 && AdminView_UCs.ManufactureYearsComboBox.SelectedIndex != -1 && AdminView_UCs.CarBodyStylesComboBox.SelectedIndex != -1
                        && AdminView_UCs.CarColorsComboBox.SelectedIndex != -1 && AdminView_UCs.NewCarsComboBox.SelectedIndex != -1
                        && AdminView_UCs.CarEnginesComboBox.SelectedIndex != -1 && AdminView_UCs.CarFueltypesComboBox.SelectedIndex != -1
                        && AdminView_UCs.CarGearboxesComboBox.SelectedIndex != -1 && AdminView_UCs.CarPricesComboBox.SelectedIndex != -1
                        && AdminView_UCs.CarEnginePowersComboBox.SelectedIndex != -1 && AdminView_UCs.CarKilometresComboBox.SelectedIndex != -1
                        && AdminView_UCs.CarTransmissionsComboBox.SelectedIndex != -1 && AdminView_UCs.CarQuantitiesComboBox.SelectedIndex != -1)
                    {

                        var item = AdminView_UCs.fullcardatalistview.SelectedItem as Car;

                        MessageBox.Show($"{item.IdCars} {item.CarBrandsandModel.BrandsandModels_of_car}");

                        if (item != null)
                        {
                            var A = AllCars.Single(X => X.IdCars == item.IdCars);

                           CurrentCar.IdCars = item.IdCars;
                             CurrentCar.CarBrandsandModel.BrandsandModels_of_car = CurrentCarBrandsandModel.BrandsandModels_of_car;
                             CurrentCar.CarBrandsandModel.Images_of_car = CurrentCarBrandsandModel.Images_of_car;
                             CurrentCar.ManufactureYear.Manufacture_Years = CurrentManufactureYear.Manufacture_Years;
                             CurrentCar.CarBodyStyle.Name_of_Car_Body_Styles = CurrentCarBodyStyle.Name_of_Car_Body_Styles;
                             CurrentCar.CarColor.Name_of_Car_Color = CurrentCarColor.Name_of_Car_Color;
                             CurrentCar.CarEngine.Number_of_Car_Engine = CurrentCarEngine.Number_of_Car_Engine;
                             CurrentCar.CarEnginePower.Number_of_Car_Engine_Powers = CurrentCarEnginePower.Number_of_Car_Engine_Powers;
                             CurrentCar.CarFueltype.Name_of_Car_Fueltypes = CurrentCarFueltType.Name_of_Car_Fueltypes;
                             CurrentCar.CarKilometre.Number_of_Car_Kilometres = CurrentCarKilometres.Number_of_Car_Kilometres;
                             CurrentCar.CarGearbox.Name_of_Car_Gearboxes = CurrentCarGearbox.Name_of_Car_Gearboxes;
                             CurrentCar.CarTransmission.Name_of_Car_Transmissions = CurrentCarTransmission.Name_of_Car_Transmissions;
                             CurrentCar.NewCar.New_Car = CurrentNewCar.New_Car;
                             CurrentCar.CarPrice.Number_of_Car_Prices = CurrentCarPrice.Number_of_Car_Prices;
                             CurrentCar.CarQuantity.Quantity_of_Car = CurrentCarQuantity.Quantity_of_Car;
                            CurrentCar.Admin.Name_of_Admins = "Admins_1";

                            _repoCar.UpdateData(CloneHelper.CloneCar(CurrentCar));
                            AllCars = _repoCar.GetAllData();

                        }

                    }

                    CurrentCar = new Car();


                    CurrentAdmin = new Admin();


                    CurrentCustomer = new Customer();

                    CurrentCarBrandsandModel = new CarBrandsandModel();



                    CurrentManufactureYear = new ManufactureYear();


                    CurrentCarBodyStyle = new CarBodyStyle();


                    CurrentCarColor = new CarColor();

                    CurrentCarEngine = new CarEngine();


                    CurrentCarEnginePower = new CarEnginePower();


                    CurrentCarFueltType = new CarFueltype();

                    CurrentCarKilometres = new CarKilometre();


                    CurrentCarGearbox = new CarGearbox();

                    CurrentCarTransmission = new CarTransmission();


                    CurrentNewCar = new NewCar();


                    CurrentCarPrice = new CarPrice();


                    CurrentCarQuantity = new CarQuantity();


               


                }
                catch (Exception)
                {


                }

            });




            DeleteCarCommand = new RelayCommand((sender) =>
            {
                try
                {


                    _repoCar.DeleteData(CurrentCar);
                    AllCars = _repoCar.GetAllData();

                    CurrentCar = new Car();


                    CurrentAdmin = new Admin();


                    CurrentCustomer = new Customer();

                    CurrentCarBrandsandModel = new CarBrandsandModel();



                    CurrentManufactureYear = new ManufactureYear();


                    CurrentCarBodyStyle = new CarBodyStyle();


                    CurrentCarColor = new CarColor();

                    CurrentCarEngine = new CarEngine();


                    CurrentCarEnginePower = new CarEnginePower();


                    CurrentCarFueltType = new CarFueltype();

                    CurrentCarKilometres = new CarKilometre();


                    CurrentCarGearbox = new CarGearbox();

                    CurrentCarTransmission = new CarTransmission();


                    CurrentNewCar = new NewCar();


                    CurrentCarPrice = new CarPrice();


                    CurrentCarQuantity = new CarQuantity();


               
                    if(AdminView_UCs.fullcardatalistview.Items==null)
                    {
                        CurrentCar.IdCars = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");

                }

            });




        }



        

    public AdminViewModel_UC()
        {

          

        }
    }
}
