using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class InstantiateTeamBattleActorsAction : Action{
        Random random = new Random();
        HandleToasterCollisionAction handleToasterCollisionAction = new HandleToasterCollisionAction();

        public InstantiateTeamBattleActorsAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> zombies = cast.GetActors("zombie");

            foreach(Actor playerActor in players){
                Player player = (Player) playerActor;

                if(player.GetIsAlive()){

                    if(player.IsPlayerIDOdd()){
                        player.SetColor(Constants.LIGHT_RED);
                    }
                    else{
                        player.SetColor(Constants.LIGHT_BLUE);
                    }
                }
            }
            
            bool isOdd = true;
            foreach(Actor zombieActor in zombies){
                ZombieShopper zombie = (ZombieShopper) zombieActor;
            
                if(zombie.GetIsAlive()){

                    if (isOdd){
                        zombie.SetColor(Constants.LIGHT_BLUE);
                        zombie.SetTeamID(2);
                    }
                    else{
                        zombie.SetColor(Constants.LIGHT_RED);
                        zombie.SetTeamID(1);
                    }
                    isOdd = !isOdd;
                }
            }
            
            
            //Create ODD score actor
            Actor scoreOdd = new Actor();
            scoreOdd.SetColor(Constants.CLEAR);
            Point scoreOddStartingPoint = new Point(Constants.MAX_X - 200, 0 + (1 * 25) + 20);
            scoreOdd.SetPosition(scoreOddStartingPoint);
            scoreOdd.SetText("");
            scoreOdd.SetTextColor(Constants.BANNER_RED);
            scoreOdd.SetWidth(25);
            scoreOdd.SetHeight(25);
            scoreOdd.SetFontSize(25);

            //Create EVEN score actor
            Actor scoreEven = new Actor();
            scoreEven.SetColor(Constants.CLEAR);
            Point scoreEvenStartingPoint = new Point(Constants.MAX_X - 200, 0 + (2 * 25) + 20);
            scoreEven.SetPosition(scoreEvenStartingPoint);
            scoreEven.SetText("");
            scoreEven.SetTextColor(Constants.BANNER_BLUE);
            scoreEven.SetWidth(25);
            scoreEven.SetHeight(25);
            scoreEven.SetFontSize(25);


            //Add score to cast
            cast.AddActor("score", scoreOdd);
            //Add score to cast
            cast.AddActor("score", scoreEven);

            scene.SetCast(cast);
            
        }
    }
}