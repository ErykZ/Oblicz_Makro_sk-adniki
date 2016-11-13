using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblicz_Makro_składniki
{
    public class Brain
    {
        double waga, wzrost, wiek, wynik, wynik2, CPM, Bialko, Weglowodany, Tluszcze, KoncowyWynik;
        string płeć, ak, rodzaj_budowy_ciala, cel;
        double[] mnoznik_aktywnosci = { 1.0, 1.2, 1.4, 1.6, 1.8, 2.0 };
        string kolor;

        public bool ustaw_wage(string _waga)
        {
            bool Is_Success = false;
            try
            {
                Waga = Convert.ToDouble(_waga);
                Is_Success = true;
            }
            catch (Exception e)
            {
                Is_Success = false;
            }

            return Is_Success;

        }

        public bool ustaw_wzrost(string _wzrost)
        {
            bool Is_Success = false;
            try
            {
                wzrost = Convert.ToDouble(_wzrost);
                Is_Success = true;
            }
            catch (Exception e)
            {
                Is_Success = false;
            }

            return Is_Success;
        }

        public bool ustaw_wiek(string _wiek)
        {
            bool Is_Success = false;
            try
            {
                wiek = Convert.ToDouble(_wiek);
                Is_Success = true;
            }
            catch (Exception e)
            {
                Is_Success = false;
            }

            return Is_Success;
        }

        /*public void Ustaw_płeć(string _płeć)
        {
            płeć = _płeć;
        }

        public string Zwroc_płeć()
        {
            return płeć;
        }*/

        public string Płeć
        {
            get
            {
                return płeć;
            }
            set
            {
                płeć = value;
            }
        }

        public double Waga
        {
            get
            {
                return waga;
            }

            set
            {
                waga = value;
            }
        }

        public void pobierz_stringi(string _waga, string _wzrost, string _wiek, string _płeć)
        {
            try
            {
                Waga = Convert.ToDouble(_waga);
                wzrost = Convert.ToDouble(_wzrost);
                wiek = Convert.ToDouble(_wiek);
            }

            catch (Exception e)
            {
                Console.WriteLine("");
            }
        }

        public void Ustaw_wynik(double _wynik)
        {
            wynik = _wynik;
        }

        public double Zwroc_wynik()
        {
            wynik = 66.47 + (13.75 * Waga) + (5 * wzrost) - (6.75 * wiek);
            return wynik;
        }

        public double Zwroc_wynik2()
        {
            wynik2 = 665.09 + (9.56 * Waga) + (1.85 * wzrost) - (4.67 * wiek);
            return wynik2;
        }

        public void Ustaw_ak(string _ak)
        {
            ak = _ak;
        }

        public string Zwroc_ak()
        {
            return ak;
        }

        public double Zwroc_CalkowitaPrzeminaMaterii(int _ak2)
        {
            int index_tablicy = _ak2 - 1;
            if (wynik > wynik2)
            {
                CPM = wynik * mnoznik_aktywnosci[index_tablicy];
                return CPM;
            }
            else
            {
                CPM = wynik2 * mnoznik_aktywnosci[index_tablicy];
                return CPM;
            }
        }

        public void Ustaw_rodzaj_budowy_ciala(string _rodzaj_budowy_ciala)
        {
            rodzaj_budowy_ciala = _rodzaj_budowy_ciala;
        }

        public string Zwroc_rodzaj_budowy_ciala()
        {
            return rodzaj_budowy_ciala;
        }

        public void Ustaw_cel(string _cel)
        {
            cel = _cel;
        }

        public string Zwroc_cel()
        {
            return cel;
        }
        
        public double Zwroc_ostateczny_wynik_kcal(int _rodzaj_budowy_ciala2, int _cel2, int _ak2)
        {
            CPM = Zwroc_CalkowitaPrzeminaMaterii(_ak2);
            if (_rodzaj_budowy_ciala2 == 1)
            {
                if (_cel2 == 1)
                {
                    KoncowyWynik = CPM + (0.2 * CPM);
                    return KoncowyWynik;
                }
                else if (_cel2 == 3)
                {
                    KoncowyWynik = CPM - (0.1 * CPM);
                    return KoncowyWynik;
                }
                else
                {
                    KoncowyWynik = CPM;
                    return KoncowyWynik;
                }
            }
            else if (_rodzaj_budowy_ciala2 == 2)
            {
                if (_cel2 == 1)
                {
                    KoncowyWynik = CPM + (0.15 * CPM);
                    return KoncowyWynik;
                }
                else if (_cel2 == 3)
                {
                    KoncowyWynik = CPM - (0.15 * CPM);
                    return KoncowyWynik;
                }
                else
                {
                    KoncowyWynik = CPM;
                    return KoncowyWynik;
                }
            }
            else
            {
                if (_cel2 == 1)
                {
                    KoncowyWynik = CPM + (0.1 * CPM);
                    return KoncowyWynik;
                }
                else if (_cel2 == 3)
                {
                    KoncowyWynik = CPM - (0.2 * CPM);
                    return KoncowyWynik;
                }
                else
                {
                    KoncowyWynik = CPM;
                    return KoncowyWynik;
                }
            }
        }
        

       public void Ustaw_Bialko(double _Bialko)
        {
            Bialko = _Bialko;
        }

        public double Zwroc_Bialko(int _ak2)
        {
            int index_tablicy = _ak2 - 1;
            if (index_tablicy <= 1)
            {
                Bialko = 1.2 * Waga;
                return Bialko;
            }
            else if (index_tablicy <= 3)
            {
                Bialko = 1.6 * Waga;
                return Bialko;
            }
            else
            {
                Bialko = 2 * Waga;
                return Bialko;
            }
            
        }

        public void Ustaw_Weglowodany(double _Weglowodany)
        {
            Weglowodany = _Weglowodany;
        }

        public double Zwroc_Weglowodany()
        {
            Weglowodany = (0.60 * CPM) / 4;
            return Weglowodany;
        }

        public void Ustaw_Tluszcze(double _Tluszcze)
        {
            Tluszcze = _Tluszcze;
        }

        public double Zwroc_Tluszcze()
        {
            Tluszcze = (0.25 * CPM) / 9;
            return Tluszcze;
        }

    }
}
