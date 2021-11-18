using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set
            {
                listaPlatos = value;
                this.NotifyPropertyChanged("ListaPlatos");
            }
        }

        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples("FotosPlatos/");
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                this.NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

    }
}
