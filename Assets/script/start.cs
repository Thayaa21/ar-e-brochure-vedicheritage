using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public GameObject Plane;
    public GameObject Vid;
    public Text ButtonText;
    int i =0;

    public void Start()
    {
      Vid.SetActive(false);
      Plane.SetActive(false);  
    }
    public void str(){
        ButtonText.text = "Start";
     }
    public void stp(){
        ButtonText.text="Stop";
    }



    public void on()
    {
        if (i==0){
        Vid.SetActive(true);
      Plane.SetActive(true);
      i=i+1;
      stp(); 
        }
        else{
        Vid.SetActive(false);
      Plane.SetActive(false);
      i=i-1;
      str();  
        }
    }
    public void off()
    {
     Vid.SetActive(false);
      Plane.SetActive(false);
      if (i==1){
      i=i-1;
      str();  
      }
}
}
