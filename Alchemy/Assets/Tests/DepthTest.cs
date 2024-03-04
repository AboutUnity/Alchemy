using System;
using Alchemy.Inspector;
using UnityEngine;

public class DepthTest : MonoBehaviour
{
    [Serializable]
    [BoxGroup]
    public class NodeA
    {
        [SerializeField] float foo;
        [SerializeField] NodeB node;
    }

    [Serializable]
    [BoxGroup]
    public class NodeB
    {
        [SerializeField] float bar;
        [SerializeField] NodeA node;
    }

    public NodeA node;
}
