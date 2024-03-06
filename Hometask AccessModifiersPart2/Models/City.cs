
namespace Hometask_AccessModifiersPart2.Models
{
    internal class City
    {
        private string _name;
        public string Name 
        { 
            get=> _name;
            set
            {
                if (Name.Length > 3 && Name.Length > 20) return;
                foreach (char c in Name)
                    if (!char.IsLetter(c)) return;
                _name = value;
            }
        }
        private int _population;
        public int Population
        {
            get => _population;
            set
            {
                if (Population < 0) return;
            }
        }
    }
    internal class  ChinaCity:City
    {
        

    }
}
