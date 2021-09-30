using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using MonoGame.Extended.Content;

namespace TerraCore.Game.Helpers
{
    /// <summary>
    /// Makes loading game content easier
    /// </summary>
    public class ContentHelper
    {
        /// <summary>
        /// Instance of ContentManager
        /// </summary>
        private readonly ContentManager _manager;

        /// <summary>
        /// Contains all game's content instances
        /// </summary>
        private readonly Dictionary<string, object> _content = new Dictionary<string, object>();

        /// <summary>
        /// Create an instance of ContentHelper
        /// </summary>
        /// <param name="manager">Instance of ContentManager</param>
        public ContentHelper(ContentManager manager)
            => _manager = manager;

        /// <summary>
        /// Get loaded content
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <param name="name">Name of content</param>
        /// <typeparam name="T">Type of content</typeparam>
        /// <exception cref="ContentException">Content was not yet loaded</exception>
        /// <returns>Content instance</returns>
        public T Get<T>(string path, string name)
        {
            string str = $"{path}->{name}";
            if (!_content.ContainsKey(str))
                throw new ContentException($"Content \"{path}->{name}\" was not yet loaded!");
            return (T)_content[str];
        }

        /// <summary>
        /// Load game content
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <param name="name">Name of content</param>
        /// <param name="doOverride">Should it override existing</param>
        /// <typeparam name="T">Type of content</typeparam>
        /// <exception cref="ArgumentNullException">Path or Name is null</exception>
        /// <exception cref="NullReferenceException">Content was not found</exception>
        /// <exception cref="ContentException">Content is already loaded</exception>
        public void Load<T>(string path, string name, bool doOverride)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            T content = _manager.Load<T>($"{path}/{name}");
            if (content == null)
                throw new NullReferenceException($"Content \"{path}->{name}\" is null");
            if (!_content.TryAdd($"{path}->{name}", content) && !doOverride)
                throw new ContentException($"Content \"{path}->{name}\" is already loaded!");
            
            if (_content.ContainsKey($"{path}->{name}")) {
                _content.Remove($"{path}->{name}");
                _content.Add($"{path}->{name}", content);
            }
        }
    }
}