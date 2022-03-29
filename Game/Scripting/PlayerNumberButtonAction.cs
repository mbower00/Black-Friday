using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class PlayerNumberButtonAction : Action{
        
        private List<int> playerCounts = new List<int>();
        private int currentPlayerCountIndex = 0;
        
        


        public PlayerNumberButtonAction(){
            playerCounts.Add(2);
            playerCounts.Add(3);
            playerCounts.Add(4);
            playerCounts.Add(5);
            playerCounts.Add(6);
            playerCounts.Add(7);
            playerCounts.Add(8);
            playerCounts.Add(9);
            playerCounts.Add(10);
            playerCounts.Add(11);
            playerCounts.Add(12);
            playerCounts.Add(13);
            playerCounts.Add(14);
            playerCounts.Add(15);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Number of Players: {Constants.PLAYER_COUNT}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.PLAYER_COUNT = GetNextPlayerCount();
                        button.SetText($"Number of Players: {Constants.PLAYER_COUNT}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private int GetNextPlayerCount(){
            currentPlayerCountIndex++;
            if (currentPlayerCountIndex >= playerCounts.Count()){currentPlayerCountIndex = 0;}
            int NextPlayerCount = playerCounts[currentPlayerCountIndex];
            return NextPlayerCount;
        }
    }
}