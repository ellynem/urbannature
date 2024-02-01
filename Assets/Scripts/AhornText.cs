using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AhornText : MonoBehaviour
{
   public GameObject ahorntext;
    void Start()
    {
      ahorntext.SetActive(false);  
    }

   public void OnMouseOver()
   {
    ahorntext.SetActive(true);
   }
    public void OnMouseExit()
   {
    ahorntext.SetActive(false);
   }
}
