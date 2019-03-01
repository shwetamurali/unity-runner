using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public Camera cameraa;

	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
        transform.LookAt(player.transform);

    }

    public void zoomOut()
    {
        Debug.Log("Zooming Out");
        cameraa.fieldOfView += 100.0f;
    }

}
