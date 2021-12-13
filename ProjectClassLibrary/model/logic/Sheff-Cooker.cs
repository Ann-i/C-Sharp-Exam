using Project.model.entity;

namespace Project.model.logic
{
    //logic operations (wich in task))
    public class Sheff_Cooker
    {
        //for MSTesting
        //start
        private static Sheff_Cooker sheffCooker;
        static Sheff_Cooker()
        {
            sheffCooker = new Sheff_Cooker();
        }
        private Sheff_Cooker() { }
        public static Sheff_Cooker GetInstance()
        {
            return sheffCooker;
        }
        //end

        //function wich calculated "weight" of "salad"(array)
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
        //function wich calculate "calories" in "salad"(array)
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
        //function wich find the most-high "calorie vegetable" in "salad"(array)
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
