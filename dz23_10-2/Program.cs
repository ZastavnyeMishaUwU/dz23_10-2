namespace dz23_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть 4 цифри по одній:");
            int[] digits = new int[4];
            for (int i = 0; i < 4; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }
            string result = string.Join("", digits);
            int number = int.Parse(result);

            Console.WriteLine($"Сформоване число: {number}");
        }
    }
}
