using UnityEngine;

public class LightViewModel
{
    private readonly Color defaultColor; 
    private readonly Color activeColor; 
    
    public string Name { get; }
    public Color Color => IsActive ? activeColor : defaultColor;
    public float DurationSeconds { get; }

    public bool IsActive { get; private set; }

    public LightViewModel(LightSetting settings, Color defaultColor)
    {
        Name = settings.Name;
        this.defaultColor = defaultColor;
        activeColor = settings.Color;
        DurationSeconds = settings.DurationSeconds;
    }

    public void SetActive(bool isVactive)
    {
        IsActive = isVactive;
    }
}