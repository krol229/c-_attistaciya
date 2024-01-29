using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace forattistat
{
        public class Task
    {
        public string TaskName { get; set; }
        public string Status { get; set; }
        public int Estimation { get; set; }
        public string SizesOfClothes { get; set; }
    }
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerPhoto { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSizes { get; set; }
        public Task[] Tasks { get; set; }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Customer> Customers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Customers = new ObservableCollection<Customer>()
                {
                    new Customer() {
                        CustomerName="Balenciaga", CustomerCountry="France", CustomerPhoto="photo\\balenci.jpg", ProjectName = "French Fashion House",
                        Tasks = new Task[] {
                        new Task(){TaskName = "Balenciaga Triple S DIY", Status = "SS24", Estimation = 173690, SizesOfClothes = "37,38,39,40,41,42,43"},
                        new Task(){TaskName = "MEN'S CROCS BOOT IN BLACK", Status = "SS22", Estimation = 60870, SizesOfClothes = "39,40,41,42,43"},
                        new Task(){TaskName = "MEN'S BULLDOZER LACE-UP BOOT IN BLACK", Status = "SS22", Estimation = 200000, SizesOfClothes = "36,37,38,39,40,41,42,43"},
                        new Task(){TaskName = "MEN'S SPEED 2.0 RECYCLED KNIT SNEAKER IN BLACK/WHITE", Status = "SS22", Estimation = 88620, SizesOfClothes = "38,39,40,41,42,43"},
                    } },
                    new Customer() {
                        CustomerName="Rick Owens", CustomerCountry="USA", CustomerPhoto="photo\\RO.jpg", ProjectName = "Designer",
                        Tasks = new Task[] {
                        new Task(){TaskName = "DRKSHDW SS24 LIDO SNEAKS", Status = "SS24 ", Estimation = 53887, SizesOfClothes = "36,37,38,39,40,41"},
                        new Task(){TaskName = "DRKSHDW FW23 LUXOR", Status = "FW23", Estimation = 53887, SizesOfClothes = "36,37,38,39,40,41" },
                        new Task(){TaskName = "DRKSHDW SS24 LIDO HEXA", Status = "SS24 ", Estimation = 55343, SizesOfClothes = "36,37,38,39,40,41" },
                    } },
                    new Customer() {
                        CustomerName="Ayne", CustomerCountry="Russia", CustomerPhoto="photo\\ay.jpg", ProjectName = "Designer",
                        Tasks = new Task[] {
                        new Task(){TaskName = "Часы “AYNE TIME” BLACK", Status = "NONE", Estimation = 10000, SizesOfClothes = "NONE" },
                        new Task(){TaskName = "Очки YETTIE “CLASSIC”", Status = "NONE", Estimation = 6000, SizesOfClothes = "NONE" },
                        new Task(){TaskName = "Очки ”IGGAAK”", Status = "NONE", Estimation = 100000, SizesOfClothes = "NONE" },
                        new Task(){TaskName = "Очки YETTIE SPORT 3", Status = "NONE", Estimation = 7000, SizesOfClothes = "NONE" },
                        new Task(){TaskName = "Шапка-балаклава YETIHEAD", Status = "NONE", Estimation = 15000, SizesOfClothes = "NONE" },
                    } },
                    new Customer() {
                        CustomerName="Vetements", CustomerCountry="Switzerland", CustomerPhoto="photo\\vet.jpg", ProjectName = "Switzerland Fashion House",
                        Tasks = new Task[] {
                        new Task(){TaskName = "Black New Rock Edition Race Sneakers", Status = "2023", Estimation = 111658, SizesOfClothes = "36,37,38,39,40,41,42,43" },
                        new Task(){TaskName = "Black New Rock Edition Loafers", Status = "2023", Estimation = 115542, SizesOfClothes = "36,37,38,39,40,41,42,43" },
                        new Task(){TaskName = "Black New Rock Edition Leather Boots", Status = "2023", Estimation = 115542, SizesOfClothes = "36,37,38,39,40,41,42,43" },
                    } },
            };
        }
        private void Butsver_Click(object sender, RoutedEventArgs e) {WindowState = WindowState.Minimized;}
        private void Butclose_Click(object sender, RoutedEventArgs e){Environment.Exit(0);}
        private void dolbaeb(object sender, MouseButtonEventArgs e){this.DragMove();}

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}