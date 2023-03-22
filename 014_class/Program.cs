using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_class
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();

      for(int i=0; i<10; i++)
        Console.WriteLine(r.Next());

      // 10명의 성적을 저장하는 배열 score를 만들고
      // 랜덤하게 점수를 생성하여 저장하시오
      int[] score = new int[10];
      for(int i=0; i<10; i++)
        score[i] = r.Next(101);

      // 배열의 내용을 출력
      foreach(var x in score)
        Console.Write(x + " ");
      Console.WriteLine();

      int min = score[0];
      int max = score[0];
      int sum = 0;

      for(int i=0; i<10; i++)
      {
        if(score[i] < min)
          min = score[i];
        if(score[i] > max)
          max = score[i];
        sum += score[i];
      }
      Console.WriteLine("min={0}, max={1}, avg={2}",
        min, max, sum/10.0);

    }
  }
}
