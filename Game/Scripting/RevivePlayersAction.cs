using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class RevivePlayersAction : Action{
        Random random = new Random();
        public RevivePlayersAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Player> playersToRevive = new List<Player>();
            
            foreach(Actor i in players){
                Player player = (Player) i;
                if(!player.GetIsAlive()){
                    if(player.IsPlayerIDOdd()){
                        player.SetTextColor(new Color(GetPrimeColorNumber(player), GetColorNumber(player), GetColorNumber(player)));
                        if(player.GetLifeTick() >= Constants.PLAYER_REVIVE_TIME){
                            playersToRevive.Add(player);
                        }
                    }
                    else{
                        player.SetTextColor(new Color(GetColorNumber(player), GetColorNumber(player), GetPrimeColorNumber(player)));
                        if(player.GetLifeTick() >= Constants.PLAYER_REVIVE_TIME){
                            playersToRevive.Add(player);
                        }
                    }
                }
                player.IncrementLifeTick();
            }

            RevivePlayers(playersToRevive);
        }

        public void RevivePlayers(List<Player> playersToRevive){
            foreach (Player undeadPlayer in playersToRevive){
                undeadPlayer.SetIsAlive(true);
                undeadPlayer.ResetLifeTick();
                undeadPlayer.SetText(Constants.SHOPPER_FACE);
                switch(undeadPlayer.IsPlayerIDOdd()){
                    case true:
                        undeadPlayer.SetTextColor(Constants.WHITE);
                        undeadPlayer.SetColor(Constants.LIGHT_RED);
                        break;
                    case false:
                        undeadPlayer.SetTextColor(Constants.WHITE);
                        undeadPlayer.SetColor(Constants.LIGHT_BLUE);
                        break;
                }
            }
        }

         
         private int GetColorNumber(Player player){
            int lifeTick = player.GetLifeTick();
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= 1){
                return 28;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .9){
                return 38;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .8){
                return 48;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .7){
                return 58;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .6){
                return 68;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .5){
                return 78;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .4){
                return 88;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .3){
                return 98;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .2){
                return 108;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .1){
                return 118;
            }
            else{
                return 128;
            }
        }

        private int GetPrimeColorNumber(Player player){
            int lifeTick = player.GetLifeTick();
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= 1){
                return 228;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .9){
                return 218;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .8){
                return 208;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .7){
                return 198;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .6){
                return 188;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .5){
                return 178;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .4){
                return 168;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .3){
                return 158;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .2){
                return 148;
            }
            if ((double) lifeTick / Constants.PLAYER_REVIVE_TIME >= .1){
                return 138;
            }
            else{
                return 128;
            }
        }
    }
}