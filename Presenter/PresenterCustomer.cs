using System.Collections;
using System.Linq;
using CourseProject.Model;
using CourseProject.View;

namespace CourseProject.Presenter
{
    public class PresenterCustomer
    {
        private IViewCustomer viewCustomer;
        private ModelCustomer modelCustomer;

        public PresenterCustomer(IViewCustomer viewCustomer)
        {
            this.viewCustomer = viewCustomer;
            modelCustomer = new ModelCustomer();
        }

        public void SetCostumer()
        {
            modelCustomer.SetCustomer(viewCustomer.Name, viewCustomer.Surname,
                                      viewCustomer.DateOfBirth, viewCustomer.Wallet,
                                      viewCustomer.ListOfPurchases.Cast<string>().ToList(), viewCustomer.NameOfCard,
                                      viewCustomer.ScoresCard);
            viewCustomer.Basket = modelCustomer.customer.CustomerBasket.Products;
            viewCustomer.Repository = modelCustomer.GetProducts();
        }

        public void SetToBasket(object obj)
        {
            viewCustomer.Basket = null;
            modelCustomer.SetToBasket(((Product)obj));
            viewCustomer.Basket = modelCustomer.customer.CustomerBasket.Products;

            viewCustomer.Repository = null;
            viewCustomer.Repository = modelCustomer.GetProducts();

        }
        public void UnsetFromBasket(object obj)
        {
            viewCustomer.Basket = null;
            modelCustomer.UnsetBasket(((Product)obj));
            viewCustomer.Basket = modelCustomer.customer.CustomerBasket.Products;

            viewCustomer.Repository = null;
            viewCustomer.Repository = modelCustomer.GetProducts();
        }
        public void Pay()
        {
            if (modelCustomer.customer.CustomerBasket.Products.Count > 0)
            {
                viewCustomer.Content = modelCustomer.Pay(viewCustomer.Score ?? false);
                viewCustomer.ScoresCard = modelCustomer.customer.CustomerBonusCard.Scores;
                viewCustomer.Wallet = modelCustomer.customer.Wallet;

                viewCustomer.Basket = null;
                viewCustomer.Basket = modelCustomer.customer.CustomerBasket.Products;
            }
        }
        public void ChangeListOfPurchases(IEnumerable list)
        {
            if (modelCustomer.customer != null)
            {
                modelCustomer.customer.ListOfPurchases = list.Cast<string>().ToList();
            }
        }
    }
}
