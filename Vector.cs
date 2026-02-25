using System;

public class Vector
{
    private int size;
    private double[] data;

    public Vector(int size)
    {
        this.size = size;
        this.data = new double[size];
    }

    public int GetSize()
    {
        return size;
    }

    public double GetValue(int i)
    {
        return data[i];
    }

    public void SetValue(int i, double value)
    {
        data[i] = value;
    }

    public void display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }
}