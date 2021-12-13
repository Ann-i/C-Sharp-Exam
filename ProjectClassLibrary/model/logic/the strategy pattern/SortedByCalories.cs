using System.Collections.Generic;
using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.the_strategy_pattern
{
    public class SortedByCalories : IComparer<Vegetable>
    {
        public int Compare(Vegetable x, Vegetable y)
        {
            if(x.Calories > y.Calories)
            {
                return 1;
            }
            else if (x.Calories < y.Calories)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
