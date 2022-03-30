using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ManageTimerAction : Action{
        
        public ManageTimerAction(){
        }

        public void Execute(Scene scene){
            Actor firstActor = scene.GetCast().GetFirstActor("info");
            Game.Casting.Timer timer = (Game.Casting.Timer) firstActor;
            List<Actor> players = scene.GetCast().GetActors("player");


            timer.SetText($"{Constants.TIMER_COUNT - timer.GetSecondTick()}");

            //manage if time runs out
            switch (Constants.TIMER_COUNT - timer.GetSecondTick()){
                case 0:
                    
                    HandleWinnerAccordingToScore(scene);

                    break;
                default:
                    break;
            }

            //update the tick
            switch (timer.GetFrameTick() - Constants.FRAME_RATE){
                case 0:
                    timer.SetFrameTick(0);
                    timer.IncrementSecondTick();
                    break;
                default:
                    timer.IncremenFrameTick();
                    break;
            }



        }

        public string GetWinnerString(List<Player> winningPlayers){
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

        public void HandleWinnerAccordingToScore(Scene scene){
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
    }
}