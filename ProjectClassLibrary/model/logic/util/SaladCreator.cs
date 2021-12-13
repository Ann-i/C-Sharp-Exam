using Project.model.entity;

namespace ProjectClassLibrary.model.logic.util
{
    class SaladCreator
    {
        public static Salad Create(int size)
        {
            Salad salad = null;

            if(size == 0)
            {
                salad = new Salad();
            }
            else if (size > 0)
            {
                salad = new Salad(size);
            }

            return salad;
        }
    }
}
