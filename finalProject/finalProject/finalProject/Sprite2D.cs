using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace finalProject
{
    public class Sprite2D : GameModel
    {
        private List<Texture2D> _Texture=new List<Texture2D>();
        private float _LayerDepth = 1;

        public float LayerDepth
        {
            get { return _LayerDepth; }
            set { _LayerDepth = value; }
        }
        public List<Texture2D> Texture
        {
            get { return _Texture; }
            set { _Texture = value;
            _nTextures = _Texture.Count;
            _iTexture = 0;
            DetectResourceSize();
                
                }
        }
        private int _nTextures;

        public int nTextures
        {
            get { return _nTextures; }
          //  set { _nTextures = value; }
        }
        private int _iTexture;

        public int iTexture
        {
            get { return _iTexture; }
           // set { _iTexture = value; }
        }

        protected float _Left;

        public float Left
        {
            get { return _Left; }
            set { _Left = value; }
        }
        protected float _Top;

        public float Top
        {
            get { return _Top; }
            set { _Top = value; }
        }
        private float _Width;
        private string strResourceName;
        private int nRes;

        public float Width
        {
            get { return _Width; }
            set {_Width = value; }
        }

        public Sprite2D(string strResourceName, int nRes, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            this.strResourceName = strResourceName;
            this.nRes = nRes;
            LoadResource(strResourceName, nRes);
            
            if (Width == 0 && Height == 0)
            {
                DetectResourceSize();
            }
            else
            {
                this.Width = Width;
                this.Height = Height;
            }
            this.Left = Left-this.Width/2;
            this.Top = Top-this.Height/2;
        }

        public Sprite2D(string strResourceName, int Left, int Top, int Width, int Height)
        {
            // TODO: Complete member initialization
            // TODO: Complete member initialization
            this.strResourceName = strResourceName;
            this.nRes = 1;
            LoadResource(strResourceName);
            this.Left = Left;
            this.Top = Top;
            if (Width == 0 && Height == 0)
            {
                DetectResourceSize();
            }
            else
            {
                this.Width = Width;
                this.Height = Height;
            }
           
        }

        private void LoadResource(string strResourceName)
        {
            _nTextures = 1;
            _Texture.Clear();
                _Texture.Add(Global.Content.Load<Texture2D>(strResourceName));
        
        }

        private void DetectResourceSize()
        {
            this.Width = _Texture[0].Width;
            this.Height = _Texture[0].Height;
        }

        private void LoadResource(string strResourceName, int nRes)
        {
            _nTextures = nRes;
            _Texture.Clear();
            for (int i = 1; i <=nRes; i++)
            {
                _Texture.Add(Global.Content.Load<Texture2D>(strResourceName+i.ToString("00")));
            }
        }
        private float _Height;
        public float Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public override void Draw(GameTime gameTime, object Paramas)
        {
           SpriteBatch spriteBatch = (SpriteBatch)Paramas;
           // if (_Left < 0 && _Top < 0)
           // {
           //     if(_State==SPRITE_STATE.NORMAL)spriteBatch.Draw(_Texture[_iTexture], new Vector2(-_Left, -_Top), Color.White);
           //     else spriteBatch.Draw(_Texture[_iTexture], new Vector2(-_Left, -_Top), Color.Silver);
           //     return;
           // }
           // Vector2 hilightLoc = new Vector2(_Left, _Top);
           // Point hilightPoint = Global.myMap.WorldToMapCell(new Point((int)hilightLoc.X, (int)hilightLoc.Y));

           // int hilightrowOffset = 0;
           // if ((hilightPoint.Y) % 2 == 1)
           //     hilightrowOffset = Tile.OddRowXOffset;

           
           // if (_State == SPRITE_STATE.NORMAL)
           //     spriteBatch.Draw(_Texture[_iTexture], Global.CurrentCamera.WorldToScreen(
           //                 new Vector2(
           //                     (hilightPoint.X * Tile.TileStepX) + hilightrowOffset,
           //                     (hilightPoint.Y + 2) * Tile.TileStepY)), Color.White);
           //else if (_State == SPRITE_STATE.SELECTED)
           // {
           //     delta = -10;
           //     spriteBatch.Draw(_Texture[_iTexture], Global.CurrentCamera.WorldToScreen(
           //                 new Vector2(
           //                     (hilightPoint.X * Tile.TileStepX) + hilightrowOffset,
           //                     (hilightPoint.Y + 2) * Tile.TileStepY)), Color.Silver);

           // }
            if (_State == SPRITE_STATE.SELECTED)
            {
                delta = -10;
                spriteBatch.Draw(_Texture[_iTexture], Global.CurrentCamera.WorldToScreen(
                            new Vector2(_Left,_Top)),Color.White);

            }
            else
            {
                spriteBatch.Draw(_Texture[_iTexture], new Vector2(_Left, _Top), Color.LightCyan);
            }

        }
        private float delta=1;
        private float ddelta=1;
        public override void Update(GameTime gameTime)
        {
           
            _iTexture = (_iTexture + 1) % _nTextures;
            base.Update(gameTime);
            double t = gameTime.TotalGameTime.TotalMilliseconds;
            if (_State == SPRITE_STATE.SELECTED)
            {
                if (Math.Abs(delta) == 10)
                    ddelta *= -1;
                delta += ddelta;

            }
            _iTexture = ((int)(t / _Delay)) % _nTextures;
        }
        public override int IsSelected(float X, float Y)
        {
            Vector2 pos = new Vector2(X, Y);
            if (_Left <= 0 && _Top <= 0)
            {
                if (-_Left <= pos.X && pos.X <= -_Left + Width && -_Top <= pos.Y && pos.Y <= -_Top + Height)
                    return 0;
            }
            pos=Global.CurrentCamera.ScreenToWorld(new Vector2(X, Y));
            if (_Left <= pos.X && pos.X <= _Left + Width && _Top <= pos.Y && pos.Y <= _Top + Height)
                return 0;
            return -1;
            
        }
        public enum SPRITE_STATE
        {
            NORMAL,
            SELECTED,
            DISABLED,
            CIRCLE
        }
        private SPRITE_STATE _State = SPRITE_STATE.NORMAL ;

        public SPRITE_STATE State
        {
            get { return _State; }
            set { _State = value;
            reLoadResource();
            }
        }
        private void reLoadResource()
        {
            if (_State == SPRITE_STATE.SELECTED)
            {
                LoadResource(this.strResourceName + "_selected", this.nRes);
            }
            else if (_State == SPRITE_STATE.DISABLED)
            {
                LoadResource(this.strResourceName + "_disabled", this.nRes);
            }
            else if (_State == SPRITE_STATE.CIRCLE)
            {
                LoadResource(this.strResourceName + "_circle", this.nRes);
            }
            else //normal
            {
                LoadResource(this.strResourceName, this.nRes);
            }
        }
        public override void Select(bool bSelect)
        {
            if (bSelect)
            {
                _State = SPRITE_STATE.SELECTED;
                _Delay = 1;
                reLoadResource();
            }
            else
            {
                _State = SPRITE_STATE.NORMAL;
                _Delay = 50;
                reLoadResource();
            }
        }
        public override void Circle(bool bSelect)
        {
            if (bSelect)
            {
                _State = SPRITE_STATE.CIRCLE;
                _Delay = 1;
                reLoadResource();
            }
            else
            {
                _State = SPRITE_STATE.NORMAL;
                _Delay = 50;
                reLoadResource();
            }
        }
        public override void Disable(bool bSelect)
        {
            if (bSelect)
            {
                _State = SPRITE_STATE.DISABLED;
                _Delay = 1;
                reLoadResource();
            }
            else
            {
                _State = SPRITE_STATE.NORMAL;
                _Delay = 50;
                reLoadResource();
            }
        }
        
        public override void Over(bool bOver)
        {
            if (bOver)
            {
                _State = SPRITE_STATE.DISABLED;
                _Delay = 1;
            }
            else
            {
                _State = SPRITE_STATE.NORMAL;
                _Delay = 50;
            }
        }
        private int _Delay =100;
        private int p;
        private int p_2;
        private int FragmentWidth;
        private int FragmentHeight;

        public int Delay
        {
            get { return _Delay; }
            set { _Delay = value; }
        }
    }
}
