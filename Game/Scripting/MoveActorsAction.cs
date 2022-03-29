using black_friday.Game.Services;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday.Game.Scripting{
    
    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    class MoveActorsAction : Action{


    /// <summary>
    /// Constructs a new instance of MoveActorsAction.
    /// </summary>
        public MoveActorsAction(){}

        public void Execute(Scene scene){
            Cast cast = scene.GetCast();
            
            // a) get all the actors from the cast
            List<Actor> actors = cast.GetAllActors();
            // b) loop through all the actors
            foreach(Actor i in actors){
                // c) call the MoveNext() method on each actor.
                i.MoveNext();
            }
        }

    }
}