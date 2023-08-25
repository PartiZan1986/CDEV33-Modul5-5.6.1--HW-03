using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDEV33_Modul5_5._6._1__HW_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var Info = UserInfo();
            PrintData(Info);
            Console.WriteLine();
            Console.ReadKey();
        }

        static (string Name, string LastName, int Age, string[] PetName, string[] favcolors) UserInfo()
        {
            (string Name, string LastName, int Age, string[] PetName, string[] favcolors) User;

            string name;
            int nameres;

            do
            {
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
            }

            while (!CheckNum(name, out nameres) || name == "0");

            User.Name = name;

            string lname;
            int lnameres;

            do
            {
                Console.WriteLine("Введите фамилию: ");
                lname = Console.ReadLine();
            }

            while (!CheckNum(lname, out lnameres) || lname == "0");


            User.LastName = lname;

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите свой возраст цифрами: ");
                age = Console.ReadLine();
            }

            while (CheckNum(age, out intage));

            User.Age = intage;

            string pet;
            int kolvop;

            do
            {
                Console.WriteLine("Напишите пожалуйста количество питомцев:");
                pet = Console.ReadLine();
            }

            while (CheckNum(pet, out kolvop));



            string[] PetName = new string[kolvop];
            Console.WriteLine("Напишите пожалуйста как зовут Вашего(их) питомца(цев): ");
            for (int i = 0; i < PetName.Length; i++)
            {
                PetName[i] = Console.ReadLine();
            }

            User.PetName = PetName;

            string col;
            int kolvoc;

            do
            {
                Console.WriteLine("Напишите пожалуйста количество Ваших любимых цветов:");
                col = Console.ReadLine();
            }

            while (CheckNum(col, out kolvoc));

            string[] favcolors = new string[kolvoc];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите Ваш любимый цвет(а): ", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            User.favcolors = favcolors;

            return User;
        }

        static bool CheckNum(string number, out int corrnumber)
        {

            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            corrnumber = 0;
            return true;

        }

        static void PrintData((string Name, string LastName, int Age, string[] PetName, string[] favcolors) Data)
        {
            Console.WriteLine(Data.Name);
            Console.WriteLine(Data.LastName);
            Console.WriteLine(Data.Age);

            foreach (var pet in Data.PetName)
            {
                Console.WriteLine(pet.ToString());
            }

            foreach (var color in Data.favcolors)
            {
                Console.WriteLine(color.ToString());
            }

        }

    }
}
