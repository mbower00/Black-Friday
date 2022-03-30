using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ReviveZombiesAction : Action{
        
        public ReviveZombiesAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> zombies = cast.GetActors("zombie");
            List<Player> playersToKill = new List<Player>();
            List<ZombieShopper> zombiesTo = new List<ZombieShopper>();
            

            
        }

        public void KillZombies(List<ZombieShopper> zombiesToKill){
            foreach (ZombieShopper deadZombie in zombiesToKill){
                deadZombie.SetIsAlive(false);
                deadZombie.SetColor(Constants.CLEAR);
                deadZombie.SetText(Constants.DEAD_SHOPPER_FACE);
                deadZombie.SetVelocity(new Point(0, 0));
                deadZombie.ResetFrameTick();
            }
        }
    }
}