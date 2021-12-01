using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace AliceMafia
{
    public class GameState
    {
        public IPlayer HealedPlayer { get; set; }
        public IPlayer PlayerWithAlibi { get; }
        public int GameCycleCount { get; set; }
        public HashSet<IPlayer> AlivePlayers { get; set; }
        public List<IPlayer> AboutToKillPlayers { get; set; }
    }

    
}