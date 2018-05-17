using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TEG.Models
{
    
    [DataContract]
    public class Game
    {
        [DataMember] private String gameId;
        [DataMember] private String gameName;
        [DataMember] private String lanes;
        [DataMember] private List<String> playersIds;
        [DataMember] private String moderatorUserId;
        
        
        
        
        
        
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

        public List<string> PlayersIds
        {
            get => playersIds;
            set => playersIds = value;
        }

        public string ModeratorUserId
        {
            get => moderatorUserId;
            set => moderatorUserId = value;
        }

    }
}