using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.Lesson
{
    public class ToUsers
    {
        User[] users;
        public void InitUser(int y)
        {
            users = new User[y];
        }

        public void AddUser(int y, User user)
        {
            users[y] = user;
        }

        public void AddressingToUser()
        {
            foreach (User user in users)
            {
                if (user.IsPremium == true)
                {
                    Console.WriteLine("Добрый день, " + user.Name);
                }
                else
                {
                    Console.WriteLine("Добрый день, " + user.Name + ", пожалуйста, ");
                    Show.ShowAds();
                }
            }
        }
    }
}
