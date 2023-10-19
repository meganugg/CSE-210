using System;
using System.ComponentModel;

public class Reference{

//ik. So many variables.
    private string _reference;
    private string _begin;
    private string _end;
    private string _finalSripture;
    private string _packagedScripture;
    private string _verse;
    private List<string> _scr = new List<string>();
    private List<string> _verses = new List<string>();
    private string[] _t1;
    private string[] _t2;
    private string[] _words;
    private int _dash;
    private int _colon;
    private int _beginVerse;
    private int _endVerse;
    private int _n;

    public Reference(){
        _reference = "";
        _dash = 0;
        _colon = 0;
        _n = 0;
    }

    public void setReference(string r){
        _reference = r;
        _dash = 0;
        _colon = 0;
        _n = 0;
        _begin = "";
        _end = "";
        _finalSripture = "";
        _packagedScripture = "";
        _verse = "";
        _scr.Clear();
        _verses.Clear();
        _beginVerse = 0;
        _endVerse = 0;

    }

    public bool search(){
        //make sure there's a colon and check for a dash (multiple verses)
        char[] elements = _reference.ToCharArray();
        for(int i = 0; i < elements.Count(); i++){
            if(elements[i].ToString() == "-"){
                _dash++;
            }
            if(elements[i].ToString() == ":"){
                _colon++;
            }
        }
        if(_dash == 0 && _colon == 1){
            foreach(String line in File.ReadLines("bible.txt")){
                if(line.Contains(_reference) == true){
                    return true;
                }
            }
            return false;
        }else if(_dash == 1 && _colon == 1){
            //making sure both verses in the range exist
            _t1 = _reference.Split("-");
            _t2 = _t1[0].Split(":");
            _begin = _t1[0];
            _end = _t2[0] + ":" + _t1[1];
            _beginVerse = int.Parse(_t2[1]);
            _endVerse = int.Parse(_t1[1]);
            foreach(String line1 in File.ReadLines("bible.txt")){
                foreach(String line2 in File.ReadLines("bible.txt")){
                    if(line1.Contains(_begin) == true && line2.Contains(_end) && _beginVerse < _endVerse){
                        return true;
                    }
                }
            }
            return false;
        }else{
            return false;
        }
    }



    public string scripture(){
        if(_dash == 0){
            return convert(_reference);
            //dichotomy of single and multiple verses
        }else if(_dash == 1){
            for(int i = 0; i <= (_endVerse - _beginVerse); i++){
                _n = _beginVerse + i;
                _verse = _t2[0] + ":" + _n;
                _verses.Add(_verse);
            }
            for(int i = 0; i <= (_endVerse - _beginVerse); i++){
                _finalSripture += convert(_verses[i]) + "\n";
            }
            return _finalSripture;
        }
        return "";
    }


    private string convert(string _ref){
        _packagedScripture = "";
        _scr.Clear();
        //could only find a way to do it with an array in between the list and string
            foreach(String line in File.ReadLines("bible.txt")){
                if(line.Contains(_ref) == true){
                    _words = line.Split(" ");
                    for(int i = 0; i < _words.Count(); i++){
                        _scr.Add(_words[i]);
                    }
                    break;
                }
            }
            //getting rid of the reference in front - it shouldn't be a part of what's shipped to "scripture"
            if(_scr[2].Contains(":")){
                _scr.RemoveAt(0);
                _scr.RemoveAt(0);
                _words = _scr[0].Split("\t");
                _scr.RemoveAt(0);
                _scr.Insert(0, _words[1]);
            }else{
                _scr.RemoveAt(0);
                _words = _scr[0].Split("\t");
                _scr.RemoveAt(0);
                _scr.Insert(0, _words[1]);
            }
            
            for(int i = 0; i < _scr.Count(); i++){
                if(i != 0){
                    _packagedScripture += " ";
                }
                _packagedScripture += _scr[i];
            }
            return _packagedScripture;
    }
}