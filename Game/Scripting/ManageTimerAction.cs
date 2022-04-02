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
                    return $"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts)";
                case 2:
                    return $"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()}";
                case 3:
                    return $"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()}";
                case 4:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()}");
                    return("[see terminal]");
                case 5:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()}");
                    return("[see terminal]");
                case 6:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()}");
                    return("[see terminal]");
                case 7:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()}");
                    return("[see terminal]");
                case 8:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()}");
                    return("[see terminal]");
                case 9:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()}");
                    return("[see terminal]");
                case 10:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()}");
                    return("[see terminal]");
                case 11:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()}");
                    return("[see terminal]");
                case 12:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()}");
                    return("[see terminal]");
                case 13:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()}");
                    return("[see terminal]");
                case 14:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()} & {winningPlayers[13].GetPlayerID()}");
                    return("[see terminal]");
                case 15:
                    Console.WriteLine($"Player {winningPlayers[0].GetPlayerID()} ({winningPlayers[0].GetScore()}pts) & {winningPlayers[1].GetPlayerID()} & {winningPlayers[2].GetPlayerID()} & {winningPlayers[3].GetPlayerID()} & {winningPlayers[4].GetPlayerID()} & {winningPlayers[5].GetPlayerID()} & {winningPlayers[6].GetPlayerID()} & {winningPlayers[7].GetPlayerID()} & {winningPlayers[8].GetPlayerID()} & {winningPlayers[9].GetPlayerID()} & {winningPlayers[10].GetPlayerID()} & {winningPlayers[11].GetPlayerID()} & {winningPlayers[12].GetPlayerID()} & {winningPlayers[13].GetPlayerID()} & {winningPlayers[14].GetPlayerID()}");
                    return("[see terminal]");
                default:
                    return "error";
            }
        }

        public void HandleWinnerAccordingToScore(Scene scene){
            List<Actor> players = scene.GetCast().GetActors("player");

            if(scene.GetNextSceneInfo().GetGameMode() == "teambattle"){
                int scoreOdd = 0;
                int scoreEven = 0;
                foreach(Actor i in players){
                    Player player = (Player) i;
                    if (player.IsPlayerIDOdd()){
                        scoreOdd += player.GetScore();
                    }
                    else{
                        scoreEven += player.GetScore();
                    }
                }
                
                
                if(scoreOdd > scoreEven){
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    scene.GetNextSceneInfo().SetWinner($"Odd Team ({scoreOdd}pts)");
                    scene.SetIsSceneOver(true);
                    return;
                }
                else if(scoreEven > scoreOdd){
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    scene.SetIsSceneOver(true);
                    scene.GetNextSceneInfo().SetWinner($"Even Team ({scoreEven}pts)");
                    return;
                }
                else{
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    scene.GetNextSceneInfo().SetWinner("No Team");
                    scene.SetIsSceneOver(true);
                    return;
                }
            }

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