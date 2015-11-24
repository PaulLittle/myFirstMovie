using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstMovie
{
    public class Movie
    {
        private static int _movieCounter;
        public static int MovieCounter { get { return _movieCounter; } set { _movieCounter = value; } }


        private string _title;
        public string Title { get { return _title; } set { _title = value; } }

        public override string ToString()
        {
            return _title;
        }

        public Movie():this("Another Film", null)
        {}

        public Movie(string theTitle, ObservableCollection<Actor> theCast)
        {
            MovieCounter++;            
            Title = theTitle;
            Cast = theCast;
        }

        private ObservableCollection<Actor> _cast;
        public ObservableCollection<Actor> Cast { get { return _cast; } set { _cast = value; } }
    }
}
