public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator()
    {
        validator = new DimensionValidator();
    }

    public Matrix add(Matrix A, Matrix B)
    {
        if (validator.validateMatrixAddition(A, B))
        {
            int rows = A.Rows(); 
            int cols = A.Cols();
            Matrix result = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double sum = A.GetValue(i, j) + B.GetValue(i, j);
                    result.SetValue(i, j, sum);
                }
            }
            return result;
        }
        return null; 
    }
}