using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objehavuzu : MonoBehaviour
{

    //ENQUEUE BAÞA DEQUEUE SONA DEMEK
    public Queue <GameObject> mermiler = new Queue <GameObject>();
    public GameObject mermi;
    public int mermiSayisi;

    public Text mermiText;

    public static objehavuzu Instance;

    #region singleton

    
    private void Awake()
    {
        if (Instance == null) 
        {
        Instance = this;
            DontDestroyOnLoad (this);
        }
        else
        {
            Destroy (gameObject);
        }
    }
#endregion
    void Start()
    {
        
        mermiUret();
    }

    // Update is called once per frame
    void Update()
    {
        mermiText.text ="Kuyruktaki top sayýsý= "+mermiler.Count.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            GameObject yenimermi = mermiler.Dequeue();
            yenimermi.SetActive(true);
        }
    }
    void mermiUret() 
    {
        for (int i = 0; i < mermiSayisi; i++)
        {
        
            GameObject mermikopya = Instantiate(mermi);
            mermi.SetActive(false);
            mermiler.Enqueue(mermikopya);
        }
    }
}
