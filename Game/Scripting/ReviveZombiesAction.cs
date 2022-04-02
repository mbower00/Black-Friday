using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ReviveZombiesAction : Action{
        Random random = new Random();
        public ReviveZombiesAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> zombies = cast.GetActors("zombie");
            List<ZombieShopper> zombiesToRevive = new List<ZombieShopper>();
            
            foreach(Actor i in zombies){
                ZombieShopper zombie = (ZombieShopper) i;
                if(!zombie.GetIsAlive()){
                    if(zombie.GetFrameTick() >= Constants.ZOMBIE_REVIVE_TIME){
                        zombiesToRevive.Add(zombie);
                    }
                }
            }

            ReviveZombies(zombiesToRevive);
        }

        public void ReviveZombies(List<ZombieShopper> zombiesToRevive){
            foreach (ZombieShopper undeadZombie in zombiesToRevive){
                undeadZombie.SetIsAlive(true);
                undeadZombie.ResetFrameTick();
                undeadZombie.SetText(Constants.SHOPPER_FACE);
                switch(undeadZombie.GetTeamID()){
                    case 1:
                        undeadZombie.SetColor(Constants.LIGHT_RED);
                        undeadZombie.SetTextColor(Constants.WHITE);

                        break;
                    case 2:
                        undeadZombie.SetColor(Constants.LIGHT_BLUE);
                        undeadZombie.SetTextColor(Constants.WHITE);

                        break;
                    default:
                        undeadZombie.SetColor(new Color(random.Next(30, 230), random.Next(30, 230), random.Next(30, 230)));
                        undeadZombie.SetTextColor(Constants.WHITE);

                        break;
                }
            }
        }
    }
}