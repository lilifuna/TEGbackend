using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TEG.Models
{
    
    [DataContract]
    public class Game
    {
        [DataMember] private String gameId { get; set; }
        [DataMember] private String gameName{ get; set; }
        [DataMember] private String lanes{ get; set; }
        [DataMember] private List<String> playersIds { get; set; }  
        [DataMember] private String moderatorUserId { get; set; }

    }
}