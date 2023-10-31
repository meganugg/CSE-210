using System;

class Activity
{
    protected string startingMessage;
    protected string finishingMessage;
    protected string description;
    protected string prompt;
    protected int duration;

    public void setDuration(int d){
        duration = d;
    }
}