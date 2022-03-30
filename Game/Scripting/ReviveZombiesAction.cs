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
                undeadZombie.SetColor(new Color(random.Next(30, 230), random.Next(30, 230), random.Next(30, 230)));
            }
        }
    }
}