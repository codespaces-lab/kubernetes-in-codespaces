namespace snff.bl.metal

using System;
using System.Numerics;

public class SimpleMove : IMove
{
    public static SimpleMove New()
    {
        return new SimpleMove();
    }

    private SimpleMove()
    {

    }

    public Matrix4x4 Move(Matrix4x4 move_matrix)
    {
        

        return move_matrix;
    }
}
