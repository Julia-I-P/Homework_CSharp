namespace HomeWork3
{
    internal class Psychiatrist : Doctor
    {
        public Psychiatrist(string name = "Valeriy", string surname = "Meladze", int age = 50,
            int workExp = 25, string specialization = "Samba belogo motylka") : base(name, surname, age, workExp, specialization) { }

        public override void ToSetDiagnosis(Patient patient)
        {
            if (patient.GetStateOfMind() == true)
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}:Well, you`re a healthy one... Get out, don`t waste my time.");
                patient.SetDiagnosis("Nothing");
            }
            else
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} setted a diagnosis");
                patient.SetDiagnosis("Twilight state");
            }
        }

        public override void Cure(Patient patient)
        {
            if (patient.GetDiagnosis() == "Twilight state")
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} gives some Galoperidol to patient.");
                Random random = new Random();
                if (random.Next(1, 5) == 1)
                {
                    Console.WriteLine("The patient is healthy now!");
                    patient.SetStateOfMind(true);
                    patient.SetDiagnosis("Nothing");
                }
                else
                {
                    Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}:Jesus Christe, you`re still ill!!!");
                }
            }
            else
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}:Well, you`re a healthy one... Get out, don`t waste my time.");
            }
        }
    }
}
