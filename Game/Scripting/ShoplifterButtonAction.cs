using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ShoplifterButtonAction : Action{
        
        public ShoplifterButtonAction(){
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == "Shoplifter"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        scene.SetIsSceneOver(true);
                        scene.GetNextSceneInfo().SetNextSceneName("rules");
                        scene.GetNextSceneInfo().SetGameMode("shoplifter");
                        button.SetIsClicked(false);
                    }
                }
            }
        }
    }
}