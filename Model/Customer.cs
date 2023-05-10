using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Model
{
    public class Customer : Person
    {
        private static int counter = 1;
        public int Id { get; private set; }
        public BonusCard CustomerBonusCard { get; set; }
        public double Wallet { get; set; }
        public List<string> ListOfPurchases { get; set; }
        public Basket CustomerBasket { get; set; }

        public Customer(string name, string surname, DateTime dateOfBirth, 
                        BonusCard bonusCard, double wallet, 
                        List<string> listOfPurchases) :
                   base(name, surname, dateOfBirth)
        {
            Id = counter++;
            CustomerBonusCard = bonusCard;
            Wallet = wallet;
            ListOfPurchases = listOfPurchases;
            CustomerBasket = new Basket();
        }

        public void Weigh(Product product)
        {
            product.Weigh();
        }

        /// <summary>
        /// Добавление в корзину
        /// </summary>
        /// <param name="product">Добавляемый продукт</param>
        public void SetToBasket(Product product)
        {
            var el = ListOfPurchases.Find(myel => myel == product.Name); // ищем в списке покупок имя данного
                                                                         // продукта
            if(el != null) // если найден
            {
                var numberBasket = CustomerBasket.Products.Where(pr => pr.Name == el).ToList().Count;
                // смотрим количество продуктов в корзине, имеющие такое же имя
                var numberList = ListOfPurchases.Where(pur => pur == el).ToList().Count;
                // смотрим количество покупок в листе покупок, имеющие такое же имя
                if (numberList > numberBasket) // в успешном случае - добавляем
                {
                    if (product.Weight == 0.0 || product.Price == 0.0) // если уже был взвешен - то не взвешиваем 
                                                                       // иначе - взвешиваем перед добавлением
                    {
                        Weigh(product);
                    }
                    CustomerBasket.AddToBasket(product); // добавляем в корзину в любом случае
                }
            }
        }
        public void UnsetFromBasket(Product product)
        {
            CustomerBasket.RemoveFromBasket(product);
        }
        public double SummaryPrice()
        {
            double summaryPrice = 0;
            foreach (var el in CustomerBasket.Products)
            {
                summaryPrice += el.Price;
            }
            return summaryPrice;
        }
        public double PayScore(double summaryPrice)
        {
            if (summaryPrice <= CustomerBonusCard.Scores)
            {
                CustomerBasket.RemoveAllFromBasket();
                CustomerBonusCard.Scores -= summaryPrice;
                return 0;
            }
            else
            {
                if (summaryPrice <= Wallet + CustomerBonusCard.Scores)
                {
                    CustomerBasket.RemoveAllFromBasket();
                    Wallet -= summaryPrice - CustomerBonusCard.Scores;
                    CustomerBonusCard.Scores = 0;
                    return Wallet;
                }
                else
                {
                    return -1;
                }
            }
        }
        public double PayMoney(double summaryPrice)
        {
            if (summaryPrice <= Wallet)
            {
                CustomerBasket.RemoveAllFromBasket();
                Wallet -= summaryPrice;
                return Wallet;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Оплата
        /// </summary>
        /// <param name="counterScore">Счетчик баллов</param>
        /// <returns></returns>
        public double Pay(bool counterScore)
        {
            double summaryPrice = SummaryPrice();
            if(counterScore)
            {
                return PayScore(summaryPrice);
            }
            else
            {
                return PayMoney(summaryPrice);
            }
        }
    }
}
