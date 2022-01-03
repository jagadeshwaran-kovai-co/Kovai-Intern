using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;


namespace SerialandDeserialization
{
    [Serializable]
    class Tutorial
    {
        public int ID;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".NET";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\Serial.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream =new FileStream(@"D:\serial.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);
            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            Console.ReadKey();


        }
    }
}
