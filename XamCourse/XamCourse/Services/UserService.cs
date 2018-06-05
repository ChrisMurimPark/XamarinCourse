using System;

using XamCourse.Models;

namespace XamCourse.Services
{
    public class UserService
    {
        public static User GetUser(int user_id)
        {
            // would normally call into remote service here
            switch (user_id)
            {
                case 0:
                    return new User("Tom", "Looking for someone to cuddle with.", 0);
                case 1:
                    return new User("Jordan", "Ballin' since I was a kid", 1);
                case 2:
                    return new User("Jennifer", "Will someone tell Tom to stop texting me?", 2);
                default:
                    throw new Exception("That user does not exist.");
            }
        }
    }
}
