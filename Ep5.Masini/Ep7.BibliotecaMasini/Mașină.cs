using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ep7.BibliotecaMasini
{
    public class Changeable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Mașină : Changeable, INotifyPropertyChanged
    {
        public Mașină()
        {
            Parcursuri = new ObservableCollection<Parcurs>();
        }

        public string Nume { get; set; }

        private ObservableCollection<Parcurs> parcursuri;
        public ObservableCollection<Parcurs> Parcursuri
        {
            get { return parcursuri; }
            set
            {
                if (parcursuri != null)
                {
                    parcursuri.CollectionChanged -= Parcursuri_CollectionChanged;
                    RemovePropertyChangeHandlers(parcursuri);
                }
                parcursuri = value;
                if (parcursuri != null)
                {
                    AddPropertyChangeHandlers(parcursuri);
                    parcursuri.CollectionChanged += Parcursuri_CollectionChanged;
                }
            }
        }

        private void Parcursuri_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                AddPropertyChangeHandlers(e.NewItems);
            if (e.OldItems != null)
                RemovePropertyChangeHandlers(e.OldItems);
            OnPropertyChanged(nameof(DistanțaTotală));
        }

        private void AddPropertyChangeHandlers(IEnumerable parcursuri)
        {
            foreach (Parcurs p in parcursuri)
                p.PropertyChanged += Parcurs_PropertyChanged;
        }
        private void RemovePropertyChangeHandlers(IEnumerable parcursuri)
        {
            foreach (Parcurs p in parcursuri)
                p.PropertyChanged -= Parcurs_PropertyChanged;
        }

        private void Parcurs_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(DistanțaTotală));
        }

        public double DistanțaTotală => Parcursuri.Sum(p => p.Distanță);
    }

    public class Parcurs : Changeable, INotifyPropertyChanged
    {
        private double timp;
        public double Timp
        {
            get { return timp; }
            set
            {
                timp = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Distanță));
            }
        }

        private double viteză;
        public double Viteză
        {
            get { return viteză; }
            set
            {
                viteză = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Distanță));
            }
        }

        public double Distanță => Timp * Viteză;
    }
}
