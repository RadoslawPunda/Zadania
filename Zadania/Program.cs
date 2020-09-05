using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zad1_1
    {
      
        static void Main(string[] args)
        {

            //Zad1_1_1();
            //Zad1_1_2();
            //Zad1_1_3();
            //Zad1_2();
            //Zad1_3();
            //Zad1_4();
            //Zad1_5();
            //Zad1_6();
            //Zad1_7();
            //Zad1_8();
            //Zad1_9();
            //Zad2_1();
            //Zad2_2();
            //Zad2_3(); nie zrobione
            //Zad2_4();
        }
        static void Zad1_1_1()
        {

            // Napisz program, który prosi użytkownika, żeby podał, ile kosztuje kilo ziemniaków. Niech program policzy i wyświetli, ile trzeba będzie zapłacić za pięć kilo ziemniaków.
            Console.WriteLine("Zadanie 1.0");
            Console.WriteLine();

            double ziemniak = 5;

            Console.WriteLine("Podaj cene za kg ziemniaków: ");
            double cena = Convert.ToDouble(Console.ReadLine());
            double koszt = cena * ziemniak;

            Console.WriteLine($"Za 5kg ziemniakow nalezy zapłacić {koszt}");


        }
        static void Zad1_1_2()
        {

            // Potem napisz program, który prosi użytkownika, żeby podał, ile kosztuje kilo ziemniaków i ile kilo chce kupić. 
            // Niech program policzy i wyświetli, ile trzeba będzie zapłacić za te ziemniaki.
            Console.WriteLine("Zadanie 1.1");
            Console.WriteLine();

            Console.WriteLine("Podaj cene za kg ziemniaków: ");
            double cena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ile kg chcesz kupic?: ");
            double ilosc = Convert.ToDouble(Console.ReadLine());
            double koszt = cena * ilosc;
            Console.WriteLine($"Za {ilosc}kg ziemniakow nalezy zapłacić {koszt}kg");
            Console.WriteLine();


        }
        static void Zad1_1_3()
        {
            // Potem napisz program, który prosi użytkownika, żeby podał, ile kosztuje kilo ziemniaków, ile kilo ziemniaków chce kupić, ile kosztuje kilo bananów i ile kilo bananów chce kupić. 
            // Niech program policzy i wyświetli, ile trzeba będzie zapłacić za te ziemniaki i banany razem. 
            // I niech program sprawdzi i powie, za co trzeba będzie zapłacić więcej - za banany czy za ziemniaki.
            Console.WriteLine("Zadanie 1.2");
            Console.WriteLine();
            Console.WriteLine("Podaj cene za kg ziemniaków: ");
            double cenaZiemniakow = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ile kg ziemniakow chcesz kupic?: ");
            double iloscZiemniakow = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj cene za kg bananow ");
            double cenaBananow = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ile kg bananow chcesz kupic?: ");
            double iloscBananow = Convert.ToDouble(Console.ReadLine());

            double kosztZiemniakow = cenaZiemniakow * iloscZiemniakow;
            double kosztBananow = cenaBananow * iloscBananow;
            double kosztCaly = kosztBananow + kosztZiemniakow;
            Console.WriteLine($"Za {iloscZiemniakow} kg ziemniakow i {iloscBananow} kg nalezy zapłacić {kosztCaly}zl");
            if (kosztZiemniakow > kosztBananow)
            {
                Console.WriteLine("Najwiecej kosztuja ziemniaki!");
            }
            else if (kosztZiemniakow < kosztBananow)
            {
                Console.WriteLine("Najwiecej kosztuja banany!");
            }
            else
            {
                Console.WriteLine("Koszt produktow jest taki sam!");
            }
            Console.ReadLine();
        }
        static void Zad1_2()
        {
            //Napisz taki program: użytkownik ma podać, w jaki dzień tygodnia oddał buty do szewca (poniedziałek to dzień 1, wtorek to dzień 2 itp.).
            //Ma też podać, ile dni będzie trwała naprawa. 
            //Program ma wypisać, w jaki dzień tygodnia buty będą gotowe do odbioru. 
            //Jeśli tak będzie ci wygodniej, możesz założyć, że naprawa butów nigdy nie będzie trwała dłużej niż siedem dni.


            int dateOfDelivery;
            int repairTimeInDays;
            int finishTime;
            Console.WriteLine("1 - PONIEDZIAŁEK");
            Console.WriteLine("2 - WTOREK");
            Console.WriteLine("3 - ŚRODA");
            Console.WriteLine("4 - CZWARTEK");
            Console.WriteLine("5 - PIĄTEK");
            Console.WriteLine("6 - SOBOTA");
            Console.WriteLine("7 - NIEDZIELA");
            Console.WriteLine("Podaj w jaki dzień tygodnia oddasz buty do szewca");
            dateOfDelivery = Convert.ToInt32(Console.ReadLine());

            if ((dateOfDelivery >= 1) || (dateOfDelivery <= 7))
            {
                Console.WriteLine("Ile dni będzie trwała naprawa?");
                repairTimeInDays = Convert.ToInt32(Console.ReadLine());
                finishTime = (dateOfDelivery + repairTimeInDays) % 7;

                switch (finishTime)
                {
                    case 1:
                        Console.WriteLine("Buty zostaną oddane w poniedziałek");
                        break;
                    case 2:
                        Console.WriteLine("Buty zostaną oddane we wtorek");
                        break;
                    case 3:
                        Console.WriteLine("Buty zostaną oddane w środę");
                        break;
                    case 4:
                        Console.WriteLine("Buty zostaną oddane w czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Buty zostaną oddane w piątek");
                        break;
                    case 6:
                        Console.WriteLine("Buty zostaną oddane w sobotę");
                        break;
                    case 7:
                        Console.WriteLine("Buty zostaną oddane w niedzielę");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nie ma takiego dnia");
            }
            Console.ReadLine();
        }
        static void Zad1_3()
        {
            //Napisz program, który dla podanych liczb: wzrostu w cm i masy ciała w kg obliczą i wypisze współczynnik BMI,
            //oraz podsumowanie informujące o stanie/zaleceniach. (Informacje o BMI: wzór, interpretację wyników, proszę znaleźć samodzielnie).
            double waga, wzrost, bmi, wspWzrostu;
            Console.Write("Podaj swoj wzrost(w cm.): ");
            wzrost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj swoja wage(w kg): ");
            waga = Convert.ToDouble(Console.ReadLine());
            wspWzrostu = wzrost / 100;
            wspWzrostu *= wspWzrostu;
            bmi = waga / wspWzrostu;
            
            Console.WriteLine("wskaznik BMI: " + Math.Round(bmi, 2));

            if (bmi < 16)
            {
                Console.WriteLine("Wspołczynnik  wskazuje na wyglodzenie organizmu");                
            }
            else if(bmi >= 16 && bmi <= 16.99)
            {
                Console.WriteLine("Wspołczynnik wskazuje na wychudzenie organizmu");
            } 
            else if (bmi >= 17 && bmi <= 18.49)
            {
                Console.WriteLine("Wspołczynnik wskazuje na niedowage organizmu");
            }
            else if(bmi >= 18.5 && bmi <= 24.99)
            {
                Console.WriteLine("Wspołczynnik jest prawidlowy");
            }
            else if (bmi >= 25 && bmi <= 29.99)
            {
                Console.WriteLine("Wspołczynnik wskazuje na nadwage organizmu");
            }
            else if (bmi >= 30 && bmi <= 34.99)
            {
                Console.WriteLine("Wspołczynnik wskazuje na otylosc 1-stopnia");
            }
            else if (bmi >= 35 && bmi <= 39.49)
            {
                Console.WriteLine("Wspołczynnik wskazuje na otylosc 2-stopnia");
            }
            else if(bmi >= 40)
            {
                Console.WriteLine("Wspołczynnik wskazuje na otylosc skrajna!");
            }
            
            Console.ReadKey();

        }
        static void Zad1_4()
        {
            /*Potem napisz taki program: użytkownik podaje swój wiek i ile nocy spędzi w hotelu, a program wylicza, ile trzeba zapłacić. Zasady są takie:
             -nieletni(poniżej 18 roku życia) płacą 100 zł za noc
             - dorośli(ci, którzy mają przynajmniej 18 lat ale mniej niż 65 lat) płacą:
                 -200 zł za noc, jeśli nocują jedną noc
                 -180 zł za noc, jeśli nocują przynajmniej dwie ale mniej niż pięć nocy
                 - 150 zł za noc, jeśli nocują pięć lub więcej nocy
             -emeryci(ci, którzy mają przynajmniej 65 lat), płacą jak dorośli, ale z 10 % zniżki
            Przykładowo: jeśli użytkownik ma 70 lat i spędzi w hotelu dziesięć nocy, zapłaci 150 zł za noc z 10% zniżki, czyli 150-15 zł za noc, 
            czyli 135 zł za noc, czyli 1350 zł.
            */
            double wiek, nocJedna, noce, znizka;

            Console.Write("Ile masz lat?");
            wiek = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ile nocy spedziles w hotelu?:");
            noce = Convert.ToDouble(Console.ReadLine());
            

            if (wiek < 18 )
            {
                nocJedna = 100 * noce;
                Console.Write($"Koszt twojego pobuty wynosi: {nocJedna} zl");
            }
            else if (wiek >= 18 && wiek < 65)
            {
                if(noce == 1)
                {
                    Console.Write("Koszt twojego pobytu wynosi: 200zl");
                }
                else if (noce >= 2 && noce <= 4)
                {
                    nocJedna = 180 * noce;
                    Console.Write($"Twoj koszt pobytu wynosi: {nocJedna} zl");
                }
                else if (noce >= 5)
                {
                    nocJedna = 150 * noce;
                    Console.WriteLine($"Twoj koszt pobytu wynosi: {nocJedna} zl");
                }
            }
            else if (wiek >= 65)
            {
                if (noce == 1)
                {
                    nocJedna = 200;
                    znizka = nocJedna - (nocJedna / 10);
                    Console.Write($"Koszt twojego pobytu wynosi: {znizka}zl");
                }
                else if (noce >= 2 && noce <= 4)
                {
                    nocJedna = 180 * noce;
                    znizka =nocJedna - (nocJedna / 10);
                    Console.Write($"Twoj koszt pobytu wynosi: {znizka} zl");
                }
                else if (noce >= 5)
                {
                    nocJedna = 150 * noce;
                    znizka = nocJedna - ( nocJedna / 10);
                    Console.WriteLine($"Twoj koszt pobytu wynosi: {znizka} zl");
                }
            }
            Console.ReadLine();
            
        }
        static void Zad1_5()
        {
            //Program, który odczytuje trzy liczby, sprawdza czy liczby te mogą stanowić boki trójkąta (np. z 2, 2 i 5 nie da się ułożyć trójkąta, prawa?),
            //a jeśli mogą, oblicza pole powierzchni trójkąta o takich bokach.

            double a, b, c, pole, polowaPola,polObliczenie;

            Console.Write("Podaj dlugośc boku a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc boku b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc boku c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Z tych liczb mozna zbudowac trojkat!");
                polowaPola = (a + b + c) / 2;
                polObliczenie = polowaPola * (polowaPola - a)*(polowaPola - b)*(polowaPola - c);
                pole = Math.Sqrt(polObliczenie);
                pole = Math.Round(pole, 3);
               
                Console.WriteLine($"Pole powierzchni trojkata wynosi: {pole}");
            }
            else
            {
                Console.WriteLine("Z tych liczb nie uda sie zbudowac trojkata!");
            }
            Console.ReadLine();
        }
        static void Zad1_6()
        {
            /*Założenia:
            - 0-6   - wiek przedszkolny - cena biletu: 0
            - 7-17  - wiek szkolny      - cena biletu: 2.28
            - 18-64 - wiek dorosły      - cena biletu: 3.80
            - +65   - wiek emerytalny   - cena biletu: 1.90

            Napisz program, który przyjmuje dwie informacje: jaki jest wiek osoby kupującej bilety i ile biletów chce kupić.
            Na tej podstawie i powyższych założeń policz ile zapłaci za bilety, które chce kupić. Wczytywanie danych i ich wyświetlenie zrealizuj za pomocą konsoli. 
            */
            double wiek, iloscBiletow, cenaBiletu;
            Console.Write("Ile masz lat?: ");
            wiek = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ile chcesz kupić biletow?:");
            iloscBiletow = Convert.ToDouble(Console.ReadLine());

            if (wiek <= 6)
            {
                cenaBiletu = 0;
                Console.WriteLine("Za wszystkie bilety zaplacisz 0zl");
            }
            else if((wiek ==  7) || ( wiek <= 17))
            {
                cenaBiletu = 2.20 * iloscBiletow;
                Console.WriteLine($"(Za wszystkie bilety zaplacisz: {cenaBiletu} zl");
            }
            else if (( wiek == 18) || (wiek <= 64))
            {
                cenaBiletu = 3.80 * iloscBiletow;
                Console.WriteLine($"Za wszystkie bilety zaplacisz: {cenaBiletu} zl");
            }else
            {
                cenaBiletu = 1.90 * iloscBiletow;
                Console.WriteLine($"Za wszystkie bilety zaplacisz: {cenaBiletu} zl");
            }

            Console.ReadLine();
        }
        static void Zad1_7()
        {
            /*
             * Zapytaj użytkownika co chce kupić, jaką ilość towaru chce kupić i jaka jest jego cena. Wyświetl odpowiedni komunikat.
             * Przykład:
             * Co chcesz kupić? - ziemniaki
             * Podaj cenę towaru - 5
             * Podaj ilość towaru - 10
             * Za ziemniaki, który chcesz kupić, zapłacisz 50 zł
             */
            string towar;
            double cena, ilosc, suma;
            Console.Write("Co chcesz kupic?: ");
            towar = Convert.ToString(Console.ReadLine());
            Console.Write("Podaj cene towaru (zl): ");
            cena = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj ilosc towaru (kg): ");
            ilosc = Convert.ToDouble(Console.ReadLine());
            suma = cena * ilosc;

            Console.WriteLine($"Za {towar} , ktory chcesz kupic, zaplacisz {suma} zl" );
            Console.ReadLine();
        }
        static void Zad1_8()
        {
            /*Zakładamy, że 1 ludzki rok, to 5 lat psich.
             * Za pomocą konsoli wczytaj imię i wiek psa.
             * Wypisz komunikat ile pies miałby lat gdyby był człowiekiem.
             * Przykład:
             * Podaj imię psa - Burek
             * Podaj wiek psa - 3
             * Gdyby Burek był człowiekiem, miałby 15 lat.
             */
            string imie;
            double wiek,ludzkiRok,psiWiek;

            Console.Write("Podaj imie psa: ");
            imie = Convert.ToString(Console.ReadLine());
            Console.Write("Podaj wiek psa: ");
            wiek = Convert.ToDouble(Console.ReadLine());
            ludzkiRok = 5;
            psiWiek = wiek * ludzkiRok;

            Console.WriteLine($"Gdyby {imie} byl czlowiekiem, mialby {psiWiek} lat" );
            Console.ReadLine();
        }
        static void Zad1_9()
        {
            //Napisz program, który wyświetla liczby od 1 do 100. 
            //Dla liczb podzielnych przez 3 niech program wyświetli `Fizz`; dla liczb podzielnych przez 5 niech wyświetli `Buzz`; a dla liczb podzielnych przez 15 niech wyświetli `FizzBuzz`.
            int i;
            for (i =1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {

                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadLine();
        }
        static void Zad2_1()
        {
            //Program losuje dwie liczby z zakresu od 0 do 99 (patrz poniżej). Podaje te dwie liczby i pyta jaka jest ich suma (nie podaje jej).
            //Użytkownik ma odgadnąć (no, policzyć w głowie) wynik. Program pyta o wynik wielokrotnie, tak długo, aż użytkownik poda prawidłowy wynik.
            int suma,podajWynik;

            Random rand = new Random();
            int liczba1 = rand.Next(99);
            int liczba2 = rand.Next(99);
            Console.WriteLine($"Wylosowane liczby to: {liczba1} i {liczba2} ");
            suma = liczba1 + liczba2;

            while (true)
            {
                Console.WriteLine("Podaj wynik dodawania tych dwóch liczb: ");
                podajWynik = Convert.ToInt32(Console.ReadLine());
                
                if (podajWynik != suma)
                {
                    Console.WriteLine("Wynik niepoprawny,sprobuj jeszcze raz");
                }else
                {
                    Console.WriteLine("Brawo!Wynik poprawny");
                    break;
                }
            }

            Console.ReadLine();
        }
        static void Zad2_2()
        {
            //Napisz program, który wczytuje liczbę całkowitą, a następnie na konsolę wypisuje w tylu liniach "choinkę" ze znaków `*`. Np. dla parametru 3 powinno się wypisać:
            //    *
            //  * * *
            //* * * * * 
            int liczbaWierszy;
            Console.WriteLine("Podaj liczbę całkowitą");
            liczbaWierszy = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < liczbaWierszy; i++)
            {
                if (i % 1 == 0)
                {
                    for (int j = 0; j < liczbaWierszy - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("\n");
                }
            }



            Console.ReadLine();
        }
        static void Zad2_3()
        {
            /*Napisz program, który odczytuje od użytkownika wiele liczb.
            Program powinien wyliczyć i na końcu wypisać następujące statystyki:
            - liczba podanych liczb (ile sztuk)
            - suma
            - średnia,
            - minimum
            - maksimum
            NIE używaj funkcji wbudowanych!
            */

            int iloscLiczb,i, liczba;
            Console.Write("Ile chcesz podac liczb?: ");
            iloscLiczb = Convert.ToInt32(Console.ReadLine());
            ArrayList lista = new ArrayList(iloscLiczb); 
            for (i = 0 ; iloscLiczb > i; i++ )
            {
                Console.Write("Podaj liczby( po enterze) ");
                liczba = Convert.ToInt32(Console.ReadLine());
                lista.Add(liczba);

                Console.WriteLine("Ilość wybranych liczb");
                
            }
            
            
            

            Console.ReadLine();

        }
        static void Zad2_4()
        {
            /*Program losuje liczbę z zakresu od 0 do 999. Użytkownik ma zgadnąć tę liczbę nie widząc jej.
             *Kiedy użytkownik poda nieprawidłowy wynik, program podpowiada pisząc czy podana liczba była za duża, czy za mała. 
             *Gdy użytkownik poda właściwą liczbę, program wypisuje gratulacje jednocześnie informując, w której próbie udało się zgadnąć liczbę.
             */
            Random rand = new Random();
            int liczba = rand.Next(999);
            int liczbaUzytkownika,iloscProb;
            iloscProb = 1;

            do
            {
                Console.WriteLine("Zgadnij liczbe w przedziale 0 do 999:");
                liczbaUzytkownika = Convert.ToInt32(Console.ReadLine());

                if(liczbaUzytkownika < liczba)
                {
                    Console.WriteLine("Twoja liczba jest za mala");
                    iloscProb++;
                }
                else if(liczbaUzytkownika > liczba)
                {
                    Console.WriteLine("Twoja liczba jest za duza");
                    iloscProb++;
                }


            }while (liczbaUzytkownika != liczba);
            Console.WriteLine($"Brawo zgadles!, trafiles za: {iloscProb} razem");
            Console.ReadLine();

        }
        
    }   
}
