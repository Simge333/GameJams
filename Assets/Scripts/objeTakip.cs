using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeTakip : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField]
    GameObject oyuncu;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - oyuncu.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
       transform.position=oyuncu.transform.position + fark+ new Vector3(-1,4,-1);
    }
}
