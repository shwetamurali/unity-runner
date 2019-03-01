using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisio : MonoBehaviour {

    public PlayerMovement movement;
    public Text CoinText;
    public int numCoins = 0;
    ParticleSystem explosion;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
            FindObjectOfType<initiateExplosion>().startEx();
            
        }
        if (collision.collider.tag == "Coin")
       {
           collision.collider.gameObject.SetActive(false);
            Debug.Log("You get a coin!");
           //FindObjectOfType<coinScript>().whenPicked();
           numCoins+=1;
           CoinText.text = "Coins: " + numCoins;
          
        }
        if (collision.collider.tag == "Magnet")
        {
            collision.collider.gameObject.SetActive(false);
            FindObjectOfType<Coin>().invokeMagnet();
            addCoins();
            Invoke("coinfivemag", 1);
            Invoke("coinsixMag", 1.8f);
        }

    }

    public void coinsixMag()
    {
        FindObjectOfType<coin6script>().invokeMagnet3();
        addCoins();
    }

    public void coinfivemag()
    {
        FindObjectOfType<coin5script>().invokeMagnet2();
        addCoins();
    }

    public void addCoins()
    {
        numCoins += 1;
        CoinText.text = "Coins: " + numCoins;
    }
}


