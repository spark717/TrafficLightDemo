using System.Collections.Generic;
using UnityEngine;

public class TrafficLightsView : MonoBehaviour
{
    [SerializeField] private Transform lightsContainer = default;
    [SerializeField] private LightView lightPrefab = default;

    private List<LightView> lightViews;
    
    private TrafficLightsViewModel viewModel;
    
    public void SetViewModel(TrafficLightsViewModel viewModel)
    {
        this.viewModel = viewModel;
    }

    public void Init()
    {
        lightViews = new List<LightView>(viewModel.Lights.Count);

        foreach (var lightViewModel in viewModel.Lights)
        {
            var lightView = Instantiate(lightPrefab, lightsContainer);
            lightView.SetViewModel(lightViewModel);
            lightView.InitialRefresh();
            lightViews.Add(lightView);
        }
    }
    
    public void Refresh()
    {
        foreach (var lightView in lightViews)
        {
            lightView.Refresh();
        }
    }
}