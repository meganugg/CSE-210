class Assignment
{
    private string _topic = "";
    protected string _name = "";

    public string getSummary(){
        return $"{_name} - {_topic}";
    }
    public void setProperties(string name, string topic){
        _topic = topic;
        _name = name;
    }

}