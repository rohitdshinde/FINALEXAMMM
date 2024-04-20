using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FINALEXAM
{
    internal class Program
    {
        static void Q5()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            pail(n, n,n, 0);
            Console.ReadKey();
        }
        static void pail(int n,int digit,int temp, int sum = 0)
        {
            if (temp== 0)
            {
                if (sum == n)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("not");
                }
                return;
            }
            digit = temp % 10;
            sum = sum*10 + digit;
            temp = temp / 10;
            pail(n, digit, temp, sum );
           
        }
        static void Main(string[] args)
        {
            //string path = "E:\\anime\\FINALl.bin";

            //string text = "helo mamam";
            //File.WriteAllText(path, text);
            //Console.WriteLine("Sucesss");

            //string st=File.ReadAllText(path);
            // Console.WriteLine(st);

            // Console.ReadLine();

            //using(BinaryWriter bi=new BinaryWriter(File.Open(path,FileMode.Create)))
            // {
            //     bi.Write(25);
            //     bi.Write("Helo");
            //     Console.WriteLine("Sucesss");
            // }



            //using(BinaryReader ba=new BinaryReader(File.Open(path,FileMode.Open)))
            //{
            //    int value=ba.ReadInt32();
            //    string st=ba.ReadString();
            //    Console.WriteLine(value+st);
            //    Console.ReadLine();
            //}



            //DirectoryInfo doc= new DirectoryInfo(path);

            //Console.WriteLine(doc.FullName);
            //Console.ReadLine();


            //FileInfo file= new FileInfo(path);

            //Console.WriteLine(file.FullName);
            //Console.ReadLine();




            //XmlDocument doc = new XmlDocument();
            // doc.Load("E:\\anime\\sem2\\FINALEXAM\\Myxml.xml");
            //doc.Save(Console.Out);



            //XmlNode node = doc.SelectSingleNode("//Name");
            //Console.WriteLine(node.OuterXml);


            //XmlElement emp = doc.CreateElement("Employee");

            //XmlElement name=doc.CreateElement("Colour");
            //name.InnerText = "Black";
            //emp.AppendChild(name);

            //XmlNode node = doc.SelectSingleNode("//Employee");
            //node.AppendChild(name);

            //doc.Save("E:\\anime\\sem2\\FINALEXAM\\Myxml.xml");

            //Console.WriteLine("Sucess");

            //Console.ReadLine();




            //int[] age = { 1, 2, 47, 95 };

            //var ab=from x in age select x;

            //foreach (var xx in ab)
            //{
            //    Console.WriteLine(xx);

            //}


            //List<int> list = new List<int> { 19,21,54,65}; 
            //var age=from i in list where i<20 select i;

            //foreach (int lii in age)
            //{
            //    Console.WriteLine(lii);
            //}


            //List<string> list = new List<string> { "Hii","li","zoro"};
            //var ch = from c in list where c.Contains("i") select c;

            //foreach(var ci in ch)
            //{
            //    Console.WriteLine(ci);
            //}



            //Console.WriteLine("Enter a number");
            //int n=int.Parse(Console.ReadLine());

            //int fact = 1;
            // for(int i = 1; i <=a; i++)
            //{
            //    fact=fact*i;
            //}
            //Console.WriteLine(fact);
            //Console.ReadLine(); 


            //int count = 0;
            //for(int i=1; i<=a;i++)
            //{
            //    if (a % i == 0)
            //    {
            //        count++;
            //    }

            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("prime");
            //}
            //else
            //{
            //    Console.WriteLine("not prime");
            //}
            //Console.ReadLine();


            //int a=0, b=1;

            //for(int i=0; i<n; i++)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();

            Program.Q5();
            



            
           


        }
    }
}
