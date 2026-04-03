using System;

public class AnimalThread
{
    public string Name; // имя зверя
    public int PriorityValue; // приоритет 
    private int _distance; // сколько пробежало животное
    private readonly object _lock = new object();// синхронизирует  доступ к общим данным из разных потоков
    private bool _stop; // останавливает поток
    private readonly Random _rand = new Random();// шаги зверя
    private readonly Thread _thread;// выподняет метод Run()
    private const int MaxDistance = 100; // максимальная дистанция

    public AnimalThread(string name, int priority)
    {
        Name = name;
        PriorityValue = priority;
        _thread = new Thread(Run);// создает новый объект Tread который будет выполнять метод Run
        SetOsPriority(priority);// вызывает приватный метод котоый утсанавливает приоритет на уроврне операционной систмемы
    }

    private void SetOsPriority(int p)
    {
        if (p <= 2) _thread.Priority = ThreadPriority.Lowest;// самай низкий приоритет 
        else if (p <= 4) _thread.Priority = ThreadPriority.BelowNormal;// ниже среднего 
        else if (p <= 6) _thread.Priority = ThreadPriority.Normal;// обычный
        else if (p <= 8) _thread.Priority = ThreadPriority.AboveNormal;// выше среднего
        else _thread.Priority = ThreadPriority.Highest;// наисвысщий 
    }

    public void UpdatePriority(int newPriority)
    {
        lock (_lock)// блокировка чтобы одновременно не изменить приоритет из двух потоков
        {
            PriorityValue = newPriority;
            SetOsPriority(newPriority);
        }
    }

    public int Distance// свойство только для чтения возвращает тя
    {
        get { lock (_lock) return _distance; }
    }

    public void Start() => _thread.Start();// запускает внутрнений поток
    public void Join() => _thread.Join();// ждет завершения внуутренего потока
    public void Stop() => _stop = true;// устанавливает флаги остановки чтобы поток завершил цикл

    private void Run()
    {
        while (!_stop && _distance < MaxDistance)// цикл работает пока не остановили и дистанция не достигла 100 
        {
            int step = _rand.Next(1, 4);// сколько методов добавиться за шаг
            lock (_lock)// блокировка перед изменением _distance
            {
                _distance += step;// увеличиваем дистанцию
                if (_distance > MaxDistance) _distance = MaxDistance;// сли перескочили финиш фиксируем ровно 100.
            }у

            Console.WriteLine($"{Name} пробежал {Distance} м (приоритет {PriorityValue})");у

            // Задержка обратно пропорциональна приоритету
            int sleepMs = 100 / PriorityValue;// время сна (в миллисекундах) обратно пропорционально приоритету чем выше приоритет тем меньше спим.
            if (sleepMs < 5) sleepMs = 5;// минимальная задержка 5 мс чтобы поток не грузил процессор на 100%
            Thread.Sleep(sleepMs);// приостанавливает поток на вычисленное время имитируя затраты времени на движение
        }
        Console.WriteLine($"{Name} финишировал с дистанцией {Distance} м");
    }
}

public class RabbitAndTurtle
{
    public static void Main()
    {
        AnimalThread rabbit = new AnimalThread("Кролик", 8);// создает обект с высоким преоритетом
        AnimalThread turtle = new AnimalThread("Черепаха", 3);// создаем объект с низки преоритетом

        // запуск обоих потооков
        rabbit.Start();
        turtle.Start();

        const int lagThreshold = 10;// для порарельного бега

        // Порог отставания в метрах если разница ≥ 10 меняем приоритеты
        while (rabbit.Distance < 100 && turtle.Distance < 100)
        {
            // тякущиий дистанции
            int r = rabbit.Distance;
            int t = turtle.Distance;
            Console.WriteLine($"Контроль: Кролик {r}, Черепаха {t}");

            if (Math.Abs(r - t) >= lagThreshold)// если разницы привысола порог в 10м
            {
                if (r > t) // Кролик лидирует
                {
                    int newTurtle = Math.Min(10, turtle.PriorityValue + 2);// повышаем приоритет
                    int newRabbit = Math.Max(1, rabbit.PriorityValue - 2);// понижаем приоритет
                    turtle.UpdatePriority(newTurtle);
                    rabbit.UpdatePriority(newRabbit);
                    Console.WriteLine($"--> Приоритеты: Черепаха {newTurtle}, Кролик {newRabbit}");
                }
                else // Черепаха лидирует меняем наоборот
                {
                    int newRabbit = Math.Min(10, rabbit.PriorityValue + 2);
                    int newTurtle = Math.Max(1, turtle.PriorityValue - 2);
                    rabbit.UpdatePriority(newRabbit);
                    turtle.UpdatePriority(newTurtle);
                    Console.WriteLine($"--> Приоритеты: Кролик {newRabbit}, Черепаха {newTurtle}");
                }
            }

            Thread.Sleep(300);// пауза между провреками
        }

        // главный поток ждет завершения обоих бегунов
        rabbit.Join();
        turtle.Join();

        Console.WriteLine("\nГонка завершена!");
        if (rabbit.Distance >= 100 && turtle.Distance >= 100)
            Console.WriteLine("Ничья!");
        else if (rabbit.Distance >= 100)
            Console.WriteLine("Победил Кролик!");
        else
            Console.WriteLine("Победила Черепаха!");
    }
}