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
        
        private List<Game> gamesOfUser;   //optimize? only the gameId is stored in the db
        

        
        
        
        
        
        
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

        public List<Game> GamesOfUser
        {
            get => gamesOfUser;
            set => gamesOfUser = value;
        }
        public override string ToString()
        {
            return userId.ToString();
        }
    }
    
    
    
}