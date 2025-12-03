//dotnet new console -n Myapp 
//создает проект консольного приложения с названием Myapp
//dir 
//выводит содержимое папки
//cd Myapp 
//переходим в папку Myapp
//после написания программы dotnet build 
//можно добавить --configuration Release
//копилируем программу
//и запускаем с помощью dotnet run 
//можно добавить --project ./Myapp чтобы указать путь если мы не переходили в папку проекта

Random random = new Random();
int[] arr = new int[50]; //основной массив
int[] count = new int[10]; //массив с кол-вом вхождений каждого числа

for (int i = 0; i < 50; i++)
{
    arr[i] = random.Next(1, 11); //присваем случ числа по усл
    count[arr[i] - 1]++; //прибавляем 1 в соотв эл массива count если число попадается
}

for (int i = 0; i < 50; i++)//сортировка пузырьком
{
    for (int j = 0; j < 50 - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];//меняем местами
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}

for (int i = 0; i < 50; i++)//выводим отсорт массив
{
    Console.Write(arr[i] + " ");

}
Console.WriteLine("");

for (int i = 0; i < 10; i++)//выводим числа
{
    Console.Write(i + 1 + " ");
}
Console.WriteLine("");

for (int i = 0; i < 10; i++)//выводим кол-во вхождений
{
    Console.Write(count[i] + " ");

}
Console.WriteLine("");

int MaxValue = count[0];

for(int i = 1; i < 10; i++)//находим наибольшее число вхождений
{
    if (count[i] > MaxValue)
        MaxValue = count[i];
}

Console.Write("Самое часто встречающееся число(a):");
for (int i = 0; i < 10; i++)
{
    if (count[i] == MaxValue)//проверяем есть ли другие числа имеющие макс кол-во вхождений и выводим
    {
        Console.Write(i + 1 + " ");
    }
}

int k = 0;
Console.WriteLine("");
for (int i = 0; i < 10; i++)//общее кол-во уникальных элементов
{
    if (count[i] != 0)
    {
        k++;
    }
}
Console.WriteLine(k + " Уникальных элементов");