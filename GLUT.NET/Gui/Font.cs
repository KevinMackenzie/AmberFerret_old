using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;
using SharpFont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GLUT.NET.Gui
{
    public class CharacterInfo
    {
        public Vector2i Advance { get; set; }
        public Vector2i BitSize { get; set; }
        public Vector2i BitLoc { get; set; }
        public Vector2 TexOffset { get; set; }
    }

    public class CharacterAtlas
    {
        public uint Width { get; set; }
        public int Height { get; set; }
        public List<CharacterInfo> Data { get; set; } = new List<CharacterInfo>();
    }


    /// <summary>
    /// This is a font helper class for putting the freetype fonts into an openGL buffer
    /// </summary>
    public class Font
    {
        public static int GlyphPadding { get; private set; } = 5;
        #region Properties

        private Library _lib;

        public Face FontFace { get { return _fontFace; } set { SetFont(value); } }
        private Face _fontFace;

        public float Size { get { return _size; } set { SetSize(value); } }
        private float _size;

        private int TexId;
        CharacterAtlas CharAtlas = new CharacterAtlas();
        private uint CharacterOffset = 32;
        private uint CharacterEnd = 0xFFF;
        private List<uint> TextureLineBreakIndices = new List<uint>();

        #endregion // Properties

        #region Constructor

        /// <summary>
        /// If multithreading, each thread should have its own FontService.
        /// </summary>
        /// <param name="charOffset">
        /// This is the character offset of the first renderable character in the texture
        /// </param>
        /// <param name="charEnd">
        /// This is the last character in the texture 
        /// </param>
        internal Font(Library lib, uint charOffset, uint charEnd)
        {
            _lib = new Library();
            _size = 8.25f;

            TexId = GL.GenTexture();
        }

        #endregion

        #region Setters

        internal void SetFont(Face face)
        {
            _fontFace = face;
            SetSize(this.Size);
        }

        internal void SetFont(string filename)
        {
            FontFace = new Face(_lib, filename);
            SetSize(this.Size);
        }

        internal void SetSize(float size)
        {
            _size = size;
            if (FontFace != null)
                FontFace.SetCharSize(0, size, 0, 96);

            RecreateOpenGLBuffer();
        }

        #endregion // Setters

        #region OpenGL Buffering

        private void RecreateOpenGLBuffer()
        {
            CharAtlas.Width = 0;
            CharAtlas.Height = 0;

            //get maximum texture size, so we don't get opengl complaining
            int maxTexSize;
            GL.GetInteger(GetPName.MaxTextureSize, out maxTexSize);

            //add one line of character texture to start
            int lineHeightWithSpacing = (int)(Size * (4.0f / 3.0f));
            CharAtlas.Height += lineHeightWithSpacing;
            int atlasWidthTmp = 0;

            //load the characters' dimmensions
            for(uint i = CharacterOffset; i < CharacterEnd; i++)
            {
                FontFace.LoadChar(i, LoadFlags.Render, LoadTarget.Lcd);

                //on each line, make sure we check if the next texture will go past the max x position
                int potentialAtlasX = atlasWidthTmp + FontFace.Glyph.Bitmap.Width + GlyphPadding;
                if (potentialAtlasX > maxTexSize)
                {
                    CharAtlas.Height += lineHeightWithSpacing;
                    if (CharAtlas.Height > maxTexSize)
                    {
                        //if it is too big, actually clamp the characters which can not be loaded (not good, but not catestrophic either)
                        CharacterEnd = i - 1;
                        break;
                    }

                    TextureLineBreakIndices.Add(i);
                    atlasWidthTmp = 0;
                }
                else
                {
                    atlasWidthTmp = potentialAtlasX;
                    CharAtlas.Width = Math.Max((uint)atlasWidthTmp, CharAtlas.Width);
                }
            }

            //generate textures
            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2D, TexId);
            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);

            // Fonts should be rendered at native resolution so no need for texture filtering
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            // Stop chararcters from bleeding over edges
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);

            float[] transparent = { 0.0f, 0.0f, 0.0f, 0.0f };
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureBorderColor, transparent);//any overflow will be transparent

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Luminance, (int)CharAtlas.Width, CharAtlas.Height, 0, PixelFormat.Luminance, PixelType.UnsignedByte, IntPtr.Zero);

            //load texture data

            //the data for the glyph padding
            byte[] paddingData = new byte[GlyphPadding * lineHeightWithSpacing];

            int x = 0;
            int y = 0;
            uint lineIndex = 0;
            for (uint i = CharacterOffset; i < CharacterEnd; ++i)
            {
                CharacterInfo charInfo = new CharacterInfo();

                if (TextureLineBreakIndices.Contains(i))
                {
                    y += lineHeightWithSpacing;
                    x = 0;
                    lineIndex = 0;
                }

                int p = (int)(i - CharacterOffset);

                FontFace.LoadChar(i, LoadFlags.Render, LoadTarget.Lcd);

                var g = FontFace.Glyph;

                if (i == 32/*space*/)
                {
                    uint spId = FontFace.GetCharIndex(32);
                    FontFace.LoadGlyph(spId, LoadFlags.Render, LoadTarget.Lcd);

                    charInfo.Advance = new Vector2i(g.Advance.X.Value >> 6, 0);
                    charInfo.BitSize = new Vector2i(charInfo.Advance.X, CharAtlas.Height);
                    charInfo.BitLoc = new Vector2i(0,0);
                    charInfo.TexOffset = new Vector2(CharAtlas.Width - GlyphPadding, (float)y / CharAtlas.Height);

                    continue;
                }

                //buffer the data into the texture
                GL.TexSubImage2D(TextureTarget.Texture2D, 0, x + ((int)lineIndex * GlyphPadding), y, g.Bitmap.Width, g.Bitmap.Rows, PixelFormat.Luminance, PixelType.UnsignedByte, g.Bitmap.Buffer);

                //this adds padding to keep the characters looking clean
                GL.TexSubImage2D(TextureTarget.Texture2D, 0, x + ((int)lineIndex * GlyphPadding), y, GlyphPadding, CharAtlas.Height, PixelFormat.Luminance, PixelType.UnsignedByte, paddingData);


                charInfo.Advance = new Vector2i(g.Advance.X.Value >> 6, g.Advance.Y.Value >> 6);
                charInfo.BitSize = new Vector2i(g.Bitmap.Width, g.Bitmap.Rows);
                charInfo.BitLoc = new Vector2i(g.BitmapLeft, g.BitmapTop);
                charInfo.TexOffset = new Vector2((float)(x + (lineIndex * GlyphPadding)) / CharAtlas.Width, (y + 0.5f) / CharAtlas.Height);

                x += g.Bitmap.Width;

                ++lineIndex;

                CharAtlas.Data.Add(charInfo);
            }
        }

        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (this.FontFace != null && !FontFace.IsDisposed)
                        try
                        {
                            FontFace.Dispose();
                            GL.DeleteTexture(TexId);
                        }
                        catch { }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~FontService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #region class DebugChar

        private class DebugChar
        {
            public char Char { get; set; }
            public float AdvanceX { get; set; }
            public float BearingX { get; set; }
            public float Width { get; set; }
            public float Underrun { get; set; }
            public float Overrun { get; set; }
            public float Kern { get; set; }
            public float RightEdge { get; set; }
            internal DebugChar(char c, float advanceX, float bearingX, float width)
            {
                this.Char = c; this.AdvanceX = advanceX; this.BearingX = bearingX; this.Width = width;
            }

            public override string ToString()
            {
                return string.Format("'{0}' {1,5:F0} {2,5:F0} {3,5:F0} {4,5:F0} {5,5:F0} {6,5:F0} {7,5:F0}",
                    this.Char, this.AdvanceX, this.BearingX, this.Width, this.Underrun, this.Overrun,
                    this.Kern, this.RightEdge);
            }
            public static void PrintHeader()
            {
                Debug.Write(string.Format("    {1,5} {2,5} {3,5} {4,5} {5,5} {6,5} {7,5}",
                    "", "adv", "bearing", "wid", "undrn", "ovrrn", "kern", "redge"));
            }
        }

        #endregion
    }
}
