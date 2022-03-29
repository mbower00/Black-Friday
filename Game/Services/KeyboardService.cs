using System.Collections.Generic;
using Raylib_cs;
using black_friday.Game.Casting;

namespace black_friday.Game.Services{
    /// <summary>
    /// <para>Detects player input.</para>
    /// <para>
    /// The responsibility of a KeyboardService is to indicate whether or not a key is up or down.
    /// </para>
    /// </summary>
    public class KeyboardService
    {
        private Dictionary<string, KeyboardKey> keys
                = new Dictionary<string, KeyboardKey>();

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        public KeyboardService()
        {
            // PLAYER 1
            keys["w"] = KeyboardKey.KEY_W; // up
            keys["a"] = KeyboardKey.KEY_A; // left
            keys["s"] = KeyboardKey.KEY_S; // down
            keys["d"] = KeyboardKey.KEY_D; // right
            keys["e"] = KeyboardKey.KEY_E; // punch
            // PLAYER 2
            keys["y"] = KeyboardKey.KEY_Y; // up
            keys["g"] = KeyboardKey.KEY_G; // left
            keys["h"] = KeyboardKey.KEY_H; // down
            keys["j"] = KeyboardKey.KEY_J; // right
            keys["u"] = KeyboardKey.KEY_U; // punch
            // PLAYER 3
            keys["p"] = KeyboardKey.KEY_P; // up
            keys["l"] = KeyboardKey.KEY_L; // left
            keys[";"] = KeyboardKey.KEY_SEMICOLON; // down
            keys["'"] = KeyboardKey.KEY_APOSTROPHE; // right
            keys["["] = KeyboardKey.KEY_LEFT_BRACKET; // punch
            // PLAYER 4
            keys["up"] = KeyboardKey.KEY_UP; // up
            keys["left"] = KeyboardKey.KEY_LEFT; // left
            keys["down"] = KeyboardKey.KEY_DOWN; // down
            keys["right"] = KeyboardKey.KEY_RIGHT; // right
            keys["0"] = KeyboardKey.KEY_KP_0; // punch
            // PLAYER 5
            keys["8"] = KeyboardKey.KEY_KP_8; // up
            keys["4"] = KeyboardKey.KEY_KP_4; // left
            keys["5"] = KeyboardKey.KEY_KP_5; // down
            keys["6"] = KeyboardKey.KEY_KP_6; // right
            keys["9"] = KeyboardKey.KEY_KP_9; // punch
            // PLAYER 6
            keys["1"] = KeyboardKey.KEY_ONE; // up
            keys["`"] = KeyboardKey.KEY_GRAVE; // left
            keys["tab"] = KeyboardKey.KEY_TAB; // down
            keys["q"] = KeyboardKey.KEY_Q; // right
            keys["2"] = KeyboardKey.KEY_TWO; // punch
        }

        /// <summary>
        /// Checks if the given key is currently down.
        /// </summary>
        /// <param name="key">The given key (w, a, s, d, i, j, k, or l)</param>
        /// <returns>True if the given key is down; false if otherwise.</returns>
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        /// <summary>
        /// Checks if the given key is currently up.
        /// </summary>
        /// <param name="key">The given key (w, a, s, d, i, j, k, or l)</param>
        /// <returns>True if the given key is up; false if otherwise.</returns>
        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }

    }
}