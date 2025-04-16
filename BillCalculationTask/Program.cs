namespace ThemeParkCalculationTask
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /* A theme park charges £15 per person for a daily ticket. If there are six or more people in a group, the group is given a £5 discount.
      Write a C# program to calculate the total charge for a group of people visiting the theme park.
      The program must:
      • get the user to enter the number of people in a group
      • calculate the total charge by:
          ○ charging £15 per person
          ○ reducing the total charge by £5 if there are six or more people
      • output the total charge.
      You should use meaningful variable name(s) inyour answer.
      */
      // Write your program and test it with the following test data
      // 1: 4 people
      // 2: 10 people
      // 3: 6 people
      // Commit your changes and add screnshot evidence of your program running to the Readme
      Console.WriteLine("how many people are in your group");
      int people = Convert.ToInt32(Console.ReadLine());
      if (people >= 6)
      {
        int cost = people * 15;
        cost = cost - 5;
        Console.WriteLine("your total is £" + cost);
      }
      else if (people < 6)
      {
        int cost2 = people * 15;
        Console.WriteLine("your total is £" + cost2);
      }
      else
      {
        Console.WriteLine("invalid input");
      }
    }
  }
}
