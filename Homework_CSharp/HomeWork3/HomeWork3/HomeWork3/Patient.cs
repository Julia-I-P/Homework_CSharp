namespace HomeWork3
{
    internal class Patient
    {
        private string _name;
        private string _surname;
        private int _quantityOfTrauma;
        private bool _stateOfMind;
        private string _diagnosis;


        public Patient(string name = "Nikolay", string surname = "Baskov", int quantityOfTrauma = 1,
            bool stateOfMind = true, string diagnosis = "Nothing")
        {
            _name = name;
            _surname = surname;
            _quantityOfTrauma = quantityOfTrauma;
            _stateOfMind = stateOfMind;
            _diagnosis = diagnosis;
        }

        public void SetName(string name) { _name = name; }
        public void SetSurname(string surname) { _surname = surname; }
        public void SetQuantityOfTrauma(int quantityOfTrauma) { _quantityOfTrauma = quantityOfTrauma; }
        public void SetStateOfMind(bool stateOfMind) { _stateOfMind = stateOfMind; }
        public void SetDiagnosis(string diagnosis) { _diagnosis = diagnosis; }
        public string GetName() { return _name; }
        public string GetSurname() { return _surname; }
        public int GetQuantityOfTrauma() { return _quantityOfTrauma; }
        public bool GetStateOfMind() { return _stateOfMind; }
        public string GetDiagnosis() { return _diagnosis; }
    }
}
