﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Knitter.Render;

namespace Knitter
{
    public class KnitterEngine
    {
        private readonly World _world;
        private bool _canRun;
        private Renderer _renderer = new Renderer();

        public KnitterEngine(World world) {
            //TODO: world should be load from asset
            _world = world;
        }

        public void Run()//TODO: avoid run twice
        {
            _canRun = true;
            while (_canRun)
            {
                Time.Update();
                //TODO: input.Update();
                _world.Update();
                //TODO: render.Update();
                Thread.Sleep((int)Random.Shared.NextInt64(100, 500));
            }
        }

        public void Stop()
        {
            _canRun = false;
        }

    }
}
