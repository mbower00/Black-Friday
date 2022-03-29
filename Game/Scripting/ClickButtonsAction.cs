using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class ClickButtonsAction : Action{
        
        MouseService mouseService;
        
        public ClickButtonsAction(MouseService mouseService){
            this.mouseService = mouseService;
        }

        public void Execute(Scene scene){
            List<Actor> buttons = scene.GetCast().GetActors("button");
            
            foreach (Actor actor in buttons){
                Button button = (Button) actor;
                if(IsButtonClicked(button)){
                    button.SetIsClicked(true);
                }
            }
        }

        private bool IsButtonClicked(Button button){
            List<Point> points = button.GetAllPoints();
            Point mousePoint = mouseService.GetCoordinates();
            foreach(Point point in points){
                if (mousePoint.Equals(point) && mouseService.IsButtonPressed("left")){
                    return true;
                }
            }
            return false;
        }
    }
}