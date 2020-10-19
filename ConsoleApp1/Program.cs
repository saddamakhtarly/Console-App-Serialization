using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serilization
            string path = @"C:\Users\Desktop\Serialization\saddam.wav";
            Student s = new Student(1, "saddam");
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, s);
            stream.Close();
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine("File saved in " + path);
            Console.ReadLine();
            #endregion


            #region Deserilization
            string path1 = @"C:\Users\Desktop\Serialization\saddam.wav";
            FileStream stream = new FileStream(path1, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine("Id :" + s.id);
            Console.WriteLine("Name :" + s.name);
            Console.ReadLine();  
            #endregion




        }
    }
}
