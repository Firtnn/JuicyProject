using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invader : MonoBehaviour
{
    [SerializeField] private Sprite[] animationSprites;

    [SerializeField] private UnityEvent OnKilled;

    [SerializeField] float animationTime = 1.0f;
    public System.Action killed;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    private ParticleSystem part;

    [SerializeField] private AudioManager audio;

    private int animationFrame;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = animationSprites[0];
        part = GetComponent<ParticleSystem>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
    }

    private void AnimateSprite()
    {
        animationFrame++;

        if (animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }

        spriteRenderer.sprite = animationSprites[animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            this.killed.Invoke();
            anim.SetTrigger("death");
            audio.Play("prout");
            part.Play();
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
        
    }
}
