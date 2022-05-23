using System.Xml.Serialization;

namespace Study
{
    class Program
    {
        /// <summary>
        /// Serialize method
        /// </summary>
        /// <param name="СoncreteWorker"></param>
        /// <param name="Path"></param>
        static void SerializeWorker(Worker mainWorker, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            var xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных
            //Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            var fStream = new FileStream(Path, FileMode.Open, FileAccess.Write);

            // Запускаем процесс сериализации
            //xmlSerializer.Serialize(fStream, СoncreteWorker);
            xmlSerializer.Serialize(fStream, mainWorker);

            // Закрываем поток
            //fStream.Close();
            fStream.Close();
        }

        static Worker DeserializeWorker(string Path)
        {
            Worker? tempWorker = new Worker();
            // Создаем сериализатор на основе указанного типа 
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));
            var xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            tempWorker = xmlSerializer.Deserialize(fStream) as Worker;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
#pragma warning disable CS8603 // Possible null reference return.
            return tempWorker;
#pragma warning restore CS8603 // Possible null reference return.
        }
        static void Main(string[] args)
        {
            Worker worker = new Worker("Bill", "Gates", "CEO", uint.MaxValue, "Microsoft Corporation");
            Console.WriteLine(worker.Print());

            SerializeWorker(worker,"bill.xml");
            worker = DeserializeWorker("bill.xml");
            Console.WriteLine(worker.Print());

        }
        
    }
  
}

