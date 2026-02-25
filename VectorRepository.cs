using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors;

    public VectorRepository()
    {
        vectors = new List<Vector>();
    }

    public void addVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector getVector(int index)
    {
        if (index >= 0 && index < vectors.Count)
        {
            return vectors[index];
        }
        return null;
    }
}