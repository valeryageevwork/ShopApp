using System.Windows;

namespace CourseProject
{
    public partial class MainWindow : Window
    {
        private CustomerWindow customerWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_enterShop_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "123")
            {
                customerWindow?.Close();
                customerWindow = new CustomerWindow();
                customerWindow.Show();
                passwordBox.Clear();
            }
        }
    }
}
