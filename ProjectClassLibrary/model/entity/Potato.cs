namespace ProjectClassLibrary.model.entity
{
    public class Potato : Vegetable
    {
        //private parametres of class Potato
        private string size;
        private string seazon;
        //basic constructor (class Potato)
        public Potato()
        {

        }
        //constructor with parametres
        public Potato(string size, string sort, double calories, double weight) : base(calories, weight)
        {
            Size = size;
            Seazon = seazon;
        }
        //get & set (color)
        public string Size
        {
            get { return size; }
            set
            {
                if (value != null)
                {
                    size = value;
                }
            }
        }
        //get & set (variety)
        public string Seazon
        {
            get { return seazon; }
            set
            {
                if (value != null)
                {
                    seazon = value;
                }
            }
        }
        //function wich print parametrs of class + param from base class
        public override string ToString()
        {
            return $"Potato: size = {size}, seazon = {seazon}, " + base.ToString();
        }
    }
}
