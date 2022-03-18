namespace black_friday.Game.Directing{
    /// <summary>
    /// Holds useful information for transitioning between sences. Created so that the PlayScene() method of Director can pass a packet of information.
    /// </summary>
    public class NextSceneInfo{
        string nextSceneName;
        string winner;

        /// <summary>
        /// Constructs a new instance of the NextSceneInfo class
        /// </summary>
        public NextSceneInfo(){
            winner = "";
            nextSceneName = "";
        }

        /// <summary>
        /// Sets the next scene equal to the lowercase of the passed string
        /// </summary>
        /// <param name="sceneName">the desired next scene's name (e.g. "gameoverscene")</param>
        public void SetNextSceneName(string nextSceneName){
            nextSceneName.ToLower();
            this.nextSceneName = nextSceneName;
        }

        public string GetNextSceneName(string nextSceneName){
            return nextSceneName;
        } 

        /// <summary>
        /// Sets the winner string equal to the lowercase of the passed string
        /// </summary>
        /// <param name="winner">the desired winner string (eg... "p1", "t1", "p2", "p3", "p4", "none", etc...)</param>
        public void SetWinner(string winner){
            winner.ToLower();
            this.winner = winner;
        }

        public string GetWinner(string winner){
            return winner;
        }

    }
}