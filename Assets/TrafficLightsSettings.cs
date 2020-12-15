using System.Collections.Generic;
using UnityEngine;

public class TrafficLightsSettings : ScriptableObject
{
    [SerializeField] private Color defaultColor = default;
    [SerializeField] private List<LightSetting> lights = default;

    public Color DefaultColor => defaultColor;
    public List<LightSetting> Lights => lights;
}