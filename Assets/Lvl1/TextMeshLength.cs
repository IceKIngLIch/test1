using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshLength : MonoBehaviour
{
    [SerializeField] private TextMeshPro MyTMP;
    private BoxCollider MyTMPCollider;
    // Start is called before the first frame update
    void Start()
    {
        MyTMPCollider = MyTMP.GetComponent<BoxCollider>();
        MyTMP.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MyTMP.text.Length * 2f); 
        MyTMPCollider.size =  MyTMP.rectTransform.rect.size;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MyTMP.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MyTMP.text.Length * 2f);
        MyTMPCollider.size = MyTMP.rectTransform.rect.size;
        
    }
}
