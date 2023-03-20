using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj1 = new Car();
            myObj.Afisare(); myObj1.Afisare();
            Car myObj2 = new Car("Dacia","galbena","7223",11000);
            myObj.color = "red";
            myObj1.color = "green";
            myObj.VIN = "2245";
            myObj1.VIN = "7792";
            myObj.Pret = 3500;
            myObj1.Pret = 8900;
            myObj.nume ="Skoda";
            myObj1.nume = "Renault";
            myObj.kilometraj = 250000;
            myObj1.kilometraj = 678000;

            myObj.Afisare();
            myObj1.Afisare();


            //myObj1.Pret = 8900 - (8900 * 20 / 100);
            myObj1.Reducere(20);
            Console.WriteLine(myObj1.Pret);
            myObj.Reducere(30);
            Console.WriteLine(myObj.Pret);
            myObj1.Vopsire("negru");
            Console.WriteLine(myObj1.color);
            myObj.Vopsire("alb");
            Console.WriteLine(myObj.color);
            myObj.ReducereKilometraj();
            Console.WriteLine(myObj.kilometraj);
            myObj1.ReducereKilometraj();
            Console.WriteLine(myObj1.kilometraj);




            myObj.Afisare();
            myObj1.Afisare();

            //De adaugat campul Kilometraj+metoda "reducere kilometraj"
            //Ex: myObj.reducekilometraj(20000)-Reduce kilometrajul cu 20000

        }
    }
}
