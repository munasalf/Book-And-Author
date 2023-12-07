

namespace Book_Management_System
{
    class Booking
    {
        public string title;
        public int publicationYear;
        public string genre;

        public Booking() { 

            // empty 
        }
        public Booking(string title, int publicationYear, string genre)
        {

            this.title = title;
            this.publicationYear = publicationYear;
            this.genre = genre;

        }
        public string displayBookInfo() => $" Enter Book Title: {this.title} \n  Enter Publication Year : {this.publicationYear} \n Enter Genre : {this.genre}";


    }


    
}
