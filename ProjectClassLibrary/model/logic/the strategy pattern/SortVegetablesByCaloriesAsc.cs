using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.the_strategy_pattern
{
    public class SortVegetablesByCaloriesAsc : IComparaable
    {
        public bool Compare(Vegetable v1, Vegetable v2)
        {
            return v1.Calories > v2.Calories;
        }
    }
}
