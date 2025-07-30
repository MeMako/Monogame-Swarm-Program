using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project1.Classes;

namespace Project1
{
    public class Game1 : Game
    {
        Texture2D ball;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameObject _ball;
       


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _ball = new GameObject(new transform2d(Vector2.Zero, Vector2.Zero, Vector2.Zero, 1f, 0f), new PlayerControls(), "ball");
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _ball.load(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //_ball.transform.Move(new Vector2(0.1f, 0));
            _ball.update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_ball.sprite, _ball.transform.position, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);


        }
    }
}
