using System;
using System.Threading;

namespace InterferenceDemo
{
    /// <summary>
    /// Демо-пример для наглядного объяснения:
    /// 1. Как возникают гонки данных (потери счётчиков).
    /// 2. Как правильно использовать Interlocked для атомарности.
    /// </summary>
    class InterferenceExample
    {
        private const int HUNDRED_MILLION = 100_000_000;

        // Потокобезопасный счётчик, который используется для управления потоками
        // Мы не считаем _counter для итога, мы используем его только как флажок
        private int _counter;

        /// <summary>
        /// Безопасно увеличиваем счётчик.
        /// Если _counter превысит 100 млн — мы скажем потокам остановиться.
        /// </summary>
        public bool Stop()
        {
            // Interlocked.Increment работает мгновенно и безопасно.
            // Никто другой не сможет прочитать значение, пока оно меняется.
            return Interlocked.Increment(ref _counter) > HUNDRED_MILLION;
        }

        public void Example()
        {
            // Создаем 2 потока, которые будут увеличивать общую статистику
            InterferenceThread thread1 = new InterferenceThread(this);
            InterferenceThread thread2 = new InterferenceThread(this);

            thread1.Start();
            thread2.Start();

            // Ждём, пока оба потока не закончатся
            thread1.Join();
            thread2.Join();

            // Вывод:
            // Ожидаемый результат: 100_000_000 (на самом деле 100 млн + 1)
            // Реальный результат будет МЕНЬШЕ, из-за ошибок в другом потоке.
            Console.WriteLine("Expected: " + HUNDRED_MILLION);
            Console.WriteLine("Result (Unsafe): " + thread1.GetI());
        }
    }

    /// <summary>
    /// Поток, который НАМЕРЕННЕ совершает ошибку (гонку данных).
    /// </summary>
    class InterferenceThread
    {
        // Ссылка на контроллер, который говорит потоку, когда остановиться
        private readonly InterferenceExample _checker;

        // !!! ОПАСНО !!!
        // Ключевое слово static делает эту переменную ОБЩЕЙ для всех созданных потоков!
        // В реальном коде здесь обычно был бы lock-блок или AtomicInt, но мы показываем ошибку.
        private static int _i;
        private Thread _thread;

        public InterferenceThread(InterferenceExample checker)
        {
            _checker = checker;
            _thread = new Thread(Run);
        }

        private void Increment()
        {
            // Операция i++ выглядит простой, но внутри это 3 шага:
            // 1. Read (чтение i)
            // 2. Inc (увеличение i)
            // 3. Write (запись i)
            // Если 2 потока сделают это одновременно, один из записей потеряется.
            _i++;
        }

        public int GetI() => _i;

        public void Start() => _thread.Start();
        public void Join() => _thread.Join();

        private void Run()
        {
            // Пока контроллер не сказал стоп (через _counter), работаем.
            // Каждый проход считывает общий static _i и меняет его.
            while (!_checker.Stop())
            {
                Increment();
            }
        }
    }

    /// <summary>
    /// Точка входа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            new InterferenceExample().Example();

            // Нажмите любую клавишу для выхода...
            Console.ReadKey();
        }
    }
}
