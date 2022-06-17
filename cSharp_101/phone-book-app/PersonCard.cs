namespace  phone_book_app
{
    public class PersonCard
    {
        string name;
        string surname;
        string phone;


        //prop 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }


        //constructor
        public PersonCard(string name,string surname,string phone)
        {
            Name = name;
            Surname = surname;
            Phone = phone;

        }

        public PersonCard()
        {
        }   
    }
}