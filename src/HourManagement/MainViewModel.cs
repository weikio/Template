using System.Threading.Tasks;
using Caliburn.Micro;

namespace HourManagement
{
    public class MainViewModel : Screen
    {
        private string _name;
    
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyOfPropertyChange();
            }
        }

        public MainViewModel()
        {
            Name = "Ei tallennettu";
        }

        public void Test()
        {
            Name = "Muutettu";
        }
    }
}
