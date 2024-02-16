using UnityEngine;

public class CoudSpawner : MonoBehaviour
{

    public GameObject cloud;
    public float cloudSpawnRate = 2;
    private float cloudtimer = 0;
    public float cloudHeightOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cloudtimer < cloudSpawnRate)
        {
            cloudtimer = cloudtimer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            cloudtimer = 0;
        }
    }

    void spawnCloud()
    {
        float clowestPoint = transform.position.y - cloudHeightOffset;
        float chighestPoint = transform.position.y + cloudHeightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(clowestPoint, chighestPoint), transform.position.z), transform.rotation);
    }
}
