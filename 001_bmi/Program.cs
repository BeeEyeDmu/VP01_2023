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
    }
  }
}
