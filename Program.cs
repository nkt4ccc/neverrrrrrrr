namespace neverrrrr
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();

            // Ввод ФИО
            System.Console.Write("Введите ФИО студента: ");
            student.FIO = System.Console.ReadLine();

            // Ввод первой оценки
            System.Console.Write("Введите первую оценку: ");
            student.Ocenka1 = int.Parse(System.Console.ReadLine());

            // Ввод второй оценки
            System.Console.Write("Введите вторую оценку: ");
            student.Ocenka2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine();

            // Показ данных о студенте
            student.Show();

            // Подсчёт и вывод средней оценки
            float sred = student.SredOcenka();
            System.Console.WriteLine($"Средняя оценка студента: {sred}");

            System.Console.ReadKey();
        }
    }

    class Student
    {
        // Открытые поля
        public string FIO;
        public int Ocenka1;
        public int Ocenka2;

        // Метод – показать данные о студенте
        public void Show()
        {
            System.Console.WriteLine($"Студент: {FIO}");
            System.Console.WriteLine($"Оценка 1: {Ocenka1}");
            System.Console.WriteLine($"Оценка 2: {Ocenka2}");
        }

        // Метод – подсчёт средней оценки
        public float SredOcenka()
        {
            return (Ocenka1 + Ocenka2) / 2f;
        }
    }
}