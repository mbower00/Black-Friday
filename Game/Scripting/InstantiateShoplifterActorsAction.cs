using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class InstantiateShoplifterActorsAction : Action{
        Random random = new Random();
        HandleToasterCollisionAction handleToasterCollisionAction = new HandleToasterCollisionAction();

        public InstantiateShoplifterActorsAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");

            //create and add the mallcop
            MallCop mallcop = new MallCop();
            cast.AddActor("mallcop", mallcop);

            //create and add the toasters
            for(int i=0; i < Constants.GET_TOASTER_COUNT(); i++){
                Actor toaster = new Actor();
                toaster.SetText(Constants.TOASTER_ICON);
                toaster.SetColor(Constants.BANNER_YELLOW);
                toaster.SetTextColor(Constants.BLACK);
                toaster.SetWidth(25);
                toaster.SetHeight(25);
                toaster.SetFontSize(25);
                toaster.SetPosition(new Point(random.Next(Constants.MAX_X - toaster.GetWidth() + 1), random.Next(Constants.MAX_Y - toaster.GetHeight() + 1)));
                
                bool shouldRepeat = false;
                do{
                    foreach(Actor actor in players){
                    Player player = (Player) actor;
                    shouldRepeat = false;

                        if(handleToasterCollisionAction.IsToasterCollision(player, toaster)){
                            toaster.SetPosition(new Point(random.Next(Constants.MAX_X - toaster.GetWidth() + 1), random.Next(Constants.MAX_Y - toaster.GetHeight() + 1)));
                            shouldRepeat = true;    
                        }
                    }
                }while(shouldRepeat);


                // bool shouldRepeat = false;
                // do{
                //     foreach(Actor actor in players){
                //     Player player = (Player) actor;
                //     shouldRepeat = false;
                //     List<Point> actorPoints = player.GetAllPoints();
                //     List<Point> toasterPoints = toaster.GetAllPoints();
                //         foreach(Point ap in actorPoints){
                //             foreach(Point tp in toasterPoints){
                //                 if(ap.Equals(tp)){
                //                     toaster.SetPosition(new Point(random.Next(Constants.MAX_X - toaster.GetWidth() + 1), random.Next(Constants.MAX_Y - toaster.GetHeight() + 1)));
                //                     shouldRepeat = true;    
                //                 }
                //             }
                //         }
                //     }
                // }while(shouldRepeat);


                cast.AddActor("toaster", toaster);
            }

            //Create the _ammoCount_ actor
            Actor ammoCount = new Actor();
            ammoCount.SetColor(Constants.CLEAR);
            Point ammoCountStartingPoint = new Point(0 + 25, 0 + 20);
            ammoCount.SetPosition(ammoCountStartingPoint);
            ammoCount.SetText("");
            ammoCount.SetTextColor(Constants.BANNER_GREEN);
            ammoCount.SetWidth(100);
            ammoCount.SetHeight(50);
            ammoCount.SetFontSize(50);
            //Add ammoCount to cast
            cast.AddActor("info", ammoCount);
            
            for(int i=0; i < Constants.PLAYER_COUNT; i++){
                //Create the score actor
                Actor score = new Actor();
                score.SetColor(Constants.CLEAR);
                Point scoreStartingPoint = new Point(Constants.MAX_X - 100, 0 + (i * 25) + 20);
                score.SetPosition(scoreStartingPoint);
                score.SetText($"P{i+1}: 00");
                score.SetTextColor(Constants.BANNER_BLUE);
                score.SetWidth(25);
                score.SetHeight(25);
                score.SetFontSize(25);
                //Add score to cast
                cast.AddActor("score", score);

                scene.SetCast(cast);
            }
        }
    }
}