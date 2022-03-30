using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ReloadMallCopGunAction : Action{

        public ReloadMallCopGunAction(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            Actor mallCopActor = cast.GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallCopActor;
            
            if(Constants.COP_CAN_RELOAD){
                mallCop.IncrementFrameTick();

                if(mallCop.GetAmmo() <= 0 && mallCop.GetFrameTick() >= Constants.GET_COP_RELOAD_TIME()){
                    mallCop.IncrementAmmo();
                    Console.WriteLine("reload");
                }
            }


        }
    }
}