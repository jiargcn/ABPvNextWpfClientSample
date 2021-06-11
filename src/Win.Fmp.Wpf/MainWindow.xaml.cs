using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace Win.Fmp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private readonly IWpfPersonService _personService;

        public MainWindow(IWpfPersonService personService)
        {
            _personService = personService;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var str= _personService.GetPersons();
            Label1.Content = str;

        }


    }
}
