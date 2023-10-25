class WritingAssignment : Assignment
{
    private string _title = "";

    public void setTitle(string title){
        _title = title;
    }
    
    public string getWritingInformation(){
        return $"{_title} by {_name}";
    }
    
}