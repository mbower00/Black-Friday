using black_friday.Game.Services;
using black_friday.Game.Directing;

namespace black_friday.Game.Scripting{
    class DrawActorsAction : Action{
        private VideoService videoService;
        public DrawActorsAction(VideoService videoService){
            this.videoService = videoService;
        }

        public void Execute(Scene scene){

        } 
    }
}