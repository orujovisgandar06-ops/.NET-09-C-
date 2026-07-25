using System;

namespace HomeworkTask
{
    public abstract class Worker
    {
        public string name;

        public Worker(string workerName)
        {
            name = workerName;
        }

        public abstract void Print();
    }

    public class President : Worker
    {
        public President(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("Должность: Президент. Имя: " + name + ". Обязанность: Руководство всей компанией.");
        }
    }

    public class Security : Worker
    {
        public Security(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("Должность: Охранник. Имя: " + name + ". Обязанность: Контроль безопасности территории.");
        }
    }

    public class Manager : Worker
    {
        public Manager(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("Должность: Менеджер. Имя: " + name + ". Обязанность: Работа с клиентами и организация задач.");
        }
    }

    public class Engineer : Worker
    {
        public Engineer(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("Должность: Инженер. Имя: " + name + ". Обязанность: Проектирование и техническая поддержка.");
        }
    }
}
