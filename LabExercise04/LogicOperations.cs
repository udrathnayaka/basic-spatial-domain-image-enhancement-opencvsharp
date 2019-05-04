using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace LabExercise04
{
    class LogicOperations
    {
        IplImage src, mask,andImage,orImage, subtractedImage;
        public void LoadOriginalImage(String fname)
        {
            src = Cv.LoadImage(fname,LoadMode.Color);
            Cv.SaveImage("1.jpg", src);
        }

        public void LoadMaskImage(String fname)
        {
            mask = Cv.LoadImage(fname, LoadMode.Color);
            Cv.SaveImage("2.jpg", mask);
        }

        public void ANDOperation()
        {
            andImage = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            Cv.And(src,mask,andImage);
            Cv.SaveImage("3.jpg", andImage);
        }

        public void OROperation()
        {
            orImage = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            Cv.Or(src, mask, orImage);
            Cv.SaveImage("4.jpg", orImage);
        }

        public void Subtraction()
        {
            subtractedImage = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            Cv.AbsDiff(src, mask, subtractedImage);
            Cv.SaveImage("5.jpg", subtractedImage);
        }
    }
}
