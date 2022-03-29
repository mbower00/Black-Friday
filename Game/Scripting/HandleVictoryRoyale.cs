using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class HandleVictoryRoyale : Action{
        
        public HandleVictoryRoyale(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Player> livingPlayers = new List<Player>();

            foreach(Actor actor in players){
                Player player = (Player) actor;
                if(player.GetIsAlive()){ // player is alive
                    livingPlayers.Add(player);
                }
            }

            switch(livingPlayers.Count()){ // Number of living players
                case 1:
                    scene.SetIsSceneOver(true);
                    scene.GetNextSceneInfo().SetWinner($"Player {livingPlayers[0].GetPlayerID()}");
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    break;
                case 0:
                    scene.SetIsSceneOver(true);
                    scene.GetNextSceneInfo().SetWinner("No One");
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    break;
                default:
                    break; //keep playing
            }
        }
    }
}