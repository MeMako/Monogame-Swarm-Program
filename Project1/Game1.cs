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
        BotFlock flock = new BotFlock(10);



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 1280;
            //_graphics.IsFullScreen = true;
            this.Window.AllowUserResizing = true;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //_ball = new GameObject(new transform2d(Vector2.Zero, Vector2.Zero, Vector2.Zero, 1f, 0f), new PlayerControls(), "ball");
            ball = Content.Load<Texture2D>("ball");
          
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //_ball.load(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //_ball.transform.Move(new Vector2(0.1f, 0));
            //_ball.update();
            flock.updateflock();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
           // _spriteBatch.Draw(_ball.sprite, _ball.transform.position, Color.White);
           foreach(BotControls bot in flock.flock)
            {
                _spriteBatch.Draw(ball, bot.transform.position, Color.White);
            }
            _spriteBatch.End();

            base.Draw(gameTime);


        }
    }
}
