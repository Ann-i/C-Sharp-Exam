namespace Project.model.entity
{
    public class Salad
    {
        public const int DEFAULT_SIZE = 30;

        private Vegetable[] vegetables;
        public int Size { get; private set; }

        public Salad() : this(DEFAULT_SIZE)
        {   }
        public Salad(int size)
        {
            vegetables = new Vegetable[size];
            Size = 0;
        }

        public void Add(Vegetable vegetable)
        {
            if (Size < vegetables.Length)
            {
                vegetables[Size++] = vegetable;
            }
        }
        public Vegetable Get(int index)
        {
            if (index >= 0 && index < Size)
            {
                return vegetables[index];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "List of vegetables:\n";

            for (int i = 0; i < Size; i++)
            {
                str += vegetables[i] + "\n";
            }
            return str;
        }
    }
}
