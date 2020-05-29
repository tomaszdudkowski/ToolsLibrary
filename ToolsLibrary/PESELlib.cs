using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Biblioteka PESEL
    /// Autor: Tomasz Dudkowski
    /// </summary>
    public static class PESELlib
    {
        private static CultureInfo CulturePL = new System.Globalization.CultureInfo("pl-PL");

        public static int ZwrocRokUrodzenia(dynamic a, dynamic b, dynamic c)
        {
            string rok = null;

            if (c == 8 || c == 9)
            {
                rok = "18" + a + b;
            }
            else if (c == 0 || c == 1)
            {
                rok = "19" + a + b;
            }
            else if (c == 2 || c == 3)
            {
                rok = "20" + a + b;
            }
            else if (c == 4 || c == 5)
            {
                rok = "21" + a + b;
            }
            else if (c == 6 || c == 6)
            {
                rok = "22" + a + b;
            }
            int _intRok = Int32.Parse(rok);
            return _intRok;
        }

        public static int ZwrocMiesiacUrodzenia(dynamic a, dynamic b)
        {
            if (a == 0 || a == 2 || a == 4 || a == 6 || a == 8)
            {
                a = 0;
            }
            else if (a == 9 || a == 3 || a == 5 || a == 7)
            {
                a = 1;
            }

            string _temp = a.ToString();
            _temp = _temp + b.ToString();
            int valueMiesiac = Int32.Parse(_temp);
            return valueMiesiac;
        }

        public static DateTime ZwrocDzienUrodzenia(int rok, int miesiac, dynamic a, dynamic b)
        {
            string _temp = a.ToString();
            _temp = _temp + b.ToString();
            int dzien = Int32.Parse(_temp);
            DateTime dateTime = new DateTime(rok, miesiac, dzien);
            return dateTime;
        }

        public static string NazwaDniaTygodnia(DateTime dateTime)
        {
            string TextValue = CulturePL.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return TextValue;
        }

        public static string NazwaMiesiaca(int valueMiesiac)
        {
            string TextValue = CulturePL.DateTimeFormat.GetMonthName(valueMiesiac);
            return TextValue;
        }

        public static string Plec(params dynamic[] args)
        {

            string _temp = "";
            string plec;
            foreach (dynamic item in args)
            {
                _temp = _temp + item.ToString();
            }
            int liczba = Int32.Parse(_temp);
            if (liczba % 2 == 0)
            {
                plec = "Kobieta";
            }
            else
            {
                plec = "Mężczyzna";
            }
            return plec;
        }

        public static bool SumaKontrolna(int[] a)
        {
            // 1 3 7 9 1 3 7 9 1 3
            int wynik = a[0] * 1 + a[1] * 3 + a[2] * 7 + a[3] * 9 + a[4] * 1 + a[5] * 3 + a[6] * 7 + a[7] * 9 + a[8] * 1 + a[9] * 3;

            bool kontrola = false;
            wynik = wynik % 10;
            wynik = 10 - wynik;
            wynik = wynik % 10;
            if (wynik == a[10])
            {
                kontrola = true;
            }
            return kontrola;
        }

        public static int GenerujSumeKontrolna(int[] a)
        {
            int wynik = a[0] * 1 + a[1] * 3 + a[2] * 7 + a[3] * 9 + a[4] * 1 + a[5] * 3 + a[6] * 7 + a[7] * 9 + a[8] * 1 + a[9] * 3;

            wynik = wynik % 10;
            wynik = 10 - wynik;
            wynik = wynik % 10;

            return wynik;
        }
    }
}
