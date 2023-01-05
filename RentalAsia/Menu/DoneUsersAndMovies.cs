using RentalAsia.RentalMovies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.Menu
{
    public class DoneUsersAndMovies
    {

        static void RentalMovies(Rental wypozyczalnia)
        {
            wypozyczalnia.AddMovie(new BluRayMovie("Garfild", 2));
            wypozyczalnia.AddMovie(new BluRayMovie("Pamiętnik", 5));
            wypozyczalnia.AddMovie(new BluRayMovie("Need For Speed", 3));
            wypozyczalnia.AddMovie(new BluRayMovie("Skazani na Shawshank", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Za szybko za wściekle", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Kamień Filozoficzny", 5));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Komnata Tajemnic", 5));
            wypozyczalnia.AddMovie(new VhsMovie("Once Upon a Time in the West", 3));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather", 7));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather II", 5));
            wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            wypozyczalnia.AddMovie(new StreamingMovie("Intouchables"));
            wypozyczalnia.AddMovie(new StreamingMovie("Inception"));
            wypozyczalnia.AddMovie(new StreamingMovie("Green Book"));
            wypozyczalnia.AddMovie(new StreamingMovie("Zootopia"));
        }

        static void UserList(UserData nameUser)
        {
            nameUser.AddUser(new UserData("Mieciu", " Mieczysław", "Kowalski", " 12.12.1956", "mieciu123@gmail.com"));//, "AlaMaKota123");
            nameUser.AddUser(new UserData("Maniek", " Stasiek", " Leniuch", " 22.12.1956", "stasiek123@gmail.com"));//, "AlaMaKota123!");
            nameUser.AddUser(new UserData("foczka", " Jola", " Motyl", " 16.12.1978", "foczka123@gmail.com"));//, "AlaMaKota1!!");
            nameUser.AddUser(new UserData("kicia", " Basia", " Trump", " 12.11.1956", "basia123@gmail.com"));//, "AlaMa");
            nameUser.AddUser(new UserData("lulu", " Stanisława", " Falalalala", "12.06.1996", "lulu123@gmail.com"));//, "AlaMaKota123iPsa");
            nameUser.AddUser(new UserData("gwiazdka", " Gertruda", " Mankiewicz", "12.12.1986", "gwiazdka123@gmail.com"));//, "AlaMaKotaiSzczura");
        }

    }
}
