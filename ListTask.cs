namespace NetologyCSharp;

public class ListTask
{
    private List<string> _list = ["first", "second", "third", "fourth", "fifth", "sixth"];
    public void TaskLoop()
    {
        var iteration = 0;
        while (true)
        {
            Console.WriteLine("Введите слово. Для выхода введите exit");
            var prompt = Console.ReadLine() ?? string.Empty;

            if (prompt == "exit")
            {
                break;
            }

            if (iteration % 2 == 0)
            {
                _list.Add(prompt);
            }
            else
            {
                _list.Insert(_list.Count / 2, prompt);
            }
            iteration++;
            
            Console.WriteLine(string.Join(", ", _list));
        }
    }
}