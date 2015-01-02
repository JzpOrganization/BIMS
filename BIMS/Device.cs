﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows .Forms;
using System.Drawing;

namespace BIMS
{
    public abstract  class BaseDevice: PictureBox 
    {
        private Form mform;

        public Form Mform
        {
            get { return mform; }
            set { mform = value; }
        }
        public BaseDevice()
        {
            this.MouseDown += new MouseEventHandler(Common_MouseDown);
            //this.MouseEnter += new EventHandler(Common_MouseEnter);
            //this.MouseLeave += new EventHandler(Common_MouseLeave);
        }

        private void Common_MouseDown(object sender, EventArgs e) 
        {
            if (Mform == null || Mform.IsDisposed)
            {
                newform();
                Mform.LostFocus += new EventHandler(Common_LostFocus);
            }

            Mform.Show();
            Mform.Focus();

            if (MousePosition.X < 1280)
            {
                if (MousePosition.Y < 720)
                { Mform.Location = new Point(MousePosition.X , MousePosition.Y ); }
                else
                { Mform.Location = new Point(MousePosition.X , MousePosition.Y - Mform.Size.Height ); }
            }
            else
            {
                if (MousePosition.Y < 720)
                { Mform.Location = new Point(MousePosition.X - Mform.Size.Width , MousePosition.Y ); }
                else
                { Mform.Location = new Point(MousePosition.X - Mform.Size.Width , MousePosition.Y - Mform.Size.Height ); }
            }
        }

        private void Common_LostFocus(object sender, EventArgs e)
        { Mform.Hide(); }
        //  private void Common_MouseEnter(object sender, EventArgs e)
        //{
        //    if (Mform == null || Mform.IsDisposed) 
        //    { 
        //         newform() ;
        //    }

        //    if (MousePosition.X < 1280)
        //    {
        //        if (MousePosition.Y < 720)
        //        { Mform.Location = new Point(MousePosition.X - 10, MousePosition.Y - 10); } 
        //        else
        //        { Mform.Location = new Point(MousePosition.X - 10, MousePosition.Y - Mform.Size.Height - 10); }
        //    }
        //    else
        //    {
        //        if (MousePosition.Y < 720)
        //        { Mform.Location = new Point(MousePosition.X - Mform.Size.Width - 10, MousePosition.Y - 10); }
        //        else
        //        { Mform.Location = new Point(MousePosition.X - Mform.Size.Width - 10, MousePosition.Y - Mform.Size.Height - 10); }
        //    }
               
        //    Mform.Show();
        //    Mform.Focus();
        //}
        //  private void Common_MouseLeave(object sender, EventArgs e) 
        //  {
        //      //Mform.Hide();
        //  }


          public virtual  void newform() { }
    }

    class DED194E_9S1YK2K2 : BaseDevice
    { 

        public DED194E_9S1YK2K2()
        {
        }

        public override  void newform() 
        { 
              Mform =new Frm_DED194E_9S1YK2K2() ;
        }
    }
}