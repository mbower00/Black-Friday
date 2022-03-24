//#include "raylib.h"
using Raylib_cs;
namespace black_friday.Game.Casting{
    class Button : Actor{

        bool isClicked;
        public Button(){
        }
        public bool GetisClicked(){
            return isClicked;
        }
        public bool SetisClicked(){
            this.isClicked = isClicked;
        }
    }
}