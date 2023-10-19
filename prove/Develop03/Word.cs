using System;
using System.Globalization;

public class Word{
    Random r = new Random();
    private bool _exit;
    private int _index;
    private string _scr;
    private string _blank;
    private string[] _elements;
    private List<string> _words = new List<string>();
    public Word(){
        _scr = "";
    }

    public string setScripture(string s){
        //sets scripture to itself minus three words
        _scr = "";
        _words.Clear();
        _elements = s.Split(" ");
        for(int i = 0; i < _elements.Count(); i++){
            _words.Add(_elements[i]);
        }
        //replace one word with blank of same length, three times
        for(int i = 0; i < 3; i++){
            _blank = "";
            _exit = false;
            _index = r.Next(0, _words.Count());
            while(_words[_index].Contains("_")){
                _index = r.Next(0, _words.Count());
                if(empty() == true){
                break;
            }
            }
            for(int j = 0; j < _words[_index].Length; j++){
                _blank += "_";
            }
            _words.RemoveAt(_index);
            _words.Insert(_index, _blank);
            if(empty() == true){
                break;
            }
        }
        for(int i = 0; i < _words.Count(); i++){
            if(i != 0){
                _scr += " ";
            }
            _scr += _words[i];
        }
        return _scr;
    }

    public bool empty(){
        for(int i = 0; i < _words.Count(); i++){
            if(_words[i].Contains("_") != true){
                return false;
            }
        }
        return true;
    }
}