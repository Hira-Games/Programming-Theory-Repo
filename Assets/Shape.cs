using UnityEngine;

public class Shape : MonoBehaviour
{
    // Encapsulated properties with getters and setters
    private string shapeName;
    private Color shapeColor;

    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }

    public Color ShapeColor
    {
        get { return shapeColor; }
        set { shapeColor = value; }
    }

    // Virtual method to be overridden in derived classes
    public virtual string GetShapeText()
    {
        return "This is a shape.";
    }
}
