using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    public float speed;
    public float xDireccion;
    public float yDireccion;
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(_transform.position.x + speed * xDireccion * Time.deltaTime, _transform.position.y + speed * yDireccion * Time.deltaTime);
        if (_transform.position.x >= 8.07)
        {
            xDireccion = -1;
            _spriteRenderer.flipX = false;
        }
        if (_transform.position.x <= -8.07)
        {
            xDireccion = 1;
            _spriteRenderer.flipX = true;
        }
        if (_transform.position.y >= 4.29)
        {
            yDireccion = -1;
            _spriteRenderer.flipY = true;
        }
        if (_transform.position.y <= -4.29)
        {
            yDireccion = 1;
            _spriteRenderer.flipY = false;
        }
    }
}
