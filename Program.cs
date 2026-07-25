using System;

namespace HomeworkTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Kettle myKettle = new Kettle("Bosch-T1", "Объем 1.7л, мощность 2200 Вт, пластик");
            myKettle.Show();
            myKettle.Desc();
            myKettle.Sound();
            
            Console.WriteLine();

            Car myCar = new Car("Toyota Camry", "Мотор 2.5л, цвет черный, седан");
            myCar.Show();
            myCar.Desc();
            myCar.Sound();

            Console.WriteLine();

            Violin myViolin = new Violin(
                "Скрипка Страдивари", 
                "4 струны, деревянный корпус, смычковый", 
                "Появилась в Италии в XVI веке, известна своим благородным звуком."
            );
            myViolin.Show();
            myViolin.Desc();
            myViolin.History();
            myViolin.Sound();

            Console.WriteLine();

            Worker[] workers = new Worker[]
            {
                new President("Алексей Дмитриевич"),
                new Security("Иван Петрович"),
                new Manager("Ольга Николаевна"),
                new Engineer("Дмитрий Иванович")
            };

            foreach (Worker w in workers)
            {
                w.Print();
            }

            Console.ReadKey();
        }
    }
}
