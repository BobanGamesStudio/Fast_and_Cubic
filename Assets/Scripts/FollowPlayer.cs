using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public Vector3 DriftingApart;
    //private Vector3 LastPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.activeSelf)
        {
            transform.position = player.transform.position + offset;
            //LastPos = transform.position;
        }
        else
        {
            transform.position = transform.position + DriftingApart;
        }
    }
}
