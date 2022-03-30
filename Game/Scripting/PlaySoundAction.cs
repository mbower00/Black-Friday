using black_friday.Game.Casting;
using black_friday.Game.Services;


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
            List<Actor> actors = cast.GetActors("sounds");
            foreach(Actor actor in actors){
                Sound sound = (Sound)actor;
                audioService.PlaySound(sound);
                cast.RemoveActor("sounds",sound);
            }
            
        }
    }
}