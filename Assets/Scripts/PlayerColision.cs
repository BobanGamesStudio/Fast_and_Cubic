using UnityEngine;
using System.Collections.Generic;

public class PlayerColision : MonoBehaviour
{
    
    public PlayerMovement movement;
    public GameObject trash;
    public Vector3 PlayerSize;
    public Vector3 ReleaseForce;

    private GameObject LastCube;
    //public float releaseForce = 1000f;

    private void Start() {
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle" & gameObject.activeSelf)
        {
            ReleaseCubes();
            gameObject.SetActive(false);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("ExplosionSoundCut");
        }
    }

    void ReleaseCubes()
    {
        trash.transform.localScale -= new Vector3(  1 - gameObject.transform.lossyScale.x * 1/(trash.transform.lossyScale.x * PlayerSize.x),
                                                    1 - gameObject.transform.lossyScale.y * 1/(trash.transform.lossyScale.y * PlayerSize.y),
                                                    1 - gameObject.transform.lossyScale.z * 1/(trash.transform.lossyScale.z * PlayerSize.z));
                                                    
        for (int x=0; x<PlayerSize.x; ++x)
        {
            for (int y=0; y<PlayerSize.y; ++y)
            {
                for (int z=0; z<PlayerSize.z; ++z)
                {
                    LastCube = Instantiate(trash, new Vector3(  x* trash.transform.lossyScale.x + gameObject.transform.position.x - 0.5f + trash.transform.lossyScale.x/2,
                                                     y* trash.transform.lossyScale.y + gameObject.transform.position.y - 0.5f + trash.transform.lossyScale.y/2,
                                                     z* trash.transform.lossyScale.z + gameObject.transform.position.z - 0.5f + trash.transform.lossyScale.z/2
                                                ), Quaternion.identity);
                    LastCube.GetComponent<Rigidbody>().AddForce(ReleaseForce.x * Time.deltaTime + Random.Range(-200.0f, 200.0f), 
                                                                ReleaseForce.y * Time.deltaTime + Random.Range(-50.0f, 50.0f),
                                                                ReleaseForce.z * Time.deltaTime + Random.Range(-50.0f, 50.0f));
                    
                }
            }
        }
        trash.transform.localScale = new Vector3(1,1,1);

        // //Debug.Log(gameObject.GetComponent<InitiatePlayer>().Cubes);
        // foreach(GameObject cube in gameObject.GetComponent<InitiatePlayer>().Cubes)
        // {
        //     cube.GetComponent<Rigidbody>().isKinematic = false;
        //     cube.GetComponent<BoxCollider>().enabled = true;
        //     cube.GetComponent<Rigidbody>().AddForce(0, 0, releaseForce);
        // }
        // gameObject.GetComponent<Rigidbody>().isKinematic = true;
        // gameObject.GetComponent<BoxCollider>().enabled = false;
        
    }
}
