using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Reference to the TextMeshPro component

    // Method to update the text on the screen
    public void UpdateText(string text)
    {
        displayText.text = text;
    }
}
