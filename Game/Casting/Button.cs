//#include "raylib.h"
using Raylib_cs;
namespace black_friday.Game.Casting{
    class Button : Actor{

        bool isClicked;
        public Button(){
        }
        public bool GetIsClicked(){
            return isClicked;
        }
        public void SetIsClicked(bool isClicked){
            this.isClicked = isClicked;
        }
    }
}