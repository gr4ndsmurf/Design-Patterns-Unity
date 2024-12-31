using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

//Controller for support gems in the UI
public class SupportGemController : MonoBehaviour
{
    [SerializeField] private GemTypeSO gemType;

    private Button button;
    public RectTransform rectTransform;

    public IGem Gem { get; set; } //Property for the gem associated with the controller

    private void Awake()
    {
        button = GetComponent<Button>();
        rectTransform = GetComponent<RectTransform>();

        //Create an instance of the gem associated with the controller using the GemFactory
        Gem = GemFactory.CreateGem(gemType);

        button.onClick.AddListener(() =>
        {
            OnButtonClick();
        });
    }

    //Method called when the support gem button is clicked
    private void OnButtonClick()
    {
        //Check if no support gem is currently selected
        if(GemManager.Instance.SelectedSupportGem == null)
        {
            //Set this support gem as the selected one
            GemManager.Instance.SelectedSupportGem = this;
            Debug.Log("Gem Selected: " + GemManager.Instance.SelectedSupportGem);
        }
        else
        {
            //Decorate the selected support gem with this support gem
            GemManager.Instance.Decorate(this);
            //Reset the selected support gem to null
            GemManager.Instance.SelectedSupportGem = null;
        }
    }

    //Move the support gem to a target position with animation
    public void MoveTo(Vector2 targetPosition)
    {
        float duration = 0.5f;
        rectTransform.DOAnchorPos(targetPosition, duration).SetEase(Ease.InBack).OnComplete(() => 
        {
            Destroy(gameObject);
        });
    }
}
