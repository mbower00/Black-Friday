using black_friday.Game.Casting;
using black_friday.Game.Scripting;

namespace black_friday.Game.Directing{
    /// <summary>
    /// Holds the cast members and the scripts for the scene. Also, keeps track of what the next scene should be and when the scene is over.
    /// </summary>
    public class Scene{
        private bool isSceneOver;
        private Cast cast;
        private Script script;
        private bool isGameScene;
        NextSceneInfo nextSceneInfo = new NextSceneInfo();
        public Scene(){
            isSceneOver = false;
            isGameScene = false;
        }

        //GETTERS AND SETTERS...
        public void SetScript(Script script){
            this.script = script;
        }
        public Script GetScript(){
            return script;
        }

        public void SetCast(Cast cast){
            this.cast = cast;
        }

        public Cast GetCast(){
            return cast;
        }

        public void SetNextSceneInfo(NextSceneInfo nextSceneInfo){
            this.nextSceneInfo = nextSceneInfo;
        }

        public NextSceneInfo GetNextSceneInfo(){
            return nextSceneInfo;
        }

        public bool GetIsSceneOver(){
            return isSceneOver;
        }

        public void SetIsSceneOver(bool isSceneOver){
            this.isSceneOver = isSceneOver;
        }

        public void SetIsGameScene(bool isGameScene)
        {
            this.isGameScene = isGameScene;
        }
        
        public bool GetIsGameScene()
        {
            return isGameScene;
        }
    }
}