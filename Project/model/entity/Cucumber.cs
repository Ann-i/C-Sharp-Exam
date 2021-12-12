namespace Project.model.entity
{
    public class Cucumber : Vegetable
    {
        //individual parameters
        private double lenght;
        private bool isPrickly;
        //constructor without parameters
        public Cucumber()
        {

        }
        //construnctor with parametrs + base constructor
        public Cucumber(double lenght, bool isPrickly, double calories, double weight) : base(calories, weight)
        {
            Lenght = lenght;
            IsPrickly = isPrickly;
        }
        //get & set (lenght)
        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value > 0)
                { 
                    lenght = value;
                }
            }
        }
        //get & set (is prickly or not)
        public bool IsPrickly
        {
            get { return isPrickly; }
            set 
            {
                if(value == true || value == false)
                {
                    isPrickly = value;
                }
            }
        }
        //function wich print parametrs of class + param from base class
        public override string ToString()
        {
            return $"Leght = {lenght}, Is prickly = {isPrickly} " + base.ToString();
        }
    }
}
