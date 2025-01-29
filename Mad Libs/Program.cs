namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();

            Console.Write("Geef een adjectief: ");
            string adjectief = Console.ReadLine();

            Console.Write("Geef een zelfstandig naamwoord: ");
            string zelfstandigNaamwoord = Console.ReadLine();

            Console.Write("Geef een werkwoord: ");
            string werkwoord = Console.ReadLine();

            Console.WriteLine("Op een dag ging " + naam + " naar de AP Hogeschool. Hij zag daar een " + adjectief +" "+ zelfstandigNaamwoord + "en vond dat zo grappig dat hij begon te " + werkwoord + ".");

        }
    }
}
