using UnityEngine;

public class coin : MonoBehaviour
{
    public int Amount = 10;

    private Collider2D _collider2D;

    private AudioSource _audioSource;

    public GameObject Graphics;

    public GameObject DeathSound;

    public GameObject DeathParticle;

   

   

    private ScoreManager _scoreManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _audioSource = GetComponent<AudioSource>();
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        if (_collider2D)
            Debug.Log(message: "This is le collider" + _collider2D);
    }

    private void OnMouseOver()
    {
        Debug.Log(message:"We should destroy this object");

        if (DeathSound)
        {
            GameObject.Instantiate(DeathSound, transform.position, transform.rotation);
        }

        if (DeathParticle)
        {
            GameObject.Instantiate(DeathParticle, transform.position, transform.rotation);
        }

        if (_scoreManager)
            _scoreManager.AddScore(Amount);

        Destroy(gameObject);

    }
    void Destroy()
    {
        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
