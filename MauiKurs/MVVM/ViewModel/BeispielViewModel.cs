using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.MVVM.ViewModel
{
    public class BeispielViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model.PKW> PkwListe
        {
            get { return Model.PKW.PKWListe; }
            set { Model.PKW.PKWListe = value; }
        }

        private string hersteller = String.Empty;

        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; HinzufügenCmd.ChangeCanExecute(); }
        }

        private int maxGeschwindigkeit;

        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
            set { maxGeschwindigkeit = value; HinzufügenCmd.ChangeCanExecute(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime baujahr;

        public DateTime Baujahr
        {
            get { return baujahr; }
            set { baujahr = value; }
        }

        public Command HinzufügenCmd { get; set; }
        public Command LöschenCmd { get; set; }
        public Command UpdateCmd { get; set; }

        public BeispielViewModel()
        {
            HinzufügenCmd = new Command
                (
                    () =>
                    {
                        Model.PKW neuerPKW = new Model.PKW() { Hersteller = Hersteller, MaxGeschwindigkeit = MaxGeschwindigkeit, Baujahr = Baujahr };
                    
                        PkwListe.Add(neuerPKW );

                        Hersteller = String.Empty;
                        MaxGeschwindigkeit = 0;
                        Baujahr = new DateTime();

                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
                    },
                    () =>
                    {
                        return !Hersteller.Equals(String.Empty) && MaxGeschwindigkeit > 0;
                    }
                );

            LöschenCmd = new Command
                (
                    p =>
                    {
                        PkwListe.Remove((p as ListView).SelectedItem as Model.PKW);
                        (p as ListView).ClearValue(ListView.SelectedItemProperty);
                        LöschenCmd.ChangeCanExecute();
                    },
                    p => ((p as ListView).SelectedItem as Model.PKW) != null
                );

            UpdateCmd = new Command(() => LöschenCmd.ChangeCanExecute());
        }


    }
}
