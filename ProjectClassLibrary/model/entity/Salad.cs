using System.Text;

namespace ProjectClassLibrary.model.entity
{
    public class Salad
    {
        //default size of array "salad"
        public const int DEFAULT_SIZE = 30;
        //private array of objects "vegetables" which combain them into salad
        private Vegetable[] vegetables;
        //get (size)
        public int Size { get; private set; }
        //copy constructor
        public Salad() : this(DEFAULT_SIZE)
        {   }
        //constructor with parametres
        public Salad(int size)
        {
            vegetables = new Vegetable[size];
            Size = 0;
        }
        //fuction wich add new "vegetables"
        public void Add(Vegetable vegetable)
        {
            if (Size < vegetables.Length)
            {
                vegetables[Size++] = vegetable;
            }
        }
        //fuction wich get "vegetables"
        public Vegetable Get(int index)
        {
            if (index >= 0 && index < Size)
            {
                return vegetables[index];
            }

            return null;
        }
        //function wich print all objects of array "salad" (print their parametres)
        public override string ToString()
        {
            StringBuilder str = new StringBuilder("List of products:\n");

            for (int i = 0; i < Size; i++)
            {
                str.Append(vegetables[i]).Append("\n");
            }

            return str.ToString();
        }
    }
}
