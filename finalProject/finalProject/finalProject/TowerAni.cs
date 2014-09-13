using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class TowerAni : GameModel
    {
        private List<Texture2D> _Texture = new List<Texture2D>();
        private List<Spritesheet> _IdleLevel1 = new List<Spritesheet>();

        public List<Spritesheet> IdleLevel1
        {
            get { return _IdleLevel1; }
            set { _IdleLevel1 = value; }
        }

        private List<Spritesheet> _IdleLevel2 = new List<Spritesheet>();

        public List<Spritesheet> IdleLevel2
        {
            get { return _IdleLevel2; }
            set { _IdleLevel2 = value; }
        }
        private List<Spritesheet> _IdleLevel3 = new List<Spritesheet>();



        public List<Spritesheet> IdleLevel3
        {
            get { return _IdleLevel3; }
            set { _IdleLevel3 = value; }
        }
        private List<Spritesheet> _ShootingLevel1 = new List<Spritesheet>();

        public List<Spritesheet> ShootingLevel1
        {
            get { return _ShootingLevel2; }
            set { _ShootingLevel2 = value; }
        }

         private List<Spritesheet> _ShootingLevel2 = new List<Spritesheet>();

        public List<Spritesheet> ShootingLevel2
        {
          get { return _ShootingLevel2; }
          set { _ShootingLevel2 = value; }
        }

         private List<Spritesheet> _ShootingLevel3 = new List<Spritesheet>();

        public List<Spritesheet> ShootingLevel3
        {
          get { return _ShootingLevel3; }
          set { _ShootingLevel3 = value; }
        }
        private Spritesheet Cur;
        private int p;
        public List<Texture2D> Texture
        {
            get { return _Texture; }
            set { _Texture = value; }
        }

        public override void setIdleLevel1(List<Spritesheet> IL1)
        {
            IdleLevel1 = IL1;
            Cur = IdleLevel1[0];
            p = 0;
        }

        public override void setIdleLevel2(List<Spritesheet> IL2)
        {
            IdleLevel2 = IL2;
        }


        public override void setIdleLevel3(List<Spritesheet> IL3)
        {
            IdleLevel3 = IL3;
        }

        public override void setShootingLevel1(List<Spritesheet> SL1)
        {
            ShootingLevel1 = SL1;
        }

        public override void setShootingLevel2(List<Spritesheet> SL2)
        {
            ShootingLevel2 = SL2;
        }

        public override void setShootingLevel3(List<Spritesheet> SL3)
        {
            ShootingLevel3 = SL3;
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

        public TowerAni(string strResourceName, int nRes, int Left, int Top, int Width, int Height, int State)
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
            spriteBatch.Draw(_Texture[Cur.Sheet], new Vector2(Left, Top), Cur.Rec, Color.White);
        }
        double t = 0;
        public override void Update(GameTime gameTime)
        {
           
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
        public enum TOWER_STATE
        {
            IDLELEVEL1,
            IDLELEVEL2,
            IDLELEVEL3,
            SHOOTINGLELEVEL1,
            SHOOTINGLELEVEL2,
            SHOOTINGLEVEL3,
            SELECTED,
            NORMAL,
            MOUSEOVER
        }
        private TOWER_STATE _State = TOWER_STATE.NORMAL;

        public TOWER_STATE State
        {
            get { return _State; }
            set { _State = value; }
        }

        public override void Select(bool bSelect)
        {
            if (bSelect)
            {
                _State = TOWER_STATE.SELECTED;
                _Delay = 1;
            }
            else
            {
                _State = TOWER_STATE.NORMAL;
                _Delay = 50;
            }
        }

        public override void changeState(int s)
        {
         
        }
        public override void Over(bool bOver)
        {
            if (bOver)
            {
                _State = TOWER_STATE.MOUSEOVER;
                _Delay = 1;
            }
            else
            {
                _State = TOWER_STATE.NORMAL;
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
