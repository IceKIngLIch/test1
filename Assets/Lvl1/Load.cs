using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshPro text;
    void Start()
    {
        text.text = Date.Dificalt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
