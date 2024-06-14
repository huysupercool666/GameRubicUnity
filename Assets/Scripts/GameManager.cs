using UnityEngine;
using UnityEngine.SceneManagement;//Change the diferent scene or reload the scene that we already on
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public void CompleteLevelGame(){
        completeLevelUI.SetActive(true);
    }
    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);// Invoke have two parameter in quotation mark is the name of the function like "restart", and the second parameter was the delay number of amount of time
        }
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
