using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public Vector3 CameraPos;
    public Quaternion CameraRo;
    public Vector3 PlayerPos;
    Transform PlayerTranform;
    Transform CameraTranform;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = Player.GetComponent<CharacterController>();
        PlayerTranform = Player.GetComponent<Transform>();
        CameraTranform = Camera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            controller.enabled = false;
            Player.transform.position = PlayerPos;
            Camera.transform.position = CameraPos;
            Camera.transform.rotation = CameraRo;
            controller.enabled = true;
        }
    }
}
