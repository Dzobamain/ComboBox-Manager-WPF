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
                    Background = GetSelectedColor()
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

        private SolidColorBrush GetSelectedColor()
        {
            var selectedItem = ColorItemComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                string selectedColor = selectedItem.Content.ToString();
                switch (selectedColor)
                {
                    case "Red": return new SolidColorBrush(Colors.Red);
                    case "Green": return new SolidColorBrush(Colors.Green);
                    case "Blue": return new SolidColorBrush(Colors.Blue);
                    case "Yellow": return new SolidColorBrush(Colors.Yellow);
                    case "Orange": return new SolidColorBrush(Colors.Orange);
                    case "Purple": return new SolidColorBrush(Colors.Purple);
                    case "Brown": return new SolidColorBrush(Colors.Brown);
                    case "Gray": return new SolidColorBrush(Colors.Gray);
                    case "Pink": return new SolidColorBrush(Colors.Pink);
                    case "Black": return new SolidColorBrush(Colors.Black);
                    default: return new SolidColorBrush(Colors.White);
                }
            }

            return new SolidColorBrush(Colors.White);
        }
    }
}

