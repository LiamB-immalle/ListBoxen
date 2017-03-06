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

namespace Listboxen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string newItem = textBox.Text;
            shoppingListBox.Items.Add(newItem);
            textBox.Clear();
            textBox.Focus();
            aantal.Text = "Aantal: " + Convert.ToString(shoppingListBox.Items.Count);
        }
    }
}
