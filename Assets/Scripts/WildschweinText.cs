using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildschweinText : MonoBehaviour
{
   public GameObject wildschweintext;
    void Start()
    {
      wildschweintext.SetActive(false);  
    }

   public void OnMouseOver()
   {
    wildschweintext.SetActive(true);
   }
    public void OnMouseExit()
   {
    wildschweintext.SetActive(false);
   }
}
