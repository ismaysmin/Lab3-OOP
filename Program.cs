using System;

class Program
{
    static void Main()
    {
        InputHandler input = new InputHandler();
        MatrixCalculator matrixCalc = new MatrixCalculator();
        VectorCalculator vectorCalc = new VectorCalculator();

        Console.WriteLine("--- MATRIX ADDITION ---");
        Console.WriteLine("Input Matrix A:");
        Matrix A = input.inputMatrix(); 

        Console.WriteLine("\nInput Matrix B:");
        Matrix B = input.inputMatrix();

        Matrix resultMatrix = matrixCalc.add(A, B);

        if (resultMatrix != null)
        {
            Console.WriteLine("\nResult Matrix:");
            resultMatrix.Display(); 
        }
        else
        {
            Console.WriteLine("\nMatrix addition failed: Incompatible dimensions.");
        }

        Console.WriteLine("\n--- VECTOR ADDITION ---");
        Console.WriteLine("Input Vector A:");
        Vector vA = input.inputVector();

        Console.WriteLine("\nInput Vector B:");
        Vector vB = input.inputVector();

        Vector resultVector = vectorCalc.add(vA, vB);

        if (resultVector != null)
        {
            Console.WriteLine("\nResult Vector:");
            resultVector.display(); 
        }
        else
        {
            Console.WriteLine("\nVector addition failed: Incompatible dimensions.");
        }
    }
}