namespace Project.model.entity
{
    public class Cucumber : Vegetable
    {
        private double lenght;
        private bool isPrickly;

        public Cucumber()
        {

        }
        public Cucumber(double lenght, bool isPrickly, double calories, double weight) : base(calories, weight)
        {
            Lenght = lenght;
            IsPrickly = isPrickly;
        }
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
        public bool IsPrickly
        {
            get { return isPrickly; }
            set
            {
                    isPrickly = value;
            }
        }
        public override string ToString()
        {
            return $"Leght = {lenght}, Is prickly = {isPrickly} " + base.ToString();
        }
    }
}
