using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model.entity
{
    public class Vegetable
    {
        private double calories;
        private double weight;

        public Vegetable()
        {

        }
        public Vegetable(double calories, double weight)
        {
            Calories = calories;
            Weight = weight;
        }

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

        public override string ToString()
        {
            return $"Calories = {Calories}, Weight = {Weight}";
        }

    }
}
