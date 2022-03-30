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
                if (actor.GetTextColor() == Constants.BANNER_RED){
                    actor.SetText($"AMMO: {mallCop.GetAmmo()}");
                }
            }
        }
    }
}