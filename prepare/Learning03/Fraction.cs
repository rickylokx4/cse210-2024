using System;
public class Fraction
{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }
    public Fraction(int top, int botton)
    {
        _top = top;
        _botton = botton;
    }
    public string GetFractionString()
    {
        return _top+"/"+_botton;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
    }

}
