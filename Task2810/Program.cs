using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DZ1;
using Teacher;

namespace DZ
{
    class Student
    {
        public void Teach(Learn learn)
        {
            learn.Teach();
        }
        public void GenInfo(Learn learn)
        {
            learn.Geninfo();
        }
        public void Help(Learn learn)
        {
            learn.Help();
        }
        public void ClassInfo(Learn learn)
        {
            learn.ClassInfo();
        }
        public void Pay(Learn learn)
        {
            learn.Pay();
        }     
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Mathem mathem = new Mathem();
            Algem algem = new Algem();

            //student.Teach(new Mathem());

            //student.GenInfo(mathem);

            //student.GenInfo(new Mathem(10,10,10,10,10));

            //student.Help(new Mathem());

            //student.ClassInfo(mathem);

            //student.Pay(mathem);

            string file = @"C:\Users\ahmet\source\repos\DZ\Task2810\testfile.txt";

            List<int> list = new List<int>();
            using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
            {
                string line;
                line = sr.ReadLine();
                var q = line.Split();
                Checkmas(q, ref list);    
            }
            student.GenInfo(new Mathem(list[0], list[1], list[2], list[3], list[4])) ;
            

            Console.Read();
        }
        public static void Checkmas(string[] q, ref List<int> list)
        {
            foreach (var i in q)
            {
                list.Add(Convert.ToInt16(i));
            }
            
        }

    }
}
