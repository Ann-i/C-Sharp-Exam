using ProjectClassLibrary.model.entity;
using ProjectClassLibrary.model.logic.the_strategy_pattern;

namespace ProjectClassLibrary.model.logic
{
    public class Sorter
    {
        public static void BubbleSort(Vegetable[] vegetables, IComparaable comparable)
        {
            bool flag = true;

            for (int i = 0; i < vegetables.Length - 1; i++)
            {
                for (int j = 0; j < vegetables.Length - 1 - i; j++)
                {
                    if (comparable.Compare(vegetables[j], vegetables[j + 1]))
                    {
                        flag = false;
                        Vegetable t = vegetables[j];
                        vegetables[j] = vegetables[j + 1];
                        vegetables[j + 1] = t;
                    }
                }

                if (flag)
                {
                    break;
                }
            }
        }
    }
}
