using System.Collections.Generic;
using System;

namespace CourseProject.Model
{
    public class ModelCustomer
    {
        public Customer customer { get; private set; }

        public void SetCustomer(string name, string surname, DateTime dateOfBirth, double money,
                                List<string> listOfPurchases, string nameCard, double scores)
        {
            customer = new Customer(name, surname, dateOfBirth,  
                                    new BonusCard(nameCard, scores), 
                                    money, listOfPurchases);
        }
        public void SetToBasket(Product product)
        {
            customer.SetToBasket(product);
        }
        public void UnsetBasket(Product product)
        {
            customer.UnsetFromBasket(product);
        }
        public string Pay(bool score)
        {
            double result = customer.Pay(score);
            switch (result)
            {
                case -1:
                    return "The money are not enough!";
                case 0:
                    return "Products are paid.\nYour change is zero.";
                default:
                    return $"Products are paid.\nCheck your wallet.";
            }
        }
        public List<Product> GetProducts()
        {
            return RepositoryShop.AllProducts;
        }
    }
}
