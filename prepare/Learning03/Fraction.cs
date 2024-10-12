using System;

public class Fraction
{
    private int top;
    private int bottom;

    // Default constructor
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int top)
    {
        this.top = top;
        this.bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getter and Setter for Top
    public int GetTop() => top;
    public void SetTop(int value) => top = value;

    // Getter and Setter for Bottom
    public int GetBottom() => bottom;
    public void SetBottom(int value) => bottom = value;

    // Method to return the fraction as a string
    public string GetFractionString() => $"{top}/{bottom}";

    // Method to return the decimal value
    public double GetDecimalValue() => (double)top / bottom;
}