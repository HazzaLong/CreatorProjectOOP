using System;

public class Youtuber : Creator
{
    public override void Create()
    {
        if (base.Creativitylevel >= 50 & base.Energy >= 50)
        {
            this.BrainstormVideoIdeas();
            this.CreateScript();
            this.VideotapeScript();
            this.EditingVideo();
            this.RenderingVideo();
        }
        else
        {
            throw new Exception("Cannot create a video. Out of videos and/or tiered.");
        }
    }

    private void BrainstormVideoIdeas()
    {
        base.Creativitylevel = base.Creativitylevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Brainstorming video ideas...");
    }

    private void CreateScript()
    {
        base.Creativitylevel = base.Creativitylevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Creating a video script...");
    }

    private void VideotapeScript()
    {
        base.Creativitylevel = base.Creativitylevel - 1;
        base.Energy = base.Energy - 10;
        Console.WriteLine("Videotaping myself executing the script...");
    }

    private void EditingVideo()
    {
        base.Creativitylevel = base.Creativitylevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Editing the video...");
    }

    private void RenderingVideo()
    {
        base.Creativitylevel = base.Creativitylevel - 1;
        base.Energy = base.Energy - 1;
        Console.WriteLine("Rendering the video...");
    }
}