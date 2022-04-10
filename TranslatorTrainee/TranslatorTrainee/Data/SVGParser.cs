using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;
namespace TranslatorTrainee.Data
{
    internal class SVGParser
    {
        private Size containersize;
        public SVGParser(Size size)
        {
            containersize = size;
        }

        public Bitmap GetBitmapFromSVG(string filename)
        {
            Bitmap bmp = null;

            string currentfilename =
                Directory.GetCurrentDirectory() + "\\SVGs\\" + filename + ".svg";
            var svgDoc = SvgDocument.Open(currentfilename);
            AdjustSize(svgDoc);
            processNodes(svgDoc.Descendants(), new SvgColourServer(Color.White));
            

            bmp = svgDoc.Draw();

            return bmp;

        }

        private SvgDocument AdjustSize(SvgDocument document)
        {
            if (document.Height > containersize.Height)
            {
                document.Width = (int)((document.Width / (double)document.Height) * containersize.Height);
                document.Height = containersize.Height;
            }
            return document;
        }

        private void processNodes(IEnumerable<SvgElement> nodes, SvgPaintServer colorServer)
        {
            foreach (var node in nodes)
            {
                if (node.Fill != SvgPaintServer.None) node.Fill = colorServer;
                if (node.Color != SvgPaintServer.None) node.Color = colorServer;
                //if (node.StopColor != SvgPaintServer.None) node.StopColor = colorServer;
                if (node.Stroke != SvgPaintServer.None) node.Stroke = colorServer;

                processNodes(node.Descendants(), colorServer);
            }
        }

    }
}
