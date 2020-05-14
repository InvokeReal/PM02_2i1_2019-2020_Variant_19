using System; 
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main() {
            // Создаем хеш-таблицу
            Hashtable u = new Hashtable();
            // Добавим несколько записей             
            u.Add(“den”, “98765456546”);             
            u.Add("user", "45837685768");             
            u.Add("root", "ddfdf3545");
            // Получаем коллекцию ключей
            ICollection keys = u.Keys;
            foreach (string S in keys)                 
            Console.WriteLine(S + ": " + u[S]);
            Console.ReadLine();
        }
    }
}
