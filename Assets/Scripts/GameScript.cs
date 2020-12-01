using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;
    private List<GameObject> _targets;

    private float _time = 0.0f;
    private bool _end = false;
    [SerializeField] private Text _displayText;
    [SerializeField] private Text _displayTimeText;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        _targets = new List<GameObject>();

        for (int i = 0; i < 10; i++) {
            Vector3 pos = new Vector3(Random.Range(-20.0f, 20), Random.Range(0.0f, 20.0f), Random.Range(-20.0f, 20.0f));
            _targets.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], pos, 
                Quaternion.identity));
        }

    }

    public void Update()
    {
        if (!_end) {
            _displayTimeText.text = "" + Time.timeSinceLevelLoad + "s";
        }
        else
        {
            count++;
            if (count >= 100)
            {
                _displayText.enabled = !_displayText.enabled;
                _displayTimeText.enabled = !_displayTimeText.enabled;
                count = 0;
            }
        }
    }

    // Update is called once per frame
    public void SendHit(GameObject _object)
    {
        _targets.Remove(_object);
        Destroy(_object);

        if (_targets.Count == 0)
        {
            _end = true;
        }
    }

}
