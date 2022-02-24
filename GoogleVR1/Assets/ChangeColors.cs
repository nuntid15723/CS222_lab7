using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    // Start is called before the first frame update
    public void grtRed(){
        this.GetComponent<Renderer>().material.color = Color.red;
    }

     public void grtBlue(){
        this.GetComponent<Renderer>().material.color = Color.blue;
    }

     public void grtGreen(){
        this.GetComponent<Renderer>().material.color = Color.green;
    }
  
}
