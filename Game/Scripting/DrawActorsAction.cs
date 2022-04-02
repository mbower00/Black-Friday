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
            
            Cast cast = scene.GetCast();
            if(cast.ContainsActorKey("background")){DrawBackground(scene);}
            if(cast.ContainsActorKey("button")){DrawButtons(scene);}
            if(cast.ContainsActorKey("player")){DrawPlayers(scene);}
            if(cast.ContainsActorKey("zombie")){DrawZombies(scene);}
            if(cast.ContainsActorKey("toaster")){DrawToasters(scene);}
            if(cast.ContainsActorKey("score")){DrawScores(scene);}
            if(cast.ContainsActorKey("info")){DrawInfos(scene);}
            
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
        private void DrawToasters(Scene scene)
        {
            List<Actor> infos = scene.GetCast().GetActors("toaster");
            foreach (Actor info in infos)
            {
                videoService.DrawActorText(info);
            }
        }
        private void DrawScores(Scene scene)
        {
            List<Actor> infos = scene.GetCast().GetActors("score");
            foreach (Actor info in infos)
            {
                videoService.DrawActorText(info);
            }
        }
        private void DrawPlayers(Scene scene)
        {
            List<Actor> infos = scene.GetCast().GetActors("player");
            foreach (Actor info in infos)
            {
                videoService.DrawActorText(info);
            }
        }
        private void DrawZombies(Scene scene)
        {
            List<Actor> infos = scene.GetCast().GetActors("zombie");
            foreach (Actor info in infos)
            {
                videoService.DrawActorText(info);
            }
        }
    }
}