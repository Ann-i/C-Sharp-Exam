using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.the_strategy_pattern
{
    class SortVegetablesByCaloriesDesc : IComparaable
    {
        public bool Compare(Vegetable v1, Vegetable v2)
        {
            return v2.Calories > v1.Calories;
        }
    }
}