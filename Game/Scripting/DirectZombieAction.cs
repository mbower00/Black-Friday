using black_friday.Game.Casting;
using black_friday.Game.Directing;

namespace black_friday.Game.Scripting{
      //players and zombies only move north, south, east, west, north-east, south-east, south-west, north-west
    class DirectZombieAction : Action{
        int x = 0;
        int y = 0;
        public DirectZombieAction(){

        }


        public void Execute(Scene scene){

            Random random = new Random();
            Point randomDirection = new Point();

            randomDirection.Random.next(x
        }
        

    }
}
