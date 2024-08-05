using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Data;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person("John", 18);
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Name : {person.Name} \n Age : {person.Age}");
        }
    }
}