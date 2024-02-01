using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taubetext : MonoBehaviour
{
   public GameObject taubetext;
    void Start()
    {
      taubetext.SetActive(false);  
    }

   public void OnMouseOver()
   {
    taubetext.SetActive(true);
   }
    public void OnMouseExit()
   {
    taubetext.SetActive(false);
   }
}
