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
        Texture2D rectangleTexture, circleTexture;
        SpriteFont titleFont;


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

            rectangleRect = new Rectangle(250, 250, 250, 200);

            circleRect = new Rectangle (225, 100, 300, 100);



        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("titleFont");

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

            _spriteBatch.Draw(circleTexture, circleRect, Color.Yellow);


            _spriteBatch.Draw(rectangleTexture, new Rectangle(240, 130, 270, 220), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.Gray);
            //_spriteBatch.Draw(circleTexture, new Rectangle(200, 210, 100, 100), Color.White);




            



            _spriteBatch.DrawString(titleFont, "Hello little gremlin", new Vector2(20, 20), Color.Purple);
            
            
            
            _spriteBatch.End();



            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
