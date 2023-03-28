namespace HomeWork3
{
    internal class Doctor
    {
        private string _name;
        private string _surname;
        private int _age;
        private int _workExp;
        private string _specialization;

        public Doctor(string name = "Филипп", string surname = "Киркоров", int age = 80,
            int workExp = 50, string specialization = "Эндогенные психозы")
        {
            _name = name;
            _surname = surname;
            _age = age;
            _workExp = workExp;
            _specialization = specialization;
        }

        public void SetName(string name) { _name = name; }
        public void SetSurname(string surname) { _surname = surname; }
        public void SetAge(int age) { _age = age; }
        public void SetWorkExp(int workExp) { _workExp = workExp; }
        public void SetSpecialization(string specialization) { _specialization = specialization; }

        public string GetName() { return _name; }
        public string GetSurname() { return _surname; }
        public int GetAge() { return _age; }
        public int GetWorkExp() { return _workExp; }
        public string GetSpecialization() { return _specialization; }

        public virtual void ToSetDiagnosis(Patient patient) { }
        public virtual void Cure(Patient patient) { }

    }
}
