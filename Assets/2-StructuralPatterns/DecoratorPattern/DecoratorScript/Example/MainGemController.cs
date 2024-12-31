using System;
using UnityEngine;
using UnityEngine.UI;

//Controller for the main gem button in the UI
public class MainGemController : MonoBehaviour
{
    //Trigger an event when the main gem button is clicked
    public static Action OnMainGemClicked;

    private Button button;
    private RectTransform rectTransform;

    private void Awake() 
    {
        button = GetComponent<Button>();
        rectTransform = GetComponent<RectTransform>();

        button.onClick.AddListener(() =>
        {
            OnMainButtonClick();
        });  
    }

    //Method called when the main gem button is clicked
    private void OnMainButtonClick()
    {
        //Check if a support is selected
        if(GemManager.Instance.SelectedSupportGem != null)
        {
            GemManager.Instance.SelectedSupportGem.MoveTo(rectTransform.anchoredPosition);
            // Use the gem associated with the selected support gem
            GemManager.Instance.SelectedSupportGem.Gem.UseGem();

            OnMainGemClicked?.Invoke();
            // TODO: AUDIO OR SOME VISUAL EFFECTS
        }
        else
        {
            OnMainGemClicked?.Invoke();
            Debug.Log("Galvanic Arrow Gem used without any other Potions.");
        }
    }
}
