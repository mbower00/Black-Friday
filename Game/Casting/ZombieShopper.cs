namespace black_friday.Game.Casting{
    class ZombieShopper : Actor{
        private int frameTick;
        
        public ZombieShopper(){
            this.frameTick = 0;
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
    }

}

/*
Ad random directions and pauses  --  Jesse
*/