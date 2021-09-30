using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerraCore.Game.Elements
{
    /// <summary>
    /// Any game element that is drawn
    /// </summary>
    public class GameElement
    {
        /// <summary>
        /// Position of an element
        /// </summary>
        public Vector2 Position;
        
        /// <summary>
        /// Rotation of an element
        /// </summary>
        public float Rotation;
        
        /// <summary>
        /// Size of an element
        /// </summary>
        public Vector2 Size;
        
        /// <summary>
        /// Update method
        /// </summary>
        public virtual void Update(GameTime gameTime) { }

        /// <summary>
        /// Draw method
        /// </summary>
        public virtual void Draw(GameTime gameTime, SpriteBatch batch) { }
    }
}