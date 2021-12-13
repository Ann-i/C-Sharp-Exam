using System;
using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.util
{
    public class SimpleVegetableFactory
    {
        public enum ProductType { TOMATO, CUCUMBER, POTATO }

        public const double MIN_CALORIES = 1;
        public const double MAX_CALORIES = 500.0;

        public const double MIN_WEIGH = 1;
        public const double MAX_WEIGH = 500.0;

        public const double MIN_LENGH = 4.0;
        public const double MAX_LENGH = 50.0;

        public readonly string[] COLOR = { "red", "yellow", "black", "orange", "green"};
        public readonly string[] VARIETY = { "scarlet dawn", "honey herat", "black prince" };

        public readonly string[] SIZE = { "little", "middle", "big"};
        public readonly string[] SEAZON = {"summer", "autumn"};

        public const int COEFFICIENT = 100;

        private Random random;

        public SimpleVegetableFactory()
        {
            random = new Random();
        }

        public Vegetable Getvegetable(ProductType type)
        {
            Vegetable vegetable = null;

            double calories = random.NextDouble() * MAX_CALORIES + MIN_CALORIES;
            double weigh = random.NextDouble() * MIN_WEIGH + MAX_WEIGH;

            switch (type)
            {
                case ProductType.CUCUMBER:
                    {
                        double lengh = random.NextDouble() * MAX_LENGH + MIN_LENGH;
                        bool isPrickly = (random.Next(100) < 50) ? true : false;
                        vegetable = new Cucumber(lengh, isPrickly, calories, weigh);
                    }
                    break;
                case ProductType.POTATO:
                    {
                        string size = SIZE[random.Next(SIZE.Length)];
                        string seazon = SEAZON[random.Next(SEAZON.Length)];
                        vegetable = new Potato(size, seazon, calories, weigh);
                    }
                    break;
                case ProductType.TOMATO:
                    {
                        string color = COLOR[random.Next(COLOR.Length)];
                        string variety = VARIETY[random.Next(VARIETY.Length)];
                        vegetable = new Tomato(color, variety, calories, weigh);
                    }
                    break;
            }
            return vegetable;
        }
    }
}
