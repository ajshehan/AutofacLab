using System;

namespace DemoWriter
{
    public interface IOutput
    {
        void Write(string content);
    }

    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }


    public interface IDateWriter
    {
        void WriteDate();
    }

    public interface ITomorrowDateWriter
    {
        void WriteDate();
    }

    public class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.ToShortDateString());
        }
    }

    public class TomorroWriter : ITomorrowDateWriter
    {
        private IOutput _output;

        public TomorroWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.AddDays(1).ToShortDateString());
        }
    }
}
