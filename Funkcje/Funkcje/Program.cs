using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {

        static void Main(string[] args)
        {
            double zadanie;
            string lista = "\n 1) Zad3_1_1 \n 2) Zad3_1_2 \n 3) Zad3_1_3 \n 4) Zad3_1_4 \n 5) Zad3_1_5 \n 6) Zad3_1_6 \n 7) Zad3_1_7 \n 8) Zad3_1_8 \n 9) Zad3_2";
            Console.WriteLine($"Lista zadan: {lista}");

            Console.WriteLine();

            Console.WriteLine("Ktore zadanie chcesz otworzyc?:");
            zadanie = Convert.ToDouble(Console.ReadLine());

            switch (zadanie)
            {
                case 1:
                    Zad3_1_1();
                    break;
                case 2:
                    Zad3_1_2();
                    break;
                case 3:
                    Zad3_1_3();
                    break;
                case 4:
                    Zad3_1_4();
                    break;
                case 5:
                    Zad3_1_5();
                    break;
                case 6:
                    Zad3_1_6();
                    break;
                case 7:
                    Zad3_1_7();
                    break;
                case 8:
                    Zad3_1_8();
                    break;
                case 9:
                    Zad3_2();
                    break;
                default:
                    Console.WriteLine("Podano zly wybor,sproboj jeszcze raz");
                    break;
            }
            Console.ReadLine();
            

            void Zad3_1_1()
            {
                // przelicza odległość wyrażoną w stopach na metry

                double dlugosc;
                double wynik;
                Console.Write($"Podaj dlugosc w stopach: ");
                dlugosc = Convert.ToDouble(Console.ReadLine());
                wynik = StopyNaMetry(dlugosc);

                Console.WriteLine($"Wynik to: {wynik}");
                Console.ReadLine();


                double StopyNaMetry(double metry)
                {
                    double stopy;
                    stopy = 3.28;
                    metry = stopy * dlugosc;

                    return metry;
                }
            }
            
            void Zad3_1_2()
            {
                //zwraca większą z dwóch liczb - postaraj się nie używać funkcji `max` wbudowanej w pythona

                double liczba1, liczba2, wynik;

                Console.Write("Podaj pierwsza liczbe:");
                liczba1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj druga liczbe:");
                liczba2 = Convert.ToDouble(Console.ReadLine());
                wynik = 0;
                wynik = Max(wynik);

                double Max(double zad)
                {
                    if (liczba1 > liczba2)
                    {
                        Console.WriteLine($"Wieksza liczba to: {liczba1}");
                    }
                    else
                    {
                        Console.WriteLine($"Wieksza liczba to: {liczba2}");
                    }

                    return zad;
                }
                Console.ReadLine();
            }

            void Zad3_1_3()
            {
                //oblicza średnią z dwóch liczb

                double liczba1, liczba2;

                Console.Write("Podaj pierwsza liczbe:");
                liczba1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj druga liczbe:");
                liczba2 = Convert.ToDouble(Console.ReadLine());
                double wynik = 0;
                wynik = Srednia(wynik);
                Console.WriteLine($"Srednia tych liczb to: {wynik}");

                double Srednia(double sr)
                {
                    double suma;
                    suma = liczba1 + liczba2;
                    sr = suma / 2;
                    return sr;
                }
                Console.ReadLine();
            }

            void Zad3_1_4()
            {
                //oblicza pole koła o podanym promieniu (jeden parametr)

                double promien, wyliczenie;

                Console.Write("Podaj dlugosc promienia:");
                promien = Convert.ToDouble(Console.ReadLine());
                wyliczenie = 0;

                wyliczenie = PoleKola(wyliczenie);
                Console.WriteLine("Pole kola wynosi: " + Math.Round(wyliczenie, 2));

                double PoleKola(double wynik)
                {
                    wynik = Math.PI * Math.Pow(promien, 2);

                    return wynik;
                }
                Console.ReadLine();
                
            }

            void Zad3_1_5()
            {
                //oblicza współczynnik BMI dla podanych dwóch parametrów: wzrostu w metrach i wagi w kg.

                double wzrost, waga, suma;

                Console.WriteLine("Podaj swoj wzrost:");
                wzrost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj swoja wage:");
                waga = Convert.ToDouble(Console.ReadLine());
                suma = 0; 
                suma = Bmi(suma);
                Console.WriteLine($"Twoje BMI wynosi: {suma}");

                double Bmi(double bmi)
                {
                    wzrost /= 100;
                    bmi = waga / Math.Pow(wzrost, 2);
                    return bmi;
                }
                Console.ReadLine();
            }

            void Zad3_1_6()
            {
                //z trzema parametrami - oblicza pole trójkąta o podanych bokach z wzoru Herona.

                double a, b, c,wynik;

                Console.WriteLine("Podaj dlugosc boku 'a' : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj dlugosc boku 'b' : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj dlugosc boku 'c' : ");
                c = Convert.ToDouble(Console.ReadLine());
                wynik = 0;
                wynik = PoleTrojkata(wynik);

                Console.WriteLine($"Pole trojkata wynosi: {wynik}");

                double PoleTrojkata(double pole)
                {
                    double polowa = (a + b + c) / 2;
                    pole = Math.Sqrt(polowa * (polowa - a) * (polowa - b) * (polowa - c));
                    Math.Round(pole, 2);

                    return pole;
                }
                Console.ReadLine();
            }

            void Zad3_1_7()
            {
                //przelicza odległość wyrażoną w kilometrach na mile

                double kilometr, mila, wynik;

                Console.Write("Podaj dlugosc w kilometrach: ");
                kilometr = Convert.ToDouble(Console.ReadLine());
                wynik = 0;
                wynik = kilometryNaMile(wynik);
                Console.WriteLine($"twoj wynik to: {wynik} mil");

                double kilometryNaMile(double suma)
                {
                    mila = 0.62;
                    suma = kilometr * mila;
                    return suma;
                }
                Console.ReadLine();
            }

            void Zad3_1_8()         
            {
                //przelicza odległość wyrażoną w milach na kilometry

                double kilometr , mile , wynik;

                Console.Write("Podaj dlugosc w milach: ");
                mile = Convert.ToDouble(Console.ReadLine());
                wynik = 0;
                wynik = MileNaKilometry(wynik);
                Console.WriteLine($"twoj wynik to: {wynik} km");

                double MileNaKilometry(double suma)
                {
                    
                    kilometr = 1.61;
                    suma = kilometr * mile;
                    return suma;
                }
                Console.ReadLine();
            }

            void Zad3_2()
            {
                // Zapytaj użytkownika o nazwę miesiąca i na tej podstawie wypisz mu ile dni na dany miesiąc. 

                int  liczbaDni;
                int  miesiac;
                
                Console.WriteLine("Podaj miesiac:");
                miesiac = Convert.ToInt32(Console.ReadLine());

                liczbaDni = 0;
                liczbaDni = IloscDni(liczbaDni);
                Console.WriteLine($"W {miesiac} jest {liczbaDni} dni");

                int IloscDni(int ilosc)
                {
                    
                    switch (miesiac)
                    {
                        case 1:
                          int  a = 31;
                        break;
                    }
                    return ilosc;
                }

                Console.ReadLine();
                
            }

            void Zad3_3()
            {
                /*Stwórz następujące funkcje. Każda z nich będzie przyjmowała listę liczb i na tej podstawie wykona odpowiednie operacje i zwróci odpowiedni wynik.
                int Suma;
                List<int> listaLiczb = new List<int>(){10, 20, 30, 40};
                int wynik = suma(listaLiczb);

                static int SumaLiczb()
                {
                    return 0;
                }
                */
            }

        }
            
    }
}
