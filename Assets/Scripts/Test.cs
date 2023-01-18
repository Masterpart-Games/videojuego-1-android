using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("buttom pressed");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("buttom is pressed");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("buttom released");
        }

        //Getting keyboard button events
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You can use this to jump");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump");
        }

        //Geting Axis for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal < 0f || horizontal >0f)
        {
            Debug.Log("Horizontal axis is " + horizontal);

        }
        if (vertical < 0f || vertical > 0f)
        {
            Debug.Log("Vertical axis is " + vertical);
        }
    }
}
