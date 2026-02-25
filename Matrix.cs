using System;
using System.Data;

public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public int Rows()
    {
        return rows;
    }

    public int Cols()
    {
        return cols;
    }

    public double GetValue(int i, int j)
    {
        return rowData[i].GetValue(j);
    }

    public void SetValue(int i, int j, double value)
    {
        rowData[i].SetValue(j, value);
    }

    public void Display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
}