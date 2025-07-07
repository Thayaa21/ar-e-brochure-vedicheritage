using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
    public GameObject bhk2first;
    public GameObject bhk2ground;
    public GameObject bhk3first;
    public GameObject bhk3ground;

    void Start()
    {
      bhk2first.SetActive(false);
      bhk2ground.SetActive(false);

    }

    // Update is called once per frame
    public void first()
    {
         bhk2first.SetActive(true);
      bhk2ground.SetActive(false);
    }

    public void ground(){
          bhk2first.SetActive(false);
      bhk2ground.SetActive(true);
    }

    public void closeall(){
         bhk2first.SetActive(false);
      bhk2ground.SetActive(false);
    }
}
