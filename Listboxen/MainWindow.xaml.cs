using System;
using System.Collections;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            input.Focus();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string newItem = input.Text;
            shoppingListBox.Items.Add(newItem);
            input.Clear();
            input.Focus();
            aantal.Text = "Aantal: " + Convert.ToString(shoppingListBox.Items.Count);
        }

        private void itemButton_Click(object sender, RoutedEventArgs e)
        {
            string item = (string)shoppingListBox.Items[Convert.ToInt32(indexTextBox.Text)];
            itemNaam.Text = item;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            shoppingListBox.Items.RemoveAt(Convert.ToInt32(indexTextBox.Text));
        }
    }
}