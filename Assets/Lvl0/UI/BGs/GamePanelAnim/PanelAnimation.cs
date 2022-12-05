using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelAnimation : MonoBehaviour// , IPointerClickHandler
{
    [SerializeField] private Animator _panelAnimator ;

   // public void OnPointerClick(PointerEventData eventData)
   // {
   //   _panelAnimator.SetTrigger("Show");
   // }
    public void Hide()
    {
        //if (_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime)
            _panelAnimator.SetTrigger("Hide");
    }
    public void Show()
    {
        //if (_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime || _panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Default"))
           _panelAnimator.SetTrigger("Show");
    }
    public void OnClickAnim()
    {
        if (_panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Default") || _panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.HideAnim"))
        {
            if(_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime || _panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Default"))
            Show();
        }
        if (_panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.ShowAnim"))
        {
            if (_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime)
            Hide();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
