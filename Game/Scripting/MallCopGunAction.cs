using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class MallCopGunAction : Action{
        HandlePunchCollisionAction handlePunchCollisionAction = new HandlePunchCollisionAction();
        MouseService mouseService = new MouseService();

        public MallCopGunAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> zombies = cast.GetActors("zombie");
            List<Actor> toasters = cast.GetActors("toaster");
            Actor mallCopActor = cast.GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallCopActor;
            List<Player> playersToKill = new List<Player>();
            List<ZombieShopper> zombiesToKill = new List<ZombieShopper>();
            
            foreach(Actor i in players){
                Player player = (Player) i;
                
                if (mouseService.IsButtonPressed("left") && mallCop.IsCollidingWith(player) && mallCop.IsEnoughAmmo()){
                    playersToKill.Add(player);
                }
            }

            foreach(Actor ii in zombies){
                ZombieShopper zombie = (ZombieShopper) ii;

                if (mouseService.IsButtonPressed("left") && mallCop.IsCollidingWith(zombie) && mallCop.IsEnoughAmmo()){
                    zombiesToKill.Add(zombie);
                }
            }

            if(mouseService.IsButtonPressed("left") && mallCop.GetAmmo() > 0){
                mallCop.DecrementAmmo();
            }

            handlePunchCollisionAction.KillPlayers(playersToKill);
            handlePunchCollisionAction.KillZombies(zombiesToKill);
        }
    }
}