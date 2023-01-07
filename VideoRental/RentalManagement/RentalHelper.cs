using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.RentalManagement.RentalMenu;
using VideoRental.Users;

namespace VideoRental.RentalManagement
{
    internal static class RentalHelper
    {
        internal static void InitializeRentalPredefinedData(Rental rental)
        {
            RentalHelper.InitializePredefinedMoviesList(rental);
            RentalHelper.InitializeStartupCollection(rental);
            RentalHelper.InitializePredefinedUsers(rental);
        }

        private static void InitializePredefinedMoviesList(Rental rental)
        {
            rental.AddMovie(new BluRayMovie("Garfild", 2));
            rental.AddMovie(new BluRayMovie("Pamiętnik", 5));
            rental.AddMovie(new BluRayMovie("Need For Speed", 3));
            rental.AddMovie(new BluRayMovie("Skazani na Shawshank", 3));
            rental.AddMovie(new DvdMovie("Za szybko za wściekle", 3));
            rental.AddMovie(new DvdMovie("Harry Potter - Kamień Filozoficzny", 5));
            rental.AddMovie(new DvdMovie("Harry Potter - Komnata Tajemnic", 5));
            rental.AddMovie(new VhsMovie("Once Upon a Time in the West", 3));
            rental.AddMovie(new VhsMovie("The Godfather", 7));
            rental.AddMovie(new VhsMovie("The Godfather II", 5));
            rental.AddMovie(new VhsMovie("12 Angry Men", 4));
            rental.AddMovie(new StreamingMovie("Intouchables"));
            rental.AddMovie(new StreamingMovie("Inception"));
            rental.AddMovie(new StreamingMovie("Green Book"));
            rental.AddMovie(new StreamingMovie("Zootopia"));

            MoviePhisical x = new VhsMovie("12 Angry Men", 4);
            rental.AddMovie(x);
        }

        private static void InitializeStartupCollection(Rental rental)
        {
            rental.AddMovieToStartupCollection("Garfild");
            rental.AddMovieToStartupCollection("The Godfather");
        }

        private static void InitializePredefinedUsers(Rental rental)
        {
            rental.AddUser(RentalUserType.StandardUser, "Maciej Zwyczajny", "haslo3", 92111212345);
            rental.AddUser(RentalUserType.PremiumUser, "Pawel", "haslo", 12345678901);
            rental.AddUser(RentalUserType.PremiumUser, "Andrzej Kaganek", "haslo", 85070712345);
            rental.AddUser(RentalUserType.PremiumUser, "Jan Kowalski", "haslo1", 87020312345);
            rental.AddUser(RentalUserType.PremiumUser, "Arnold Nowak", "haslo2", 98050312345);
        }
    }
}
