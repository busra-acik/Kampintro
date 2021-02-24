using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{  
     class Urun
    {

        //Property = özellik, aşağıdakilerin hepsi özellik
        public int Id { get; set; }//Bir datayı dğierlerinden ayırt etmeye yarayan eşsiz değer tc gibi
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
