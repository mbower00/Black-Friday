namespace black_friday.Game.Casting{
    class MallCop : Actor{
        private int playerID;

        private int ammo = 0;
        
        public MallCop(){
            playerID = -1;
            SetHeight(1);
            SetWidth(1);
            SetColor(Constants.CLEAR);
            SetTextColor(Constants.CLEAR);
            ammo = Constants.PLAYER_COUNT + Constants.EXTRA_AMMO;
        }

        public bool IsCollidingWith(Actor actor){
            int x = this.GetPosition().GetX();
            int y = this.GetPosition().GetY();
            List<int> edges = GetHitBoxEdges(actor);

            if(y >= edges[0] && y <= edges[1] && x >= edges[2] && x <= edges[3]){
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the edges of the hit box of an actor
        /// </summary>
        /// <param name="actor">an actor</param>
        /// <returns>[0]top [1]bottom [2]left [3]right</returns>
        private List<int> GetHitBoxEdges(Actor actor){
            List<int> edges = new List<int>();
            
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int h = actor.GetHeight();
            int w = actor.GetWidth();
            
            int top = y;
            edges.Add(top);
            int bottom = y + h;
            edges.Add(bottom);
            int left = x;
            edges.Add(left);
            int right = x + w;
            edges.Add(right);

            return edges;
        }

        public void SetPlayerID(int playerID){this.playerID = playerID;}
        public int GetPlayerID(){return playerID;}
        public void SetAmmo (int ammo){this.ammo = ammo;}
        public int GetAmmo (){return ammo;}
        public void IncrementAmmo (int increment = 1){this.ammo += increment;}
        public void DecrementAmmo (int decrement = 1){this.ammo -= decrement;}
        public bool IsEnoughAmmo(){
            if(ammo > 0){return true;}
            return false;
        }
    }
}