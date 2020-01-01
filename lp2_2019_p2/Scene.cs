using System;
using System.Collections.Generic;
using System.Text;

namespace lp2_2019_p2
{
    class Scene
    {
        IEnumerable<IGameObject> gameObjects;

        bool running;

        public Scene()
        {
            running = true;
            GameLoop();
        }

        private void GameLoop()
        {
            while(running)
            {
                // User Input

                // Update each GameObject
                foreach (IGameObject go in gameObjects)
                    go.Update();

                // Render
            }
        }
    }
}
