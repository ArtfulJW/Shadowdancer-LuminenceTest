using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCalculator : MonoBehaviour
{

    [SerializeField]
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(Mathf.InverseLerp(0,1, calculateBrightness(light, other.transform.position)));
        }
    }

    /*
     * Calculates the Brightness of a position as lit by a light.
     * Parameters:
     * Luminence
     * Distance (from Light)
     * 
     * Returns: Brightness of GivenPosition, lit by givenLight
     */
    public float calculateBrightness(Light givenLight, Vector3 PlayerPosition)
    {
        return (givenLight.intensity / (4 * Mathf.PI * Mathf.Pow(calcDistFromLight(givenLight.transform.position, PlayerPosition), 2)));
    }

    /*
     * Calculates the distance from 2 points in space.
     * Parameters:
     * 1. Light 
     * 2. Given Position (Vector3)
     * 
     * Returns:
     * Float: Distance between the Given Position (Vector3) to the Light.
     */
    public float calcDistFromLight(Vector3 LightPosition, Vector3 GivenPosition)
    {
        return (Vector3.Distance(GivenPosition, LightPosition)/light.range);
    }

}
