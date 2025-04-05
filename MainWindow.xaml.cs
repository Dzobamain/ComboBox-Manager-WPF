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

namespace ComboBox_Manager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewItemTextBox.Text))
            {
                var newItem = new ComboBoxItem
                {
                    Content = NewItemTextBox.Text,
                };

                ItemComboBox.Items.Add(newItem);
                NewItemTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name for the new item.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemComboBox.SelectedItem != null)
            {
                ItemComboBox.Items.Remove(ItemComboBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

