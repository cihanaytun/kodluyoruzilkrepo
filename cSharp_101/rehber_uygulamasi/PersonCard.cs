using System;
using System.Collections;

namespace RehberUygulamasi
{
     public class PersonCard
    {
        //type safety
        private string name;
        private string surname;
        private string phone;


        //prop 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }


        
        public PersonCard(string name,string surname,string phone)
        {
            Name = name;
            Surname = surname;
            Phone = phone;

        }

        public PersonCard()
        {
        }

        internal object Split(string v)
        {
            throw new NotImplementedException();
        }
    }
}