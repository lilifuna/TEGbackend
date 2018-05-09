using System;

namespace TEG.Models
{
    public class GameModel
    {
        public string gameID { get; set; }
        public string lastPlayerID { get; set; }
        public string[] players { get; set; }
        public string lanes { get; set; }
    }
}
