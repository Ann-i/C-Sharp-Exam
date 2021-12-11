namespace Project.model.entity
{
    public class Tomato : Vegetable
    {
        private string color;
        private string sort;

        public Tomato()
        {

        }
        public Tomato(string color, string sort, double calories, double weight) : base(calories, weight)
        {
            Color = color;
            Sort = sort;
        }
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
        public string Sort
        {
            get { return sort; }
            set
            {
                if (value != null)
                {
                    sort = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Color = {color}, Sort = {sort}, " + base.ToString();
        }
    }
}
