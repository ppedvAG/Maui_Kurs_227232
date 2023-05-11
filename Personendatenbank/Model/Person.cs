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

        //Lab 10
        public static ObservableCollection<Person> PersonList { get; set; } = new ObservableCollection<Person>()
        {
            new Person(){ Name = "Anna Nass", Gender=Gender.Weiblich, IsMarried = true, Birthdate=new DateTime(2003, 12, 3) },
        };
    }
}
