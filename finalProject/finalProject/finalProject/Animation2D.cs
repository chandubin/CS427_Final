using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Animation2D : GameModel
    {
        private List<Texture2D> _Texture = new List<Texture2D>();
        private List<Spritesheet> _RightAni = new List<Spritesheet>();

        public List<Spritesheet> RightAni
        {
            get { return _RightAni; }
            set { _RightAni = value; }
        }

        private List<Spritesheet> _LeftAni = new List<Spritesheet>();

        public List<Spritesheet> LeftAni
        {
            get { return _LeftAni; }
            set { _LeftAni = value; }
        }
        private List<Spritesheet> _UpAni = new List<Spritesheet>();



        public List<Spritesheet> UpAni
        {
            get { return _UpAni; }
            set { _UpAni = value; }
        }
        private List<Spritesheet> _DownAni = new List<Spritesheet>();

        public List<Spritesheet> DownAni
        {
            get { return _DownAni; }
            set { _DownAni = value; }
        }
        private Spritesheet Cur;
        private int p;
        public List<Texture2D> Texture
        {
            get { return _Texture; }
            set { _Texture = value; }
        }

        public override void setRightAni(List<Spritesheet> RA)
        {
            RightAni = RA;
            Cur = RightAni[0];
            p = 0;
        }

        public override void setDownAni(List<Spritesheet> DA)
        {
            DownAni = DA;
        }


        public override void setUpAni(List<Spritesheet> UA)
        {
            UpAni = UA;
        }

        private float _Left;

        public float Left
        {
            get { return _Left; }
            set { _Left = value; }
        }
        private float _Top;

        public float Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
        private float _Width;
        private string strResourceName;

        public float Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        private int speed = 1;

        public Animation2D(string strResourceName, int nRes, int Left, int Top, int Width, int Height, int State)
        {
            // TODO: Complete member initialization
            // TODO: Complete member initialization
            this.strResourceName = strResourceName;
            LoadResource(strResourceName, nRes);
            this.Left = Left;
            this.Top = Top;
            if (Width == 0 && Height == 0)
            {
                // DetectResourceSize();
            }
            else
            {
                this.Width = Width;
                this.Height = Height;
            }
            changeState(State);
        }


        private void LoadResource(string strResourceName, int nRes)
        {
            _Texture.Clear();
            for (int i = 1; i <= nRes; i++)
            {
                _Texture.Add(Global.Content.Load<Texture2D>(strResourceName + i.ToString("00")));
            }
        }

        //private void DetectResourceSize()
        //{
        //    this.Width = _Texture.Width;
        //    this.Height = _Texture.Height;
        //}

        private float _Height;
        public float Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public override void Draw(GameTime gameTime, object Paramas)
        {
            SpriteBatch spriteBatch = (SpriteBatch)Paramas;
            if (State == ANIMATION_STATE.GOINGLEFT)
            {
                spriteBatch.Draw(_Texture[Cur.Sheet], new Vector2(Left, Top), Cur.Rec, Color.White, 0.0f, new Vector2(0, 0), 1f, SpriteEffects.FlipHorizontally, 0.0f);
            }
            else
                spriteBatch.Draw(_Texture[Cur.Sheet], new Vector2(Left, Top), Cur.Rec, Color.White);
        }
        double t = 0;
        public override void Update(GameTime gameTime)
        {
            t += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (_State == ANIMATION_STATE.GOINGRIGHT)
            {

                if (t > Delay)
                {
                    ++p;
                    if (p >= RightAni.Count)
                        p = 0;
                    Left += speed;
                    Cur = RightAni[p];
                    t = 0;
                }
            }
            if (_State == ANIMATION_STATE.GOINGUP)
            {

                if (t > Delay)
                {
                    ++p;
                    if (p >= UpAni.Count)
                        p = 0;
                    Top -= speed;
                    Cur = UpAni[p];
                    t = 0;
                }
            }
            if (_State == ANIMATION_STATE.GOINGDOWN)
            {

                if (t > Delay)
                {
                    ++p;
                    if (p >= DownAni.Count)
                        p = 0;
                    Top += speed;
                    Cur = DownAni[p];
                    t = 0;
                }
            }
            if (_State == ANIMATION_STATE.GOINGLEFT)
            {

                if (t > Delay)
                {
                    ++p;
                    if (p >= RightAni.Count)
                        p = 0;
                    Left -= speed;
                    Cur = RightAni[p];
                    t = 0;
                }
            }
        }
        public override int IsSelected(float X, float Y)
        {
            Vector2 pos = Global.mouseHelper.GetMousePosition();
            pos = Vector2.Transform(pos, Global.CurrentCamera.InvWVP);
            if (pos.X >= _Left && pos.X <= _Left + _Width && pos.Y >= _Top && pos.Y <= _Top + _Height)
            {
                return 0;
            }
            return -1;
        }
        public enum ANIMATION_STATE
        {
            GOINGRIGHT,
            GOINGLEFT,
            GOINGDOWN,
            GOINGUP,
            TURNLEFT,
            TURNRIGHT,
            DYING,
            SELECTED,
            NORMAL,
            MOUSEOVER
        }
        private ANIMATION_STATE _State = ANIMATION_STATE.NORMAL;

        public ANIMATION_STATE State
        {
            get { return _State; }
            set { _State = value; }
        }

        public override void Select(bool bSelect)
        {
            if (bSelect)
            {
                _State = ANIMATION_STATE.SELECTED;
                _Delay = 1;
            }
            else
            {
                _State = ANIMATION_STATE.NORMAL;
                _Delay = 50;
            }
        }

        public override void changeState(int s)
        {
            if (s == 0)
                _State = ANIMATION_STATE.GOINGUP;
            else if (s == 1)
                _State = ANIMATION_STATE.GOINGRIGHT;
            else if (s == 2)
                _State = ANIMATION_STATE.GOINGDOWN;
            else if (s == 3)
                _State = ANIMATION_STATE.GOINGLEFT;

        }
        public override void Over(bool bOver)
        {
            if (bOver)
            {
                _State = ANIMATION_STATE.MOUSEOVER;
                _Delay = 1;
            }
            else
            {
                _State = ANIMATION_STATE.NORMAL;
                _Delay = 50;
            }
        }
        private int _Delay = 33;

        public int Delay
        {
            get { return _Delay; }
            set { _Delay = value; }
        }
    }

}
