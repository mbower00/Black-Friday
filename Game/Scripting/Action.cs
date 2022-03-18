using black_friday.Game.Directing;

namespace black_friday.Game.Scripting{
    /// <summary>
    /// <para>A thing that is done.</para>
    /// <para>
    /// The responsibility of action is to do something that is integral or important in the game. 
    /// Thus, it has one method, Execute(...), which should be overridden by derived classes.
    /// </para>
    /// </summary>
    public interface Action{
        /// <summary>
        /// Executes something that is important in the game. This method should be overriden by 
        /// derived classes.
        /// 
        /// You will want to run this code in your overriden Execute() method to get the sperate elements of the scene:
        /// Script script = scene.GetScript();
        /// Cast cast = scene.GetCast();
        /// NextSceneInfo nextSceneInfo = scene.GetNextSceneInfo();
        /// </summary>
        /// <param name="scene">The scene, which has a cast, script, </param>
        void Execute(Scene scene);
    }
}