namespace Hometask_AccessModifiersPart2.Models
{
    internal class City
    {
        string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 3 && value.Length > 20) return;
                foreach (char c in value)
                    if (!char.IsLetter(c)) return;
                _name = value;
            }
        }
        protected int _population;
        public virtual int Population
        {
            get => _population;
            set
            {
                if (value > 0) _population = value;
            }
        }
    }
    internal class ChinaCity : City
    {
        public override int Population
        {
            get => _population;
            set
            {
                if(value>100000) _population=value;
            }
        }
    }
}
