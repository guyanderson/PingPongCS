using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace PingPong.Objects
{
  public class PingPong
  {
    private int _number;
    private List<string> numberList = new List<string> {};
    public PingPong(int number)
    {
      _number = number;
      MakeList(_number);
    }
    public string IsPingPong(int number)
    {
      if(IsNumberDivisibleBy15(number))
      {
        return "PingPong";
      }
      else if(IsNumberDivisibleBy5(number))
      {
        return "Pong";
      }
      else if(IsNumberDivisibleBy3(number))
      {
        return "Ping";
      }
      else
      {
        return number.ToString();
      }
    }

    public void MakeList(int number)
    {
      for(int i = 0; i <= number; i++)
      {
        numberList.Add(IsPingPong(i));
      }
    }

    public List<string> GetList()
    {
      return numberList;
    }

    public bool IsNumberDivisibleBy15(int number)
    {
      return number % 15 == 0;
    }
    public bool IsNumberDivisibleBy5(int number)
    {
      return number % 5 == 0;
    }
    public bool IsNumberDivisibleBy3(int number)
    {
      return number % 3 == 0;
    }
    public int GetNumber()
    {
      return _number;
    }
  }
}
