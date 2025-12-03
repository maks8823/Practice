//Вариант 9
//Создайте массив из 14 целых чисел в диапазоне от -25 до 25. Скопируйте в новый массив все положительные элементы из исходного массива. Выведите оба массива.


Random random = new Random();

    void PrintArray(int[] arr) //функция для вывода массива
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    int[] arr = new int[14];

    int countpos = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-25, 26);
        if (arr[i] > 0)
        {
            countpos++;//считаем кол-во полож. эл.
        }
    }

    int[] arrpos = new int[countpos];

    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            arrpos[j] = arr[i];//присваиваем во второй массив положительные элементы
            j++;
        }
    }
    PrintArray(arr);
    PrintArray(arrpos);
/*
Разберитесь с коллекциями встроенными в C#. При реализации задания разработайте класс, решающий задачу с обязательным соблюдением принципов SOLID.
Вариант 9 (Queue)
Разработайте класс MessageBus, который хранит сообщения (строки) в коллекции Queue<string>. Реализуйте методы для отправки (добавления) сообщения и
получения следующего сообщения без его удаления из очереди (с использованием Peek). Соблюдайте принципы SOLID.
*/
IMessageBus bus = new MessageBus();

bus.SendMessage("Привет");
bus.SendMessage("Привет!!!");

Console.WriteLine(bus.PeekNextMessage());
Console.WriteLine(bus.PeekNextMessage());

if (bus.HasMessages)
{
    Console.WriteLine("Есть сообщения в очереди");
}


public interface IMessageBus
{
    void SendMessage(string message);
    string? PeekNextMessage();
    bool HasMessages { get; }
}


public class MessageBus:IMessageBus
{
    private readonly Queue<string> messages = new Queue<string>();
    public bool HasMessages => messages.Count > 0;

    public void SendMessage(string message)
    {
        if (string.IsNullOrWhiteSpace(message)) 
        {
            throw new ArgumentException("Сообщение не может быть null или пустым", nameof(message));
        }
        messages.Enqueue(message);
    }
    public string? PeekNextMessage()
    {
        if (!HasMessages)
            return null;

        return messages.Peek();
    }
}