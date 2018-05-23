using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TEG.Models
{
    
    [DataContract]
    public class Game
    {

        public enum GameStatus
        {
            CREATED,
            STARTED,
            PAUSED,
            FINISHED
        }
        
        private String gameId;
        private String gameName;
        private String lanes;
        private String playersIds; //JSON
        private String moderatorUserId;
        private String agreed; //JSON
        private GameStatus status;

       


        //Accessors
        public string GameId
        {
            get => gameId;
            set => gameId = value;
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
        
        public GameStatus Status
        {
            get => status;
            set => status = value;
        }
    }
}