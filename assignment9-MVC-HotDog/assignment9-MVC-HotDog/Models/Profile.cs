using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment9_MVC_HotDog.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string FavoriteDog { get; set; }
        public string LastAteLocation { get; set; }
        public DateTime LastAteDate { get; set; }
        public int Rating { get; set; }
        public string Picture { get; set; }
        public List<string> PastDogs { get; set; }
    }
}