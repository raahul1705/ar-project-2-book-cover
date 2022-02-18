using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ToggleReview : MonoBehaviour
{
    public GameObject overview;
    public GameObject review;
    public VirtualButtonBehaviour vb;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnTogglePressed);
        overview.SetActive(true);
        review.SetActive(false);
    }

    void OnTogglePressed(VirtualButtonBehaviour vb)
    {
        if (overview.activeInHierarchy)
        {
            overview.SetActive(false);
            review.SetActive(true);
        }
        else
        {
            overview.SetActive(true);
            review.SetActive(false);
        }
    }
}
