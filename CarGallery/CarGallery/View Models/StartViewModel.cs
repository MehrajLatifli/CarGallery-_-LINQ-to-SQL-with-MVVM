using CarGallery.Commands;
using CarGallery.Models;
using CarGallery.Models.Abstraction;
using CarGallery.Models.Additional_Classes;
using CarGallery.Models.Data_Access.SQL_Server;
using CarGallery.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarGallery.View_Models
{
   public class StartViewModel:BaseViewModel
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }
        public Start Starts { get; set; }

        public ComboBoxSelect ComboBoxSelect { get; set; }

       public int adminId = 0;
        public string adminIdText = string.Empty;

        public ObservableCollection<Position> Positions { get; set; }

        private Position _Position;
        public Position Position { get { return _Position; } set { _Position = value; OnPropertyChanged(); } }

        AdminViewModel_UC AdminViewModel_UC { get; set; }

        CustomerViewModel_UC CustomerViewModel_UC { get; set; }

        private readonly IRepository<Car> _repoCarStart;

        private ObservableCollection<Car> allCarsStart;

        public ObservableCollection<Car> AllCarsStart
        {
            get { return allCarsStart; }
            set { allCarsStart = value; OnPropertyChanged(); }
        }

        private Car currentCarStart;

        public Car CurrentCarStart
        {
            get { return currentCarStart; }
            set { CurrentCarStart = value; OnPropertyChanged(); }
        }


        private readonly IRepository<Admin> _repoadminStart;

        private ObservableCollection<Admin> alladminStart;

        public ObservableCollection<Admin> AllAdminsStart
        {
            get { return alladminStart; }
            set { alladminStart = value; OnPropertyChanged(); }
        }

        private Admin currentAdmin;

        public Admin CurrentAdmin
        {
            get { return currentAdmin; }
            set { currentAdmin = value; OnPropertyChanged(); }
        }


        private readonly IRepository<Customer> _repoCustomerStart;

        private ObservableCollection<Customer> allCustomerStart;

        public ObservableCollection<Customer> AllCustomersStart
        {
            get { return allCustomerStart; }
            set { allCustomerStart = value; OnPropertyChanged(); }
        }

        private Customer currentCustomer;

        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; OnPropertyChanged(); }
        }



        public RelayCommand SelectPositonCommand { get; set; }




        public ICommand GotoAdmin_Command { get; set; }

        private object selectedPositionViewModel_UC;

        public object SelectedPositionViewModel_UC
        {
            get { return selectedPositionViewModel_UC; }
            set
            {
                selectedPositionViewModel_UC = value;
                OnPropertyChanged(nameof(SelectedPositionViewModel_UC));
            }
        }
        public ICommand GotoCustomer_Command { get; set; }





        private void NavigateToCustomer(object obj)
        {
            DataContext = new CarGalleryDataClassesDataContext();

            var customer = new Customer();
            customer = DataContext.Customers.FirstOrDefault(c => c.Name_of_Customers == Starts.NameTxtBox.Text && c.Passwords_of_Customers == Starts.PasswordTxtBox.Password);

            try
            {
                if (Starts.PositionCombobox.SelectedIndex == 1)
                {
                    if (!string.IsNullOrEmpty(Starts.NameTxtBox.Text) || !string.IsNullOrEmpty(Starts.PasswordTxtBox.Password))
                    {
                        if (DataContext.Customers.Any(x => x.Name_of_Customers == Starts.NameTxtBox.Text) && DataContext.Customers.Any(x => x.Passwords_of_Customers == Starts.PasswordTxtBox.Password))
                        {
                            MessageBox.Show($"{customer.Name_of_Customers} {customer.Passwords_of_Customers}");

                            SelectedPositionViewModel_UC = new CustomerViewModel_UC();

                        }


                        if (customer == null)
                        {
                            MessageBox.Show($"SingIn Error");
                        }

                    }

                    else
                    {
                        MessageBox.Show($"Empty Field");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");

            }

        }

        private void NavigateToAdmin(object obj)
        {
            DataContext = new CarGalleryDataClassesDataContext();

            var admin = new Admin();
            admin = DataContext.Admins.FirstOrDefault(c => c.Name_of_Admins == Starts.NameTxtBox.Text && c.Passwords_of_Admins == Starts.PasswordTxtBox.Password);



            try
            {

                if (Starts.PositionCombobox.SelectedIndex == 0)
                {
                    if (!string.IsNullOrEmpty(Starts.NameTxtBox.Text) || !string.IsNullOrEmpty(Starts.PasswordTxtBox.Password))
                    {
                        if (DataContext.Admins.Any(x => x.Name_of_Admins == Starts.NameTxtBox.Text) && DataContext.Admins.Any(x => x.Passwords_of_Admins == Starts.PasswordTxtBox.Password))
                        {
                            MessageBox.Show($"{admin.Name_of_Admins} {admin.Passwords_of_Admins}");


                            SelectedPositionViewModel_UC = new AdminViewModel_UC();

                            //adminIdWrite();

                        }


                        if (admin == null)
                        {
                            MessageBox.Show($"SingIn Error");
                        }

                    }

                    else
                    {
                        MessageBox.Show($"Empty Field");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }


   


            public StartViewModel(ICarRepository repocarStart, IAdminRepository adminRepository, ICustomerRepository customerRepository)
        {
            _repoCarStart = repocarStart;
            AllCarsStart = _repoCarStart.GetAllData();

            _repoadminStart = adminRepository;
            AllAdminsStart = _repoadminStart.GetAllData();

            _repoCustomerStart = customerRepository;
            AllCustomersStart = _repoCustomerStart.GetAllData();

            //CurrentCar = new Car();
        }


        public void adminIdWrite()
        {
            CurrentAdmin = new Admin();
            try
            {
                using (FileStream fs = new FileStream("AdminNameCheck.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {

                    adminIdText = Starts.NameTxtBox.Text.ToString();
                    byte[] bytes = Encoding.Default.GetBytes(adminIdText);
                    fs.Write(bytes, 0, bytes.Length);

                }

                MessageBox.Show($"{adminIdText}");

            }
            catch (Exception)
            {

            }
        }

        public StartViewModel()
        {
            //  Starts = new Start();



            ComboBoxSelect = new ComboBoxSelect();
            Positions = new ObservableCollection<Position>(ComboBoxSelect.ComboBoxGetAll());

            GotoAdmin_Command = new RelayCommand(NavigateToAdmin);
            GotoCustomer_Command = new RelayCommand(NavigateToCustomer);

            SelectPositonCommand = new RelayCommand((sender) =>
            {
                if (Starts.PositionCombobox.SelectedIndex == 0)
                {
                    Starts.SingInButtonasAdmin.Visibility = Visibility.Visible;
                    Starts.SingInButtonasCustomer.Visibility = Visibility.Hidden;

                }

                if (Starts.PositionCombobox.SelectedIndex == 1)
                {
                    Starts.SingInButtonasCustomer.Visibility = Visibility.Visible;
                    Starts.SingInButtonasAdmin.Visibility = Visibility.Hidden;
                }


            });

        }
    }
}
