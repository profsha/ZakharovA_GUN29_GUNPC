int[] arr1 = { 0, 1, 1, 2, 3, 5, 8, 13 };
string[] arr2 =
{
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
};

int[,] arr3 =
{
    { 2, 3, 4 },
    { 2*2, 3*3, 4*4 },
    { 2*2*2, 3*3*3, 4*4*4 }
};

double[][] arr4 =
{
    new[] { 1d,2,3,4,5 },
    new[] { Math.E, Math.PI },
    new[] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)}
};
Console.WriteLine("Первый");
Console.WriteLine(String.Join(" ", arr1));
Console.WriteLine("Второй");
Console.WriteLine(String.Join(" ", arr2));
Console.WriteLine("Третий");
for (var i = 0; i < 3; ++i)
{
    var str = "";
    for (var j = 0; j < 3; ++j) {
        str += $"{arr3[i, j]} ";
    }
    Console.WriteLine(str.Trim());
}
Console.WriteLine("Четвертый");
foreach (var arr in arr4)
{
    Console.WriteLine(String.Join(" ", arr));
}

// массивы для заданий 5 и 6.
int[] array = { 1, 2, 3, 4, 5 };
int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
Array.Copy(array, array2, 3);
Console.WriteLine("Пятый, Копия");
Console.WriteLine(String.Join(" ", array2));

Array.Resize(ref array, array.Length * 2 );
Console.WriteLine("Шестой, ресайз");
Console.WriteLine(String.Join(" ", array));

