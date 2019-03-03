using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public GameObject linePrefab;

    private LineRenderer render;
    Line activeLine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGo = Instantiate(linePrefab);


            activeLine = lineGo.GetComponent<Line>();
            Destroy(lineGo, 10f);

        }
        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }
        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }

}