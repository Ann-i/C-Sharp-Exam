using System.Text;
using ProjectClassLibrary.model.entity;

namespace ProjectClassLibrary.model.logic.util
{
    public class Convertor
    {
        public static string ConvertToString(Vegetable[] vegetables)
        {
            StringBuilder str = new StringBuilder("List of products:\n");

            for (int i = 0; i < vegetables.Length; i++)
            {
                str.Append(vegetables[i]).Append("\n");
            }

            return str.ToString();
        }
    }
}
