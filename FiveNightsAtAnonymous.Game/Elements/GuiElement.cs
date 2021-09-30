using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TerraCore.Game.Elements
{
    /// <summary>
    /// Any GUI game element
    /// </summary>
    public class GuiElement : GameElement
    {
        /// <summary>
        /// Is mouse hovered?
        /// </summary>
        public bool MouseHovered;
        
        /// <summary>
        /// Is mouse clicked?
        /// </summary>
        public bool MouseClicked;
        
        /// <summary>
        /// Is mouse dragging?
        /// </summary>
        public bool MouseDragging;
        
        /// <summary>
        /// Last cursor position for dragging detect
        /// </summary>
        private Point _lastCursorPos;

        /// <summary>
        /// On mouse hover method
        /// </summary>
        public virtual void OnMouseHover() { }

        /// <summary>
        /// On mouse click method (base should be called!)
        /// </summary>
        public virtual void OnMouseClick()
        {
            _lastCursorPos = Mouse.GetState().Position;
        }
        
        /// <summary>
        /// On mouse drag method
        /// </summary>
        public virtual void OnMouseDrag() { }

        /// <summary>
        /// Update method (base should be called!)
        /// </summary>
        public override void Update(GameTime gameTime)
        {
            if (Mouse.GetState().Position.X > Position.X && Mouse.GetState().Position.X < Position.X + Size.X 
                && Mouse.GetState().Position.Y > Position.Y && Mouse.GetState().Position.Y < Position.Y + Size.Y)
            {
                MouseHovered = true;
                OnMouseHover();
            } else MouseHovered = false;
            
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && MouseHovered)
            {
                MouseClicked = true;
                OnMouseClick();
            } else MouseClicked = false;

            if (_lastCursorPos != Mouse.GetState().Position && MouseClicked)
            {
                MouseDragging = true;
                OnMouseDrag();
            } else MouseDragging = false;
        }
    }
}