using black_friday.Game.Casting;

namespace black_friday{
    public class Constants
    {
        public static string DEAD_SHOPPER_FACE = " :(";
        public static string SHOPPER_FACE = " :)";
        public static string SHOPPER_PUNCHING_FACE = ">:(";
        public static int PUNCH_DURATION = 30; //IN FRAMES
        public static int PUNCH_COOLDOWN_DURATION = 120; //IN FRAMES
        public static int SHOPPER_SPEED = 5;
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 1350;
        public static int MAX_Y = 900;
        public static int TIMER_COUNT = 100;
        public static int NPC_COUNT = 10;
        public static int PLAYER_COUNT = 2;
        public static int FRAME_RATE = 60;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Black Friday";
        public static Color RED = new Color(255, 0, 0);
        public static Color BANNER_RED = new Color(255, 0, 0, 175);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);
        public static Color BANNER_GREEN = new Color(0, 255, 0, 175);
        public static Color BLUE = new Color(0, 0, 255);
        public static Color BANNER_BLUE = new Color(0, 0, 255, 175);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color BANNER_WHITE = new Color(255, 255, 255, 125);
        public static Color BLACK = new Color(0, 0, 0);
        public static Color BANNER_BLACK = new Color(0, 0, 0, 175);
        public static Color CLEAR = new Color(0, 0, 0, 0);
    }
}