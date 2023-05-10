using System.Collections.Generic;

namespace CourseProject.Model
{
    public class Basket
    {
        public List<Product> Products { get; private set; }

        public Basket()
        {
            Products = new List<Product>();
        }
        public void AddToBasket(Product product)
        {
            Products.Add(product);
            RepositoryShop.RemoveFromRepository(product);
        }
        public void RemoveFromBasket(Product product)
        {
            var el = Products.Find(el => el == product);
            if(el != null)
            {
                Products.Remove(el);
                RepositoryShop.AddToRepository(el);
            }
        }
        public void RemoveAllFromBasket()
        {
            Products.Clear();
        }
    }
}
