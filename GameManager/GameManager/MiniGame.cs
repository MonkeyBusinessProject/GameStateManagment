using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameManager
{
    class MiniGame
    {
        protected Manager manager;
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        protected ContentManager Content;

        public MiniGame(Manager manager) {
            this.manager = manager;
            GetManagerVariables();
            this.Content = manager.Content;
        }
        public void GetManagerVariables()
        {
            this.graphics = manager.getGraphicDevice();
            this.spriteBatch = manager.getSpriteBatch();
        }
        public virtual void Initialize() { }
        public virtual void Draw(GameTime gameTime) { }
        public virtual void Update(GameTime gameTime) { }
        public virtual void LoadContent()
        {

        }
        public virtual void UnloadContent() { }
    }
}
