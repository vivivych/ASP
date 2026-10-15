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
//SVG - Scaleable Vector Graphic, масштабируемая векторная графика. Изображение хранится не в виде двумерного массива пикселов, (как в растровых) а в виде
// математических формул. Благодаря этому векторные изображения могут масштабироваться сколько угодно без потери качества. Мат формулы в текстовом виде занимают меньше места
// чем двумерные массивы. Что ускоряет передачу векторых изображений по сети. 