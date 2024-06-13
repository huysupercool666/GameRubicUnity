using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
   // public float stopCountingDistance = 0f;   
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        /*if(player.position.y < -1f){
            stopCountingDistance = player.position.z;
            FindObjectOfType<GameManager>().EndGame();
        }*/
    }
}
