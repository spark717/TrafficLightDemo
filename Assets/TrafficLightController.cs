using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    [SerializeField] private TrafficLightsSettings settings = default;
    [SerializeField] private TrafficLightsView trafficLightsView = default;

    private TrafficLightsViewModel trafficLightsViewModel;
    
    private void Awake()
    {
        trafficLightsViewModel = new TrafficLightsViewModel(settings);
        trafficLightsViewModel.Init();
        
        trafficLightsView.SetViewModel(trafficLightsViewModel);
        trafficLightsView.Init();
    }

    private void Update()
    {
        if (trafficLightsViewModel.TryActivateNextLight())
        {
            trafficLightsView.Refresh();
        }
    }
}
