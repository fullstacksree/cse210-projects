using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Hotel Park", "Beach Road", "Visakhapatnam", "530017", "Andhra Pradesh", "India");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Digital Marketing", "Conference on Digital Marketing in 2023", "February 24, 2023", "04:00 PM to 06:00 PM", $"{lectureAddress}", "Lecture", "Mr Digital Deepak");
        
        Console.WriteLine("___________________________");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureCompleteDetails();

        Address address2 = new Address ("Dine-In", "Lawsons Bay Colony, Beach Road", "Visakhapatnam", "530017", "Andhra Pradesh", "India");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Master Akhil", "Master Akhil's Birthday Party", "February 28, 2023", "06:00 PM to 10:00 PM", $"{receptionAddress}", "Reception", "Full Moon");

        Console.WriteLine("___________________________");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceiptionCompleteDetails();

        Address address3 = new Address ("Waltair Club", "Near Siripuram Junction", "Visakhapatnam", "530017", "Andhra Pradesh", "India");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Romeo and Juliet", "Romeo weds Juliet Wedding Ceremony", "MArch 1, 2023", "06:00 AM to 07:00 PM", $"{outdoorAddress}", "Outdoor", "Sunny");

        Console.WriteLine("___________________________");
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorCompleteDetails();

    }
}