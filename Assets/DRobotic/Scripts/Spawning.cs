using UnityEngine;

public class Spawning : MonoBehaviour {

    // Unity Members 
    [SerializeField]
    public GameObject PrefabToSpawn;
    [SerializeField]
    public float SpawningRate = 2;
    [SerializeField]
    public Vector3 m_Variation;

    // Members
    public System.DateTime m_DeltaTime;

    void Start()
    {
        m_DeltaTime = System.DateTime.Now;
    }

    void Update()
    {
        
        if (!PauseMenu.isPaused && System.DateTime.Now > m_DeltaTime + System.TimeSpan.FromSeconds(SpawningRate)) 
        {
            var spawnedObject = GameObject.Instantiate(PrefabToSpawn); 
            spawnedObject.transform.position = this.transform.position + CreateRandomVector();
            m_DeltaTime = System.DateTime.Now; 
        }
        
    }

    Vector3 CreateRandomVector()
    {
        
        return new Vector3(Random.Range(-m_Variation.x, m_Variation.x), Random.Range(-m_Variation.y, m_Variation.y), Random.Range(-m_Variation.z, m_Variation.z));
    }
}