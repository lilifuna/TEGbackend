using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TEG.Models
{
    public class User
    {

        
        [Key]
        private int userId;

        private string username;
        
        private ICollection<GamesOfUsers> gamesOfUsers;

        
         public int UserId
                {
                    get => userId;
                    set => userId = value;
                }
        
        
        public string Username
        {
            get => username;
            set => username = value;
        }
        
        public ICollection<GamesOfUsers> GamesOfUsers
        {
            get => gamesOfUsers;
            set => gamesOfUsers = value;
        }

    
        public override string ToString()
        {
            return userId.ToString();
        }
    }
    
    
    
}