using System;
using Autofac;
using DemoWriter;

namespace autofacsameple
{
    class Program
    {

        private static IContainer _container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>().UsingConstructor(typeof(IOutput));
            builder.RegisterType<TomorroWriter>().As<ITomorrowDateWriter>();
            _container = builder.Build();

            WriteDate();

            Console.ReadLine();
        }

        public static void WriteDate()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();                
            }
        }
    }
}
