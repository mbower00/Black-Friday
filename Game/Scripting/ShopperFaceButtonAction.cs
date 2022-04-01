using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;
using System.Collections.Generic;


namespace black_friday.Game.Scripting{
    class ShopperFaceButtonAction : Action{
        
        private List<string> shopperFaces = new List<string>();
        private int currentShopperFaceIndex = 0;
        
        


        public ShopperFaceButtonAction(){
            shopperFaces.Add(" :)");
            shopperFaces.Add(" :|");
            shopperFaces.Add(":\\");
            shopperFaces.Add(" :]");
            shopperFaces.Add(":D");
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach(Actor actor in buttons){
                if(actor.GetText() == $"Shopper Face: {Constants.SHOPPER_FACE}"){
                    Button button = (Button) actor;
                    if(button.GetIsClicked()){
                        Constants.SHOPPER_FACE = GetNextShopperFace();
                        button.SetText($"Shopper Face: {Constants.SHOPPER_FACE}");
                        button.SetIsClicked(false);
                    }
                }
            }
        }

        private string GetNextShopperFace(){
            currentShopperFaceIndex++;
            if (currentShopperFaceIndex >= shopperFaces.Count()){currentShopperFaceIndex = 0;}
            string nextShopperFace = shopperFaces[currentShopperFaceIndex];
            return nextShopperFace;
        }
    }
}