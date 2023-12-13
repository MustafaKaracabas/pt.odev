using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saat_dakika_saniye
{
    internal class Program
    {
        static void Main(string[] args)
        {
                sbyte saniyeBirler = 0, saniyeOnlar = 0, DakikaBirler = 0, DakikaOnlar = 0, saatBirler = 0, saatOnlar = 0;
                for (saatOnlar = 0; saatOnlar <= 2; saatOnlar++)
                    for (saatOnlar = 0; saatOnlar <= 2; saatOnlar++)
                    {
                        for (saatBirler = 0; saatBirler <= 9; saatBirler++)
                        {




                            for (DakikaOnlar = 0; DakikaOnlar <= 5; DakikaOnlar++)
                            {
                                for (DakikaBirler = 0; DakikaBirler <= 9; DakikaBirler++)
                                {

                                    for (saniyeOnlar = 0; saniyeOnlar <= 5; saniyeOnlar++)
                                        for (saniyeBirler = 0; saniyeBirler <= 9; saniyeBirler++)

                                        {
                                            Console.WriteLine(saatOnlar.ToString() + saatBirler.ToString() + "." + DakikaOnlar.ToString() + DakikaBirler.ToString() + "." + saniyeOnlar.ToString() + saniyeBirler.ToString());
                                            System.Threading.Thread.Sleep(1000);// 1000 milisaniye=1 saniye bekleme
                                            Console.Clear();
                                            if ((saatOnlar == 2 && saatBirler == 3) && (DakikaOnlar == 5 && DakikaBirler == 9) && (saniyeBirler == 9 && saniyeOnlar == 5))
                                            {
                                                goto cık;
                                            }
                                        }
                                }
                            }
                        }
                    }
                cık:
                Console.WriteLine("Bir tuşa basınız ");
                Console.ReadKey();
            }
    }
}
