using System;

namespace Wages
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Pusti riesenie a vyriesi zadany problem
            Riesenie.Ries();
        }
    }
    /// <summary>
    /// Trieda obsahujuca logiku na vyriesenie problemu
    /// </summary>
    internal class Riesenie
    {
        /// <summary>
        ///     Metoda, ktora spusti riesenie ulohy
        /// </summary>
        public static void Ries()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Platy zamestnancov");
            Console.WriteLine("--------------------");

            Console.WriteLine("Plat pracovnika na hlavny pracovny pomer: {0}",
                new PracovnikNaHlavnyPracovnyPomer().VypocitajMzdu());
            Console.WriteLine("Plat manazera: {0}",
                new Manazer().VypocitajMzdu());
            Console.WriteLine("Plat pracovnika na dohodu: {0}",
                new PracovnikNaDohodu().VypocitajMzdu());
            Console.WriteLine("--------------------");
            Console.ReadLine();
        }
    }

    /// <summary>
    ///     Základná trieda pre zamestnanca, obsahujúca konštanty s pracovnými hodinami a pracovnými dnami v mesiaci
    /// </summary>
    internal abstract class Zamestnanec
    {
        public const int PracHodin = 8, PracDni = 21;

        /// <summary>
        ///     Metoda na výpočet mzdy zamestnanca
        /// </summary>
        /// <returns></returns>
        public abstract double VypocitajMzdu();
    }

    /// <summary>
    ///     Trieda pracovnika na hlavny pracovny pomer, dediacia od zamestnanca, ktorá vypočíta jeho mzdu
    /// </summary>
    internal class PracovnikNaHlavnyPracovnyPomer : Zamestnanec
    {
        public override double VypocitajMzdu()
        {
            return 11 * (PracHodin * PracDni);
        }
    }

    /// <summary>
    ///     Trieda manazera, dediaca od zamestnanca, ktorá vypočíta jeho mzdu
    /// </summary>
    internal class Manazer : Zamestnanec
    {
        public override double VypocitajMzdu()
        {
            return 15 * (PracHodin * (PracDni - 7));
        }
    }

    /// <summary>
    ///     Trieda pracovnika na dohodu, dediaca od zamestnanca, ktorá vypočíta jeho mzdu
    /// </summary>
    internal class PracovnikNaDohodu : Zamestnanec
    {
        public override double VypocitajMzdu()
        {
            return 6 * (PracHodin * PracDni);
        }
    }
}