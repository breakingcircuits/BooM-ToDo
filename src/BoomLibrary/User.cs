using System;
using System.Collections.Generic;
namespace BoomLibrary
{
    public class User
    {
        public string UserName { get; set; }
        private string userPassword;

        private int boomSum;
        //private guid Id;

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
            UserName = userNameInput;
        }

        public User(string userNameInput, string userPasswordInput)
        {
            userPassword = userPasswordInput;
        }
    }
}
