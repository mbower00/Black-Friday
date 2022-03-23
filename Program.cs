using black_friday.Game.Services;
using black_friday.Game.Scripting;
using black_friday.Game.Directing;
using black_friday.Game.Casting;

namespace black_friday{
    public class Program{
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args){
            
            //CREATE THE SERVICES
            //Create the VIDEO service
            KeyboardService keyboardService = new KeyboardService();
            //Create the KEYBOARD service
            VideoService videoService = new VideoService(false);
            
            
            
            
            //CREATE THE HOME SCENE
            Scene homeScene = new Scene();
            //Create the cast for the HOME scene
            Cast homeCast = new Cast();
            //Create the __ actor
            Actor homeTitle = new Actor();
            homeTitle.SetColor(Constants.BANNER_WHITE);
            
            //Create the __ actor
            
            //Create the __ actor
            
            //Create the __ actor
            
            //Add actor(s) to the cast for the HOME scene
            
            //Create the script for the HOME scene
            Script homeScript = new Script();
            //Add INPUT action(s) to the script for the HOME scene
            
            //Add UPDATE action(s) to the script for the HOME scene
            
            //Add OUTPUT action(s) to the script for the HOME scene
            
            //Add the cast and script to the HOME scene
            homeScene.SetCast(homeCast);
            homeScene.SetScript(homeScript);



            //CREATE THE SETTINGS SCENE
            Scene settingsScene = new Scene();
            //Create the cast for the SETTINGS scene
            Cast settingsCast = new Cast();
            //Create the __ actor
            
            //Create the __ actor
            
            //Create the __ actor
            
            //Create the __ actor
            
            //Add actor(s) to the cast for the SETTINGS scene
            
            //Create the script for the SETTINGS scene
            Script settingsScript = new Script();
            //Add INPUT action(s) to the script for the SETTINGS scene
            
            //Add UPDATE action(s) to the script for the SETTINGS scene
            
            //Add OUTPUT action(s) to the script for the SETTINGS scene
            
            //Add the cast and script to the SETTINGS scene
            settingsScene.SetCast(settingsCast);
            settingsScene.SetScript(settingsScript);



            //CREATE THE RULES SCENE
            Scene rulesScene = new Scene();
            //Create the cast for the RULES scene
            Cast rulesCast = new Cast();
            //Create the __ actor
            
            //Add actor(s) to the cast for the RULES scene
            
            //Create the script for the RULES scene
            Script rulesScript = new Script();
            //Add INPUT action(s) to the script for the RULES scene
            
            //Add UPDATE action(s) to the script for the RULES scene
            
            //Add OUTPUT action(s) to the script for the RULES scene
            
            //Add the cast and script to the RULES scene
            rulesScene.SetCast(rulesCast);
            rulesScene.SetScript(rulesScript);



            //CREATE THE PLAYER SELECT SCENE
            Scene playerSelectScene = new Scene();
            //Create the cast for the PLAYER SELECT scene
            Cast playerSelectCast = new Cast();
            //Create the __ actor
            
            //Add actor(s) to the cast for the PLAYER SELECT scene
            
            //Create the script for the PLAYER SELECT scene
            Script playerSelectScript = new Script();
            //Add INPUT action(s) to the script for the PLAYER SELECT scene
            
            //Add UPDATE action(s) to the script for the PLAYER SELECT scene
            
            //Add OUTPUT action(s) to the script for the PLAYER SELECT scene
            
            //Add the cast and script to the PLAYER SELECT scene
            playerSelectScene.SetCast(playerSelectCast);
            playerSelectScene.SetScript(playerSelectScript);



            //CREATE THE BATTLE ROYALE SCENE
            Scene battleRoyaleScene = new Scene();
            //Create the cast for the BATTLE ROYALE scene
            Cast battleRoyaleCast = new Cast();
            //Create the __ actor
            
            //Add actor(s) to the cast for the BATTLE ROYALE scene
            
            //Create the script for the BATTLE ROYALE scene
            Script battleRoyaleScript = new Script();
            //Add INPUT action(s) to the script for the BATTLE ROYALE scene
            
            //Add UPDATE action(s) to the script for the BATTLE ROYALE scene
            
            //Add OUTPUT action(s) to the script for the BATTLE ROYALE scene
            
            //Add the cast and script to the BATTLE ROYALE scene
            battleRoyaleScene.SetCast(battleRoyaleCast);
            battleRoyaleScene.SetScript(battleRoyaleScript);



            //CREATE THE GAME OVER SCENE
            Scene gameOverScene = new Scene();
            //Create the cast for the GAME OVER scene
            Cast gameOverCast = new Cast();
            //Create the __ actor
            
            //Add actor(s) to the cast for the GAME OVER scene
            
            //Create the script for the GAME OVER scene
            Script gameOverScript = new Script();
            //Add INPUT action(s) to the script for the GAME OVER scene
            
            //Add UPDATE action(s) to the script for the GAME OVER scene
            
            //Add OUTPUT action(s) to the script for the GAME OVER scene
            
            //Add the cast and script to the GAME OVER scene
            gameOverScene.SetCast(gameOverCast);
            gameOverScene.SetScript(gameOverScript);






            //CREATE THE DIRECTING
            //Create the DIRECTOR
            Director director = new Director();
            //Create the NEXT SCENE INFO
            NextSceneInfo nextSceneInfo = new NextSceneInfo();
            //Set to start at the HOME SCENE
            nextSceneInfo.SetNextSceneName("home");
            //Declare a method for converting the string scene name to the proper instance of Scene.
            Scene ConvertSceneNameToInstance(string sceneName){
            switch (sceneName){
                case "home":
                    return homeScene;
                case "settings":
                    return settingsScene;
                case "rules":
                    return rulesScene;
                case "playerselect":
                    return playerSelectScene;
                case "battleroyale":
                    return battleRoyaleScene;
                case "gameover":
                    return gameOverScene;
                default:
                    return homeScene;
            }
        }



            //BEGIN THE PROGRAM LOOP
            videoService.OpenWindow();
            while (videoService.IsWindowOpen()){
                //Play the scene that is up to be played (determined by the nextSceneName saved in Program's instance of NextSceneInfo), then assign the returned instance of NextSceneInfo to Program's instance of NextSceneInfo
                nextSceneInfo = director.PlayScene(ConvertSceneNameToInstance(nextSceneInfo.GetNextSceneName()));
                //Set the scene-to-be-executed-next's instance of NextSceneInfo to be equal to Program's (newly updated) instance of NextSceneInfo.
                //This way, a scene can communicate to the next scene.
                ConvertSceneNameToInstance(nextSceneInfo.GetNextSceneName()).SetNextSceneInfo(nextSceneInfo);
            }
            videoService.CloseWindow();
        }
    }
}
