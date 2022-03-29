using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class TimerCountButtonAction : Action{
        
        private List<int> timerCounts = new List<int>();
        private int currentTimerCountIndex = 0;
        
        


        public TimerCountButtonAction(){
            timerCounts.Add(100);
            timerCounts.Add(150);
            timerCounts.Add(200);
            timerCounts.Add(250);
            timerCounts.Add(10);
            timerCounts.Add(25);
            timerCounts.Add(50);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Timer Count: {Constants.TIMER_COUNT}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.TIMER_COUNT = GetNextTimerCount();
                        button.SetText($"Timer Count: {Constants.TIMER_COUNT}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private int GetNextTimerCount(){
            currentTimerCountIndex++;
            if (currentTimerCountIndex >= timerCounts.Count()){currentTimerCountIndex = 0;}
            int NextTimerCount = timerCounts[currentTimerCountIndex];
            return NextTimerCount;
        }
    }
}