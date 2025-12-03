Варианты 6, 8
6.   Работа с параметрами запроса
В контроллере создайте действие, которое принимает два опциональных строковых параметра search и sortBy из строки запроса (/users?search=john&sortBy=name) и возвращает их значения.
8.   Фильтрация Pipeline
Создайте middleware, который для всех запросов к пути /admin возвращает статус 401 Unauthorized, не пропуская их дальше по pipeline.

Запуск cmd в директории:
dotnet build apin.csproj
dotnet run
http://localhost:5138