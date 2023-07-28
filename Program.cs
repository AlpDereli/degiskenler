using System;
namespace degiskenler
{
    class odev
    {
        public void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;
            sbyte c = 5;
            short s = 5;
            ushort us = 5;
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            
            uint ui = 2;
            long l = 4;
            ulong ul = 4;


            float f = 5;
            double d =5;
            decimal de = 5;

            char ch = '2';
            string str = "Alp";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "Alp Dereli";
            string ad ="Alp";
            string soyad = "Dereli";
            string tam = ad+ " "+soyad;
            int integer1 = 5;
            int integer = 3;
            int integer3 = integer1 * integer;

            bool bool1 = 10>2;

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger);
            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.mm.yy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/mm/yyyy");

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
