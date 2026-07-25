using System;

namespace HomeworkTask
{
    public class Device
    {
        public string name;
        public string info;

        public Device(string deviceName, string deviceDesc)
        {
            name = deviceName;
            info = deviceDesc;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Устройство издает звук");
        }

        public void Show()
        {
            Console.WriteLine("Название устройства: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Характеристики и Описание: " + info);
        }
    }

    public class Kettle : Device
    {
        public Kettle(string name, string info) : base(name, info) { }

        public override void Sound()
        {
            Console.WriteLine(" Буль-буль! (Чайник закипел)");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string info) : base(name, info) { }

        public override void Sound()
        {
            Console.WriteLine(" Пип-пип-пип! (Еда готова)");
        }
    }

    public class Car : Device
    {
        public Car(string name, string info) : base(name, info) { }

        public override void Sound()
        {
            Console.WriteLine("Вруум-вруум! Би-бииип!");
        }
    }

    public class Steamboat : Device
    {
        public Steamboat(string name, string info) : base(name, info) { }

        public override void Sound()
        {
            Console.WriteLine("Тууууууу-тууууууу! (Гудок парохода)");
        }
    }
}
