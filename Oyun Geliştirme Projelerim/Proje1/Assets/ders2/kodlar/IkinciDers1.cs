using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IkinciDers1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text helloWorld;
    public Text sayacText;
    public Image sayacresmi;
    public float sayac = 10;
    void Start()
    {
        helloWorld.text = "Merhaba Dünya";
        Debug.Log("oyun baþladý");
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime = geçen zaman
        sayac = sayac - Time.deltaTime;
        if (sayac>0)
        {
            //sayacText.text = sayac.ToString(); //mantýk hatasý var
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
            helloWorld.text = "ders baþlýyor...";
        }
        else if (sayac<=0) {
            sayac = 0;
            sayacresmi.gameObject.SetActive(false);
            sayacText.text = " ";
            helloWorld.text = "ders baþladý";

        }
    }
}
