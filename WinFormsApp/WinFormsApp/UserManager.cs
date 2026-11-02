using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    public static class UserManager
    {
        public static List<User> lstUsers = new List<User>();// this is the list where I will storing all the data 


        //GetAll 
        public static List<User> GetAll()
        {
            return lstUsers;
        }

        // add 
        public static void Add(User user)
        {
            lstUsers.Add(user);
        }


        // add 
        public static void Remove(User user)
        {
            //find 
            var u = lstUsers.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if(u != null)
            {
                lstUsers.Remove(u);
            }

            
        }

    }
}
