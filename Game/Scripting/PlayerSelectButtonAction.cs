using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class PlayerSelectButtonAction : Action{
        
        public PlayerSelectButtonAction(){
        }
        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == "To Player Select"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        scene.SetIsSceneOver(true);
                        scene.GetNextSceneInfo().SetNextSceneName("playerselect");
                        button.SetIsClicked(false);
                        scene.GetNextSceneInfo().SetGameMode(scene.GetNextSceneInfo().GetGameMode());
                    }
                }
            }
        }
    }
}