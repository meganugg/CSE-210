using System;
using System.Runtime.CompilerServices;

public class Fraction{
    private int _numerator;
    private int _denominator;
    public Fraction(){
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int nd){
        _numerator = 5;
        _denominator = 1;
    }
    public Fraction(int n, int d){
        _numerator = n;
        _denominator = d;
    }

    public String getFractionString(){
        return ($"{_numerator.ToString()}/{_denominator.ToString()}");
    }

    public double getFractionDecimal(){
        double n = Convert.ToDouble(_numerator);
        double d = Convert.ToDouble(_denominator);
        return n/d;
    }
}