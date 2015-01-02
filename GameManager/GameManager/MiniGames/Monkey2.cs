using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace GameManager.MiniGames
{
    class Monkey2 : MiniGame
    {
        private Texture2D SpriteTexture;

        public Monkey2(Manager manager) : base(manager)
        {

        }
        public override void Initialize() { }
        public override void Draw(GameTime gameTime)
        {
            GetManagerVariables();
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            Vector2 pos = new Vector2(100, 100);
            spriteBatch.Draw(SpriteTexture, pos, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime) { }
        public override void LoadContent()
        {
            SpriteTexture = Content.Load<Texture2D>("monkey2");
        }
        public override void UnloadContent() { }
    }
}
