using UnityEngine;

public class HueLoop : MonoBehaviour
{
    public Material skyboxMaterial; // Assign the skybox material here
    public float hueSpeed = 1.0f;   // Speed of hue change

    private float hue = 0;

    void Update()
    {
        // Increment hue based on time and speed
        hue += hueSpeed * Time.deltaTime;

        // Keep hue between 0 and 1
        hue = Mathf.Repeat(hue, 1f);

        // Convert hue to RGB (Saturation and Value remain 1 for full color)
        Color color = Color.HSVToRGB(hue, 1, 1);

        // Apply the color to the Tint property of the skybox material
        skyboxMaterial.SetColor("_Tint", color);
    }
}
