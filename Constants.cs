using black_friday.Game.Casting;

namespace black_friday{
    public class Constants
    {
        
        public static Color LIGHT_BLUE = new Color(30, 30, 230);
        public static Color LIGHT_RED = new Color(230, 30, 30);


        /*SOUNDS*/
        public static string GET_DOUBLE_KILL_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/DKP.wav";
                case 1:
                    return "Game/Props/Sounds/DKJ.wav";
                case 2:
                    return "Game/Props/Sounds/DK3.wav";
                default:
                    return "Game/Props/Sounds/DK3.wav";
            }
        }
        
        public static string GET_TRIPLE_KILL_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/TKP.wav";
                case 1:
                    return "Game/Props/Sounds/TK7.wav";
                case 2:
                    return "Game/Props/Sounds/TK3.wav";
                default:
                    return "Game/Props/Sounds/TK3.wav";
            }
        }
        
        public static string GET_OVERKILL_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/OKP.wav";
                case 1:
                    return "Game/Props/Sounds/OK7.wav";
                case 2:
                    return "Game/Props/Sounds/OK3.wav";
                default:
                    return "Game/Props/Sounds/OK3.wav";
            }
        }
        
        public static string GET_KILLTACULAR_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/KTP.wav";
                case 1:
                    return "Game/Props/Sounds/KT7.wav";
                case 2:
                    return "Game/Props/Sounds/KT3.wav";
                default:
                    return "Game/Props/Sounds/KT3.wav";
            }
        }
        
        public static string GET_BATTLE_ROYALE_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/BRM.wav";
                case 1:
                    return "Game/Props/Sounds/BRJ.wav";
                case 2:
                    return "Game/Props/Sounds/BRN.wav";;
                default:
                    return "Game/Props/Sounds/BRM.wav";

            }
        }

        public static string GET_SHOPLIFTER_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/SLJ.wav";
                case 1:
                    return "Game/Props/Sounds/SLN.wav";
                case 2:
                    return "Game/Props/Sounds/SLM.wav";
                default:
                    return "Game/Props/Sounds/SLM.wav";
            }
        }

        public static string GET_STEAKTACULAR_ENDING_SOUND(){
            Random random = new Random();
            switch(random.Next(0, 3)){
                case 0:
                    return "Game/Props/Sounds/ThankSTJ.wav";
                case 1:
                    return "Game/Props/Sounds/ThankSTN.wav";
                case 2:
                    return "Game/Props/Sounds/ThankSTM.wav";
                default:
                    return "Game/Props/Sounds/ThankSTM.wav";
            }
        }

        public static string GET_ENDING_SOUND(){
            return "Game/Props/Sounds/Thank.wav";
        }

        public static string GET_SALE_START_SOUND(){
            return "Game/Props/Sounds/SaleBegun.wav";
        }


        public static int FRAME_RATE = 60;
        public static int COP_RELOAD_TIME = 20; //IN seconds
        public static int GET_COP_RELOAD_TIME(){
            return Constants.COP_RELOAD_TIME * Constants.FRAME_RATE;
        }
        public static bool COP_CAN_RELOAD = true;
        public static string TOASTER_ICON = " Õ";
        public static string DEAD_SHOPPER_FACE = " :(";
        public static string SHOPPER_FACE = " :)";
        public static string SHOPPER_PUNCHING_FACE = ">:(";
        public static int ZOMBIE_REVIVE_TIME = 300; //IN FRAMES
        public static int PLAYER_REVIVE_TIME = 500; //IN FRAMES
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
        public static int FONT_SIZE = 15;
        public static int EXTRA_AMMO = 0;
        public static string CAPTION = "Black Friday";
        public static Color RED = new Color(255, 0, 0);
        public static Color BANNER_RED = new Color(255, 0, 0, 175);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color BANNER_YELLOW = new Color(255, 255, 0, 175);
        public static Color GREY = new Color(128, 128, 128);
        public static Color BANNER_GREY = new Color(128, 128, 128, 175);

        public static Color GREEN = new Color(0, 255, 0);
        public static Color BANNER_GREEN = new Color(0, 255, 0, 175);
        public static Color BLUE = new Color(0, 0, 255);
        public static Color BANNER_BLUE = new Color(0, 0, 255, 175);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color BANNER_WHITE = new Color(255, 255, 255, 125);
        public static Color BLACK = new Color(0, 0, 0);
        public static Color BANNER_BLACK = new Color(0, 0, 0, 175);
        public static Color CLEAR = new Color(0, 0, 0, 0);
        public static int GET_TOASTER_COUNT(){
            return Constants.PLAYER_COUNT * 2 + 15;
        }
    }
}