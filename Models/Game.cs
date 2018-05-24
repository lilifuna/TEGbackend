using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TEG.Models
{
    
    
    public class Game
    {

        public enum GameStatus
        {
            CREATED,
            STARTED,
            PAUSED,
            FINISHED
        }
        
        
        [Key] 
        private int gameId;
        
        [Required]
        [MaxLength(256)]
        private String gameName;
        
        private String lanes = "";
        
        private String playersIds = "\"players\" : []"; //JSON
        
        private String moderatorUserId = "";
        
        private String agreed = "\"agreed\" : []"; //JSON
        
        //private GameStatus status = GameStatus.CREATED;

        private List<User> players = new List<User>();





        public void Copy(Game source)
        {
            gameId = source.GameId;
            lanes = source.lanes;
            playersIds = source.playersIds;
            moderatorUserId = source.moderatorUserId;
            agreed = source.agreed;
            gameName = source.gameName;
            players = source.players;
        }
        
        
        //Accessors
        public int GameId
        {
            get => gameId;
            set => gameId = value;
        }
        
        public List<User> Players
                {
                    get => players;
                    set => players = value;
                }
        
        public string GameName
        {
            get => gameName;
            set => gameName = value;
        }

        public string Lanes
        {
            get => lanes;
            set => lanes = value;
        }

        public string PlayersIds
        {
            get => playersIds;
            set => playersIds = value;
        }

        public string ModeratorUserId
        {
            get => moderatorUserId;
            set => moderatorUserId = value;
        }
 
        public String Agreed
        {
            get => agreed;
            set => agreed = value;
        } 
        
        /*public GameStatus Status
        {
            get => status;
            set => status = value;
        }*/
    }
}