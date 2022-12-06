using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CheckToggle : MonoBehaviour
{ 
    [SerializeField] ToggleGroup DificaltToggleGroup;
    public void ToggleChanged()
    {       
        Text txt = DificaltToggleGroup.GetFirstActiveToggle().transform.Find("Label").GetComponent<Text>();        
        Date.Dificalt = txt.text;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
/*public static class Date 
{
    // Start is called before the first frame update
    public static string Dificalt = "Easy";
    public static ToggleGroup DificaltGroup;

    public static void ChangeDificalt(ToggleGroup DificaltGroup)
    {
        string str = DificaltGroup.GetFirstActiveToggle().GetComponent<Text>().ToString();
    }
}*/
