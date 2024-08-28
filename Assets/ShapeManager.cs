using UnityEngine;
using TMPro;

public class ShapeManager : MonoBehaviour
{
    public UIManager uiManager; // Reference to the UIManager

    void Update()
    {
        // Check for mouse input
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Perform a raycast to detect clicks on shapes
            if (Physics.Raycast(ray, out hit))
            {
                Shape shape = hit.transform.GetComponent<Shape>();

                if (shape != null)
                {
                    // Update the UI text based on the shape clicked
                    uiManager.UpdateText(shape.GetShapeText());
                }
            }
        }
    }
}
