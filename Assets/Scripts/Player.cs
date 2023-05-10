using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    public float Hiz = 5.0f;
    void Update()
    {
        //W-A-S-D ya Yön tuşlarına basılırsa yatay adlı değişkene eksene göre değer verir.
        float yatay = Input.GetAxis("Horizontal") * Time.deltaTime * Hiz;

        enemy.transform.Translate(new Vector3(yatay, 0, 0)); // Y eksenini değiştir.

       /* if (Input.GetKeyDown(KeyCode.Space)) //Eğer Boşluk tuşuna basılırsa.
        {
            if (yerdeMi) //yerDemi değişkeni True ise içerisini gerçekleştir.
            {

                rb.AddForce(new Vector3(0, ziplamaGucu, 0), ForceMode.Impulse);
            }
        }*/

    }
}
