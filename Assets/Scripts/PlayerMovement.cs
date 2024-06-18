using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    // Update is called once per frame
    void Update()
    {
        //add a foward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        //code control the cube
        if(Input.GetKey("d")){
            rb.AddForce(sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < 85.90){
            FindAnyObjectByType<GameManager>().EndGame();
            
        }
       
    }
}
