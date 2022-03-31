using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class ShopperSpeedButtonAction : Action{
        
        private List<int> shopperSpeeds = new List<int>();
        private int currentshopperSpeedIndex = 0;
        
        


        public ShopperSpeedButtonAction(){
            shopperSpeeds.Add(5);
            shopperSpeeds.Add(7);
            shopperSpeeds.Add(10);
            shopperSpeeds.Add(15);
            shopperSpeeds.Add(3);
            shopperSpeeds.Add(1);
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Shopper Speed: {Constants.SHOPPER_SPEED}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.SHOPPER_SPEED = GetNextshopperSpeed();
                        button.SetText($"Shopper Speed: {Constants.SHOPPER_SPEED}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private int GetNextshopperSpeed(){
            currentshopperSpeedIndex++;
            if (currentshopperSpeedIndex >= shopperSpeeds.Count()){currentshopperSpeedIndex = 0;}
            int NextshopperSpeed = shopperSpeeds[currentshopperSpeedIndex];
            return NextshopperSpeed;
        }
    }
}