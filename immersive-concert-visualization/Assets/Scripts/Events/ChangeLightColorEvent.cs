// allows Event knows how to find a light and change its color
using UnityEngine;

// base class (TimelineEvent) defines execution method
    // ChangeLightColorEvent inherits from base class and overrides the method
public class ChangeLightColorEvent : TimelineEvent 
{
    [SerializeField] private Light targetLight; // reference to the target light object
    [SerializeField] private Color targetColor; // the color to change the light to

    public ChangeLightColorEvent(Light light, Color color)
    {
        targetLight = light;
        targetColor = color;
    } 

    public override void Execute()
    {
        if (targetLight != null)
        {
            targetLight.color = targetColor; // change the light's color
        }
        else
        {
            Debug.LogWarning("ChangeLightColorEvent: Target light is null.");
        }
    }
}