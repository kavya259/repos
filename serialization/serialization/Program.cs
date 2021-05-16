using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\serialized\serial.txt";              //@" path\anyname.txt"

             Student student = new Student(1, "shah");                    //set some values

            FileStream stream = new FileStream(filePath,FileMode.OpenOrCreate);//create a file to save 

            BinaryFormatter formater = new BinaryFormatter();        //use binary formatter

            formater.Serialize(stream, student);            //use serialize method to save it to harddisk
            stream.Close();                                  //close the stream

            Console.WriteLine("file saved in " + filePath);  
            Console.ReadLine();
        }
    }
}
