using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirkeText : MonoBehaviour
{
   public GameObject birketext;
    void Start()
    {
      birketext.SetActive(false);  
    }

   public void OnMouseOver()
   {
    birketext.SetActive(true);
   }
    public void OnMouseExit()
   {
    birketext.SetActive(false);
   }
}
