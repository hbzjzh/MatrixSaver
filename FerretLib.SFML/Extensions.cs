﻿using SFML.Window;

namespace FerretLib.SFML
{
    public static class Extensions
    {
        public static Vector2i ToVector2i(this Vector2f input)
        {
            return new Vector2i((int)input.X, (int)input.Y);
        }

        public static Vector2f ToVector2f(this Vector2i input)
        {
            return new Vector2f(input.X, input.Y);
        }
    }
}