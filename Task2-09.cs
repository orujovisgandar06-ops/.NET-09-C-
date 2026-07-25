using System;

namespace HomeworkTask
{
    public class MusicInstrument
    {
        public string name;
        public string info;
        public string history;

        public MusicInstrument(string instrumentName, string instrumentInfo, string instrumentHistory)
        {
            name = instrumentName;
            info = instrumentInfo;
            history = instrumentHistory;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Инструмент звучит");
        }

        public void Show()
        {
            Console.WriteLine("Инструмент: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Характеристики: " + info);
        }

        public void History()
        {
            Console.WriteLine("История: " + history);
        }
    }

    public class Violin : MusicInstrument
    {
        public Violin(string name, string info, string history) : base(name, info, history) { }

        public override void Sound()
        {
            Console.WriteLine(" Нежный звук скрипки ");
        }
    }

    public class Trombone : MusicInstrument
    {
        public Trombone(string name, string info, string history) : base(name, info, history) { }

        public override void Sound()
        {
            Console.WriteLine(" Громкий звук тромбона ");
        }
    }

    public class Ukulele : MusicInstrument
    {
        public Ukulele(string name, string info, string history) : base(name, info, history) { }

        public override void Sound()
        {
            Console.WriteLine(" Гавайские мотивы укулеле ");
        }
    }

    public class Cello : MusicInstrument
    {
        public Cello(string name, string info, string history) : base(name, info, history) { }

        public override void Sound()
        {
            Console.WriteLine(" Глубокий низкий звук виолончели ");
        }
    }
}
