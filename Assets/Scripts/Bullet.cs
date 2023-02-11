using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 direction;
    public void Shoot(Vector3 direction)
    {
        this.direction = direction;
    }

    public void DestroyBullet()
    {
        ObjectPool.ReturnObject(this);
    }

    void Update()
    {
        transform.Translate(direction);   
    }
}
