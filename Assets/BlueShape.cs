using UnityEngine;

public class BlueShape : Shape
{
    private void Start()
    {
        ShapeName = "Blue Shape";
        ShapeColor = Color.blue;
    }

    public override string GetShapeText()
    {
        return "    This is a blue shape.    It is a cube ";
    }
}
