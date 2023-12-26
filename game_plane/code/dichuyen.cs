using UnityEngine;
using UnityEngine.UI;
public class dichuyen : MonoBehaviour
{
    [Range(250.0f, 350.0f)]
    public float speed;
    public Rigidbody2D rb;
    float dirX;
    [SerializeField] Text tx;
    public Transform shootingPoint;
    public GameObject dan;
    private GameControler m_gc;
    private int m_score;
    private bool m_isGameover;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource span;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_gc = FindObjectOfType<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        float dichuyen = dirX * speed * Time.deltaTime;

        if ((rb.position.x <= -7.8f && dirX < 0) || (rb.position.x >= 7.8f && dirX > 0))
        {
            Debug.Log("Vi phạm");
            return;
        }

        rb.velocity = new Vector2(dichuyen, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }

    public void shoot()
    {
        if (dan && shootingPoint)
        {
           Quaternion rotation = Quaternion.Euler(0, 0, 270); // Xoay với góc quay z là 270 độ
           GameObject newshoot =  Instantiate(dan, shootingPoint.position, rotation);
           span.Play();
           Destroy(newshoot, 5f); 
        }
    }

    public int Score
    {
        get { return m_score; }
        set { m_score = value; }
    }

    public bool IsGameover
    {
        get { return m_isGameover; }
        set { m_isGameover = value; }
    }

  
    public void ScoreIncrement()
    {
        m_score++;
        tx.text = "Score: " + m_score.ToString();
        audioSource.Play();
    }
}