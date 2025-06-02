namespace NetologyCSharp;

public class DictTask
{
    private Dictionary<string, int> _dict = new Dictionary<string, int>();
    public void TaskLoop()
    {
        while (true)
        {
            Console.WriteLine("Введите имя студента. Для просмотра введите list. Для выхода введите exit.");
            var name = Console.ReadLine() ?? string.Empty;

            if (name == "exit")
            {
                break;
            }

            if (name == "list")
            {
                Console.WriteLine(string.Join(", ", _dict.Select(x => $"{x.Key}: {x.Value}")));
                continue;
            }

            Console.WriteLine("Введите его оценку от 2 до 5");
            int grade = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out grade);
            } while (grade is < 2 or > 5);

            _dict[name] = grade;
        }
    }
}