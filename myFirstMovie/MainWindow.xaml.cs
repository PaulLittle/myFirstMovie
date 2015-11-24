using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace myFirstMovie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> screenings = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            screenings.Add(new Movie()
            {
                Title = "The Lord of The Rings",
                Cast = new ObservableCollection<Actor>() {
                    new Actor() { Name = "Elijah Woods", DOB = new DateTime(1988,01,28)},
                    new Actor() { Name = "Christopher Lee", DOB = new DateTime(1650,05,27)},
                    new Actor() { Name = "Viggo Mortenson", DOB = new DateTime(1958,10,20)},
                    new Actor() { Name = "Ian McKellan"},
                    new Actor() { Name = "Orlando Bloom", DOB = new DateTime(1977,01,13)},
                    new Actor() { Name = "Cate Blanchett", DOB = new DateTime(1969,05,14)},
                    new Actor() { Name = "Liv Tyler", DOB = new DateTime(1977,07,01) },
                    new Actor()}
            });
            screenings.Add(new Movie()
            {
                Title = "Star Wars",
                Cast = new ObservableCollection<Actor>() {
                    new Actor() { Name = "Harison Ford", DOB = new DateTime(1942,07,13) },
                    new Actor() { Name = "Mark Hamill", DOB = new DateTime(1951,09,25) },
                    new Actor() { Name = "Carrie Fisher", DOB = new DateTime(1956,10,21) },
                    new Actor() }
            });

            lbxMovies.ItemsSource = screenings;

            if (screenings.Count != 0)
            {
                lbxMovies.SelectedIndex = 0;
            }

            foreach (Movie mov in screenings)
            {
                //movieCounter++;
                
            }
            tbkStats.Text = String.Format("{0} Movies with {1} Actors", Movie.MovieCounter, Actor.ActorCounter);

        }

        private void lbxMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selMovie = lbxMovies.SelectedItem as Movie;
            lbxCast.ItemsSource = selMovie.Cast;
        }
    }  // end manWindow class
}  // end ns
