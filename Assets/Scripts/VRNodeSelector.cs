using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRNodeSelector : MonoBehaviour
{
    LabNode node;

    private void Start()
    {
        node = GetComponent<LabNode>();
        if (node == null)
        {
            Debug.LogError("CircuitNode Missing");
        }
    }

    public void OnSelect()
    {
        Debug.Log("NODE CLICKED : " + node.nodeID);

        WireManager.Instance.SelectNode(node);
    }
}