using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstMovie
{
    class Movie
    {
        private string _title;
        public string Title { get { return _title; } set { _title = value; } }

        public override string ToString()
        {
            return _title;
        }

        private ObservableCollection<Actor> _cast;
        public ObservableCollection<Actor> Cast { get { return _cast; } set { _cast = value; } }
    }
}
