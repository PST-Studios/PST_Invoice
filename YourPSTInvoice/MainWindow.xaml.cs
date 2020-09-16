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

namespace YourPSTInvoice
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

        int option1 = 50, option2 = 40, option3 = 35, option4 = 30, option5 = 25;

        private void Savecustomer_button_Click(object sender, RoutedEventArgs e)
        {
            customerlist_listview.Items.Add(customername_text.Text + " / " + customeremail_text.Text + " / " + customerphone_text.Text);
        }

        private void Tolist_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Toinvoice_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(toinvoice_combo.Text);
            if(toinvoice_combo.Text == "Lessons")
            {
                int amount = int.Parse(toinvoicetext_text.Text);
                int new_amount = option1 * amount;
                toinvoice_listview.Items.Add(new MyItem { Name = "Lessons", Price = option1, Amount = amount, Total = new_amount });
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

    public class MyItem
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public int Total { get; set; }
    }
}
