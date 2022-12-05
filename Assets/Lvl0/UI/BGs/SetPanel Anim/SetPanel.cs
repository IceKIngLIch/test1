using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPanel : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollBar;
    [SerializeField] private ScrollRect _scrollRect;
    [SerializeField] private Animator _panelAnimator;
    // Start is called before the first frame update
    void Start()
    {
        _scrollBar.interactable = false;
        _scrollBar.transform.localScale = new Vector3(0, 0, 0);
        _scrollRect.enabled = false;
    }

    private void OffHideScrollBar()
    {
        _scrollBar.interactable= false;
        _scrollBar.transform.localScale = new Vector3(0, 0, 0);
        _scrollRect.enabled = false;
    }
    private void OnShowScrollBar()
    {
        _scrollBar.interactable = true;
        _scrollBar.transform.localScale = new Vector3(1, 1, 1);
        _scrollRect.enabled = true;
    }
    private void Hide()
    {
        _panelAnimator.SetTrigger("Hide");
    }
    private void Show()
    {
        _panelAnimator.SetTrigger("Show");
    }
    public void OnClickAnim()
    {
        if (_panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Default") || _panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.HideAnim"))
        {
            if (_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime || _panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Default"))
            {
                Show();
                OnShowScrollBar();
            }
        }
        if (_panelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.ShowAnim"))
        {
            if (_panelAnimator.GetCurrentAnimatorStateInfo(0).length < _panelAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime)
            {
                Hide();
                OffHideScrollBar();
            }
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
