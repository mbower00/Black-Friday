using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class PlayButtonAction : Action{
        
        public PlayButtonAction(){
        }
        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == "Start Game"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        scene.SetIsSceneOver(true);
                        switch(scene.GetNextSceneInfo().GetGameMode()){
                            case "battleroyale":
                                scene.GetNextSceneInfo().SetNextSceneName("battleroyale");
                                break;
                            case "shoplifter":
                                scene.GetNextSceneInfo().SetNextSceneName("shoplifter");
                                break;
                            default:
                                Console.WriteLine("default case in PlayButtonAction");
                                scene.GetNextSceneInfo().SetNextSceneName("battleroyale");
                                break;
                        }
                        scene.GetNextSceneInfo().SetGameMode(scene.GetNextSceneInfo().GetGameMode());
                        button.SetIsClicked(false);
                    }
                }
            }
        }
    }
}