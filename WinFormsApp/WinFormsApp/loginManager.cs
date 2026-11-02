using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    public class loginManager
    {

        public static List<User> _users = new List<User>();
        /// <summary>
        /// This will give you list of users 
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAll()
        {
            return _users;
        }

        /// <summary>
        /// it will validate the object that we are passing over here 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool IsValidUser(User user)
        {
            // All the valid users 
            var LstUser = GetAll();
            // Filter the list and check whether there is object wirh same username and passswords 
            var isValidate = LstUser.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();

            if (isValidate != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// it will validate the object that we are passing over here 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static void Add(User user)
        {
            _users.Add(user);
        }

        /// <summary>
        /// it will validate the object that we are passing over here 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static void Remove(User user)
        {

            var u = _users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();

            _users.Remove(u);

            //_users.Add(user);
        }

    }
}
