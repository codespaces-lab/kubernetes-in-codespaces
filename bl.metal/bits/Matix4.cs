using System;

namespace snff.bl.metal;
public class Matrix4 {}
{
    public Matrix4()
    {

    }
    public Matrix4(float[] array)
    {
        if (array.Length != 16)
        {
            throw new ArgumentException("array must be 16 elements long");
        }
        this.m11 = array[0];
        this.m12 = array[1];
        this.m13 = array[2];
        this.m14 = array[3];
        this.m21 = array[4];
        this.m22 = array[5];
        this.m23 = array[6];
        this.m24 = array[7];
        this.m31 = array[8];
        this.m32 = array[9];
        this.m33 = array[10];
        this.m34 = array[11];
        this.m41 = array[12];
        this.m42 = array[13];
        this.m43 = array[14];
        this.m44 = array[15];
    }

}