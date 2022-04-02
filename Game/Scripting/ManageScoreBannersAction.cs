using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ManageScoreBannersAction : Action{
        
        public ManageScoreBannersAction(){
        }

        public void Execute(Scene scene){
            List<Actor> scoreBanners = scene.GetCast().GetActors("score");
            List<Actor> players = scene.GetCast().GetActors("player");
            
            for(int i=0; i < scoreBanners.Count(); i++){
                scoreBanners[i].SetText($"P{i+1}: {GetPlayerFromID(i+1, players).GetScore()}");
                if(GetPlayerFromID(i+1, players).GetIsAlive()){
                    scoreBanners[i].SetTextColor(Constants.BANNER_BLUE);
                }
                else{
                    scoreBanners[i].SetTextColor(Constants.BANNER_GREY);
                }
            }
        }

        private Player GetPlayerFromID(int iD, List<Actor> players){
            
            foreach(Actor player in players){
                Player pPlayer = (Player) player;
                
                if(pPlayer.GetPlayerID() == iD){
                    return pPlayer;
                }
            }
            Console.WriteLine("ScoreBannersAction ERROR... GetPlayerFromID() returning new Player()");
            return new Player();
        }
    }
}