using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
  
    public class MainWindowVM
    {
     

        public string Kilo { get; set; }

        public MainWindowVM()
        {
            Kilo = "100";
        }

        public void Paste()
        {

            if (Clipboard.ContainsImage())
            {


                Bitmap bmp = (Bitmap)System.Windows.Forms.Clipboard.GetImage();
                BitmapSource bmpSrc = Clipboard.GetImage();

                //img1.Source = bmpSrc;

            }

            if (Clipboard.ContainsFileDropList())
            {

                var files = Clipboard.GetFileDropList();

                foreach (var item in files)
                {

                }

                Bitmap bmp = (Bitmap)System.Windows.Forms.Clipboard.GetImage();
                BitmapSource bmpSrc = Clipboard.GetImage();

                //img1.Source = bmpSrc;

            }
        }
    }
}
