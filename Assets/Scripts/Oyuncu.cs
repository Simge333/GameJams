using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{
    public float harekethizi = 3;
    [HideInInspector] public Vector3 yon;
    float xInput, yInput;
    CharacterController controller;
    float speed = 0.2f;
    bool isMove = false;
    // Start is called before the first frame update
    void Start()
    {
        controller= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region Yön kendii yazýðým
    
    private void FixedUpdate()
    {
        isMove = false;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f,0f,speed));
            isMove = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, 0f, -speed));
            isMove = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0f,0f));
            isMove = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0f, 0f));
            isMove = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0f,speed,0f));
            isMove = true; 
        }
    }
    #endregion
	#region Hareket
     
	#endregion
}
