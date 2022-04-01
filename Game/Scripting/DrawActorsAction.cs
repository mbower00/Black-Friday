using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    class DrawActorsAction : Action{
        private VideoService videoService;
        public DrawActorsAction(VideoService videoService){
            this.videoService = videoService;
        }

        public void Execute(Scene scene){
            videoService.ClearBuffer();
            DrawBackground(scene);
            DrawButtons(scene);
            DrawInfos(scene);
            videoService.FlushBuffer();
        } 

        private void DrawBackground(Scene scene)
        {
            Actor background = scene.GetCast().GetFirstActor("background");
            videoService.DrawActorImage(background);
        }

        private void DrawButtons(Scene scene)
        {
            List<Actor> buttons = scene.GetCast().GetActors("button");
            foreach (Actor button in buttons)
            {
                videoService.DrawActorText(button);
            }
        }

        private void DrawInfos(Scene scene)
        {
            List<Actor> infos = scene.GetCast().GetActors("info");
            foreach (Actor info in infos)
            {
                videoService.DrawActorText(info);
            }
        }
    }
}