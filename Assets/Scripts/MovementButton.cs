using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButton : MonoBehaviour
{

    PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void derechaOn()
    {
        Player.XMovement(1);
    }

    public void derechaOff()
    {
        Player.XMovement(0);
    }
}
