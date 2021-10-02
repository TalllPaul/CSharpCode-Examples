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

namespace DowncastingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //The source of the click is the object sender parameter (button). If you check sender you can only view the properties of the sender class and not the object button.
        //To view all we need to downcast. var button = (Button) sender;
        //If we do not know the runtime type of an object, to avoid exceptions we can use the as keyword. 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button) sender;

            //Checks if it is of type Button
            var button = sender as Button;
            //If it doesn't return null (it's a button) we do what we want to do.
            if(button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }

            MessageBox.Show("Hello World!");
        }
    }
}
