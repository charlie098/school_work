using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    float fast = 8.0f;
    float slow = 5.0f;
    //float very_slow = 3.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        move();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Slow")
        {
            fast = 3.0f;
            slow = 3.0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Slow")
        {
            fast = 8.0f;
            slow = 5.0f;
        }
    }


    private void move()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)) //좌 쉬프트와 화살표 위 키를 같이 누르면 가속됨
        {
            this.transform.Translate(Vector3.forward * fast * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * slow * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.forward * fast * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.forward * slow * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.forward * fast * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.forward * slow * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.forward * fast * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.forward * slow * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        }

    }

}