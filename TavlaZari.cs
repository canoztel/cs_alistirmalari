using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    
    internal class TavlaZari
    {
        /// <summary>
        /// Zarın alabileceği maksimum değer değişkeni
        /// </summary>
        int maksimumZarDegeri;  //field
        Random random = new Random();

        /// <summary>
        /// Zarın alabileceği maksimum değeri giriniz
        /// </summary>
        /// <param name="maksimumZarDegeri"></param>
        public TavlaZari (int maksimumZarDegeri) //construction
        {
            this.maksimumZarDegeri = maksimumZarDegeri;
        }
        /// <summary>
        /// rastgele bir sayi için zar at
        /// </summary>
        /// <returns></returns>
        public int ZarAt() //metod
        {
            //rastgele bir sayi atılacak
            return random.Next(1, maksimumZarDegeri + 1); // . Next belirlenen aralıkta random sayılar seçecektir
        }
    }

}
