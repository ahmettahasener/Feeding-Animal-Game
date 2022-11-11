using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zRange = 10.0f;
    public GameObject projectilePrefab;
    public Vector3 offset = new Vector3(0, 0, 1); //merminin bize çarpmamasý için 1 birim ötede oluþturduk
    //inputs
    public float verticalInput;
    public float horizontalInput; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange) //saða sola gitmeyi sýnýrla
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -6);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


        horizontalInput = Input.GetAxis("Horizontal"); //horizontal movements
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position+offset, projectilePrefab.transform.rotation); //mermiyi kopya olarak çoðalttýk ve mermi kendi scriptinden dolayý oluþtuðu anda 40 hýzýyla ilerledi
        }
    }
}
