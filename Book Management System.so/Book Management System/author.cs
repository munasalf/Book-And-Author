

namespace Book_Management_System
{
    internal class author
    {
        private string authorName;
        private int birthYear;
        private string nationality;
        public List<Booking> bookings = new List<Booking>();
        //public author()
        //{
        //    // empty
        //}
        public author(string authname , int biry , string nation)
        {
            this.authorName = authname;
            this.birthYear = biry;
            this.nationality = nation;

        }
        public string displayAuthorInfo() => $" name : {this.authorName} \n  Birth Year : {this.birthYear} \n Nationality : {this.nationality}";

        public string Getname()
        {
            return authorName;
        }
        public void Setname(string name )
        {
            this.authorName = name;
        }

        public void addBooking(Booking booking) {
            bookings.Add( booking );


        }
        public void displaybooking() {
            for (int i = 0; i < bookings.Count();i++ )
            {
                Console.WriteLine(i+1 + " " + bookings[i].displayBookInfo() );
            }
        }
        
    }
}
