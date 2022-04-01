using black_friday.Game.Casting;
using black_friday.Game.Services;
using black_friday.Game.Directing;


namespace black_friday.Game.Scripting
{
    public class PlaySoundAction : Action
    {
        private AudioService audioService;
        

        public PlaySoundAction(AudioService audioService)
        {
            this.audioService = audioService;
           
        }

        public void Execute(Scene scene)
        {
            Cast cast = scene.GetCast();
            List<Actor> actors = cast.GetActors("sound");
            foreach(Actor actor in actors){
                Sound sound = (Sound)actor;
                audioService.PlaySound(sound);
                cast.RemoveActor("sound",sound);
            }
            
        }
    }
}