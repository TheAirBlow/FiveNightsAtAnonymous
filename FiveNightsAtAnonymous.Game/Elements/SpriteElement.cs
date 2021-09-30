using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerraCore.Game.Elements
{
    /// <summary>
    /// Sprite element
    /// </summary>
    public class SpriteElement : GuiElement
    {
        /// <summary>
        /// Text content
        /// </summary>
        private readonly Texture2D _sprite;

        /// <summary>
        /// Create new TextElement
        /// </summary>
        public SpriteElement(Texture2D sprite)
        {
            _sprite = sprite;
        }

        /// <summary>
        /// Draw override
        /// </summary>
        /// <param name="gameTime">GameTime</param>
        /// <param name="batch">SpriteBatch</param>
        public override void Draw(GameTime gameTime, SpriteBatch batch)
            => batch.Draw(_sprite, Position, null, Color.White, Rotation, Vector2.Zero, Vector2.One, SpriteEffects.None, 0);
    }
}