using System;

public class Programmer : Creator
{
    public override void Create()
    {
        if (base.Creativitylevel >= 70 && base.Energy >= 80)
    {
            this.BrainstormSolutions();
            this.PickMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
         }
         else
         {
            throw new Exception("Cannot create a program. Out of ideas and/or tiered.");
         }
    }

    private void BrainstormSolutions()
    {
        base.Creativitylevel = base.Creativitylevel - 15;
        base.Energy = base.Energy - 10;
        Console.WriteLine("Brainstorming solutions...");
    }

    private void PickMostOptimalSolution()
    {
        base.Creativitylevel = base.Creativitylevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Picking most optimal solution...");
    }

    private void WriteCode()
    {
        base.Creativitylevel = base.Creativitylevel - 7;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Writing code...");
    }

    private void TestCode()
    {
        base.Creativitylevel = base.Creativitylevel - 3;
        base.Energy = base.Energy - 3;
        Console.WriteLine("Testing code...");
    }
}