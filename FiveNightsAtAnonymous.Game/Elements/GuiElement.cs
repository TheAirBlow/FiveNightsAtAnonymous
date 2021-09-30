using System.Numerics;

namespace TerraCore.Game
{
    public class GuiElement
    {
        public bool MouseHovered;
        public bool MouseClicked;
        public bool MouseDragging;
        private Vector2 _lastCursorPos;

        public virtual void OnMouseHover() { }
        public virtual void OnMouseClick() { }
        public virtual void OnMouseDrag() { }

        public void Update()
        {
            
        }
    }
}