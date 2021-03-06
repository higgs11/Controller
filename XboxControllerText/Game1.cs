using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace XboxControllerText
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GamePadState previousGamePadState;
        TextForm textForm;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            previousGamePadState = GamePad.GetState(PlayerIndex.One);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            GammaRamp gammaRamp = GraphicsDevice.GetGammaRamp();
            textForm = new TextForm();
            //textForm.TopLevel = true;            
            textForm.Show();
            

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            UpdateInput();


            base.Update(gameTime);
        }

        void UpdateInput()
        {

            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
           
            
            // Process input only if connected.
            if (currentState.IsConnected)
            {
                // Increase vibration if the player is tapping the A button.
                // Subtract vibration otherwise, even if the player holds down A

                if (currentState.Buttons.LeftShoulder == ButtonState.Pressed &&
                    previousGamePadState.Buttons.LeftShoulder == ButtonState.Released)
                {
                    textForm.ControllerInputLeft();
                   
                }
                else if (currentState.Buttons.RightShoulder == ButtonState.Pressed &&
                    previousGamePadState.Buttons.RightShoulder == ButtonState.Released)
                {
                    textForm.ControllerInputRight();
                    
                }

                else if (currentState.Buttons.A == ButtonState.Pressed &&
                    previousGamePadState.Buttons.A == ButtonState.Released)
                {
                    textForm.SelectLetter();
                }
                else if (currentState.Buttons.Y == ButtonState.Pressed &&
                    previousGamePadState.Buttons.Y == ButtonState.Released)
                {
                    textForm.ResetLetters();
                }
                else if (currentState.Buttons.B == ButtonState.Pressed &&
                    previousGamePadState.Buttons.B == ButtonState.Released)
                {
                    textForm.EraseLastLetter();
                }

                // Update previous gamepad state.
                previousGamePadState = currentState;
            }
        }


       
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
                     

            GraphicsDevice.Clear(Color.SteelBlue);            

            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}
