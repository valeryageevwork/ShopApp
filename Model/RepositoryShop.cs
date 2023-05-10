using System;
using System.Collections.Generic;

namespace CourseProject.Model
{
    public static class RepositoryShop
    {
        public static List<Product> AllProducts { get; private set; }

        static RepositoryShop()
        {
            AllProducts = new List<Product>();
            Random r = new Random();
            Bucher bucher = new Bucher();

            for (int i = 0; i < 30; i++)
            {
                switch (r.Next(1, 10))
                {
                    case 1:
                        ExoticMeetBuilder exoticMeetBuilder = new ExoticMeetBuilder();
                        Meet exoticMeet = bucher.GetMeet(exoticMeetBuilder);
                        AddToRepository(exoticMeet);
                        break;
                    case 2:
                        FatMeetBuilder fatMeetBuilder = new FatMeetBuilder();
                        Meet fatMeet = bucher.GetMeet(fatMeetBuilder);
                        AddToRepository(fatMeet);
                        break;
                    case 3:
                        FriedMeetBuilder friedMeetBuilder = new FriedMeetBuilder();
                        Meet friedMeet = bucher.GetMeet(friedMeetBuilder);
                        AddToRepository(friedMeet);
                        break;
                    case 4:
                        Meet meet = new Meet();
                        AddToRepository(meet);
                        break;
                    case 5:
                        Bread russianBread = new RussianBread();
                        for (int j = 0; j < 3; j++)
                        {
                            russianBread = r.Next(0, 2) == 0 ? new CheeseBread(russianBread) : new SweetBread(russianBread);
                        }
                        AddToRepository(russianBread);
                        break;
                    case 6:
                        Bread bulgarianBread = new BulgarianBread();
                        for (int j = 0; j < 3; j++)
                        {
                            bulgarianBread = r.Next(0, 2) == 0 ? new CheeseBread(bulgarianBread) : new SweetBread(bulgarianBread);
                        }
                        AddToRepository(bulgarianBread);
                        break;
                    case 7:
                        Tomato tomato = new Tomato();
                        AddToRepository(tomato);
                        break;
                    case 8:
                        Fish fish = new Fish();
                        AddToRepository(fish);
                        break;
                    case 9:
                        Apple apple = new Apple();
                        AddToRepository(apple);
                        break;
                }
            }

        }
        public static void AddToRepository(Product product)
        {
            AllProducts.Add(product);
        }
        public static void RemoveFromRepository(Product product)
        {
            product = AllProducts.Find(el => el == product);
            if(product != null)
            {
                AllProducts.Remove(product);
            }
        }
        public static void NewProduct(string name)
        {
            Random r = new Random();
            Bucher bucher = new Bucher();
            switch (name)
            {
                case "exotic meet":
                    ExoticMeetBuilder exoticMeetBuilder = new ExoticMeetBuilder();
                    Meet exoticMeet = bucher.GetMeet(exoticMeetBuilder);
                    AddToRepository(exoticMeet);
                    break;
                case "fat meet":
                    FatMeetBuilder fatMeetBuilder = new FatMeetBuilder();
                    Meet fatMeet = bucher.GetMeet(fatMeetBuilder);
                    AddToRepository(fatMeet);
                    break;
                case "fried meet":
                    FriedMeetBuilder friedMeetBuilder = new FriedMeetBuilder();
                    Meet friedMeet = bucher.GetMeet(friedMeetBuilder);
                    AddToRepository(friedMeet);
                    break;
                case "meet":
                    Meet meet = new Meet();
                    AddToRepository(meet);
                    break;
                case "russian bread":
                    Bread russianBread = new RussianBread();
                    for (int j = 0; j < 3; j++)
                    {
                        russianBread = r.Next(0, 2) == 0 ? new CheeseBread(russianBread) : new SweetBread(russianBread);
                    }
                    AddToRepository(russianBread);
                    break;
                case "bulgarian bread":
                    Bread bulgarianBread = new BulgarianBread();
                    for (int j = 0; j < 3; j++)
                    {
                        bulgarianBread = r.Next(0, 2) == 0 ? new CheeseBread(bulgarianBread) : new SweetBread(bulgarianBread);
                    }
                    AddToRepository(bulgarianBread);
                    break;
                case "tomato":
                    Tomato tomato = new Tomato();
                    AddToRepository(tomato);
                    break;
                case "fish":
                    Fish fish = new Fish();
                    AddToRepository(fish);
                    break;
                case "apple":
                    Apple apple = new Apple();
                    AddToRepository(apple);
                    break;
            }
        }
    }
}
