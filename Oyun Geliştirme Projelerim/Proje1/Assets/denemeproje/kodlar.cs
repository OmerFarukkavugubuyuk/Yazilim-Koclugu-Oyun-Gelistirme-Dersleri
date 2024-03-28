using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kodlar : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// saçma sapan biþey oldu baþlamadan tekrar bak
    /// 
    /// </summary>

    public double hýz;
   
    public GameObject kamera;
    public GameObject arac;

    public Rigidbody fiziksistemi;

    Vector3 eksen;
    Vector3 eksenarac;
                   

    void Start()
    {
        eksen=kamera.transform.position;

        eksenarac = arac.transform.position;

        


    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        ileri();
        saga();
        sola();
        geri();
        Vector3 eksenaracc = transform.forward * moveVertical * 5f;
        //hareket();
    }



    void geri() {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            
        }
    }
    

    void sola()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            fiziksistemi.AddForce(Vector3.left*2);
        
        }

    }
    void saga()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            fiziksistemi.AddForce(Vector3.right*2);
        }

    }


    void ileri() { 
    
        if (Input.GetKey(KeyCode.UpArrow))
        {
            

            
        }
    }

}
