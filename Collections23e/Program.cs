// See https://aka.ms/new-console-template for more information


List<int> myList = new List<int>();
myList.Add(10);
myList.Add(20);
myList.Add(30);
myList.Insert(1, 15);
myList[1] = 32;
myList.Remove(20);
myList.Insert(0, myList[2]);

myList.Sort();

foreach (var item in myList)
{
    Console.Write(item + " ");
}




