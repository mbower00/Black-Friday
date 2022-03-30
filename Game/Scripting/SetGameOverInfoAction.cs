using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class SetGameOverInfoAction : Action{
        
        public SetGameOverInfoAction(){
        }

        public void Execute(Scene scene){
            List<Actor> infos = scene.GetCast().GetActors("info");
            foreach(Actor actor in infos){
                if(actor.GetFontSize() == 75){
                    actor.SetText($"{scene.GetNextSceneInfo().GetWinner()} Won!");
                }
            }
        }
    }
}