#include "raylib.h"
using Raylib_cs;
namespace black_friday.Game.Casting{
    class Button : Actor{

        bool isClicked;
        
        public bool CanClick()
    {
        Vector2 mousePos = new Vector2(Raylib.GetMousePosition().X, Raylib.GetMousePosition().Y);           // Get the position of the mouse
        if (mousePos.X >= GlobalPosition.X && mousePos.X <= (GlobalPosition.X + ButtonWidth))
        {
            if (mousePos.Y >= GlobalPosition.Y && mousePos.Y <= GlobalPosition.Y + ButtonHeight)
            {
                return true;
            }
        }

        return false;
    }

    public void DetectClick()
    {
        if(Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
        {
            if(CanClick())
            {
                Console.WriteLine(objectName + " Pos: " + GlobalPosition.ToString());
                if (!isClicked)
                {
                    isClicked = true;
                }
            }
        }
    }
        
        public Button(){
            

        }
    }
}