using System.Collections.Generic;
using Raylib_cs;
using black_friday.Game.Casting;
using System.Numerics;


namespace black_friday.Game.Services{

    /// <summary>
    /// <para>Outputs the game state.</para>
    /// <para>
    /// The responsibility of the class of objects is to draw the game state on the screen. 
    /// </para>
    /// </summary>
    public class VideoService
    {
        private bool debug = false;
        
        private Dictionary<string, Texture2D> _textures 
            = new Dictionary<string, Texture2D>();
        
        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        /// <param name="cellSize">The cell size (in pixels).</param>
        public VideoService(bool debug)
        {
            this.debug = debug;
        }

        /// <summary>
        /// Closes the window and releases all resources.
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// <summary>
        /// Clears the buffer in preparation for the next rendering. This method should be called at
        /// the beginning of the game's output phase.
        /// </summary>
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (debug)
            {
                DrawGrid();
            }
        }

        public void DrawActorImage(Actor actor)
        {
            string path = actor.GetPath();
            if (!_textures.ContainsKey(path))
            {
                _textures[path] = Raylib.LoadTexture(path);
            }
            Texture2D texture = _textures[path];
            Vector2 position = new Vector2(actor.GetPosition().GetX(), actor.GetPosition().GetY());
            Raylib_cs.Color tint = Raylib_cs.Color.WHITE;
            Raylib.DrawTextureEx(texture, position, 0f, 1f, Raylib_cs.Color.WHITE);
        }

        /// <summary>
        /// Draws the given actor's text on the screen.
        /// </summary>
        /// <param name="actor">The actor to draw.</param>
        public void DrawActorText(Actor actor)
        {
            string text = actor.GetText();
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int width = actor.GetWidth();
            int height = actor.GetHeight();
            int fontSize = actor.GetFontSize();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color textcolor = ToRaylibColor(actor.GetTextColor());
            Raylib_cs.Color color = ToRaylibColor(c);

            DrawRectangle(x, y, width, height, c);
            Raylib.DrawText(text, x, y, fontSize, textcolor);
        }

        /// <summary>
        /// Draws the given list of actors on the screen.
        /// </summary>
        /// <param name="actors">The list of actors to draw.</param>
        public void DrawActorTexts(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActorText(actor);
            }
        }
        
        /// <summary>
        /// Copies the buffer contents to the screen. This method should be called at the end of
        /// the game's output phase.
        /// </summary>
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// <summary>
        /// Whether or not the window is still open.
        /// </summary>
        /// <returns>True if the window is open; false if otherwise.</returns>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// <summary>
        /// Opens a new window with the provided title.
        /// </summary>
        public void OpenWindow()
        {
            Raylib.InitWindow(Constants.MAX_X, Constants.MAX_Y, Constants.CAPTION);
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }

        /// <summary>
        /// Draws a grid on the screen.
        /// </summary>
        private void DrawGrid()
        {
            for (int x = 0; x < Constants.MAX_X; x += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(x, 0, x, Constants.MAX_Y, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < Constants.MAX_Y; y += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(0, y, Constants.MAX_X, y, Raylib_cs.Color.GRAY);
            }
        }

        /// <summary>
        /// Converts the given color to it's Raylib equivalent.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>A Raylib color.</returns>
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            
            
            int r = color.GetRed();
            int g = color.GetGreen();
            if(color.GetGreen() > 255){g = 255;}
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }


        public void DrawRectangle(int posX, int posY, int width, int height, Casting.Color color){
            Raylib.DrawRectangle(posX, posY, width, height, ToRaylibColor(color));
        }
    }
}