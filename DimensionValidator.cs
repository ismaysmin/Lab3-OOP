public class DimensionValidator
{
    public bool validateMatrixAddition(Matrix A, Matrix B)
    {
        if (A.Rows() == B.Rows() && A.Cols() == B.Cols())
        {
            return true;
        }
        return false;
    }

    public bool validateVectorAddition(Vector A, Vector B)
    {
        if (A.GetSize() == B.GetSize())
        {
            return true;
        }
        return false;
    }
}