namespace HomeWork5.App2
{
    internal class Record
    {
        private string _type;
        private string _name;
        private DateTime _dateOfChange;

        public Record(string type, string name, string dateOfChange)
        {
            _type = type;
            _name = name;
            _dateOfChange = DateTime.Parse(dateOfChange);
        }
        public void SetType(string type) { _type = type; }
        public void SetName(string name) { _name = name; }
        public void SetDateOfChange(string dateOfChange) { _dateOfChange = DateTime.Parse(dateOfChange); }
        public string GetType() { return _type; }
        public string GetName() { return _name; }
        public DateTime GetDateOfChange() { return _dateOfChange; }
    }
}
