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
                            actor.SetText("Carol down the street KNEW\nyou were getting the new\nBarbie bike for your daughter\nFind her and get rid of her\n, you're a better mom than her after all\n(Hint: Try to mimic \nthe npcs to remain undetected");
                            scene.GetCast().AddActor("sound", new Sound("black_friday\Game\Props\Informational\BRJ.wav"));
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