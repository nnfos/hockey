using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    private void Update()
    {
        if (hasAuthority)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            
            float speed = 5f * Time.deltaTime;

            transform.Translate(new Vector2(horizontal * speed, vertical * speed));
        }
    }
}
