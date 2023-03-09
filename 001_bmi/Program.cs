using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_bmi
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("키(cm): ");
      double height = double.Parse(Console.ReadLine());

      Console.Write("체중(kg): ");
      double weight = double.Parse(Console.ReadLine());

      double bmi = weight / (height / 100 * height / 100);
      //Console.WriteLine("BMI = " + bmi);
      //Console.WriteLine("BMI = {0,20:F2}", bmi);
      //Console.WriteLine("CMI = {0,20:F2}", 5897563.56487);

      Console.WriteLine("BMI = {0:F2}", bmi);
      //Console.WriteLine("BMI = {0:#.##}", bmi);

      // 비만 판정
      // if(조건식)
      //    문장;
      // else if(조건식)
      //    문장;
      // ...
      // else
      //    문장;

      if (bmi < 20)
        Console.WriteLine("저체중");
      else if ( bmi < 25)
        Console.WriteLine("정상체중");
      else if ( bmi < 30)
        Console.WriteLine("경도비만");
      else if ( bmi < 40)
        Console.WriteLine("비만");
      else 
        Console.WriteLine("고도비만");
    }
  }
}
