using System;

public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator()
    {
        validator = new DimensionValidator();
    }

    public Vector add(Vector A, Vector B)
    {
        if (validator.validateVectorAddition(A, B))
        {
            int size = A.GetSize();
            Vector result = new Vector(size);

            for (int i = 0; i < size; i++)
            {
                double sum = A.GetValue(i) + B.GetValue(i);
                result.SetValue(i, sum);
            }
            return result;
        }
        return null;
    }
}