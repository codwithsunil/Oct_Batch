using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    public static class UserManager
    {
        //GetAll 
        public static List<User> GetAll()
        {
            return DataStoreManager.Users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public static void Add(User user)
        {
            user.Id = DataStoreManager.NextUserId();
            DataStoreManager.Users.Add(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public static void Remove(User user)
        {
            //find 
            var u = DataStoreManager.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (u != null)
            {
                DataStoreManager.Users.Remove(u);
            }
        }

    }
}
