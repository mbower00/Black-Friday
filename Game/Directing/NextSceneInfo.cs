namespace black_friday.Game.Directing{
    /// <summary>
    /// Holds useful information for transitioning between sences and starting the game.
    /// 
    /// The PlayScene() method of Director uses this to return a packet of information to Program.
    /// 
    /// When a scene is transitioned to and begins, it's instance of NextSceneInfo will be equal to the scene-that-just-played's ending instace of NextSceneInfo.
    /// This is useful because scenes can communicate with the next scene as well as recive commnications from the previous scene.
    /// For Example:
    /// The battleRoyaleScene begins
    /// The battle royale game is played with player one being victorious
    /// The battleRoyaleScene sets its instance of NextSceneInfo's attribute of winner to "p1"
    /// The battleRoyaleScene ends
    /// At the end of battleRoyaleScene, the next scene to be played is gameOverScene
    /// The gameOverScene's instance of NextSceneInfo is set to what the battleRoyaleScene's instance of NextSceneInfo was at it's end
    /// The gameOverScene begins
    /// The gameOverScene discovers that its instance of NextSceneInfo's attribute of winner is "p1"
    /// The gameOverScene determines that "p1" means that player one was the winner displays text saying "Player One Wins!" 
    /// </summary>
    public class NextSceneInfo{
        private string nextSceneName;
        private string winner;
        private string gameMode;

        /// <summary>
        /// Constructs a new instance of the NextSceneInfo class
        /// </summary>
        public NextSceneInfo(){
            winner = "";
            nextSceneName = "";
            gameMode = "";
        }

        /// <summary>
        /// Sets the next scene equal to the lowercase of the passed string
        /// </summary>
        /// <param name="sceneName">the desired next scene's name (no spaces, e.g. "gameover")</param>
        public void SetNextSceneName(string nextSceneName){
            nextSceneName.ToLower();
            this.nextSceneName = nextSceneName;
        }

        public string GetNextSceneName(){
            return nextSceneName;
        } 

        /// <summary>
        /// Sets the winner string equal to the lowercase of the passed string
        /// </summary>
        /// <param name="winner">the desired winner string (eg... "Player 1", "Player 2", "Team 1", "No One", etc...)</param>
        public void SetWinner(string winner){
            winner.ToLower();
            this.winner = winner;
        }

        public string GetWinner(){
            return winner;
        }

        public void SetGameMode(string gameMode){
            gameMode.ToLower();
            this.gameMode = gameMode;
        }

        public string GetGameMode(){
            return gameMode;
        }

    }
}