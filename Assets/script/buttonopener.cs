using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonopener : MonoBehaviour
{
   
   public GameObject bhk2b1;
    public GameObject bhk2b0;
     public GameObject bhk3b1;
    public GameObject bhk3b0;

    void Start()
    {
      bhk2b1.SetActive(false);
      bhk2b0.SetActive(false);
      bhk3b1.SetActive(false);
      bhk3b0.SetActive(false);


    }

   
    public void open2bhk()
    {
        bhk2b1.SetActive(true);
      bhk2b0.SetActive(true);
       bhk3b1.SetActive(false);
      bhk3b0.SetActive(false);

    }

     public void open3bhk()
    {
        bhk2b1.SetActive(false);
      bhk2b0.SetActive(false);
       bhk3b1.SetActive(true);
      bhk3b0.SetActive(true);

    }

  
}


