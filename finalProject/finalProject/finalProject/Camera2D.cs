using Microsoft.Xna.Framework;
namespace WindowsGame1
{
    public class Camera2D : InvisibleGameEntity
    {
        private Matrix _World=Matrix.Identity;

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
        
        }
        public Matrix WVP//screen to world
        {
            get { return World * View * Projection; }
        }
        public Matrix InvWVP//world to screen
        {
            get { return Matrix.Invert(WVP); }
        }
        protected float TransX = 0, TransY = 0, TransZ = 0;
        protected float RotX = 0, RotY = 0, RotZ = 0;
        protected float ScaleX = 1, ScaleY = 1, ScaleZ = 1;
        protected float PreTransX = 0, PreTransY = 0, PreTransZ = 0;
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            View = Matrix.CreateTranslation(PreTransX, PreTransY, PreTransZ) *
                Matrix.CreateScale(ScaleX, ScaleY, ScaleZ) *
                Matrix.CreateRotationX(RotX) *
                Matrix.CreateRotationY(RotY) *
                Matrix.CreateRotationZ(RotZ) *
                Matrix.CreateTranslation(TransX, TransY, TransZ);
        }

        public void Translate(float transX, float transY, float transZ)
        {
            TransX += transX;
            TransY += transY;
            TransZ += transZ;
        }
        public void Zoom(Vector2 StartPos, float ScaleFactor)
        {
            PreTransX = -StartPos.X; PreTransY = -StartPos.Y; PreTransZ = 0;
            ScaleX = ScaleY = ScaleFactor; ScaleZ = 1;
            TransX = StartPos.X; TransY = StartPos.Y; TransZ = 0;
        }
        public void Zoom(Vector2 StartPos, Vector2 EndPos, float ScaleFactor)
        {
            PreTransX = -StartPos.X; PreTransY = -StartPos.Y; PreTransZ = 0;
            ScaleX = ScaleY = ScaleFactor; ScaleZ = 1;
            TransX = EndPos.X; TransY = EndPos.Y; TransZ = 0;
        }
        //new feature
        public  Vector2 location = Vector2.Zero;

        public   int ViewWidth { get; set; }
        public   int ViewHeight { get; set; }
        public   int WorldWidth { get; set; }
        public   int WorldHeight { get; set; }

        public   Vector2 DisplayOffset { get; set; }

        public  Vector2 Location
        {
            get
            {
                return location;
            }
            set
            {
                location = new Vector2(
                    MathHelper.Clamp(value.X, 0f, WorldWidth - ViewWidth),
                    MathHelper.Clamp(value.Y, 0f, WorldHeight - ViewHeight));
            }
        }

        public  Vector2 WorldToScreen(Vector2 worldPosition)
        {
            return worldPosition - Location + DisplayOffset;
        }

        public Vector2 ScreenToWorld(Vector2 screenPosition)
        {
            return screenPosition + Location - DisplayOffset;
        }

        public  void Move(Vector2 offset)
        {
            Location += offset;
        }
    }
    
    

}
