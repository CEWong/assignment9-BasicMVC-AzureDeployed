using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using assignment9_MVC_HotDog.Models;
using System.Net;

namespace assignment9_MVC_HotDog.Models
{
    public class ProfileService
    {
        private static List<Profile> persons;
        public ProfileService()
        {
            persons = ListProfiles();
        }

        //Method to reset profile list to default
        public void defaultProfiles()
        {
            persons = ListProfiles();
        }

        //Returns list of people
        public List<Profile> getProfiles()
        {
            return persons;   
        }
        public Profile getProfile(int id)
        {
            Profile wantedProfile = new Profile();
            foreach (Profile p in persons)
            {
                if (p.ProfileID == id)
                {
                    wantedProfile = p;
                }
            }
            return wantedProfile;
        }

        //Add new profile
        public void addProfile(Profile p)
        {
            //Add validation
            persons.Add(p);
        }

        // Delete profile
        public void deleteProfile(Profile p)
        {
            Profile dp = getProfile(p.ProfileID);
            persons.Remove(dp);
        }
        //Populate list
        private static List<Profile> ListProfiles()
        {
            List<Profile> profiles = new List<Profile>();

            Profile person1 = new Profile()
            {
                ProfileID = 001,
                Name = "Carissa Wong",
                Bio = "Blah Blah I like Hot Dogs Blah Blah.",
                FavoriteDog = "All Beef Franks",
                LastAteLocation = "Kentucky",
                LastAteDate = new DateTime(2015, 3, 19),
                Rating = 5,
                Picture = "https://s-media-cache-ak0.pinimg.com/avatars/cewong05-83_140.jpg",
                PastDogs = new List<string> { "Turkey Dog", "Smoked Pork", "Beer Brat" }
            };
            profiles.Add(person1);

            Profile person2 = new Profile()
            {
                ProfileID = 002,
                Name = "Tom Hanks",
                Bio = "Bam chicka bow wow .. Hot Dogs .. Kaboom!",
                FavoriteDog = "Original Ball Park Frank",
                LastAteLocation = "California",
                LastAteDate = new DateTime(2015, 1, 31),
                Rating = 3,
                Picture = "http://entertainment.blogs.foxnews.com/files/2011/03/tomhanks600.jpg",
                PastDogs = new List<string> { "All Beef Frank", "Jalapeno Cheddar" }
            };
            profiles.Add(person2);

            return profiles;
        }
    }
}