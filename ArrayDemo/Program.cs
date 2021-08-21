//var arr = new string[] { "a", "b", "c", "d" };

//var newArr = arr[..2];
//for (int i = 0; i < newArr.Length; i++)
//{
//    Console.WriteLine(newArr[i]);
//}
var arr = new string[] { "b", "c", "a", "d" };
Array.Sort(arr);
Array.Reverse(arr);
foreach (var e in arr)
{
    Console.WriteLine(e);
}

//var arr1 = new string[,] {
//    {"a1","a2","a3" },
//    {"b2","b2","b3" }
//};
//for (var r = 0; r < arr1.GetLength(0); r++)
//{
//    for (var c = 0; c < arr1.GetLength(1); c++)
//    {
//        Console.WriteLine(arr1[r, c]);
//    }
//    Console.WriteLine("-------");
//}

//var arr = new string[2][] {
//new string[]{"a1","a2"},
//new string[]{"b1","b2","b3"},
//};

//for (var r = 0; r < arr.Length; r++)
//{
//    for (var c = 0; c < arr[r].Length; c++)
//    {
//        Console.WriteLine(arr[r][c]);
//    }
//    Console.WriteLine("-------");
//}