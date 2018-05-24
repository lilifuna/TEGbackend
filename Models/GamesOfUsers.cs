namespace TEG.Models
{
    public class GamesOfUsers
    {
        private int gameId;
        private Game game;

        private int playerId;
        private User player;
        
        
        
        public int GameId
        {
            get => gameId;
            set => gameId = value;
        }

        public Game Game
        {
            get => game;
            set => game = value;
        }

        public int PlayerId
        {
            get => playerId;
            set => playerId = value;
        }

        public User Player
        {
            get => player;
            set => player = value;
        }

      
    }
}