using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    public delegate void PropertyEventHandler(object sender, Man e);
    public class Man : IPropertyChanged
    {
        public string Name { get; set; } = "Oleg";
        public bool isHandsome;
        public bool IsHandsome { get
            {
                return isHandsome;
            }
            set
            {
                PropertyChanged?.Invoke(Name, this);
                isHandsome = value;
            }
        }

        public event PropertyEventHandler PropertyChanged;
    }
}
