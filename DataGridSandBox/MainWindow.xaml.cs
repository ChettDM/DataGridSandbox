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
using DataGridSandBox.Models;

namespace DataGridSandBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Element> List { get; set; }

        public MainWindow()
        {
            List = new ObservableCollection<Element>();
            
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            for (var i = 1; i <= 5; i++)
                List.Add(new Element
                {
                    Id = i,
                    IdHasError = true,
                    IdErrorMessage = "Error: This is an example Id Error Message - " + i,
                    Order = i,
                    OrderHasError = true,
                    OrderErrorMessage = "Error: This is an example OrderErrorMessage Error Message - " + i,
                    Description1 = nameof(Element.Description1) + " - " + i,
                    Description1HasError = true,
                    Description1ErrorMessage = "Error: This is an example Description1 Error Message - " + i,
                    Description2 = nameof(Element.Description2) + " - " + i,
                    Description2HasError = true,
                    Description2ErrorMessage = "Error: This is an example Description2 Error Message - " + i,

                    ElementErrorMessage = "Error: This is an example of a row error."
                });

        }
    }
}
