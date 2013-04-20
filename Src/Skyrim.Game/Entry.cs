﻿using RGiesecke.DllExport;
using Skyrim.API;
using Skyrim.Game.IO;
using Skyrim.Script;
using System.Windows.Forms;

namespace Skyrim.Game
{
    public class Entry
    {
        private static IWorld instance = null;
        private static IO.InputManager inputManager = null;

        public static IO.GameClient gameClient = null;

        [DllExport]
        private static void Load()
        {
        }

        [DllExport]
        private static void Initialize()
        {
            Application.EnableVisualStyles();

            Application.Run(new Config.Play());

            if (Enabled)
            {
                gameClient.Connect();

                if (instance == null)
                    instance = new World();
                //if (inputManager == null)
                //    inputManager = new IO.InputManager();
            }
        }

        [DllExport]
        private static void Update()
        {
            inputManager.Update();   
            instance.Update();
            if (gameClient.connected == true)
                gameClient.Update();
        }

        static public IWorld World
        {
            get { return instance; }
        }

        static public bool Enabled
        {
            get;
            set;
        }
    }
}
