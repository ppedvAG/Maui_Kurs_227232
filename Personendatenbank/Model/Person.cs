using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.Model
{
    internal class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name { get => name; set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))); } }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public bool IsMarried { get; set; }

        public Person()
        {
            Birthdate = DateTime.Now;

            Gender = Gender.Weiblich;
        }

    }
}
