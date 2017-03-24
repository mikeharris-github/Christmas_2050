using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{

    //public GameObject present1;
    public GameObject present;
    public GameObject presentUI;
    public GameObject gift;
    public GameObject presentPoof;
    public AudioClip presentClick;
    private AudioSource source;

    public float rotation = 30f;

    public bool isPressed = false;
    public bool UI2active = false;
    public bool destroy = false;

    // Use this for initialization
    void Start()
    {
        presentUI.SetActive(false);
        gift.SetActive(false);
        source = GetComponent<AudioSource>();
        source.clip = presentClick;
        
    }

    // Update is called once per frame
    void Update()
    {
        present.transform.Rotate(0f, rotation * Time.deltaTime, 0f);
        if (isPressed == true)
        {
            Debug.Log("UI ON");
            AudioSource.PlayClipAtPoint(presentClick, new Vector3(transform.position.x, transform.position.y, transform.position.z));
            print("audio source played!");
            presentUI.SetActive(true);
            gift.SetActive(true);
            Instantiate(presentPoof, transform.position, Quaternion.Euler(-90f, 0, 0));
            present.SetActive(false);
            //Destroy(gameObject);

        }
        else if (isPressed == false)
        {
            Debug.Log("UI OFF");
            presentUI.SetActive(false);
            gift.SetActive(false);
        }
    }

    public void OnClick2()
    {
        if (isPressed == false)
        {
            isPressed = true;
        }
        else if (isPressed == true)
        {
            isPressed = false;
        }
    }

    public void CloseWindow()
    {
        Destroy(presentUI);
        Destroy(gift);
        Destroy(present);
    }
}
