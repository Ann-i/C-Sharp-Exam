using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model.entity
{
    public class Vegetable
    {
        //individual parameters
        private double calories;
        private double weight;
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
            return $"Calories = {Calories}, Weight = {Weight}";
        }

    }
}
