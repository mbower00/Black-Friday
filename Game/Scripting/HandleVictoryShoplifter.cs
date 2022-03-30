using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class HandleVictoryShoplifter : Action{
        
        public HandleVictoryShoplifter(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> toasters = cast.GetActors("toaster");
            Actor mallCopActor = cast.GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallCopActor;

            if(!IsAnyPlayerAlive(scene)){ //no more players
                HandleMallCopWin(scene);
            }

            if(!IsAnyToasterAlive(scene)){ //no more toasters
                HandleWinnerAccordingToScore(scene);
            }
        }

        private bool IsAnyToasterAlive(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> toasters = cast.GetActors("toaster");
            foreach(Actor toaster in toasters){
                
                if(toaster.GetIsAlive()){
                    return true;
                }
            }
            return false;
        }

        private bool IsAnyPlayerAlive(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            foreach(Actor i in players){
                Player player = (Player) i;
                
                if(player.GetIsAlive()){
                    return true;
                }
            }
            return false;
        }

        private void HandleMallCopWin(Scene scene){
            scene.SetIsSceneOver(true);
            scene.GetNextSceneInfo().SetNextSceneName("gameover");
            scene.GetNextSceneInfo().SetWinner("The Mall Cop");
        }

        private void HandleWinnerAccordingToScore(Scene scene){
            List<Actor> players = scene.GetCast().GetActors("player");
            
            List<Player> winningPlayers = new List<Player>();
            Player winningPlayer = new Player();
            winningPlayers.Add(winningPlayer);
            foreach(Actor i in players){
                Player player = (Player) i;
                if(player.GetScore() > winningPlayers[0].GetScore()){
                    winningPlayers.Clear();
                    winningPlayers.Add(player);
                }
                else if(player.GetScore() == winningPlayers[0].GetScore()){
                    winningPlayers.Add(player);
                }
            }
            if(winningPlayers[0].GetScore() == 0){
                scene.SetIsSceneOver(true);
                scene.GetNextSceneInfo().SetNextSceneName("gameover");
                scene.GetNextSceneInfo().SetWinner("No One");
            }
            if(winningPlayers[0].GetScore() > 0){
                scene.SetIsSceneOver(true);
                scene.GetNextSceneInfo().SetNextSceneName("gameover");
                scene.GetNextSceneInfo().SetWinner(GetWinnerString(winningPlayers));
            }
        }

        private string GetWinnerString(List<Player> winningPlayers){
            switch (winningPlayers.Count()){
                case 1:
                    return $"Player {winningPlayers[0].GetPlayerID()}";
                case 2:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()}";
                case 3:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()}";
                case 4:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()}";
                case 5:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()}";
                case 6:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()}";
                case 7:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()}";
                case 8:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()}";
                case 9:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()}";
                case 10:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()}";
                case 11:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()}";
                case 12:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()}";
                case 13:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()}";
                case 14:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()} & {winningPlayers[13].GetPlayerID()}";
                case 15:
                    return $"Player {winningPlayers[0].GetPlayerID()} & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()} & {winningPlayers[13].GetPlayerID()} & {winningPlayers[14].GetPlayerID()}";
                default:
                    return "error";
            }
        }
    }
}