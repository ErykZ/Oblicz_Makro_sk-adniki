using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblicz_Makro_składniki
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Brain oblicz = new Brain();

            Console.WriteLine("Hi, please provide your weight: ");
            string waga = Console.ReadLine();
            bool waga2 = oblicz.ustaw_wage(waga);
            if (waga2 == false)
            {
                Console.WriteLine("To nie jest liczba");
            }
            Console.WriteLine("\nthanks \nNow please provide your height (in cm): ");
            string wzrost = Console.ReadLine();
            bool wzrost2 = oblicz.ustaw_wzrost(wzrost);
            if (wzrost2 == false)
            {
                Console.WriteLine("To nie jest liczba");
            }
            Console.WriteLine("\nthanks \nNow please provide your age: ");
            string wiek = Console.ReadLine();
            bool wiek2 = oblicz.ustaw_wiek(wiek);
            if (wiek2 == false)
            {
                Console.WriteLine("To nie jest liczba");
            }
            
            Console.WriteLine("\nplease provide your sex: male [1] or female [2] ");
            string płeć = Console.ReadLine();

            int płeć2 = Convert.ToInt32(płeć);
            oblicz.pobierz_stringi(waga, wzrost, wiek, płeć2);
            if (płeć2 == 1)
            {
                Console.WriteLine("Your energy requirements is: " + oblicz.Zwroc_wynik() + "kcal");
            }
            else if (płeć2 == 2)
            {
                Console.WriteLine("Your energy requirements is: " + oblicz.Zwroc_wynik2() + "kcal");
            }
            else
            {
                Console.WriteLine("Podałeś/aś nieprawidłowe dane");
            }
            Console.WriteLine("\nProsze określić swoją aktywność fizyczną w ciągu dnia w skali od 1 do 6,");
            Console.Write("1 oznacza leżący bądź siedzący tryb życia, brak aktywności fizycznej \n2 praca siedząca, aktywność fizyczna na niskim poziomie \n3 praca nie fizyczna, trening 2 razy w tygodniu \n4 lekka praca fizyczna, trening 3-4 razy w tygodniu \n5 praca fizyczna, trening 5 razy w tygodniu \n6 ciężka praca fizyczna, codzienny trening:\n");
            string ak = Console.ReadLine();
            int ak2 = Convert.ToInt32(ak);
            if (ak2 > 6)
            {
                Console.WriteLine("Podałeś inną liczbę niż z zakresu od 1 do 6");
                Console.ReadLine();
            }
            
            Console.WriteLine("\nOkreśl swój somatotyp:\nEktomorfik [1] bardzo niski poziom tkanki tłuszczowej, bardzo małe mięśnie, szczupłe ramiona, płaska klatka piersiowa, określenie sylwetki – patyk" + "\nMezomorfik [2] niski poziom tkanki tłuszczowej, szerokie barki, wąska talia, wyraźnie widoczne mięśnie, określenie sylwetki – atletyczna" + "\nEndomorfik [3] wysoki poziom tkanki tłuszczowej, bardzo łatwo przybiera masy mięśniowej oraz masy tłuszczowej, określenie sylwetki – owalna");
            string rodzaj_budowy_ciala = Console.ReadLine();
            int rodzaj_budowy_ciala2 = Convert.ToInt32(rodzaj_budowy_ciala);
            if (rodzaj_budowy_ciala2 > 3)
            {
                Console.WriteLine("Podałeś inną liczbę niż z zakresu od 1 do 3");
                Console.ReadLine();
            }
            Console.WriteLine("\nOkreśl swój cel:\n[1] zwiększenie masy ciała \n[2] utrzymanie masy ciała \n[3] redukcja masy ciała");
            string cel = Console.ReadLine();
            int cel2 = Convert.ToInt32(cel);
            if (cel2 > 3)
            {
                Console.WriteLine("Podałeś inną liczbę niż z zakresu od 1 do 3");
                Console.ReadLine();
            }
            Console.WriteLine("Twój ostateczny bilans kaloryczny wynosi: " + oblicz.Zwroc_ostateczny_wynik_kcal(rodzaj_budowy_ciala2, cel2, ak2));

            Console.WriteLine("\nPrzykładowe zapotrzebowanie dzienne na białko uwzglednijąc plany na mase ciała wynosi: " + oblicz.Zwroc_Bialko(ak2) + "g");
            Console.WriteLine("\nPrzykładowe zapotrzebowanie dzienne na węglowodany uwzglednijąc plany na mase ciała wynosi: " + oblicz.Zwroc_Weglowodany() + "g");
            Console.WriteLine("\nPrzykładowe zapotrzebowanie dzienne na tłuszcze uwzglednijąc plany na mase ciała wynosi: " + oblicz.Zwroc_Tluszcze() + "g");

            Console.ReadLine();
        }
    }
}
