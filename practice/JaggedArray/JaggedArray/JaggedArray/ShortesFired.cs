using System;
using System.Collections.Generic;
using System.Text;

namespace JaggedArray
{
    public static class ShortesFired
    {
        public static void GetShortesFriend()
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
            var partyFriends = GetPartyFirends(friends, 10);

            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }

        private static List<string> GetPartyFirends(List<string> friends, int count)
        {
            if(friends == null)
            {
                throw new ArgumentNullException("List", "The list is empty");
            }
            if (count > friends.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater then elements in the ");
            }
            var buffer = new List<string>(friends);
            var partyFriends = new List<string>();
            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFirends(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }
        /// <summary>
        /// This is the logic to figure out who is the party friends
        /// </summary>
        /// <param name="friends"></param>
        /// <returns></returns>
        private static string GetPartyFirends(List<string> friends)
        {
            string shortestName = friends[0];
            for(var i= 0; i<friends.Count; i++)
            {
                if (friends[i].Length < shortestName.Length) ;
                shortestName = friends[i];
            }
            return shortestName;
        }
    }
}
