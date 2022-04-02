namespace black_friday.Game.Casting{
    class ZombieShopper : Actor{
        private bool isMoving = false;
        private int duration;
        private int frameTick;

        private int teamID = 0;

        private Point direction = new Point(0, 0);
        Random random = new Random();

        public ZombieShopper(){
            frameTick = 0;
            this.SetText(Constants.SHOPPER_FACE);
            this.SetColor(new Color(random.Next(30, 230), random.Next(30, 230), random.Next(30, 230)));
            this.SetTextColor(Constants.WHITE);
            this.SetWidth(50);
            this.SetHeight(50);
            this.SetFontSize(50);
            this.SetPosition(new Point(random.Next(Constants.MAX_X - this.GetWidth() + 1), random.Next(Constants.MAX_Y - this.GetHeight() + 1)));
        }

        /// <summary>
        /// Gets the frame tick for this instance of ZombieShopper
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
        /// Resets the frame tick to 0
        /// </summary>
        public void ResetFrameTick(){
            this.frameTick = 0;
        }

        public void SetIsMoving (bool isMoving){this.isMoving = isMoving;}
        public bool GetIsMoving (){return isMoving;}
        public void SetDuration (int duration){this.duration = duration;}
        public int GetDuration (){return duration;}
        public void SetDirection (Point direction){this.direction = direction;}
        public Point GetDirection (){return direction;}
        public void SetTeamID (int teamID){this.teamID = teamID;}
        public int GetTeamID (){return teamID;}

    }

}