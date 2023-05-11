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
    //Im ViewModel-Teil eines MVVM-Programms werden Klassen definiert, welche als Verbindungsstück zwischen den Views und den Modelklassen fungieren.
    //Diese Klassen sind die einzigen Programmteile, welche Referenzen auf Model-Klassen beinhalten. Sie selbst sind jeweils einem View zugrordnet,
    //mit welchem sie (nur) über den BindingContext des jeweiligen Views verbunden sind.
    //INotifyPropertyChanged informiert die GUI über Veränderungen in den Daten
    public class BeispielViewModel : INotifyPropertyChanged
    {
        //Property zur Repräsentation der Anzahl der geladenen Personen (verlinkt an die Model-Klasse)
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

        //Command-Properties
        public Command HinzufügenCmd { get; set; }
        public Command LöschenCmd { get; set; }
        public Command UpdateCmd { get; set; }

        public BeispielViewModel()
        {
            HinzufügenCmd = new Command
                (

                   //Execute-Methode des Commands (Definiert, was das Command bei Ausführung tut)
                   () =>
                    {
                        Model.PKW neuerPKW = new Model.PKW() { Hersteller = Hersteller, MaxGeschwindigkeit = MaxGeschwindigkeit, Baujahr = Baujahr };
                    
                        PkwListe.Add(neuerPKW );

                        Hersteller = String.Empty;
                        MaxGeschwindigkeit = 0;
                        Baujahr = new DateTime();

                        //Aufruf des PropertyChanged-Events zur Benachrichtigung der GUI über Veränderungen
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
                    },
                    //CanExecute-Methode des Commands (Definiert, wann das Command ausgeführt werden darf)
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
