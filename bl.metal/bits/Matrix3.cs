namespace snff.bl.metal
using System;

public record Matrix3
{
    public double[,] Values { get; set; } = new double[3, 3];

    public Matrix3()
    {
        Values[2, 2] = 1;
    }

    public Matrix3(double[,] values)
    {
        Values = values;
    }

    public Matrix3(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3)
    {
        Values[0, 0] = a1;
        Values[0, 1] = a2;
        Values[0, 2] = a3;
        Values[1, 0] = b1;
        Values[1, 1] = b2;
        Values[1, 2] = b3;
        Values[2, 0] = c1;
        Values[2, 1] = c2;
        Values[2, 2] = c3;
    }

    public static Matrix3 operator *(Matrix3 a, Matrix3 b)
    {
        throw new NotImplementedException();
    }