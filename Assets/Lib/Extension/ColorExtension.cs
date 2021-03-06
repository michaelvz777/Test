﻿using UnityEngine;

namespace UnityLib.Extension
{
    public static class ColorExtension
    {
        // Note that Color32 and Color implictly convert to each other. You may pass a Color object to this method without first casting it.
        public static string ToHex(this Color32 color)
        {
            return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        }

        public static string ToHex(this Color color)
        {
            var color32 = (Color32)color;
            return color32.r.ToString("X2") + color32.g.ToString("X2") + color32.b.ToString("X2");
        }

        public static Color ToColor(this string hex)
        {
            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            return new Color32(r, g, b, 255);
        }
    }
}