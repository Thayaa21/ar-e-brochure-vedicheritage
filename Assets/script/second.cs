using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second : MonoBehaviour
{
    public GameObject Herbal;
    public GameObject Museum;
    public GameObject Games;
    public GameObject baba;
    public GameObject global;
    public GameObject yoga;
    public GameObject veda;
    public GameObject path;

    

    void Start()
    {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);

    }

    public void herbal(){
       Herbal.SetActive(true);
       Museum.SetActive(false);
       Games.SetActive(false); 
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);
    }

    public void museum(){
       Herbal.SetActive(false);
       Museum.SetActive(true);
       Games.SetActive(false); 
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);
    }

    public void games(){
       Herbal.SetActive(false);
       Museum.SetActive(false);
       Games.SetActive(true); 
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);
    }
    public void Baba() {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(true);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);

    }
    public void Global()
    {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(true);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);

    }
    public void Yoga()
    {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(true);
       veda.SetActive(false);
       path.SetActive(false);

    }

    public void Veda()
    {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(true);
       path.SetActive(false);

    }
    public void Path()
    {
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(true);

    }

    public void stopt(){
      
       Herbal.SetActive(false);
       Museum.SetActive(false );
       Games.SetActive(false);
       baba.SetActive(false);
       global.SetActive(false);
       yoga.SetActive(false);
       veda.SetActive(false);
       path.SetActive(false);
    }



    
}
