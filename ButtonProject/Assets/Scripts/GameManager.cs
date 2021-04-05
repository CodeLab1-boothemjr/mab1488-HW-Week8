using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptableObject currentLocation;

    public Text locationNameText;
    public Text locationDescription;

    public GameObject buttonNorth;
    public GameObject buttonSouth;
    public GameObject buttonEast;
    public GameObject buttonWest;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateLocation();
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0 : currentLocation = currentLocation.locationNorth;
                break;
            case 1 : currentLocation = currentLocation.locationSouth;
                break;
            case 2 : currentLocation = currentLocation.locationEast;
                break;
            case 3 : currentLocation = currentLocation.locationWest;
                break;
        }

        UpdateLocation();
    }
    
    void UpdateLocation()
    {
        locationNameText.text = currentLocation.locationName;
        locationDescription.text = currentLocation.description;

        if (currentLocation.locationNorth == null)
        {
            buttonNorth.SetActive(false);
        }
        else
        {
            buttonNorth.SetActive(true);
        }
        if (currentLocation.locationSouth == null)
        {
            buttonSouth.SetActive(false);
        }
        else
        {
            buttonSouth.SetActive(true);
        }
        if (currentLocation.locationEast == null)
        {
            buttonEast.SetActive(false);
        }
        else
        {
            buttonEast.SetActive(true);
        }
        if (currentLocation.locationWest == null)
        {
            buttonWest.SetActive(false);
        }
        else
        {
            buttonWest.SetActive(true);
        }
    }
}
