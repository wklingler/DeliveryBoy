using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    private float _waitDestroyTime = 0.5f;

    [SerializeField]
    Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField]
    Color32 noPackageColor = new Color32(1,1,1,1);
    private bool _hasPackage = false;

    SpriteRenderer _spriteRenderer;

    private void Start() 
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Oh crap! I think I hit something!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Package":
                PickUpPackage(other.gameObject);
            break;
            case "Customer":
                DeliverPackage();
            break;
        }
    }

    private void PickUpPackage(GameObject package)
    {
        if (!_hasPackage)
        {
            Debug.Log("Package picked up");
            _hasPackage = true;
            _spriteRenderer.color = hasPackageColor;
            Destroy(package, _waitDestroyTime);
        }
    }

    private void DeliverPackage()
    {
        if(_hasPackage)
        {
            Debug.Log("Package delivered");
            _hasPackage = false;
            _spriteRenderer.color = noPackageColor;
        }
    }
}
