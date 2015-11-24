using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstMovie
{
    public class Actor
    {
        private static int _actorCounter;
        public static int ActorCounter { get { return _actorCounter; } set { _actorCounter = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private DateTime _dob;
        public DateTime DOB { get { return _dob; } set { _dob = value; } }

        public Actor():this("John Doe")
        { }

        public Actor(string nme, string dte="1968/10/7")
        {
            ActorCounter ++;
            Name = nme;
            DateTime.TryParse(dte, out _dob);
        }

        public string Age
        {
            get
            {
                if ((DateTime.Now.Year - DOB.Year > 130) || (DOB.Year > DateTime.Now.Year)) return "Unsure";
                return ((DateTime.Now - _dob).Days / 365).ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} Age: {1}", Name, Age);
        }
    }
}
