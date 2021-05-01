using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    float movePower = 1f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 movePosition = Vector3.zero;
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            movePosition = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            movePosition = Vector3.right;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            movePosition = Vector3.up;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            movePosition = Vector3.down;
        }

        transform.position += movePosition * movePower * Time.deltaTime;
    }

    public int SquareTest(int a, int b)
    {
        return a + b;
    }
}
