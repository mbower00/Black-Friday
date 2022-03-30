using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class SetRulesInfoAction : Action{
        
        public SetRulesInfoAction(){
        }

        public void Execute(Scene scene){
            List<Actor> infos = scene.GetCast().GetActors("info");
            foreach(Actor actor in infos){
                if(actor.GetWidth() == 800){
                    switch(scene.GetNextSceneInfo().GetGameMode()){
                        case "battleroyale":
                            actor.SetText("Find the other players while\nbeing undetected to knock \nthem out! (Hint: Try to mimic \nthe npcs to remain undetected");
                            break;
                        case "shoplifter":
                            actor.SetText("Shoplifters: steal toasters\n(Hint: you can punch others)\nMall Cop (uses mouse): \neliminate shoplifters");
                            break;
                        default:
                            actor.SetText("error");
                            break;
                    }
                }
            }
        }
    }
}