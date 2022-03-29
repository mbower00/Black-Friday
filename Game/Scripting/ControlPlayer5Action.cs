using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ControlPlayer5Action : Action{
        KeyboardService keyboardService = new KeyboardService();
        public ControlPlayer5Action(){
        }
        public void Execute(Scene scene){
            int vx = 0;
            int vy = 0;
            bool isPunching = false;

            // punch
            if (keyboardService.IsKeyDown("9"))
            {
                isPunching = true;
            }
            // up
            if (keyboardService.IsKeyDown("8"))
            {
                vy = -1;
            }
            // left
            if (keyboardService.IsKeyDown("4"))
            {
                vx = -1;
            }
            // down
            if (keyboardService.IsKeyDown("5"))
            {
                vy = 1;
            }
            // right
            if (keyboardService.IsKeyDown("6"))
            {
                vx = 1;
            }
            

            Point velocity = new Point(vx, vy).Scale(Constants.SHOPPER_SPEED);

            List<Actor> players = scene.GetCast().GetActors("player");
            foreach(Actor actor in players){
                Player player = (Player) actor;
                if(player.GetPlayerID() == 5 && player.GetIsAlive()){
                    if (isPunching && player.GetFrameTick() > Constants.PUNCH_COOLDOWN_DURATION){ //punching and able to punch
                        player.SetIsPunching(true);
                        player.SetText(Constants.SHOPPER_PUNCHING_FACE);
                        player.ResetFrameTick();
                    }
                    if(player.GetFrameTick() > Constants.PUNCH_DURATION){ //no longer punching
                        player.SetIsPunching(false);
                        player.SetText(Constants.SHOPPER_FACE);
                    }
                    if(!player.GetIsPunching()){ //not actually punching
                        player.SetVelocity(velocity);
                    }
                    else{ //punching
                        player.SetVelocity(new Point(0, 0));
                    }
                    player.IncrementFrameTick(); //always increment the frame tick
                }
            }
        }
    }
}