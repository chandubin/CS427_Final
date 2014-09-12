using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public class Camera3D : InvisibleGameEntity
    {
        private Matrix _World = Matrix.Identity;

        public Matrix World
        {
            get { return _World; }
            set { _World = value; }
        }
        private Matrix _View = Matrix.Identity;

        public Matrix View
        {
            get { return _View; }
            set { _View = value; }
        }
        private Matrix _Projection = Matrix.Identity;

        public Matrix Projection
        {
            get { return _Projection; }
            set { _Projection = value; }
        }

        public Matrix WVP
        {
            get
            {
                return World * View * Projection;
            }
        }

        public float TransX = 0, TransY = 0, TransZ = 0;
        public float RotX = 0, RotY = 0, RotZ = 0.0f;
        public float ScaleX = 1, ScaleY = 1, ScaleZ = 1f;
        public float PreTranX = 0, PreTranY = 0, PreTranZ = 0;

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
/*            View = Matrix.CreateTranslation(PreTranX, PreTranY, PreTranZ) *
                Matrix.CreateScale(ScaleX, ScaleY, ScaleZ) *
                Matrix.CreateRotationX(RotX) * Matrix.CreateRotationY(RotY) * Matrix.CreateRotationZ(RotZ) *
                Matrix.CreateTranslation(TransX, TransY, TransZ);*/

            View = Matrix.CreateLookAt(CameraPosition, CameraTarget, CameraUpVector);
            Projection = Matrix.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, zNear, zFar);

        }

        public Matrix InvWVP
        {
            get
            {
                return Matrix.Invert(WVP);
            }
        }

        internal void Translate(float transX, float transY, int transZ)
        {
            TransX += transX;
            TransY += transY;
            TransZ += transZ;
        }

        internal void Zoom(Vector2 StartPos, float ScaleFactor)
        {
        }



        public Vector3 CameraPosition;
        public Vector3 CameraTarget;
        public Vector3 CameraUpVector;
        public  float FieldOfView;
        public float AspectRatio;
        public float zNear;
        public float zFar;

        internal void Init(Vector3 CameraPosition, Vector3 CameraTarget, Vector3 CameraUpVector, float FieldOfView, float AspectRatio, float zNear, float zFar)
        {
            this.CameraPosition = CameraPosition;
            this.CameraTarget = CameraTarget;
            this.CameraUpVector= CameraUpVector;
            this.FieldOfView = FieldOfView;
            this.AspectRatio = AspectRatio;
            this.zNear = zNear;
            this.zFar = zFar;

            View = Matrix.CreateLookAt(CameraPosition, CameraTarget, CameraUpVector);
            Projection = Matrix.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, zNear, zFar);
        }
    }
}

