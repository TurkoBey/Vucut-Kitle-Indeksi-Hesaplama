using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vucut_Kitle_Indeksi_Hesaplama
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Vücut Kitle Endeksi Hesaplama";
			Console.ForegroundColor = ConsoleColor.Cyan;
			string title = @"                                                                                                           
                                           _   _ _   _            _       _   ___ _   _       
                                          | | | (_) (_)          | |     | | / (_) | | |      
                                          | | | |_   _  ___ _   _| |_    | |/ / _| |_| | ___  
                                          | | | | | | |/ __| | | | __|   |    \| | __| |/ _ \ 
                                          \ \_/ / |_| | (__| |_| | |_    | |\  \ | |_| |  __/ 
                                           \___/ \__,_|\___|\__,_|\__|   \_| \_/_|\__|_|\___| 
                                                                                                                                                                                           
    _____          _      _        _     _   _                       _                        
   |  ___|        | |    | |      (_)   | | | |                     | |                       
   | |__ _ __   __| | ___| | _____ _    | |_| | ___  ___  __ _ _ __ | | __ _ _ __ ___   __ _  
   |  __| '_ \ / _` |/ _ \ |/ / __| |   |  _  |/ _ \/ __|/ _` | '_ \| |/ _` | '_ ` _ \ / _` | 
   | |__| | | | (_| |  __/   <\__ \ |   | | | |  __/\__ \ (_| | |_) | | (_| | | | | | | (_| | 
   \____/_| |_|\__,_|\___|_|\_\___/_|   \_| |_/\___||___/\__,_| .__/|_|\__,_|_| |_| |_|\__,_| 
                                                              | |                             
                                                              |_|";
			
			Console.WriteLine(title + "\n\n\n");
			Console.ForegroundColor = ConsoleColor.Green;

			double BOY, KILO, VKI;
			Console.WriteLine("Kilonunuzu giriniz : Örğ : 1.85");
			BOY = double.Parse(Console.ReadLine());
			Console.WriteLine("Kilonunuzu giriniz : Örğ : 100");
			KILO = double.Parse(Console.ReadLine());

			VKI = KILO / (BOY * BOY);
			Console.WriteLine("==================================");
			if (VKI < 18.5)
			{
				Console.WriteLine("Vücut kitle endeksi             :: " + Math.Round(VKI, 3));
				Console.WriteLine("\n18, 5 kg/m.'nin altında olanlar :: Zayıf");
			}
			else if (VKI >= 18.5 && VKI < 24.9)
			{
				Console.WriteLine("\nVücut kitle endeksi                 :: " + Math.Round(VKI, 3));
				Console.WriteLine("\n18.5 – 24, 9 kg/m. arasında olanlar :: Normal kilolu");
			}
			else if (VKI >= 25 && VKI < 29.9)
			{
				Console.WriteLine("\nVücut kitle endeksi               :: " + Math.Round(VKI, 3));
				Console.WriteLine("\n25 – 29, 9 kg/m. arasında olanlar :: Fazla kilolu");
			}
			else if (VKI >= 30 && VKI < 39.9)
			{
				Console.WriteLine("\nVücut kitle endeksi               :: " + Math.Round(VKI, 3));
				Console.WriteLine("\n30 – 39, 9 kg/m. arasında olanlar :: Obez");
			}
			else if (VKI >= 40)
			{
				Console.WriteLine("\nVücut kitle endeksi  :: " + Math.Round(VKI, 2));
				Console.WriteLine("İleri derecede obez (morbid obez), olarak görülür.");
			}
			Console.Write("\n\nPress any key to exit...");
			Console.ReadKey(true);
		}
	}
}
