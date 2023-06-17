 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float Movespeed;
    [SerializeField] private float xMax;
    [SerializeField] private float zMax;
    [SerializeField] private float xMin;
    [SerializeField] private float zMin;
    [SerializeField] private float PlayerHP;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per fram
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)
            transform.Translate(new Vector3(Movespeed, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
            transform.Translate(new Vector3(0, 0, Movespeed) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin)
            transform.Translate(new Vector3(-Movespeed, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin)
            transform.Translate(new Vector3(0, 0, -Movespeed) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerHP--;
        }

        if(PlayerHP <=0)
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy");
        }

    }
    private void OnDestroy()
    {
        SceneManager.LoadScene("End");
    }
}



