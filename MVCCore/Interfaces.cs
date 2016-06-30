﻿using EventManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore
{
    namespace Interfaces
    {
        public interface IModelManager
        {
            IModel GetModel(string path);
            bool LoadModel(StreamReader stream, string serializerKey);
            void RegisterSerializer(IModelSerializer serializer, string key);
        }

        public interface IModel
        {
        }

        public interface IModelSerializer
        {
            string Serialize(IModel model);
            IModel Deserialize(StreamReader inData);
        }
        
        public interface IView
        {
            void RenderFrame(TimeSpan deltaTime);
            void UpdateFromModel(IModel model);
        }

        public interface IViewManager
        {
            void RenderAll(TimeSpan deltaTime);
            void Render(TimeSpan deltaTime, int viewIndex);
            //returns the index of the added view
            int AddView(IView view);
        }

        public interface ISceneGraphNode
        {
            void PreRender();
            void Render(TimeSpan deltaTime);
            void PostRender();
            void RenderChildren(TimeSpan deltaTime);
        }

    }
}
