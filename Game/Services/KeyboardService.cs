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
            keys["divide"] = KeyboardKey.KEY_KP_DIVIDE; // up
            keys["7"] = KeyboardKey.KEY_KP_7; // left
            keys["8"] = KeyboardKey.KEY_KP_8; // down
            keys["9"] = KeyboardKey.KEY_KP_9; // right
            keys["*"] = KeyboardKey.KEY_KP_MULTIPLY; // punch
            // PLAYER 6
            keys["t1"] = KeyboardKey.KEY_ONE; // up
            keys["`"] = KeyboardKey.KEY_GRAVE; // left
            keys["tab"] = KeyboardKey.KEY_TAB; // down
            keys["q"] = KeyboardKey.KEY_Q; // right
            keys["t2"] = KeyboardKey.KEY_TWO; // punch
            // PLAYER 7
            keys["f"] = KeyboardKey.KEY_F; // up
            keys["c"] = KeyboardKey.KEY_C; // left
            keys["v"] = KeyboardKey.KEY_V; // down
            keys["b"] = KeyboardKey.KEY_B; // right
            keys["x"] = KeyboardKey.KEY_X; // punch
            // PLAYER 8
            keys["k"] = KeyboardKey.KEY_K; // up
            keys["m"] = KeyboardKey.KEY_M; // left
            keys[","] = KeyboardKey.KEY_COMMA; // down
            keys["."] = KeyboardKey.KEY_PERIOD; // right
            keys["n"] = KeyboardKey.KEY_N; // punch
            // PLAYER 9
            keys["f3"] = KeyboardKey.KEY_F3; // up
            keys["t3"] = KeyboardKey.KEY_THREE; // left
            keys["t4"] = KeyboardKey.KEY_FOUR; // down
            keys["t5"] = KeyboardKey.KEY_FIVE; // right
            keys["f4"] = KeyboardKey.KEY_F4; // punch
            // PLAYER 10
            keys["f11"] = KeyboardKey.KEY_F11; // up
            keys["t9"] = KeyboardKey.KEY_NINE; // left
            keys["t0"] = KeyboardKey.KEY_ZERO; // down
            keys["t-"] = KeyboardKey.KEY_MINUS; // right
            keys["f10"] = KeyboardKey.KEY_F10; // punch
            // PLAYER 11
            keys["f8"] = KeyboardKey.KEY_F8; // up
            keys["t6"] = KeyboardKey.KEY_SIX; // left
            keys["t7"] = KeyboardKey.KEY_SEVEN; // down
            keys["t8"] = KeyboardKey.KEY_EIGHT; // right
            keys["f7"] = KeyboardKey.KEY_F7; // punch
            // PLAYER 12
            keys["]"] = KeyboardKey.KEY_RIGHT_BRACKET; // left
            keys["enter"] = KeyboardKey.KEY_ENTER; // down
            keys["\\"] = KeyboardKey.KEY_BACKSLASH; // right
            keys["backspace"] = KeyboardKey.KEY_BACKSPACE; // up
            keys["="] = KeyboardKey.KEY_EQUAL; // punch
            // PLAYER 13
            keys["5"] = KeyboardKey.KEY_KP_5; // up
            keys["1"] = KeyboardKey.KEY_KP_1; // left
            keys["2"] = KeyboardKey.KEY_KP_2; // down
            keys["3"] = KeyboardKey.KEY_KP_3; // right
            keys["6"] = KeyboardKey.KEY_KP_6; // punch
            // PLAYER 14
            keys["z"] = KeyboardKey.KEY_Z; // right
            keys["cap"] = KeyboardKey.KEY_CAPS_LOCK; // up
            keys["lshift"] = KeyboardKey.KEY_LEFT_SHIFT; // left
            keys["lctrl"] = KeyboardKey.KEY_LEFT_CONTROL; // down
            keys["lalt"] = KeyboardKey.KEY_LEFT_ALT; // punch
            // PLAYER 15
            keys["/"] = KeyboardKey.KEY_SLASH; // up
            keys["space"] = KeyboardKey.KEY_SPACE; // left
            keys["ralt"] = KeyboardKey.KEY_RIGHT_ALT; // down
            keys["rctrl"] = KeyboardKey.KEY_RIGHT_CONTROL; // right
            keys["rshift"] = KeyboardKey.KEY_RIGHT_SHIFT; // punch
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