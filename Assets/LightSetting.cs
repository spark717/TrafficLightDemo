using System;
using UnityEngine;

[Serializable]
public class LightSetting
{
    [SerializeField] private string name = default;
    [SerializeField] private float durationSeconds = 1f;
    [SerializeField] private Color color = default;
    
    public string Name => name;
    public float DurationSeconds => durationSeconds;
    public Color Color => color;
}
