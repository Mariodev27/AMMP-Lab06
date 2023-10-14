using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio07
{
    public class Tecsup : List<Person>
    {
        public string Title { get; set; }
        public Tecsup(string title)
        {
            Title = title;
        }
    }
}
