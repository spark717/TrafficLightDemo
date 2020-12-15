using System.Collections.Generic;
using UnityEngine;

public class TrafficLightsViewModel
{
    private int currentLightIndex;
    private float currentLightShowTimestamp;
    
    public List<LightViewModel> Lights { get; }
    public LightViewModel CurrentLight => Lights[currentLightIndex];
    
    public TrafficLightsViewModel(TrafficLightsSettings settings)
    {
        Lights = new List<LightViewModel>(settings.Lights.Count);
        
        foreach (var lightSettings in settings.Lights)
        {
            var lightModel = new LightViewModel(lightSettings, settings.DefaultColor);
            Lights.Add(lightModel);
        }
    }

    public void Init()
    {
        currentLightShowTimestamp = Time.time;
        CurrentLight.SetActive(true);
    }
    
    public bool TryActivateNextLight()
    {
        bool needChange = Time.time - currentLightShowTimestamp > CurrentLight.DurationSeconds;

        if (!needChange)
        {
            return false;
        }
        
        CurrentLight.SetActive(false);
        
        currentLightIndex++;

        if (currentLightIndex >= Lights.Count)
        {
            currentLightIndex = 0;
        }

        CurrentLight.SetActive(true);

        currentLightShowTimestamp = Time.time;

        return true;
    }
}
