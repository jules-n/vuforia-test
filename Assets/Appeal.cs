using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Appeal : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    public GameObject main;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("target");
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].SetActive(false);
        }
        main.SetActive(true);
        Debug.Log("Success!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
