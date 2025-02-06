namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ProcessorCount = Environment.ProcessorCount;
            long WorkingSet = Environment.WorkingSet;
            string MachineName = Environment.MachineName;
            bool is64OperatingSystem = Environment.Is64BitOperatingSystem;
            string UserName = Environment.UserName;
            Console.WriteLine($"Systeeminformatie voor {UserName} op {MachineName}:\r\n---------------------------------------------------\r\n    Aantal processors: {ProcessorCount}\r\n    64-bit besturingssysteem: {is64OperatingSystem}\r\n    Huidige geheugengebruik: {WorkingSet}\r\n---------------------------------------------------");
        }
    }
}
