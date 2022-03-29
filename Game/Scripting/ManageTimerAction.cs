using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ManageTimerAction : Action{
        
        public ManageTimerAction(){
        }

        public void Execute(Scene scene){
            Actor firstActor = scene.GetCast().GetFirstActor("info");
            Game.Casting.Timer timer = (Game.Casting.Timer) firstActor;

            timer.SetText($"{Constants.TIMER_COUNT - timer.GetSecondTick()}");

            //manage if time runs out
            switch (Constants.TIMER_COUNT - timer.GetSecondTick()){
                case 0:
                    scene.SetIsSceneOver(true);
                    scene.GetNextSceneInfo().SetNextSceneName("gameover");
                    scene.GetNextSceneInfo().SetWinner("No One");
                    timer.SetFrameTick(-2);
                    timer.SetSecondTick(0);
                    break;
                default:
                    break;
            }

            //update the tick
            switch (timer.GetFrameTick() - Constants.FRAME_RATE){
                case 0:
                    timer.SetFrameTick(0);
                    timer.IncrementSecondTick();
                    break;
                default:
                    timer.IncremenFrameTick();
                    break;
            }

        }
    }
}