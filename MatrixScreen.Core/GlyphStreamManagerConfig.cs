﻿using System.Data;

namespace MatrixScreen
{
    public class GlyphStreamManagerConfig
    {
        public GlyphStreamConfig GlyphStreamConfig { get; private set; }

        public int MaximumGlyphStreams;
        public float ChanceOfNewGlyphStream;

        internal static GlyphStreamManagerConfig Debug()
        {
            return new GlyphStreamManagerConfig()
            {
                MaximumGlyphStreams = 1,
                ChanceOfNewGlyphStream = 1,

                GlyphStreamConfig = new GlyphStreamConfig()
                {
                    MaxGlyphs = 20,
                    MinGlyphs = 3,
                    MaxMovementRate = 300f,
                    MinMovementRate = 40f,

                    MinGlyphScale = 0.05f,
                    MaxGlyphScale = 0.4f,
                },
            };
        }

        internal static GlyphStreamManagerConfig Mini()
        {
            return new GlyphStreamManagerConfig()
            {
                MaximumGlyphStreams = 1000,
                ChanceOfNewGlyphStream = 0.08f,                
                GlyphStreamConfig = new GlyphStreamConfig(){
                    MaxGlyphs = 20,
                    MinGlyphs = 3,
                    MaxMovementRate = 300f,
                    MinMovementRate = 40f,

                    MinGlyphScale= 0.02f,
                    MaxGlyphScale = 0.08f,
                },
            };
        }

        internal static GlyphStreamManagerConfig Big()
        {
            return new GlyphStreamManagerConfig()
            {
                MaximumGlyphStreams = 50,
                ChanceOfNewGlyphStream = 0.03f,
                GlyphStreamConfig = new GlyphStreamConfig()
                {
                    MaxGlyphs = 20,
                    MinGlyphs = 3,
                    MaxMovementRate = 300f,
                    MinMovementRate = 40f,

                    MinGlyphScale = 0.02f,
                    MaxGlyphScale = 0.36f,
                },
            };
        }
    }
}