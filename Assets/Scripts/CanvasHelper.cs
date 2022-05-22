using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHelper : MonoBehaviour
{
    public Canvas Canvas1;
    public Canvas Canvas2;
   public void LoadCanvasClick() {

          Canvas1.gameObject.SetActive(true);
 
            Canvas2.gameObject.SetActive(false);
           
     
}
}
