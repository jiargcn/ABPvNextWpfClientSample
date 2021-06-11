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
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Win.Fmp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ITransientDependency
    {
        private readonly IProfileAppService _profileAppService;

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(IProfileAppService profileAppService)
        {
            InitializeComponent();
            _profileAppService = profileAppService;
        }

      

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var output = await _profileAppService.GetAsync();
            MessageBox.Show($"{output.UserName}+{output.Email}+{output.Name}+{output.Surname}");
        }
    }
}
