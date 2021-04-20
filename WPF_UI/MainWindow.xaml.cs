using System;
using System.Collections.Generic;
using System.Collections;
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

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<Item> items = new List<Item>();
        //Hashtable items = new Hashtable();
        Dictionary <string, dynamic> items = new Dictionary<string, dynamic>();
        public double balance = 0;
        public string order_code = "";
        public MainWindow()
        {
            InitializeComponent();
            //items.Add(new Item ( code = "A1", title = "Snack 1", amount = 5 ));
            items.Add("A1", new Item { code = "A1", title = "Snack A1", amount = 5, price = 2.5 });
            items.Add("A2", new Item { code = "A2", title = "Snack A2", amount = 5, price = 1.5 });
            items.Add("A3", new Item { code = "A3", title = "Snack A3", amount = 5, price = 1.75 });
            items.Add("A4", new Item { code = "A4", title = "Snack A4", amount = 5, price = 2.75 });
            items.Add("B1", new Item { code = "B1", title = "Snack B1", amount = 5, price = 1.75 });
            items.Add("B2", new Item { code = "B2", title = "Snack B2", amount = 5, price = 2.75 });
            items.Add("B3", new Item { code = "B3", title = "Snack B3", amount = 5, price = 1.75 });
            items.Add("B4", new Item { code = "B4", title = "Snack B4", amount = 5, price = 1.75 });
            items.Add("C1", new Item { code = "C1", title = "Snack C1", amount = 5, price = 1.10 });
            items.Add("C2", new Item { code = "C2", title = "Snack C2", amount = 5, price = 1.75 });
            items.Add("C3", new Item { code = "C3", title = "Snack C3", amount = 5, price = 1.75 });
            items.Add("C4", new Item { code = "C4", title = "Snack C4", amount = 5, price = 2.75 });
            items.Add("D1", new Item { code = "D1", title = "Snack D1", amount = 5, price = 3.75 });
            items.Add("D2", new Item { code = "D2", title = "Snack D2", amount = 5, price = 1.75 });
            items.Add("D3", new Item { code = "D3", title = "Snack D3", amount = 5, price = 1.50 });
            items.Add("D4", new Item { code = "D4", title = "Snack D4", amount = 5, price = 1.75 });
            //cbItemSelected.ItemsSource = items;
            //items.Add(new Item { code = "A1", title = "Snack A1", amount = 5, price = 2.5 });
            //items.Add(new Item { code = "A2", title = "Snack A2", amount = 5, price = 1.5 });
            //items.Add(new Item { code = "A3", title = "Snack A3", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "A4", title = "Snack A4", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "B1", title = "Snack B1", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "B2", title = "Snack B2", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "B3", title = "Snack B3", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "B4", title = "Snack B4", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "C1", title = "Snack C1", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "C2", title = "Snack C2", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "C3", title = "Snack C3", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "C4", title = "Snack C4", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "D1", title = "Snack D1", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "D2", title = "Snack D2", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "D3", title = "Snack D3", amount = 5, price = 1.75 });
            //items.Add(new Item { code = "D4", title = "Snack D4", amount = 5, price = 1.75 });
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int count_of_coin = 0;
            count_of_coin = (int)(Math.Round(balance, 2) / 2.0);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Tooney : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance( - count_of_coin * 2.0 );

            count_of_coin = (int)(Math.Round(balance, 2) / 1.0);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Looney : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance(-count_of_coin * 1.0);

            count_of_coin = (int)(Math.Round(balance, 2) / 0.25);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Quater : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance(-count_of_coin * 0.25);
            count_of_coin = (int)(Math.Round(balance, 2) / 0.1);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Dime : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance(-count_of_coin * 0.10);

            count_of_coin = (int)(Math.Round(balance, 2) / 0.05);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Nickle : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance(-count_of_coin * 0.05);

            count_of_coin = (int)(Math.Round(balance, 2) / 0.01);
            if (count_of_coin > 0)
            {
                tbMessage.Text = "Penny : \t" + count_of_coin + "\r\n" + tbMessage.Text;
            }
            update_balance(-(count_of_coin * 0.01));
        }

        private void OnCoinInserted(object sender, RoutedEventArgs e)
        {
            // WPF has no ImageButton Component! Thus, we have to use a trick in the xaml
            // That is why the button can not have content.
            double coin_value = double.Parse((((Button)sender).Name).Substring(3, 3));
            coin_value = Math.Round((coin_value / 100), 2);
            balance += coin_value;
            tbBalance.Text = balance.ToString("n2");
            //MessageBox.Show($"Hello $ {coin_amount}"); // for testing
        }
        private void OnOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            // WPF has no ImageButton Component! Thus, we have to use a trick in the xaml
            // The sender.Content is one of A,B,C,D,1,2,3,4
            order_code += ((Button)sender).Content;

            // The order code should be one of A1, A2, ...D4
            if ( order_code.Length < 2 ) return;

            // check the order_code is correct
            if ( !items.ContainsKey(order_code ))
            {
                // display message it is wrong order code
                tbMessage.Text = order_code + ": Wrong Button Pressed \t : \r\n" + tbMessage.Text;
                order_code = "";
                return;
            }
            // When the balance is not enough
            //KeyValuePair<string, Item> item = items[order_code];
            if (balance < items[order_code].price)
            {
                tbMessage.Text = items[order_code].title + "\t : " + items[order_code].price + "\t The Balance is not enough!\r\n" + tbMessage.Text;
                order_code = "";
                return;
            }
            // When the amount of item is not enough
            if ( items[order_code].amount < 1)
            {
                tbMessage.Text = items[order_code].title + "\t : " + items[order_code].amount + "\t The amount is not enough!\r\n" + tbMessage.Text;
                order_code = "";
                return;
            }

            update_balance(-items[order_code].price);
            items[order_code].amount--;
            //order_list.Add(new Order((DateTimeOffset.Now).ToString("M/d/yyyy h:mm:ss"), item));
            tbMessage.Text = items[order_code].title + "\t : " + items[order_code].price + "\r\n" + tbMessage.Text;
            // found matched code
            order_code = "";

            // Incorrect button pressed = incorrect order
            order_code = "";
        }
        private void update_balance(double _price )
        {
            balance += _price;
            tbBalance.Text = balance.ToString("n2");
        }

    }
}
