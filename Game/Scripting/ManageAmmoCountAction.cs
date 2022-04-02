using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
namespace black_friday.Game.Scripting{
    class ManageAmmoCountAction : Action{
        
        
        public ManageAmmoCountAction(){
        }

        public void Execute(Scene scene){
            List<Actor> infoActors = scene.GetCast().GetActors("info");
            Actor mallcopActor = scene.GetCast().GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallcopActor;

            foreach(Actor actor in infoActors){
                if (actor.GetPosition().Equals(new Point(0 + 25, 0 + 20))){
                    actor.SetText($"AMMO: {mallCop.GetAmmo()}");
                    actor.SetTextColor(new Color(GetColorNumber(mallCop), GetPrimeColorNumber(mallCop), GetColorNumber(mallCop), 175));
                }
            }
        }

        private int GetColorNumber(MallCop mallCop){
            int frameTick = mallCop.GetFrameTick();
            //if(frameTick == 0){frameTick = 1;}
            //return (int) (255 % ((decimal) (frameTick / Constants.GET_COP_RELOAD_TIME()) * 255));
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= 1){
                return 0;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .9){
                return 20;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .8){
                return 32;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .7){
                return 44;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .6){
                return 56;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .5){
                return 68;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .4){
                return 80;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .3){
                return 92;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .2){
                return 104;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .1){
                return 116;
            }
            else{
                return 128;
            }
        }

        private int GetPrimeColorNumber(MallCop mallCop){
            int frameTick = mallCop.GetFrameTick();
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= 1){
                return 255;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .9){
                return 243;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .8){
                return 230;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .7){
                return 217;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .6){
                return 204;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .5){
                return 192;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .4){
                return 179;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .3){
                return 166;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .2){
                return 153;
            }
            if ((double) frameTick / Constants.GET_COP_RELOAD_TIME() >= .1){
                return 140;
            }
            else{
                return 128;
            }
        }
    }
}