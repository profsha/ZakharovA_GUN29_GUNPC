namespace NetologyCSharp;

public class LinkedListTask
{
    public void TaskLoop()
    {
        Node? first = null;
        while (true)
        {
            Console.WriteLine("Добавьте строку в список. Для просмотра введите list. Для выхода введите exit.");
            var input = Console.ReadLine() ?? string.Empty;

            if (input == "exit")
            {
                break;
            }
            
            if (input == "list")
            {
                if (first == null)
                {
                    Console.WriteLine("Список пуст");
                }
                else
                {
                    var item = first.First;
                    do
                    {
                        Console.Write(item?.Value + " ");
                        item = item?.Next;
                    } while (item != null);

                    Console.WriteLine();

                    item = first.Last;
                    do
                    {
                        Console.Write(item?.Value + " ");
                        item = item?.Previous;
                    } while (item != null);

                    Console.WriteLine();
                }

                continue;
            }

            if (first == null)
            {
                first = new Node(input);
            }
            else
            {
                first.Append(new Node(input));
            }
        }
    }
}