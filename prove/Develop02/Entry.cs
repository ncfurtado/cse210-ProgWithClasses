class Entry
{
    public override string ToString()
    {
        string outputString = "";
        string _date = GetDate();
        string _entryQuestion = EntryQuestion();
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        return outputString;

    }
    public void DisplayEntry(string Journal)
    {

    }
    public string GetDate()
    {
        string _date = "";
        return _date;
    }
    public string EntryQuestion();
    {

    }
}