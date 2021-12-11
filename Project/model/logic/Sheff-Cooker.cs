using Project.model.entity;

namespace Project.model.logic
{
    public class Sheff_Cooker
    {
        private static Sheff_Cooker sheffcooker;

        static Sheff_Cooker()
        {
            sheffcooker = new Sheff_Cooker();
        }
        private Sheff_Cooker() { }
        public double CaltulateWeightOfSalad(Salad salad)
        {
            double sum = 0;

            if(salad != null && salad.Size > 0)
            {
                for (int i = 0; i < salad.Size; i++)
                {
                    sum += salad.Get(i).Weight;
                }
            }

            return sum;
        }
        public double CalculateCalories(Salad salad)
        {
            double sum = 0;

            if (salad != null && salad.Size > 0)
            { 
                for (int i = 0; i < salad.Size; i++)
                {
                    sum += salad.Get(i).Calories;
                }
            }

            return sum;
        }
        public Vegetable TheMostHighCalorieProduct(Salad salad)
        {
            Vegetable theMostHighCalorieProduct = null;

            if(salad != null && salad.Size > 0)
            {
                theMostHighCalorieProduct = salad.Get(0);

                for (int i = 1; i < salad.Size; i++)
                {
                    if (theMostHighCalorieProduct.Calories < salad.Get(i).Calories)
                    {
                        theMostHighCalorieProduct = salad.Get(i);
                    }
                }
            }

            return theMostHighCalorieProduct;
        }
    }
}
