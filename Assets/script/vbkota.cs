using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbkota : MonoBehaviour
{
    public GameObject Falls;
    public GameObject Covai;
    public GameObject Ooty;
    public GameObject Coonoor;
    public GameObject Kotagiri;
         int i =0;
         int j =0;
        int k =0;
         int l =0;
         int m =0;         
    

    void Start()
    {
       Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);

    }

    public void falls(){


         if (i==0){
       Falls.SetActive(true);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
       i=1;
        j =0;
         k =0;
          l =0;
         m =0;
    }
     else{
         Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
       i=0;
         j =0;
         k =0;
          l =0;
         m =0;
     }

    }

    public void covai(){


         if (j==0){
       Falls.SetActive(false);
       Covai.SetActive(true );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        j=1;
         i =0;
         k =0;
          l =0;
         m =0;
    }
        else{
         Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        i=0;
         j =0;
         k =0;
          l =0;
         m =0;
     }
    }

    public void ooty(){

         if (k==0){
       Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(true);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        k=1;
         j =0;
         i =0;
          l =0;
         m =0;
    }
        else{
         Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        i=0;
         j =0;
         k =0;
          l =0;
         m =0;
     }
    }
    public void coonoor() {

         if (l==0){
      Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(true);
       Kotagiri.SetActive(false);
        l=1;
         j =0;
         k =0;
          i =0;
         m =0;
    }

        else{
         Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        i=0;
         j =0;
         k =0;
          l =0;
         m =0;
     }
    }
    public void kotagiri()
    {
         
         if (m==0){
      Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(true);
        m=1;
         j =0;
         k =0;
          l =0;
         i =0;
    }
        else{
         Falls.SetActive(false);
       Covai.SetActive(false );
       Ooty.SetActive(false);
       Coonoor.SetActive(false);
       Kotagiri.SetActive(false);
        i=0;
         j =0;
         k =0;
          l =0;
         m =0;
       
     }
    }
  

}
