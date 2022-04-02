using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class ExtraAmmoButtonAction : Action{
        
        private List<int> options = new List<int>();
        private int optionIndex = 0;
        
        


        public ExtraAmmoButtonAction(){
            options.Add(0);
            options.Add(1);
            options.Add(2);
            options.Add(3);
            options.Add(4);
            options.Add(5);
            options.Add(10);
            options.Add(50);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Extra Ammo Count: {Constants.EXTRA_AMMO}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.EXTRA_AMMO = GetNextOption();
                        button.SetText($"Extra Ammo Count: {Constants.EXTRA_AMMO}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private int GetNextOption(){
            optionIndex++;
            if (optionIndex >= options.Count()){optionIndex = 0;}
            int NextOption = options[optionIndex];
            return NextOption;
        }
    }
}