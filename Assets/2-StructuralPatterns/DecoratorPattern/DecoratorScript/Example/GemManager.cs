using UnityEngine;

// Managing gem functionalities
public class GemManager : SingletonDestroyMono<GemManager>
{
    public SupportGemController SelectedSupportGem;

    //Decorate the gem
    public void Decorate(SupportGemController clickedSupportGem)
    {
        if(SelectedSupportGem == clickedSupportGem) { return; }
        
        // Check if the selected gem is already a decorator
        if(SelectedSupportGem.Gem is GemDecorator decorator)
        {
            Debug.Log("Decorating Gems...");
            decorator.Decorate(clickedSupportGem.Gem);
            clickedSupportGem.Gem = decorator;

            SelectedSupportGem.MoveTo(clickedSupportGem.rectTransform.anchoredPosition);
            // TODO: AUDIO OR SOME VISUAL EFFECTS
        }
        else
        {
            Debug.LogWarning("Can't Decorate Gems!");
        }
    }
}
