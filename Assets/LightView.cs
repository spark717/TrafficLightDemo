using UnityEngine;
using UnityEngine.UI;

public class LightView : MonoBehaviour
{
    [SerializeField] private Text nameText = default;
    [SerializeField] private Image image = default;

    private LightViewModel viewModel;
    
    public void SetViewModel(LightViewModel viewModel)
    {
        this.viewModel = viewModel;
    }

    public void InitialRefresh()
    {
        nameText.text = viewModel.Name;
        
        Refresh();
    }
    
    public void Refresh()
    {
        if (image.color != viewModel.Color)
        {
            image.color = viewModel.Color;
        }
    }
}