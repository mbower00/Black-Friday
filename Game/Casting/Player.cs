namespace black_friday.Game.Casting{
    class Player : Actor{
        private int playerID = 0;
        Random random = new Random();
        private bool isPunching;
        private int frameTick = Constants.PUNCH_COOLDOWN_DURATION + Constants.PUNCH_DURATION + 1;
        
        public Player(){
            this.SetText(Constants.SHOPPER_FACE);
            this.SetColor(new Color(random.Next(30, 230), random.Next(30, 230), random.Next(30, 230)));
            this.SetTextColor(Constants.WHITE);
            this.SetWidth(50);
            this.SetHeight(50);
            this.SetFontSize(50);
            this.SetPosition(new Point(random.Next(Constants.MAX_X - this.GetWidth() + 1), random.Next(Constants.MAX_Y - this.GetHeight() + 1)));
        }

        public void SetIsPunching(bool isPunching)
        {
            this.isPunching = isPunching;
        }
        
        public bool GetIsPunching()
        {
            return isPunching;
        }

        public void SetPlayerID(int playerID)
        {
            this.playerID = playerID;
        }
        
        public int GetPlayerID()
        {
            return playerID;
        }

        /// <summary>
        /// Gets the frame tick for this instance of Player
        /// </summary>
        /// <returns>The frame tick</returns>
        public int GetFrameTick(){
            return this.frameTick;
        }

        /// <summary>
        /// Increments the frame tick
        /// </summary>
        /// <param name="increment">The amount by which to increment the frame tick (DEFAULT = 1)</param>
        public void IncrementFrameTick(int increment = 1){
            this.frameTick += increment;
        }
        
        /// <summary>
        /// Sets the frame tick to 0
        /// </summary>
        public void ResetFrameTick(){
            this.frameTick = 0;
        }
    }
}