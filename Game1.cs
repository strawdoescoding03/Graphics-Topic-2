using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Graphics_Topic_2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Rectangle rectangleRect;
        Rectangle circleRect;
        Rectangle stopSignRect;
        Texture2D rectangleTexture, circleTexture, stopSignTexture;
        SpriteFont titleFont;

        int busGrateFront = 240;
        int doorGrate = 200;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            rectangleRect = new Rectangle(250, 290, 250, 120);

            circleRect = new Rectangle (240, 80, 270, 100);

            stopSignRect = new Rectangle(510, 200, 60, 60);

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("titleFont");
            stopSignTexture = Content.Load<Texture2D>("Stop_sign");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);




        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            
            //Body
            
            _spriteBatch.Draw(circleTexture, circleRect, Color.Yellow);


            _spriteBatch.Draw(rectangleTexture, new Rectangle(240, 130, 270, 250), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(240, 300, 270, 100), Color.Black);
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.Gray);
            //_spriteBatch.Draw(circleTexture, new Rectangle(200, 210, 100, 100), Color.White);


            _spriteBatch.Draw(rectangleTexture, new Rectangle(250, 180, 120, 100), Color.PowderBlue);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(380, 180, 120, 100), Color.PowderBlue);

           
            
            //Grate lines Front
            
            for (int i = 0; i < 14; i++)

            {
                
                _spriteBatch.Draw(rectangleTexture, new Rectangle(i * 20 + busGrateFront, 300, 10, 100), Color.Black);
            }

           
            //Left window glare

            _spriteBatch.Draw(rectangleTexture, new Rectangle(330, 200, 10, 10), Color.White);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(340, 210, 10, 10), Color.White);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(350, 220, 10, 10), Color.White);


            //Right window glare

            _spriteBatch.Draw(rectangleTexture, new Rectangle(460, 200, 10, 10), Color.White);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(470, 210, 10, 10), Color.White);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(480, 220, 10, 10), Color.White);


            //Side Door
            
            _spriteBatch.Draw(rectangleTexture, new Rectangle(190, 190, 50, 200), Color.DimGray);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(200, 200, 40, 150), Color.PowderBlue);



            for (int i = 0; i < 4; i++)

            {

                _spriteBatch.Draw(rectangleTexture, new Rectangle(i * 10 + doorGrate, 360, 5, 20), Color.Gray);
            }


            //Bus Accessories 

            _spriteBatch.DrawString(titleFont, "SCHEWL BUS", new Vector2(249, 120), Color.Black);

            _spriteBatch.Draw(stopSignTexture, stopSignRect, Color.White);


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
