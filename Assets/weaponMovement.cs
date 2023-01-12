using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponMovement : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    public GameObject leftdown;
    public GameObject rightdown;
    public GameObject upright;
    public GameObject upleft;
    void Start()
    {
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(false);
        leftdown.SetActive(false);
        rightdown.SetActive(false);
        upright.SetActive(false);
        upleft.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.D)))
        {
            upright.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upleft.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.A)))
        {
            upleft.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.D)))
        {
            rightdown.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.A)))
        {
            leftdown.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            upright.SetActive(false);
            rightdown.SetActive(false);
            upleft.SetActive(false);
        }





        else if (Input.GetKey(KeyCode.W))
        {
            up.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            left.SetActive(true);

            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            right.SetActive(true);

            left.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            down.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.D)))
        {
            upright.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upleft.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.A)))
        {
            upleft.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            rightdown.SetActive(false);
            upright.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.D)))
        {
            rightdown.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            leftdown.SetActive(false);
            upright.SetActive(false);
            upleft.SetActive(false);
        }

        else if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.A)))
        {
            leftdown.SetActive(true);

            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
            upright.SetActive(false);
            rightdown.SetActive(false);
            upleft.SetActive(false);
        }
    }
}
