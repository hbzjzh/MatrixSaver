﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FerretLib.SFML;

namespace MatrixScreen
{
    public static class Config
    {                
        

        public const bool IsFullscreen = false;
        public const bool IsMultipleMonitorEnabled = true;

        public const bool IsDebugRendering = false;
        public const bool IsDebugGlyphStreams = false;
        
        public static ScreenSaverSettings ScreenSaverSettings = new ScreenSaverSettings
        {
            IsFullscreen = Config.IsFullscreen,
            IsMultiMonitorEnabled = Config.IsMultipleMonitorEnabled,
            MaxFps = 60,
        };

        //// Debugging
        //public const int MaximumGlyphStreams = 1;
        //public const bool IsFullscreen = false;
        //public const bool IsDebugRendering = true;
        //public const bool IsDebugGlyphStreams = true;

        //// Preset - mini
        //public const int MaximumGlyphStreams = 1000;
        //public const float ChanceOfNewGlyphStream = 0.08f;
        //public const float GlyphScaleMinimum = 0.02f;
        //public const float GlyphScaleMaximum = 0.08f;

        //// Preset - mini
        public const int MaximumGlyphStreams = 200;
        public const float ChanceOfNewGlyphStream = 0.08f;
        public const float GlyphScaleMinimum = 0.02f;
        public const float GlyphScaleMaximum = 0.12f;

        // Preset - big stuff
        //public const int MaximumGlyphStreams = 50;
        //public const float GlyphScaleMinimum = 0.02f;
        //public const float GlyphScaleMaximum = 0.36f;
        //public const float ChanceOfNewGlyphStream = 0.03f;
    }

    public class MatrixConfig
    {
        public bool IsFullscreen;
        public bool IsMultipleMonitorEnabled;

        public bool IsDebugRendering;
        public bool IsDebugGlyphStreams;

        public int MaximumGlyphStreams;
        public float ChanceOfNewGlyphStream;
        public float GlyphScaleMinimum;
        public float GlyphScaleMaximum;
    }
}
