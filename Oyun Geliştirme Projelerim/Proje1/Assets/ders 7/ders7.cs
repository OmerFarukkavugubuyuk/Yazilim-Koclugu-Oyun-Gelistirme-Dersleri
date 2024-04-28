using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ders7 : MonoBehaviour
{
    public Transform küp, top, silindir;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            küp.DOMove(new Vector3(4,3,5),1f);
            top.DOScale(3, 1f);
            silindir.DORotate(new Vector3(0, 0, 180), 2f).OnComplete(() => 
            {
                
            
            
            });
        }
    }
}
