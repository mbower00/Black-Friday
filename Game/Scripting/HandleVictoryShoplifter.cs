using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class HandleVictoryShoplifter : Action{
        
        public HandleVictoryShoplifter(){
        }

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            List<Actor> players = cast.GetActors("player");
            List<Actor> toasters = cast.GetActors("toaster");
            Actor mallCopActor = cast.GetFirstActor("mallcop");
            MallCop mallCop = (MallCop) mallCopActor;

            
        }
    }
}