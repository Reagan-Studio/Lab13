
using Lab13;
using System.Text;


////(II)номер1-----------------------------------------------------------------------------------------------------

Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine());

CircularLinkedList<int> list = new CircularLinkedList<int>();

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    list.AddLast(number);
}

NodeT<int> current = list.Head;

Console.WriteLine(list.ToString());

Console.Write("Введите количество команд: ");
int k = int.Parse(Console.ReadLine());

for (int i = 0; i < k; i++)
{
    Console.Write($"Введите команду {i + 1}: ");
    string command = Console.ReadLine();

    string[] parts = command.Split(' ');
    string direction = parts[0];
    int count = int.Parse(parts[1]);

    if (direction == "R")
    {
        for (int j = 0; j < count; j++)
        {
            current.Next = current.Next.Next;
            list.DecrementCount();
        }
    }
    else if (direction == "L")
    {

        for (int j = 0; j < count && current.Next.Prev != null; j++)
        {
            current.Next.Prev = current.Next.Next;
            current.Next = current.Next.Prev;
            list.DecrementCount();
        }
        if (current.Next.Prev == null)
        {
            current = list.Tail;
        }
    }

    Console.WriteLine($"Список после команды {i + 1}: {list.ToString()}");
}

Console.Write("Введите искомое число: ");
int searchValue = int.Parse(Console.ReadLine());

bool contains = list.Contains(searchValue);

if (contains)
{
    Console.WriteLine($"Список содержит число {searchValue}");
}
else
{
    Console.WriteLine($"Список не содержит число {searchValue}");
}






//(I)номер3------------------------------------------------------------------------------------------------------
//LinkedList<int> list = new LinkedList<int>();

//Console.WriteLine("Введите любое число в диапазоне (-1000, 1000): ");
//while (true)
//{
//    string str = Console.ReadLine();

//    if (string.IsNullOrEmpty(str))
//    {
//        break;
//    }

//    int number = int.Parse(str);
//    if (list.Count < 2)
//    {
//        list.AddLast(number);
//    }
//    else
//    {
//        if (Math.Abs(number - list.First.Value) < Math.Abs(number - list.Last.Value))
//        {
//            list.AddFirst(number);
//        }
//        else
//        {
//            list.AddLast(number);
//        }
//    }
//}

//Console.WriteLine($"\nРазмер: {list.Count}");
//Console.WriteLine("\nСписок:");
//foreach (int item in list)
//{
//    Console.Write($"{item} ");
//}








//(I)номер2-----------------------------------------------------------------------------------------------------
//DoublyLinkedList positiveList = new DoublyLinkedList();
//DoublyLinkedList negativeList = new DoublyLinkedList();

//Console.WriteLine("Введите числа (для завершения введите пустую строку):");
//while (true)
//{
//    string input = Console.ReadLine();
//    if (string.IsNullOrEmpty(input))
//    {
//        break;
//    }

//    int number = int.Parse(input);
//    if (number >= 0)
//    {
//        positiveList.AddLast(number);
//    }
//    else
//    {
//        negativeList.AddLast(number);
//    }
//}

//if (positiveList.Size % 2 != 0)
//{
//    Console.WriteLine("Количество положительных чисел должно быть четным!");
//    return;
//}

//a
//Node centerNode = positiveList.GetNodeAt(positiveList.Size / 2);

//centerNode.Prev.Next = negativeList.FirstNode;
//negativeList.FirstNode.Prev = centerNode.Prev;

//centerNode.Prev = negativeList.LastNode;
//negativeList.LastNode.Next = centerNode;

//Console.WriteLine($"\nРезультат: {positiveList.ToString()}");


//b
//DoublyLinkedList result = new DoublyLinkedList();
//Node nodeFromPos = positiveList.FirstNode;
//Node nodeFromNeg = negativeList.FirstNode;

//while (nodeFromPos != null && nodeFromNeg != null)
//{
//    result.AddLast(nodeFromPos.Value);
//    result.AddLast(nodeFromNeg.Value);
//    nodeFromPos = nodeFromPos.Next;
//    nodeFromNeg = nodeFromNeg.Next;
//}

//while (nodeFromNeg != null)
//{
//    result.AddLast(nodeFromNeg.Value);
//    nodeFromNeg = nodeFromNeg.Next;
//}

//while (nodeFromPos != null)
//{
//    result.AddLast(nodeFromPos.Value);
//    nodeFromPos = nodeFromPos.Next;
//}

//Console.WriteLine("Result:");
//Console.WriteLine(result.ToString());









//(I)номер1--------------------------------------------------------------------------------------------------------------------------------------
//DoublyLinkedList list = new DoublyLinkedList();

//while (true)
//{
//    Console.Write("Введите любое число в диапазоне (-1000, 1000): ");
//    string str = Console.ReadLine();

//    if (string.IsNullOrEmpty(str))
//    {
//        break;
//    }

//    int number = int.Parse(str);
//    if (list.Size < 2)
//    {
//        list.AddLast(number);
//    }
//    else
//    {
//        if (Math.Abs(number - list.GetFirst) < Math.Abs(number - list.GetLast))
//        {
//            list.AddFirst(number);
//        }
//        else
//        {
//            list.AddLast(number);
//        }
//    }
//}

//Console.WriteLine($"Размер: {list.Size}");
//Console.WriteLine($"Список: {list.ToString()}");