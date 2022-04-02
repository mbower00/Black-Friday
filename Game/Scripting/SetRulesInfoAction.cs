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
                if(actor.GetWidth() == 1060){
                    switch(scene.GetNextSceneInfo().GetGameMode()){
                        case "battleroyale":
                            actor.SetText("Carol down the street KNEW you were getting the new \nBarbie bike for your daughter! Find her and get rid of her,\nyou're a better mom than her after all\n\nMimc and eliminate others to be the last player left");
                            scene.GetCast().AddActor("sound", new Sound(Constants.GET_BATTLE_ROYALE_SOUND()));
                            break;
                        case "shoplifter":
                            actor.SetText("Oh no... There's been word of shoplifters stealing toasters.\nFind them and take them out to restore honor to your\nBadge! You'll show those City Cops that Mall Cops are just\nas good!\n\nShoplifters: steal the most toasters while staying alive\n(Hint: you can eliminate others)\nMall Cop (uses mouse): eliminate shoplifters\n(Hint: hover over toasters to reveal if they have been \nstolen)");
                            break;
                        case "teambattle":
                            actor.SetText("Aw, come on! Carol brought a whole group. Good thing you're \nnot the only mom on the street who is environmentally \nfrendly. You started carpooling WAY before she ever did, \nanyways.\n\nTeams:\n\t\tOdd players (e.g. P1, P3, etc..)\n\t\tEven players (e.g. P2, P4, etc..)\nGet more knock outs than the other team.\n(Hint: You will be revived moments after being knocked out,\nso be ready!)");
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