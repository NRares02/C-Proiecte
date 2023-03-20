using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Car
    {//campuri:
        public string color;
        public string VIN;
        public int Pret;
        public string nume;
        public int kilometraj;
        //constructori:
        public Car(string Nume,string Color,string vin,int pret)
        {
            nume = Nume;
            color = Color;
            Pret = pret;
            VIN = vin;
        }

        public Car()
        {
            nume ="neinitializat";
            color = "neinitializat";
            Pret = 0;
            VIN = "neinitializat";
        }


        //metode:
        public void Reducere(int procent)
        {

            Pret = Pret - (Pret * procent / 100);
        }

        public void Vopsire(string culoare)
        {
            color = culoare;
        }

        public void ReducereKilometraj()
        {
            kilometraj=kilometraj - 20000;
        }

        public void Afisare()
        {
            Console.WriteLine($"Masina {nume} are culoarea: {color},VIN: {VIN}, pretul: {Pret} si are {kilometraj} km.");

        }


    }
}
