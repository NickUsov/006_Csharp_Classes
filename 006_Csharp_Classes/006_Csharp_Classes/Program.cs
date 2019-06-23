using System;
using System.Linq;
using static System.Console;

namespace _006_Csharp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Описать класс Client содержащий поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом;
            //общая сумма заказов клиента. Использовать ключевое слово this для делегации конструктора и инициализации полей.
            Console.WriteLine("1. exercise");
            Random rnd = new Random();
            Client client = new Client(1234, "CC", "Seas avenu", 223322, 5, 500.0);
            WriteLine(client);

            //2. Реализовать класс, описывающий студента. Предусмотреть в нем следующие поля: фамилия, имя, отчество, группа, возраст,
            //массив (зубчатый) оценок по программированию, администрированию и дизайну.
            // А также добавить методы по работе с перечисленнями данными:  возможность установки оценки, получение среднего балла
            //по заданному предмету, распечатка данных о студенте.Проверить выходит ли стипендия (если ср.бал по всем предметам больше 10.7).
            //Клас описать в двух файлах.

            Console.WriteLine("2. exercise");
            int[][] arr = new int[3][];
            for (int i = 0; i < 3; i++)
                arr[i] = new int[5];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<5;j++)
                {
                    arr[i][j] = rnd.Next(11, 13);
                }
            }
            Student Petrenko = new Student("Stepan", "Alexeevich", "Petrenko", "RPO-19-3", arr);
            Petrenko.PrintStudent();
            Petrenko.CheckStipend();

        }
    }
    //1. Описать класс Client содержащий поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом;
    //общая сумма заказов клиента. Использовать ключевое слово this для делегации конструктора и инициализации полей.
    public class Client
    {
        int id;
        string fullName;
        string address;
        int phoneNumber;
        int numberOrders;
        double summOrders;
        public Client()
        {
            this.id=0;
            this.fullName="";
            this.address="";
            this.phoneNumber=0;
            this.numberOrders=0;
            this.summOrders=0;
        }
        public Client(int id):this()
        {
            this.id = id;
        }
        public Client(int id, string fullName):this(id)
        {
            this.fullName = fullName;
        }
        public Client(int id, string fullName, string address):this(id,fullName)
        {
            this.address = address;
        }
        public Client(int id, string fullName, string address,int phoneNumber):this(id,fullName,address)
        {
            this.phoneNumber = phoneNumber;
        }
        public Client(int id, string fullName, string address, int phoneNumber, int numberOrders):this(id,fullName,address,phoneNumber)
        {
            this.numberOrders = numberOrders;
        }
        public Client(int id, string fullName, string address, int phoneNumber, int numberOrders, double summOrders):this(id,fullName,address,phoneNumber,numberOrders)
        {
            this.summOrders = summOrders;
        }
        public override string ToString()
        {
            return $"{id} {fullName} {address} {phoneNumber} {numberOrders} {summOrders}";
        }
    }

    //2. Реализовать класс, описывающий студента. Предусмотреть в нем следующие поля: фамилия, имя, отчество, группа, возраст,
    //массив (зубчатый) оценок по программированию, администрированию и дизайну.
    // А также добавить методы по работе с перечисленнями данными:  возможность установки оценки, получение среднего балла
    //по заданному предмету, распечатка данных о студенте.Проверить выходит ли стипендия (если ср.бал по всем предметам больше 10.7).
    //Клас описать в двух файлах.

    partial class Student
    {
        public void SetScore(string subject, int score)
        {
            switch(subject)
            {
                case "Programming": { int index = scores[0].Length; Array.Resize(ref scores[0], scores[0].Length + 1);scores[0][index]=score; }break;
                case "Administration": { int index = scores[1].Length; Array.Resize(ref scores[1], scores[1].Length + 1); scores[1][index] = score; } break;
                case "Design": { int index = scores[2].Length; Array.Resize(ref scores[2], scores[2].Length + 1); scores[2][index] = score; } break;
                default:WriteLine("Not correct subject name");break;
            }
        }
        public double GetSubjectScoreAvg(string subject)
        {
            switch (subject)
            {
                case "Programming": { return scores[0].Average(); }
                case "Administration": { return scores[1].Average(); }
                case "Design": { return scores[2].Average(); }
                default: return -1;
            }
        }
        public void PrintStudent()
        {
            WriteLine($"{firstName} {fathersName} {lastName} {group}");
            Write("Programming: ");
            foreach (var sc in scores[0])
                Write(sc + " ");
            WriteLine();
            Write("Administration: ");
            foreach (var sc in scores[1])
                Write(sc + " ");
            WriteLine();
            Write("Design: ");
            foreach (var sc in scores[2])
                Write(sc + " ");
            WriteLine();
        }
        public void CheckStipend()
        {
            double avg1 = scores[0].Average();
            double avg2 = scores[1].Average();
            double avg3 = scores[2].Average();
            if (avg1 > 10.7 && avg2 > 10.7 && avg3 > 10.7)
                WriteLine("This student will have a stipend");
            else
                WriteLine("This student will not have a stipend");
        }
    }

    //3. 
}
