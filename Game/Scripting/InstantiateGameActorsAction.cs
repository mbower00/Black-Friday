using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class InstantiateGameActorsAction : Action{
        
        public InstantiateGameActorsAction(){
        }

        public void Execute(Scene scene){
            Cast cast = new Cast();
            
            for(int i = 1; i <= Constants.PLAYER_COUNT; i++){
                Player player = new Player();
                player.SetPlayerID(i);
                cast.AddActor("player", player);
            }
            for(int i = 1; i <= Constants.NPC_COUNT; i++){
                cast.AddActor("zombie", new ZombieShopper());
            }


            //Create the _timer_ actor
            Game.Casting.Timer timer = new Game.Casting.Timer();
            timer.SetColor(Constants.CLEAR);
            Point timerStartingPoint = new Point(Constants.MAX_X / 2 - 50, 0 + (Constants.MAX_Y - 100));
            timer.SetPosition(timerStartingPoint);
            timer.SetText("");
            timer.SetTextColor(Constants.BANNER_WHITE);
            timer.SetWidth(100);
            timer.SetHeight(50);
            timer.SetFontSize(50);
            //Add timer to cast
            cast.AddActor("info", timer);

            scene.SetCast(cast);
        }
    }
}