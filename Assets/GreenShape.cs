using UnityEngine;

public class GreenShape : Shape
{
    private void Start()
    {
        ShapeName = "Green Shape";
        ShapeColor = Color.green;
    }

    public override string GetShapeText()
    {
        return "   This is a green shape.  It is a capsule";
    }
}
