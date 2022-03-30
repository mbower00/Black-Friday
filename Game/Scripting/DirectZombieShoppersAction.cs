//players and zombies only move north, south, east, west, north-east, south-east, south-west, north-west

using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class DirectZombieShoppersAction : Action{
        
        Random random = new Random();
        
        public DirectZombieShoppersAction(){
        }

        public void Execute(Scene scene){
            List<Actor> zombies = scene.GetCast().GetActors("zombie");
            foreach(Actor actor in zombies){
                ZombieShopper zombie = (ZombieShopper) actor;
                if (zombie.GetIsAlive()){
                    if(!zombie.GetIsMoving()){ //IS NOT MOVING
                        if(random.Next(120) == 0){
                            zombie.SetIsMoving(true);
                            Point velocity = new Point(random.Next(-1, 2), random.Next(-1, 2)).Scale(Constants.SHOPPER_SPEED); //a random cardinal direction (holding still is included) and scale it to Constants.SHOPPER_SPEED
                            zombie.SetVelocity(velocity);
                            zombie.SetDirection(velocity);
                            zombie.SetDuration(random.Next(50, 500));
                            zombie.ResetFrameTick();
                        }
                    }
                    else{ //IS MOVING
                        if(zombie.GetFrameTick() >= zombie.GetDuration()){ // MOVEMENT DURATION TIMED OUT
                            Point holdStill = new Point(0, 0);
                            zombie.SetIsMoving(false);
                            zombie.SetVelocity(holdStill);
                            zombie.SetDirection(holdStill);
                        }
                        else{ // STILL MOVING
                            zombie.SetVelocity(zombie.GetDirection());
                        }
                    }
                }
                zombie.IncrementFrameTick();
            }
        }
    }
}