using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class MoveMallCopAction : Action{
        MouseService mouseService = new MouseService();


        public MoveMallCopAction(){}

        public void Execute(Scene scene){
            scene.GetCast().GetFirstActor("mallcop").SetPosition(mouseService.GetCoordinates());
        }

    }
}