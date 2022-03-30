using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class HandlePunchCollisionAction : Action{
        
        public HandlePunchCollisionAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> zombies = cast.GetActors("zombie");
            List<Player> playersToKill = new List<Player>();
            List<ZombieShopper> zombiesToKill = new List<ZombieShopper>();
            

            foreach(Actor i in players){
                Player player = (Player) i;
                
                foreach(Actor j in players){
                    Player jplayer = (Player) j;
                    
                    if(player.GetIsPunching() && player.GetIsAlive() && jplayer.GetIsAlive() && jplayer.GetPlayerID() != player.GetPlayerID() && isCollision(player, jplayer)){ // player is punching, living, and colliding with a living jplayer
                        playersToKill.Add(jplayer);
                    }
                }

                foreach(Actor jj in zombies){
                    ZombieShopper zombie = (ZombieShopper) jj;
                    if(player.GetIsPunching() && player.GetIsAlive() && zombie.GetIsAlive() && isCollision(player, zombie)){ // player is punching, living, and colliding with a living zombie
                        zombiesToKill.Add(zombie);
                    }
                }
            }
            
            
            KillPlayers(playersToKill);

            KillZombies(zombiesToKill);
        }


        public void KillPlayers(List<Player> playersToKill){
            foreach (Player deadPlayer in playersToKill){
                deadPlayer.SetIsAlive(false);
                deadPlayer.SetIsPunching(false);
                deadPlayer.SetColor(Constants.CLEAR);
                deadPlayer.SetTextColor(Constants.BANNER_RED);
                deadPlayer.SetText(Constants.DEAD_SHOPPER_FACE);
                deadPlayer.SetVelocity(new Point(0, 0));
                deadPlayer.SetScore(0);
            }
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

        public bool isCollision(Actor actor1, Actor actor2, int widthOrHeight=50){
            int x1;
            x1 = actor1.GetPosition().GetX();
            int y1;
            y1 = actor1.GetPosition().GetY();
            int x2;
            x2 = actor2.GetPosition().GetX();
            int y2;
            y2 = actor2.GetPosition().GetY();

            int topEdgeOfArea = y1 - widthOrHeight;
            int bottomEdgeOfArea = y1 + widthOrHeight;
            int leftEdgeOfArea = x1 - widthOrHeight;
            int rightEdgeOfArea = x1 + widthOrHeight;

            if(y2 >= topEdgeOfArea && y2 <= bottomEdgeOfArea && x2 >= leftEdgeOfArea && x2 <= rightEdgeOfArea){ // within collision range
                Console.WriteLine($"collision at ({x1}, {y1}) and ({x2}, {y2}) top({topEdgeOfArea}) bottom({bottomEdgeOfArea}) left({leftEdgeOfArea}) right({rightEdgeOfArea})");
                return true;
            }

            return false;
        }
    }
}