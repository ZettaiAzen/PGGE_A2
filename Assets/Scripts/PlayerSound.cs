using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    // the array that will store all the footsteps according to the material
    public AudioClip[] Concrete_Footsteps;
    public AudioClip[] Dirt_Footsteps;
    public AudioClip[] Metal_Footsteps;
    public AudioClip[] Sand_Footsteps;
    public AudioClip[] Wood_Footsteps;

    // hehe
    public AudioClip[] Angela_Footsteps;

    public AudioSource footstepSource;

    public LayerMask floor;

    // will store the tag of the material the player is stepping on
    string materialTag = null;

    // Start is called before the first frame update
    void Start()
    {
        footstepSource = GetComponent<AudioSource>();
        floor = LayerMask.GetMask("Floor");
    }
  
    private void GettingFloorType()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, out hit, Mathf.Infinity, floor)){
           materialTag = hit.collider.transform.gameObject.tag;
        }
    }

    public void WalkFootHit()
    {
        AudioClip clip;

        GettingFloorType();

        Debug.Log("Floor is: " + materialTag);

        //checking what material it is
        switch (materialTag)
        {
            case "Concrete":
                clip = Concrete_Footsteps[Random.Range(0, Concrete_Footsteps.Length)];
                Debug.Log("stepping on concrete!!");
                break;

            case "Dirt":
                clip = clip = Dirt_Footsteps[Random.Range(0, Dirt_Footsteps.Length)];
                break;

            case "Metal":
                clip = Metal_Footsteps[Random.Range(0, Metal_Footsteps.Length)];
                break;

            case "Sand":
                clip = Sand_Footsteps[Random.Range(0, Sand_Footsteps.Length)];
                break;

            case "Wood":
                clip = Wood_Footsteps[Random.Range(0, Wood_Footsteps.Length)];
                break;

            // silly

            case "Angela":
                clip = Angela_Footsteps[Random.Range(0, Angela_Footsteps.Length)];
                break;

            default:
                clip = null;
                break;
        }

        if (materialTag != null)
        {
            footstepSource.clip = clip;
            Debug.Log("Playing: " + clip);
            // selecting random volume
            footstepSource.volume = Random.Range(0.2f, 0.5f);
            // selecting random pitch
            footstepSource.pitch = Random.Range(0.8f, 1.2f);
            if (materialTag == "Angela")
            {
                footstepSource.pitch = 1.0f;
            }
            footstepSource.Play();
        }
    }

    public void JumpSound()
    {
        AudioClip clip;

        GettingFloorType();

        Debug.Log("Floor is: " + materialTag);

        //checking what material it is
        switch (materialTag)
        {
            case "Concrete":
                clip = Concrete_Footsteps[Random.Range(0, Concrete_Footsteps.Length)];
                Debug.Log("stepping on concrete!!");
                break;

            case "Dirt":
                clip = clip = Dirt_Footsteps[Random.Range(0, Dirt_Footsteps.Length)];
                break;

            case "Metal":
                clip = Metal_Footsteps[Random.Range(0, Metal_Footsteps.Length)];
                break;

            case "Sand":
                clip = Sand_Footsteps[Random.Range(0, Sand_Footsteps.Length)];
                break;

            case "Wood":
                clip = Wood_Footsteps[Random.Range(0, Wood_Footsteps.Length)];
                break;

            default:
                clip = null;
                break;
        }

        if (materialTag != null)
        {
            footstepSource.clip = clip;
            Debug.Log("Playing: " + clip);
            // selecting random volume
            footstepSource.volume = Random.Range(0.6f, 1.0f);
            // selecting random pitch
            footstepSource.pitch = Random.Range(1.2f, 2.0f);
            footstepSource.Play();
        }
    }
}



