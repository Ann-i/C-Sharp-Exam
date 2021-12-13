using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.the_strategy_pattern
{
    public interface IComparaable
    {
        bool Compare(Vegetable v1, Vegetable v2);
    }
}
