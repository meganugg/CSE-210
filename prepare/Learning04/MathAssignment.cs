class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public void setHomeWorkList(string section, string problems){
        _textBookSection = section;
        _problems = problems;
    }

    public string getHomeWorkList(){
        return $"Section {_textBookSection}, problems {_problems}";
    }
}