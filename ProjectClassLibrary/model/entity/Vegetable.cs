using System;

namespace ProjectClassLibrary.model.entity
{
    public class Vegetable : IComparable<Vegetable>
    {
        //individual parameters
        protected double calories;
        private double weight;
        public string Name { get; set; }
        //constructor without parameters
        public Vegetable()
        {   }
        //construnctor with parametrs + base constructor
        public Vegetable(double calories, double weight)
        {
            Calories = calories;
            Weight = weight;
        }
        //get & set (calories)
        public double Calories
        {
            get { return calories; }
            set
            {
                if (value > 0)
                {
                    calories = value;
                }
            }
        }
        //get & set (weight)
        public double Weight
        {
            get { return weight; }
            set
            {
                if(value > 0)
                {
                    weight = value;
                }
            }
        }
        //function wich print parametrs of class + param from base class
        public override string ToString()
        {
            return $"calories = {Calories}, weight = {Weight}";
        }
        public int CompareTo(Vegetable other)
        {
            return other.Name.CompareTo(Name);
        }

    }
}
