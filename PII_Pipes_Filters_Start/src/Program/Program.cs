using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;


namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            IPipe pipeNull = new PipeNull();
            IFilter filterNegative = new FilterNegative();
            IPipe pipeSerial = new PipeSerial(filterNegative, pipeNull);
            IFilter filter_GreyScale= new FilterGreyscale();
            IPipe pipeSerial2 = new PipeSerial(filter_GreyScale, pipeSerial);

            picture = pipeSerial2.Send(picture);
        
            provider.SavePicture(picture, @"beer1.jpg" );

            
        }
    }
}
