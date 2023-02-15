using System;

public class Lectures : Event
{
    private string _speaker;
    private string _capacity;
        

    public Lectures(string title, string description, string date, string time, string address, string type, string capacity) : base (title, description, date, time, address, type)
    {
        //_speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeakerName(string speaker)
    {
        _speaker = speaker;
    }
    public string GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }
    public void DisplayLectureCompleteDetails()
    {
        DisplayCompleteDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}