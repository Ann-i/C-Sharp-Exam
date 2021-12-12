namespace Project.model.entity
{
    public class Tomato : Vegetable
    {
        //private parametres of class Tomato
        private string color;
        private string variety;
        //basic constructor (class Tomato)
        public Tomato()
        {

        }
        //constructor with parametres
        public Tomato(string color, string sort, double calories, double weight) : base(calories, weight)
        {
            Color = color;
                Variety = variety;
        }
        //get & set (color)
        public string Color
        {
            get { return color; }
            set
            {
                if (value != null)
                {
                    color = value;
                }
            }
        }
        //get & set (variety)
        public string Variety
        {
            get { return variety; }
            set
            {
                if (value != null)
                {
                    variety = value;
                }
            }
        }
        //function wich print parametrs of class + param from base class
        public override string ToString()
        {
            return $"Color = {color}, Variety = {variety}, " + base.ToString();
        }
    }
}
