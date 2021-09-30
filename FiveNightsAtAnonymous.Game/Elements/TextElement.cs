using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerraCore.Game.Elements
{
    /// <summary>
    /// Text element
    /// </summary>
    public class TextElement : GuiElement
    {
        /// <summary>
        /// Text content
        /// </summary>
        private readonly string _text;
        
        /// <summary>
        /// Text font
        /// </summary>
        private readonly SpriteFont _font;

        /// <summary>
        /// Text color
        /// </summary>
        private readonly Color _color;

        /// <summary>
        /// Create new TextElement
        /// </summary>
        /// <param name="text">Text content</param>
        /// <param name="font">Text font</param>
        /// <param name="color">Text color</param>
        public TextElement(string text, SpriteFont font, Color color)
        {
            _text = text;
            _font = font;
            _color = color;
        }

        /// <summary>
        /// Draw override
        /// </summary>
        /// <param name="gameTime">GameTime</param>
        /// <param name="batch">SpriteBatch</param>
        public override void Draw(GameTime gameTime, SpriteBatch batch) 
            => batch.DrawString(_font, _text, Position, _color, Rotation, Vector2.Zero, Vector2.One, SpriteEffects.None, 0);
    }
}