using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dELEGATE1_3
{
    public delegate double DelegateConvertTempurate(double d);

    class Program
    {
        static void Main(string[] args)
        {
            TempurareConvertImp tpi = new TempurareConvertImp();
            DelegateConvertTempurate[] ConWert = new DelegateConvertTempurate[2];
            ConWert[1] = tpi.for_cls;
            ConWert[0] = tpi.Cls_For;
            Write(ConWert);
            Console.Read();
        }

        private static void Write(DelegateConvertTempurate[] ConWert)
        {
            try
            {
                Console.WriteLine(ConWert[0](int.Parse(Console.ReadLine())));
                Console.WriteLine(ConWert[1](int.Parse(Console.ReadLine())));
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Write(ConWert);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Write(ConWert);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Write(ConWert);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Write(ConWert);
            }

        }
        
    }

    public class TempurareConvertImp
    {
        public double Cls_For(double C)
        {
            return C * 9 / 5 + 32;
        }

        public double for_cls(double F)
        {
            return (F - 32) * 5 / 9;
        }
    }


}
