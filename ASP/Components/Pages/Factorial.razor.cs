using System.Numerics;

namespace ASP.Components.Pages
{
    public partial class Factorial
    {
        int n = 0;    //RAII - Resource Aquisition is Initialization (выделение ресурсов - инициализация)

        BigInteger f = 1;

        void Calculate()
        {
            f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;

            }


        }
    }
}
