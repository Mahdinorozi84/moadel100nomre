using try1;
using System.IO;
string Path = "C:\\Users\\Acer\\Desktop\\c# tamrin\\try1\\Students.txt";
string[] Lines = File.ReadAllLines(Path);

Student[] students = new Student[9];
for (int i = 0; i < students.Length; i++)
{
    string[] line = Lines[i].Split(",");
    Student Student = new Student();
    Student.Name = line[0];
    Student.LName = line[1];
    Student.pishraftre2 = Int32.Parse(line[2]);
    Student.pishrafte1 = Int32.Parse(line[3]);
    Student.algoritm = Int32.Parse(line[4]);
    Student.sheygerayi = Int32.Parse(line[5]);
    Student.riazi = Int32.Parse(line[6]);
    Student.kargah = Int32.Parse(line[7]);
    Student.tarbiat = Int32.Parse(line[8]);
    Student.tafsir = Int32.Parse(line[9]);
    Student.system = Int32.Parse(line[9]);
    Student.zaban = Int32.Parse(line[11]);

    students[i] = Student;


}


bool an = true;
do
{
    Darsha darsha = new Darsha();

    IfElse ifElse = new IfElse();

    IsPrime ISPrime = new IsPrime();

    Console.WriteLine("Welcome");
    Console.WriteLine("1:moadel kol doros");
    Console.WriteLine("2:moadel doros ***");
    Console.WriteLine("3:moadel doros **");
    Console.WriteLine("4:model doros *");
    Console.WriteLine("5:moadel be tartib (sort bandi)");
    Console.WriteLine("6:moadel bar asas grade");
    Console.WriteLine("7:daneshjoyani ba moadel adad aval");


    int option = int.Parse(Console.ReadLine());

    string[] dars = new string[10]
    { "pishrafte1" , "pishrafte2","sheygerayi","system","algoritm","zaban","riazi","kargah","tarbiat","tafsir" };


    int majmozarib1 = 1 * 5, majmozarib2 = 2 * 5, majmozarib3 = 3 * 5;

    switch (option)
    {
        case 1:
            for (int i = 0; i < 100; i++)
            {
                darsha.dars3setare();
                darsha.majmo1 /= majmozarib3;
                darsha.dars2setare();
                darsha.majmo2 /= majmozarib2;
                darsha.dars1setare();
                darsha.majmo3 /= majmozarib1;

                ifElse.majmo4 = (darsha.majmo1 + darsha.majmo2 + darsha.majmo3) / 3;

                

                ifElse.IfElse1();
                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine("moadel kol   "  + " : " + ifElse.majmo4);
                }
            }
            break;

        case 2:
            for (int j = 0; j < 100; j++)
            {
                darsha.dars3setare();
                darsha.majmo1 /= majmozarib3;

                Console.WriteLine("moadel doros ***  "  + " : " + darsha.majmo1);

                ifElse.majmo4 = darsha.majmo1;

                ifElse.IfElse1();
                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine("moadel doros ***  " + " : " + darsha.majmo1);

                }

            }

            break;
        case 3:
            for (int i = 0; i < 100; i++)
            {
                darsha.dars2setare();
                darsha.majmo2 /= majmozarib2;

                Console.WriteLine("moadel doros **  "  + " : " + darsha.majmo2);

                ifElse.majmo4 = darsha.majmo2;

                ifElse.IfElse1();
                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine("moadel doros **  " + " : " + darsha.majmo2);

                }

            }



            break;
        case 4:
            for (int i = 0; i < 100; i++)
            {
                darsha.dars1setare();
                darsha.majmo3 /= majmozarib1;

                Console.WriteLine("moadel doros *  "  + " : " + darsha.majmo3);

                ifElse.majmo4 = darsha.majmo3;

                ifElse.IfElse1();

                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine("moadel doros *  " + " : " + darsha.majmo3);

                }
            }



            break;
        case 5:
            for (int i = 0; i < 100; i++)
            {
                darsha.dars3setare();
                darsha.majmo1 /= majmozarib3;
                darsha.dars2setare();
                darsha.majmo2 /= majmozarib2;
                darsha.dars1setare();
                darsha.majmo3 /= majmozarib1;

                ifElse.majmo4 = (darsha.majmo1 + darsha.majmo2 + darsha.majmo3) / 3;

                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine(" : " + "moadel kol   " + ifElse.majmo4 + "  \n //  " + "moadel dros ***" + "     " + darsha.majmo1 + "   \n //  " + "moadel dros ** " + "    " + darsha.majmo2 + " \n //    " + "moadel dros *" + "    " + darsha.majmo3);

                }
            }

            break;

        case 6:

            for (int i = 0; i < 100; i++)
            {
                darsha.dars3setare();
                darsha.majmo1 /= majmozarib3;
                darsha.dars2setare();
                darsha.majmo2 /= majmozarib2;
                darsha.dars1setare();
                darsha.majmo3 /= majmozarib1;

                ifElse.majmo4 = (darsha.majmo1 + darsha.majmo2 + darsha.majmo3) / 3;

                ifElse.IfElse1();
                foreach (var student in students)
                {
                    Console.WriteLine(student.names());
                    Console.WriteLine("grade dros  : ");

                }
            }

            break;
        case 7:
            for (int i = 0; i < 100; i++)
            {
                darsha.dars3setare();
                darsha.majmo1 /= majmozarib3;
                darsha.dars2setare();
                darsha.majmo2 /= majmozarib2;
                darsha.dars1setare();
                darsha.majmo3 /= majmozarib1;

                ifElse.majmo4 = (darsha.majmo1 + darsha.majmo2 + darsha.majmo3) / 3;

                int x = (int)ifElse.majmo4;

                if (x >= 2 && ISPrime.IsPrime1(x))
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine(student.names());
                    Console.WriteLine("moadel kol   "  + " : " + x);

                    }
                }
            }

            break;

    }

    Console.WriteLine("aya tammam beshe?");

    string answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
    {
        an = false;
    }

} while (an);

Console.WriteLine();
Console.WriteLine("end");
public class IsPrime
{
    public bool IsPrime1(int num)
    {
        for (int z = 2; z * z <= num; z++)
        {
            if (num % z == 0)
            {
                return false;
            }
        }
        return true;
    }
}
public class IfElse
{

    public double majmo4;

    public void IfElse1()
    {
        string grade;
        if (majmo4 > 17)
        {
            grade = "A";
        }
        else if (majmo4 > 15)
        {
            grade = "B";
        }
        else if (majmo4 > 13)
        {
            grade = "C";
        }
        else if (majmo4 > 10)
        {
            grade = "D";
        }
        else if (majmo4 > 7)
        {
            grade = "E";
        }
        else if (majmo4 > 3)
        {
            grade = "F";
        }
        else
        {
            grade = "G";
        }
        Console.WriteLine(grade);
    }

}
public class Darsha
{
    public double majmo1;

    public double majmo2;

    public double majmo3;

    public void dars3setare()
    {
        for (int i = 0; i < 5; i++)
        {
            double point = Random.Shared.Next(0, 21);
            point *= 3;
            majmo1 += point;

        }

    }

    public void dars2setare()
    {
        for (int i = 5; i < 8; i++)
        {
            double point = Random.Shared.Next(0, 21);
            point *= 2;
            majmo2 += point;
        }

    }
    public void dars1setare()
    {
        for (int i = 8; i < 10; i++)
        {
            double point = Random.Shared.Next(0, 21);
            point *= 1;
            majmo3 += point;
        }
    }

}
public class Student
{


    public string Name { get; set; }

    public string LName { get; set; }

    public double pishrafte1 { get; set; }

    public double pishraftre2 { get; set; }

    public double sheygerayi { get; set; }

    public double algoritm { get; set; }

    public double system { get; set; }

    public double riazi { get; set; }

    public double kargah { get; set; }

    public double tafsir { get; set; }

    public double zaban { get; set; }
    public double tarbiat { get; set; }
    public string names()
    {
        return $"\n=>Name:{Name}";
    }
    public double Miangin()
    {
        return Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3) + (algoritm * 2) + (system * 2) + (riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 18, 2);
    }

    public string Moadelzarib3()
    {
        return $" Moadelzarib3:{Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3)) / 9, 2)}";
    }
    public string Moadelzarib2()
    {
        return $" Moadelzarib2: {Math.Round(((algoritm * 2) + (system * 2)) / 4, 2)}";
    }

    public string Moadelzarib1()
    {
        return $"Moadelzarib1: {Math.Round(((riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 5, 2)}";
    }

}
