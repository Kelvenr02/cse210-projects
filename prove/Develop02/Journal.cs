using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        newEntry._promptText = ""; // Continue from here
        newEntry._entryText = "";""
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFle(string file)
    {

    }
}