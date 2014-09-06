using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace finalProject
{
    public class MenuDialog : VisibleGameEntity
    {
        public List<MenuDialogItem> item;
        public string infor;
        public MenuDialog(string strResourceName, int nRes, int Left, int Top, int Width, int Height)
        {
         
            _MainModel = new Sprite2D(strResourceName, nRes, Left, Top, Width, Height);
            ((Sprite2D)_MainModel).LayerDepth = 0.98f;
            item=new List<MenuDialogItem>(); 
        }
        //public void AddItem(MenuDialogItem tem)
        //{
        //    item.Add(tem);
        //}
        public override void Draw(GameTime gameTime, object Paramas)
        {

            
            base.Draw(gameTime, Paramas);
            for (int i = 0; i < item.Count; i++)
            {

                item[i].Draw(gameTime, Paramas);
            }
        }
        public void Select(int index)
        {
            for (int i = 0; i < this.item.Count; i++)
            {
                item.ElementAt(i).Select(index == i);
                
            }
        }
        public void Circle(int index)
        {
            for (int i = 0; i < this.item.Count; i++)
            {
                item.ElementAt(i)._MainModel.Circle(index == i);

            }
        }
        
   
        public override int IsSelected(float X, float Y)
        {
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].IsSelected(X, Y) != -1)
                    return i;
            }
            return -1;
        }
        //public void LoadMenu(string infor)
        //{
        //    item.RemoveRange(0, item.Count);
        //    this.infor = infor;
        //    string[] t = infor.Split(';');
        //    int k = 0;
        //    for (int i = 0; i < t.Count(); i++)
        //    {
                
        //        switch (t[i])
        //        {
        //            case "DSea":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Dragon/Sea", 1, 0, -k, 0, 0,"DSea"));
        //                    break;
        //                }
        //            case "DNature":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Dragon/Nature", 1, 0, -k, 0, 0,"DNature"));
        //                    break;
        //                }
        //            case "DElectric":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Dragon/Electric", 1, 0, -k, 0, 0,"DElectric"));
        //                    break;
        //                }
        //            case "HSea":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Habitat/Sea", 1, 0, -k, 0, 0, "HSea"));
        //                    break;
        //                }
        //            case "HNature":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Habitat/Nature", 1, 0, -k, 0, 0, "HNature"));
        //                    break;
        //                }
        //            case "HElectric":
        //                {
        //                    item.Add(new MenuDialogItem(@"Buttons/Habitat/Electric", 1, 0, -k, 0, 0, "HElectric"));
        //                    break;
        //                }

        //        }
        //        k += 70;
        //    }
            

        //}
    }
}
