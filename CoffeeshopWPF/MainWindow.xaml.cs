using CoffeeShop.Business_Logic;
using CoffeeshopWPF.Pages;
using CoffeeshopWPF.ViewModel;
using System.Windows;

namespace CoffeeshopWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public IPresenter presenter;

        static FindByDate fbdPage;
        static FindByName fbnPage;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
            fbdPage = new FindByDate();
            fbnPage = new FindByName();
            Container.Content = fbdPage;
        }

        private void MenuItem1Click(object sender, RoutedEventArgs e)
        {
            Container.Content = fbdPage;
        }

        private void MenuItem2Click(object sender, RoutedEventArgs e)
        {
            Container.Content = fbnPage;
        }
    }
}
