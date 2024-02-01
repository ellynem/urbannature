using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustromTackableForDifferentContents : DefaultObserverEventHandler
{
    public GameObject AnimalContent;
    public GameObject PlantContent;

    protected override void Start()
    {
        base.Start();

        AnimalContent.SetActive(false);
        PlantContent.SetActive(false);
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }

    public void SelectAnimals()
    {
        AnimalContent.SetActive(true);
        PlantContent.SetActive(false);
    }

    public void SelectPlants()
    {
        PlantContent.SetActive(true);
        AnimalContent.SetActive(false);
    }


}
