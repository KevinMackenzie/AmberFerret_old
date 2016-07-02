using Pencil.Gaming.MathUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor
{
    public class TransformComponent : IActorComponent
    {
        public Vector3 Position { get; set; }
        public Quaternion QRotation { get; set; }
        public Vector3 Scale { get; set; }

        /// <summary>
        /// Allows Control over the order in which transformations are applied; almost always ScaleRotationPosition
        /// </summary>
        public enum TransformOrder
        {
            ScaleRotationPosition,
            ScalePositionRotation,
            RotationScalePosition,
            RotationPositionScale,
            PositionScaleRotation,
            PositionRotationScale
        }
        public TransformOrder TransOrder { get; set; } = TransformOrder.ScaleRotationPosition;

        public Matrix Transform()
        {
            return Matrix.CreateTranslation(Position) * Matrix.CreateFromQuaternion(QRotation) * Matrix.CreateScale(Scale);
        }
        public Vector3 LookAt()
        {
            return QRotation.LookAt();
        }
        public string GetName()
        {
            return "TransformComponent";
        }
        public bool Init()
        {
            return true;
        }
        public void OnChanged()
        {  }
        public void PostInit()
        {  }
        public void Update(TimeSpan deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}
