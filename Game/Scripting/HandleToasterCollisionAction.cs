using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class HandleToasterCollisionAction : Action{
        
        public HandleToasterCollisionAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> toasters = cast.GetActors("toaster");
            Actor mallCopActor = cast.GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallCopActor;
            List<Actor> toastersToKill = new  List<Actor>();
            List<Player> playersToAward = new List<Player>();
            
            //if a living player collides with living toaster, the player get a point and the toaster is killed
            foreach(Actor i in players){
                Player player = (Player) i;

                foreach(Actor toaster in toasters){
                    if(player.GetIsAlive() && IsToasterCollision(player, toaster) && toaster.GetIsAlive()){
                        toastersToKill.Add(toaster);
                        playersToAward.Add(player);
                    }
                }
            }

            KillToasters(toastersToKill);
            AwardPlayers(playersToAward);

            //if the mouse hovers over a dead toaster, the toaster will disappear
            foreach(Actor toaster in toasters){
                if(mallCop.IsCollidingWith(toaster) && !toaster.GetIsAlive()){ 
                    toaster.SetColor(Constants.CLEAR);
                    toaster.SetTextColor(Constants.CLEAR);
                }
            }
        }

        public void AwardPlayers(List<Player> playersToAward){
            foreach (Player greedyPlayer in playersToAward){
                greedyPlayer.IncrementScore();
            }
        }

        public void KillToasters(List<Actor> toastersToKill){
            foreach (Actor deadToaster in toastersToKill){
                deadToaster.SetIsAlive(false);
            }
        }

        public bool IsToasterCollision(Actor player, Actor toaster){
            int wp = player.GetWidth();
            int hp = player.GetHeight();

            int wt = toaster.GetWidth();
            int ht = toaster.GetHeight();
            
            int xp;
            xp = player.GetPosition().GetX();
            int yp;
            yp = player.GetPosition().GetY();

            int xt;
            xt = toaster.GetPosition().GetX();
            int yt;
            yt = toaster.GetPosition().GetY();

            int top = yp - ht;
            int bottom = yp + hp;
            int left = xp - wt;
            int right = xp + wp;

            if(yt >= top && yt <= bottom && xt >= left && xt <= right){
                //Console.WriteLine($"Toaster Collision at (player) {xp} {yp} - (toaster) {xt} {yt} \n\ttop {top} - bottom {bottom} - left {left} - right {right}");
                return true;
            }

            return false;
        }
    }
}