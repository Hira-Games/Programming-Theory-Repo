using UnityEngine;

public class RedShape : Shape
{
    private void Start()
    {
        ShapeName = "Red Shape";
        ShapeColor = Color.red;
    }

    public override string GetShapeText()
    {
        return "    This is a red shape.    It is a sphere";
    }
}
