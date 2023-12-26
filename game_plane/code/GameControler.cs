using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject diabay;
    float m_spawnTime;
    public float SpawnTime;

    private bool m_isGameover;

    public bool IsGameover
    {
        get { return m_isGameover; }
        set { m_isGameover = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (m_spawnTime < 0)
        {
            spawndiabay();
            m_spawnTime = SpawnTime;
        }
    }

 private void spawndiabay()
{
    Vector2 spawnPos = new Vector2(Random.Range(-7.4f, 7.4f), 6.6f);
    if (diabay)
    {
        GameObject newDiabay = Instantiate(diabay, spawnPos, Quaternion.identity);
        Destroy(newDiabay, 5f); // Huỷ đối tượng mới sau 10 giây
    }
}
 
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }
}