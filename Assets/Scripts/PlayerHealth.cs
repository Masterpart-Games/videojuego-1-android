using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int TotalHealth = 5;
    public RectTransform hearthUI;

    public RectTransform gameOverMenu;
    public GameObject hordes;

    private int health;
    private float hearthSize = 16f;

    private SpriteRenderer _renderer;
    private Animator _animator;
    private PlayerController _controller;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _controller = GetComponent<PlayerController>();
    }



    // Start is called before the first frame update
    void Start()
    {
        health = TotalHealth;
    }

    public void AddDamage(int amount)
    {
        health = health - amount;

        StartCoroutine("VisualFeedback");

        if (health <= 0)
        {
            health = 0;
            gameObject.SetActive(false);
        }

        hearthUI.sizeDelta = new Vector2(hearthSize * health, hearthSize);
        Debug.Log("Player got damaged. His current health is " + health);
    }

    public void AddHealth(int amount)
    {
        health = health + amount;

        if (health > TotalHealth)
        {
            health = TotalHealth;
        }

        hearthUI.sizeDelta = new Vector2(hearthSize * health, hearthSize);
        Debug.Log("Player got some life. His current health is " + health);
    }
    // Update is called once per frame
    private IEnumerator VisualFeedback()
    {
        _renderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        _renderer.color = Color.white;

        yield return new WaitForSeconds(0.1f);

        _renderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        _renderer.color = Color.white;
    }

    private void OnEnabled()
    {
        health = TotalHealth;
    }

    private void OnDisable()
    {
        gameOverMenu.gameObject.SetActive(true);

        hordes.SetActive(false);
        _animator.enabled = false;
        _controller.enabled = false;

        health = TotalHealth;
        _renderer.color = Color.white;
    }
}
