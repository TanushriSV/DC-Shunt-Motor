using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CircuitManager : MonoBehaviour
{
    public static CircuitManager Instance;

    public GameObject wirePrefab;

    public TMP_Text statusText;

    public bool circuitCompleted;

    int correctConnections = 0;

    HashSet<string> connectedPairs =
        new HashSet<string>();

    Dictionary<string, string> validConnections =
        new Dictionary<string, string>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        validConnections.Add(
            "MCB_P",
            "Circuit_P");

        validConnections.Add(
            "MCB_N",
            "Circuit_N");

        validConnections.Add(
            "Starter_L",
            "Diagram_L");

        validConnections.Add(
            "Starter_F",
            "Diagram_F");

        validConnections.Add(
            "Starter_A",
            "Diagram_A");

        validConnections.Add(
            "VA_1",
            "Diagram_VA_1");

        validConnections.Add(
            "VA_2",
            "Diagram_VA_2");

        validConnections.Add(
            "IF_1",
            "Diagram_IF_1");

        validConnections.Add(
            "IF_2",
            "Diagram_IF_2");

        validConnections.Add(
            "IA_1",
            "Diagram_IA_1");

        validConnections.Add(
            "IA_2",
            "Diagram_IA_2");
    }

    public void CheckConnection(
        LabNode startNode,
        LabNode endNode)
    {
        Debug.Log(
        "Checking : " +
        startNode.nodeID +
        " -> " +
        endNode.nodeID);

        if (validConnections.ContainsKey(
            startNode.nodeID))
        {
            if (validConnections[startNode.nodeID]
                == endNode.nodeID)
            {
                Debug.Log("CORRECT CONNECTION");

                string pair =
                    startNode.nodeID +
                    "_" +
                    endNode.nodeID;

                if (!connectedPairs.Contains(pair))
                {
                    connectedPairs.Add(pair);

                    CreateWire(
                        startNode.transform,
                        endNode.transform);

                    correctConnections++;

                    CheckCircuit();
                }
            }
        }
    }

    void CreateWire(
        Transform start,
        Transform end)
    {
        Debug.Log("WIRE CREATED");

        GameObject wire =
            Instantiate(wirePrefab);

        LineRenderer lr =
            wire.GetComponent<LineRenderer>();

        lr.positionCount = 2;

        lr.SetPosition(
            0,
            start.position);

        lr.SetPosition(
            1,
            end.position);
    }

    void CheckCircuit()
    {
        if (correctConnections == 11)
        {
            circuitCompleted = true;

            statusText.text =
                "Circuit Connection Finished";
        }
    }
}