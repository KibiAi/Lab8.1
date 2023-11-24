using Lab8._1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введіть ключ налаштування:");
            string key = Console.ReadLine();
            Console.WriteLine("Введіть значення налаштування:");
            string value = Console.ReadLine();

            ConfigurationManager.Instance.UpdateSetting(key, value);

            Console.WriteLine($"Нове значення для {key} встановлено на {ConfigurationManager.Instance.Settings[key]}");
        }
    }
}