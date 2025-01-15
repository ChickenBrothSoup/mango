using UnityEngine;

public class coin : MonoBehaviour
{
    public int Amount = 10;

    private Collider2D _collider2D;

    private AudioSource _audioSource;

    public GameObject Graphics;

    public AudioClip Audioclip; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _audioSource = GetComponent<AudioSource>();

        if (_collider2D)
            Debug.Log(message: "This is le collider" + _collider2D);
    }

    private void OnMouseOver()
    {
        Debug.Log(message:"We should destroy this object");

        if (_audioSource && Audioclip && !_audioSource.isPlaying)
        {
            _audioSource.PlayOneShot(Audioclip);
        }

        if (Graphics)
        {
            Graphics.SetActive(false);
        }
            
        Invoke(methodName: "Destroy", time: 0.5f);


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
