using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermihareket : MonoBehaviour
{

    public int harekethizi;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * harekethizi * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            //OBJE HAVUZUNA ERÝÞ ORADAKÝ KUYRUK YAPISINA BU OBJEYÝ EKLE

            objehavuzu.Instance.mermiler.Enqueue(gameObject);
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }
    }
}
