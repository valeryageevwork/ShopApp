using CourseProject.View;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections;
using CourseProject.Presenter;

namespace CourseProject
{
    public partial class CustomerWindow : Window, IViewCustomer
    {
        private PresenterCustomer presenterCustomer;

        #region Свойства
        public new string Name { get => textBox_name.Text; }
        public string Surname { get => textBox_surname.Text; }
        public DateTime DateOfBirth { get => datePicker.DisplayDate; }
        public double Wallet
        {
            get
            {
                if (textBox_wallet.Text == "")
                {
                    return -1;
                }
                else
                {
                    return Convert.ToDouble(textBox_wallet.Text);
                }
                    
            }
            set
            {
                textBox_wallet.Text = string.Format("{0:f2}", value);
            }
        }
        public double ScoresCard
        {
            get
            {
                if (textBox_scores.Text == "")
                {
                    return -1;
                }
                else
                {
                    return Convert.ToDouble(textBox_scores.Text);
                }
            }
            set
            {
                textBox_scores.Text = string.Format("{0:f2}", value);
            }
        }
        public string NameOfCard { get => textBox_nameCard.Text; }
        public new string Content { get => textBox_changes.Text; set => textBox_changes.Text = value; }
        public bool? Score { get => checkBox_scores.IsChecked; }
        public IEnumerable? ListOfPurchases
        {
            get => listBox_purchases.Items;
        }
        public IEnumerable? Basket
        {
            get => dataGrid_basket.ItemsSource;
            set => dataGrid_basket.ItemsSource = value;
        }
        public IEnumerable? Repository
        {
            get => dataGrid_repository.ItemsSource;
            set => dataGrid_repository.ItemsSource = value;
        }
        #endregion

        public CustomerWindow()
        {
            InitializeComponent();
            presenterCustomer = new PresenterCustomer(this);
        }

        #region Методы
        private void button_addCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (Name != default && Surname != default &&
               (DateTime.Now.Year - DateOfBirth.Year > 10) && NameOfCard != default &&
               ScoresCard >= 0.0 && Wallet >= 0.0 &&
               listBox_purchases.Items.Count != 0)
            {
                presenterCustomer.SetCostumer();
                textBox_name.IsEnabled = false;
                textBox_surname.IsEnabled = false;
                datePicker.IsEnabled = false;
                textBox_nameCard.IsEnabled = false;
                textBox_scores.IsEnabled = false;
                textBox_wallet.IsEnabled = false;
                button_addCustomer.IsEnabled = false;

                button_pay.IsEnabled = true;
                checkBox_scores.IsEnabled = true;
            }
        }

        private void button_addPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox_products.Text != "")
            {
                listBox_purchases.Items.Add(comboBox_products.Text);
                presenterCustomer.ChangeListOfPurchases(ListOfPurchases);
            }
        }

        private void menuItem_add_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid_repository.Items.Count > 0 && dataGrid_repository.SelectedItem != null)
            {
                presenterCustomer.SetToBasket(dataGrid_repository.SelectedItem);
            }
        }

        private void menuItem_remove_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid_basket.Items.Count > 0 && dataGrid_basket.SelectedItem != null)
            {
                presenterCustomer.UnsetFromBasket(dataGrid_basket.SelectedItem);
            }
        }

        private void button_pay_Click(object sender, RoutedEventArgs e)
        {
            presenterCustomer.Pay();
        }

        private void button_removePurchase_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox_products.Text != "")
            {
                listBox_purchases.Items?.Remove(comboBox_products.Text);
                presenterCustomer.ChangeListOfPurchases(ListOfPurchases);
            }     
        }

        private void textBox_wallet_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(textBox_wallet.Text, out double num))
            {
                textBox_wallet.Clear();
            }
            else
            {
                if (num < 0)
                {
                    textBox_wallet.Clear();
                }
            }
        }

        private void textBox_scores_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(textBox_scores.Text, out double num))
            {
                textBox_scores.Clear();
            }
            else 
            {
                if (num < 0)
                {
                    textBox_scores.Clear();
                }
            }
        }
        #endregion

    }
}
