using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Bindings
{
    internal class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateGui() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));


        public ObservableCollection<DateTime> WichtigeTage { get; set; } = new ObservableCollection<DateTime>()
        {
            DateTime.Now,
            new DateTime(2002, 12, 1),
            new DateTime(1999, 2, 23),
        };

    }
}
