using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeMenu : MonoBehaviour
{
    public GameObject catalogueControls;
    public GameObject moveControls;
    public GameObject rotateControls;
    public GameObject scaleControls;
    public GameObject currentlyDisplayed;
    public bool isSectionDisplayedToggle = true;
    void Start()
    {
        catalogueControls.SetActive(true);
        currentlyDisplayed = catalogueControls;
    }
    
    public void SetCatalogue()
    {
        ToggleMenu(catalogueControls);
    }
    public void SetMove()
    {
        ToggleMenu(moveControls);
    }
    
    public void SetRotate()
    {
        ToggleMenu(rotateControls);
    }
    
    public void SetScale()
    {
        ToggleMenu(scaleControls);
    }
    
    private void ToggleMenu(GameObject menu)
    {
        if (currentlyDisplayed != menu)
        {
            currentlyDisplayed.SetActive(false);
            menu.SetActive(true);
            currentlyDisplayed = menu;
            isSectionDisplayedToggle = true;
        }
        else
        {
            currentlyDisplayed.SetActive(!isSectionDisplayedToggle);
            isSectionDisplayedToggle = !isSectionDisplayedToggle;
        }
    }
}
