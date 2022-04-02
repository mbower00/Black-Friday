using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ManageTeamScoreBannersAction : Action{
        
        public ManageTeamScoreBannersAction(){
        }

        public void Execute(Scene scene){
            List<Actor> scoreBanners = scene.GetCast().GetActors("score");
            List<Actor> players = scene.GetCast().GetActors("player");
            
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

            

            scoreBanners[0].SetText($"Odd Team: {scoreOdd}");
            scoreBanners[1].SetText($"Even Team: {scoreEven}");
        }

        
    }
}