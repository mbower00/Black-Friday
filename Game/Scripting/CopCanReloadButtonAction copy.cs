using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class ExtraAmmoButtonAction : Action{
        
        private List<bool> options = new List<bool>();
        private int optionIndex = 0;
        
        


        public ExtraAmmoButtonAction(){
            options.Add(true);
            options.Add(false);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Cop Can Reload: {Constants.COP_CAN_RELOAD}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.COP_CAN_RELOAD = GetNextOption();
                        button.SetText($"Cop Can Reload: {Constants.COP_CAN_RELOAD}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private bool GetNextOption(){
            optionIndex++;
            if (optionIndex >= options.Count()){optionIndex = 0;}
            bool NextOption = options[optionIndex];
            return NextOption;
        }
    }
}