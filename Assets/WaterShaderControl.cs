using UnityEngine;

public class WaterShaderControl : MonoBehaviour
{
    // Reference to the material with the water shader
    public Material waterMaterial;

    // The name of the exposed shader property for wave height (ensure this matches the name in your shader)
    public string waveHeightProperty = "_WaveHeight";  // Adjust this if your property name differs

    // Variables to control wave height
    public float waveHeightSpeed = 0.5f;  // Speed of the wave height oscillation
    public float maxWaveHeight = 1.5f;  // Maximum wave height
    public float minWaveHeight = 0.2f;  // Minimum wave height

    // Update is called once per frame
    void Update()
    {
        // Calculate the wave height based on a sine wave to make it oscillate
        float waveHeight = Mathf.PingPong(Time.time * waveHeightSpeed, maxWaveHeight - minWaveHeight) + minWaveHeight;

        // Set the wave height property in the shader
        if (waterMaterial != null)
        {
            waterMaterial.SetFloat(waveHeightProperty, waveHeight);
        }
    }
}
