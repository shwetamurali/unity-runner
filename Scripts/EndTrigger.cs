using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public Scene currentScene;
    ParticleSystem Rocket;
    public Text winText;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<PlayerMovement>().stopBall();
        if (other.name == "Player")
        {
            if (currentScene.name == "Level01") {
                gameManager.CompleteLevel();
            }
            else if(currentScene.name == "Level02")
            {
                FindObjectOfType<PlayerMovement>().removeBall();
                FindObjectOfType<fireworks>().sendRockets();
                FindObjectOfType<FollowPlayer>().zoomOut();
                winText.text = "YOU WIN!";
            }
        }
        
    }
}
