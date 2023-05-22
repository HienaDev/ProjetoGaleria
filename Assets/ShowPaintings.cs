using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ShowPaintings : MonoBehaviour
{

    [SerializeField]
    private Sprite[] paintings;

    [SerializeField]
    private GameObject[] uiPositions;

    // Start is called before the first frame update
    private void Start()
    {
        UpdatePaitings();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            UpdatePaitings();
        }
    }

    private void UpdatePaitings()
    {
        System.Random random = new System.Random();
        uiPositions = uiPositions.OrderBy(x => random.Next()).ToArray();

        for (int i = 0; i < uiPositions.Length; i++)
        {
            uiPositions[i].GetComponent<Image>().sprite = paintings[i];
            Debug.Log(uiPositions[i].GetComponent<Image>());
        }
    }
}
