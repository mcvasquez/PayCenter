using System;
using System.Collections.Generic;

namespace PayCenter.Models
{
    public class MockData
    {
        public static List<User> Users = new List<User>
        {
            new User { Name = "Matt E", PhotoUrl = "https://cdn.pixabay.com/photo/2015/01/08/18/29/entrepreneur-593358_960_720.jpg" },
            new User { Name = "Lizzie B", PhotoUrl = "https://cdn.pixabay.com/photo/2018/01/13/19/39/fashion-3080644__340.jpg" },
            new User { Name = "Cameron S", PhotoUrl = "https://cdn.pixabay.com/photo/2016/03/23/04/01/beautiful-1274056__340.jpg" },
            new User { Name = "Haley M", PhotoUrl = "https://cdn.pixabay.com/photo/2017/03/17/04/07/beautiful-2150881__340.jpg" },
            new User { Name = "John D", PhotoUrl = "https://cdn.pixabay.com/photo/2015/01/08/18/30/entrepreneur-593371_960_720.jpg" },
            new User { Name = "Steve J", PhotoUrl = "https://cdn.pixabay.com/photo/2016/09/24/03/20/passion-1690965__340.jpg" },
            new User { Name = "Michael J", PhotoUrl = "https://cdn.pixabay.com/photo/2016/03/27/17/40/black-and-white-1283231__340.jpg" },
            new User { Name = "Denzel W", PhotoUrl = "https://cdn.pixabay.com/photo/2017/06/26/02/47/people-2442565__340.jpg" }
        };

        public static List<Activity> RecentActivities = new List<Activity>
        {
            new Activity { User = Users[5], Amount = 15 },
            new Activity { User = Users[6], Amount = 5 },
            new Activity { User = Users[7], Amount = 5 }
        };

        public static List<Activity> Activities = new List<Activity>
        {
            new Activity { User = Users[5], Amount = 15 },
            new Activity { User = Users[0], Amount = 50 },
            new Activity { User = Users[2], Amount = 75 },
            new Activity { User = Users[3], Amount = 35 },
            new Activity { User = Users[1], Amount = 47 },
            new Activity { User = Users[5], Amount = 3 },
            new Activity { User = Users[5], Amount = 60 },
            new Activity { User = Users[6], Amount = 82 },
            new Activity { User = Users[1], Amount = 100 },
            new Activity { User = Users[4], Amount = 4 },
            new Activity { User = Users[7], Amount = 36 },
            new Activity { User = Users[5], Amount = 78 },
            new Activity { User = Users[0], Amount = 147 },
            new Activity { User = Users[2], Amount = 24 },
            new Activity { User = Users[3], Amount = 365 },
            new Activity { User = Users[1], Amount = 110 }
        };
    }
}
