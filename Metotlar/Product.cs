using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Product
    {
        Urun urun1 = new Urun();
        urun1.Adi=''Elma'';
        urun1.Fiyati=15;
        urun1.Aciklama=''Amasya Elması'';

        Urun urun2 = new Urun();
        urun2.Adi=''Armut'';
        urun2.Fiyati=26;
        urun2.Aciklama=''Ordu Armutu'';

        urun[] Urunler = new urun[] { urun1, urun2 };

        foreach (Urun urun in urunler)

	{
        Console.WriteLine(urun.adi);
        Console.WriteLine(urun.Fiyati);
        Console.WriteLine(urun.aciklama);
        Console.WriteLine(''...............'');
	}
    Console.WriteLine(''..........Metotlar'');
        Sepetmanager sepetmanager = new Sepetmanager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);


    }
