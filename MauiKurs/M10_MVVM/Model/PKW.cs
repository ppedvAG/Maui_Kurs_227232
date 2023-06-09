﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.MVVM.Model
{
    public class PKW
    {
        //Der Model-Teil beinhaltet alle Modelklassen und Klassen, welche nur mit diesen interagieren.
        //Keine Model-Klasse darf einen Referenz auf den ViewModel- oder den Model-Teil beinhalten
        public static ObservableCollection<PKW> PKWListe { get; set; } = new ObservableCollection<PKW>
        {
            new PKW(){Hersteller="Audi", MaxGeschwindigkeit=300, Baujahr = new DateTime(2002, 1, 1)}
        };


        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public DateTime Baujahr { get; set; }


        public override string ToString()
        {
            return $"{Hersteller} ({MaxGeschwindigkeit} km/h) {Baujahr.ToString()}";
        }
    }
}
