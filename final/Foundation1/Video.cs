using System;

class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comment = new List<Comment>();
    public Video(string t, string a, int l){
        title = t;
        author = a;
        length = l;
    }
    public void AddComment(string n, string x){
        Comment c = new Comment(n, x);
        comment.Add(c);
    }
    public string GetVideo(){
        string temp = $"{title}, {author} ({length/60}:{length%60})\nnumber of comments: {comment.Count()}";
        for(int i = 0; i < comment.Count(); i++){
            temp = temp + $"\n\t{comment[i].GetName()}: {comment[i].GetText()}";
        }
        return temp;
    }
}