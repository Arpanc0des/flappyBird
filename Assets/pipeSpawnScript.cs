using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 10;
    public float timer = 0;
    public float heightOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipes();
            timer = 0;
        }
    }

    void spawnPipes()
    {
        float lowerPoint = transform.position.y - heightOffset;
        float highPoint = transform.position.y + heightOffset;
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowerPoint, highPoint), 0), transform.rotation);
    }
}
