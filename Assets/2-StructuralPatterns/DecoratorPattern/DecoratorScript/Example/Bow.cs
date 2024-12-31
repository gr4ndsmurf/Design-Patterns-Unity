using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField] private Animator bowAnimator;

    //Subscribe to the event
    private void Start() 
    {
        MainGemController.OnMainGemClicked += MainGemController_OnMainGemClicked;    
    }

    //Play an animation and create a particle when the event is triggered
    private void MainGemController_OnMainGemClicked()
    {
        bowAnimator.SetTrigger("GemClicked");
        // TODO: AUDIO OR PARTICLE
    }
}
