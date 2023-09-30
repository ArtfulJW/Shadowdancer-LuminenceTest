using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private List<Light> _Lights = new List<Light>();

    // Make sure there is only ever one GameManager
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        // Do stuff

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void addLight(Light inputLight)
    {
        _Lights.Add(inputLight);

        Debug.Log("========== Number of Lights in Level: " + _Lights.Count);
        for(int i = 0; i < _Lights.Count; i++)
        {
            Debug.Log(_Lights[i].GetInstanceID());
        }
        Debug.Log("====================");

    }

}