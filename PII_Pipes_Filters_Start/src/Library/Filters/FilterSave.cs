using System;
using System.Drawing;
using CompAndDel;
using TwitterUCU;

// EJERCICIO 2
namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        private int Counting = 0;
        
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();

            PictureProvider p = new PictureProvider();
            p.SavePicture(result, @$"beer{this.Counting}.jpg" );
            //EJE 3 api de twitter.
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"{this.Counting} and none of the average",@$"C:\Users\Luana\OneDrive\Escritorio\facultad segundo\Programacion\PII_Pipes_Filters_Start\src\Program\beer{this.Counting}.jpg"));
            this.Counting +=1;

            return result;
        }
        
        
    }
}
