using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;

    [SerializeField] private float speed = 5.0f;

    [SerializeField] private UnityEvent OnShoot;
    [SerializeField] private UnityEvent OnMoveRight;
    [SerializeField] private UnityEvent OnMoveLeft;
    [SerializeField] private UnityEvent OnHit;

    [SerializeField] private AudioManager audio;

    private bool _bulletActive;


    private bool CityCanMove = false;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            boolForCity();
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (CityCanMove == false)
            {
                OnMoveLeft.Invoke();
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (CityCanMove == false)
            {
                OnMoveRight.Invoke();
            }
        }
        
        

        if(Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        if (!_bulletActive)
        {
            Bullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.destroyed += BulletDestoyed;
            _bulletActive = true;
            // audio.Play("Shoot");
            OnShoot.Invoke();
        }
    }

    private void BulletDestoyed()
    {
        _bulletActive = false;
    }
    void boolForCity()
    {
        if (CityCanMove == false)
        {
            CityCanMove = true;
        }
        else
        {
            CityCanMove = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Invader") || other.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}

