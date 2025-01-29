namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ProcessorCount = 8;
            string WorkingSet = "23.00 MB (0.02 GB)";
            string MachineName = "damsPowahPC";
            string is64OperatingSystem = "True";
            string UserName = "admin";
            Console.WriteLine($"Systeeminformatie voor {UserName} op {MachineName}:\r\n---------------------------------------------------\r\n    Aantal processors: {ProcessorCount}\r\n    64-bit besturingssysteem: {is64OperatingSystem}\r\n    Huidige geheugengebruik: {WorkingSet}\r\n---------------------------------------------------");
        }
    }
}
