using System.Collections.Generic;
using black_friday.Game.Casting;
using black_friday.Game.Scripting;
using black_friday.Game.Services;


namespace black_friday.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {

        VideoService videoService;

        /// <summary>
        /// Constructs a new instance of Director
        /// </summary>
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the scene and plays the scene until the end is triggered
        /// </summary>
        /// <param name="scene">the given scene to play</param>
        /// <returns>the name of the scene to play next</returns>
        public NextSceneInfo PlayScene(Scene scene)
        {
            while (videoService.IsWindowOpen()){
                if (scene.GetIsGameScene()){
                    ExecuteActions("start", scene);
                }
                while (!scene.GetIsSceneOver())
                {
                    ExecuteActions("input", scene);
                    ExecuteActions("update", scene);
                    ExecuteActions("output", scene);
                    if(!videoService.IsWindowOpen()){videoService.CloseWindow();}
                }
                scene.SetIsSceneOver(false);
                return scene.GetNextSceneInfo();
            }
            return new NextSceneInfo();
        }

        /// <summary>
        /// Calls execute for each action in the given group.
        /// </summary>
        /// <param name="group">the type of action(s) to execute</param>
        /// <param name="scene">the given scene</param>
        private void ExecuteActions(string group, Scene scene)
        {
            List<black_friday.Game.Scripting.Action> actions = scene.GetScript().GetActions(group);
            foreach(black_friday.Game.Scripting.Action action in actions)
//     ↑↑↑↑↑  Not sure if "black_friday.Game.Scripting.Action" can be simpleified.  ↑↑↑↑↑ 
            {
               action.Execute(scene);
            }
        }
    }
}