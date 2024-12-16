
namespace WpfLibrary1
{

    public static class NumberCounter
    {
        public static ainura Count(this IEnumerable<int> numbers)
        {
            var result = new ainura();

            foreach (int number in numbers)
            {
                if (number % 2 > 0)
                {
                    result.nechet++;
                }
                else
                {
                    result.chet++;
                }
            }

            return result;
        }

        public class ainura
        {
            public int chet { get; set; } = 0; // Инициализация
            public int nechet { get; set; } = 0; // Инициализация
        }
    }
}

