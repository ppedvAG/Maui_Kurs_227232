using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.ViewModel
{
    internal class ListViewModel
    {
        public ObservableCollection<Model.Person> PersonList
        {
            get { return Model.Person.PersonList; }
        }

        public Command DeleteCmd { get; set; } = new Command
            (
                p =>
                {
                    Model.Person.PersonList.Remove(p as Model.Person);
                },
                p => p is Model.Person
            );
    }
}
