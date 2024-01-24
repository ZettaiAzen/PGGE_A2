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
        // shooting a raycast down to the floor to check what the material is
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, out hit, Mathf.Infinity, floor)){
           // gets the tag from whatever was hit
           materialTag = hit.collider.transform.gameObject.tag;
        }
        else
        {
            // if hit nothing or if the ground is not something that has sound effects, then there is no tag
            materialTag = null;
        }
    }

    // function that plays footsteps
    public void WalkFootHit()
    {
        AudioClip clip;

        GettingFloorType();

        //checking what material it is
        switch (materialTag)
        {
            case "Concrete":
                clip = Concrete_Footsteps[Random.Range(0, Concrete_Footsteps.Length)];
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
            // selecting random volume
            footstepSource.volume = Random.Range(0.1f, 0.4f);
            // selecting random pitch
            footstepSource.pitch = Random.Range(0.8f, 1.2f);
            footstepSource.Play();
        }
    }

    public void RunFootHit()
    {
        AudioClip clip;

        GettingFloorType();

        //checking what material it is
        switch (materialTag)
        {
            case "Concrete":
                clip = Concrete_Footsteps[Random.Range(0, Concrete_Footsteps.Length)];
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
            // selecting random volume, louder than walking but softer than jumping
            footstepSource.volume = Random.Range(0.5f, 0.7f);
            // selecting random pitch, higher than walking but lower than jumping
            footstepSource.pitch = Random.Range(1.0f, 1.5f);
            footstepSource.Play();
        }
    }

    // function that plays jump sound effects
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
            // jump has a louder volume and higher pitch
            // selecting random volume
            footstepSource.volume = Random.Range(0.8f, 1.0f);
            // selecting random pitch
            footstepSource.pitch = Random.Range(1.6f, 2.0f);
            footstepSource.Play();
        }
    }
}



