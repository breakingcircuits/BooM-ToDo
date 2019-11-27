using System;
using System.Collections.Generic;
namespace BoomLibrary
{
    public class User
    {
        private string userName;
        private string userPassword;

        private int boomSum;
        private guid Id;

        /// <summary>
        /// List to store notes from user
        /// </summary>
        /// <typeparam name="Note"></typeparam>
        /// <returns></returns>//  
        List<Note> notes = new List<Note>();       
         
        /// <summary>
        /// construktors. Gets name or name and password from user
        /// </summary>
        /// <param name="userNameInput"></param>
        public User(string userNameInput)
        {
            userName = userNameInput;
        }

        public User(string userNameInput, string userPasswordInput)
        {
            userPassword = userPasswordInput;
        }

        static void CreatUser()
        {
            var user = new User();
            Guid guid = new Guid();
            Id = guid;
        }
    }
}
