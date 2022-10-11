using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.ToDoAppDatas
{
    public class Card
    {
        private string Title;
        private string Content;
        private string Person;
        private string Size;
        private string Line;


        public string title { get => Title; set => Title = value; }
        public string content { get => Content; set => Content = value; }
        public string person { get => Person; set => Person = value; }
        public string size { get => Size; set => Size = value; }
        public string line { get => Line; set => Line = value; }


        public Card(string title, string content, string person, string size, string line)
        {
            Title = title;
            Content = content;
            Person = person;
            Size = size;
            Line = line;
        }

        public Card()
        {

        }
    }
}
