namespace HomeWork3
{
    internal class Traumatologist : Doctor
    {
        public Traumatologist(string name = "Philipp", string surname = "Kirkorov", int age = 80,
            int workExp = 50, string specialization = "Fractures") : base(name, surname, age, workExp, specialization) { }

        public override void ToSetDiagnosis(Patient patient)
        {
            if (patient.GetQuantityOfTrauma() > 0 && patient.GetQuantityOfTrauma() < 10)
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} setted a diagnosis.");
                patient.SetDiagnosis("Fracture(s)");
            }
            else
            {
                if (patient.GetQuantityOfTrauma() > 10)
                {
                    Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} setted a diagnosis.");
                    patient.SetDiagnosis("Multiple fractures. Hospitalization");
                }
                else
                {
                    Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}:I don`t know how to cure this." +
                        $" Go to another doctor.");
                }
            }
        }

        public override void Cure(Patient patient)
        {
            if (patient.GetDiagnosis() == "Fracture(s)")
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} setted a plantain leafs.");
            }
            else
            {
                if (patient.GetDiagnosis() == "Multiple fractures. Hospitalization")
                {
                    Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}: Wow, dude...how did you survived?");
                    Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()} setted a multiple plantain leafs and smeard a \"Zvezdochka\" balm.");
                }
                else
                {
                    Console.WriteLine("Well, you`re a healthy one... Get out, don`t waste my time.");
                    return;
                }
            }
            Random random = new Random();
            if (random.Next(1, 3) == 1)
            {
                Console.WriteLine("The patient is healthy now!");
                patient.SetQuantityOfTrauma(0);
                patient.SetDiagnosis("Nothing");
            }
            else
            {
                Console.WriteLine($"Doctor {this.GetName()} {this.GetSurname()}:Jesus Christe, you`re still ill!!!");
            }
        }
    }
}
