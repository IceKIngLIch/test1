using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Onclick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshPro _text;
    public void OnPointerClick(PointerEventData eventData)
    {
        
       
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        _text.faceColor= new Color(r, g, b,255);
      
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
