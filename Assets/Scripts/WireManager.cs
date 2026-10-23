using UnityEngine;

public class WireManager : MonoBehaviour
{
    public static WireManager Instance;

    private LabNode firstNode;

    private void Awake()
    {
        Instance = this;
    }

    public void SelectNode(LabNode node)
    {
        Debug.Log("Selected : " + node.nodeID);

        if (firstNode == null)
        {
            firstNode = node;

            Debug.Log("First Node Stored");

            return;
        }

        Debug.Log("Second Node Selected");

        CircuitManager.Instance.CheckConnection(
            firstNode,
            node
        );

        firstNode = null;
    }
}