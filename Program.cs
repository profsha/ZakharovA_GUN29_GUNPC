using NetologyCSharp;

string? input = null;
do
{
    Console.WriteLine("Введите номер задания 1, 2 или 3, или exit для выхода");
    input = Console.ReadLine();
    if (int.TryParse(input, out int a))
    {
        switch (a)
        {
            case 1:
                var firstTask = new ListTask();
                firstTask.TaskLoop();
                break;
            case 2:
                var secondTask = new DictTask();
                secondTask.TaskLoop();
                break;
            case 3:
                var thirdTask = new LinkedListTask();
                thirdTask.TaskLoop();
                break;
        }
    }
} while (input != "exit");

