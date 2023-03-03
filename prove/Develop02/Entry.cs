
class Entry
{
    string date, prompt, response;
    public Entry(string _date, string _prompt, string _resonse)
    {

    }
    public void DisplayEntry()
    {

    }
    public string getEntryAsCVS()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
        
    }
}