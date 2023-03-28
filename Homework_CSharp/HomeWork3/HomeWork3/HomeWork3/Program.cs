using System.Numerics;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patientShiza = new Patient("Dima", "Bilan", 0, false);
            Patient patientTrauma = new Patient("Sergey", "Lazarev", 9, true);
            Patient patientTrauma2 = new Patient("Vlad", "Topalov", 13, true);

            Doctor[] doctors = new Doctor[2];
            Traumatologist traumatologist = new Traumatologist();
            doctors[0] = traumatologist;
            Psychiatrist psychiatrist = new Psychiatrist();
            doctors[1] = psychiatrist;

            Console.WriteLine($"Patient {patientShiza.GetName()} {patientShiza.GetSurname()} started a treatment.");
            doctors[1].ToSetDiagnosis(patientShiza);
            doctors[1].Cure(patientShiza);
            Console.WriteLine("");

            Console.WriteLine($"Patient {patientTrauma.GetName()} {patientTrauma.GetSurname()} started a treatment.");
            doctors[0].ToSetDiagnosis(patientTrauma);
            doctors[0].Cure(patientTrauma);
            Console.WriteLine("");

            Console.WriteLine($"Patient {patientTrauma2.GetName()} {patientTrauma2.GetSurname()} started a treatment.");
            doctors[0].ToSetDiagnosis(patientTrauma2);
            doctors[0].Cure(patientTrauma2);
            Console.WriteLine("");
        }
    }
}